using System;
using System.Collections.Generic; 
using System.Data;
using System.Data.SQLite;
using System.Linq; 
using System.Windows.Forms;
using School.Models;
using System.IO;
using School.Settings;
using System.Drawing;

namespace School.Pages
{
    public partial class AddTicket : Form
    {
        SQLiteConnection con = new SQLiteConnection(Login.connection);
        List<Quation> quations = new List<Quation>();
        List<Category> categories = new List<Category>();
        List<int> quation_ids = new List<int>();

        public AddTicket()
        {
            InitializeComponent();
            selectAllForTable("Quations");
            selectAllForTable("Categories");
            setScrollImages();
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Tickets.ThisForm.Show();
        }
         
        void setScrollImages()
        {
            foreach (var grp in this.grpMain.Controls)
            {
                if(grp is GroupBox)
                {
                    GroupBox groupBox = grp as GroupBox;
                    foreach (var obj in groupBox.Controls)
                    {
                        if(obj is Panel)
                        {
                            Panel panel = obj as Panel;
                            panel.HorizontalScroll.Maximum = 0;
                            panel.AutoScroll = false;
                            panel.VerticalScroll.Visible = false;
                            panel.AutoScroll = true;
                        }
                        if(obj is ComboBox)
                        {
                            ComboBox cmb = obj as ComboBox; 
                            foreach (Category cat in this.categories)
                            {
                                ComboboxItem item = new ComboboxItem();
                                item.Text = cat.Name;
                                item.Value = cat.Id;
                                cmb.Items.Add(item); 
                                cmb.TextChanged += Cmb_SelectedIndexChanged;
                            }
                        }
                    }
                }
            }
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            int category_id = Convert.ToInt32((cmb.SelectedItem as ComboboxItem).Value);
            Control nextCtl = cmb.Parent.GetNextControl(cmb, true);
            Panel pnl = nextCtl.Parent.GetNextControl(nextCtl, true) as Panel;
            List<Quation> newQuations = this.quations.Where(q => q.Category_id == category_id).ToList();
            pnl.Controls.Clear();
            int top = 0;
            foreach (Quation item in newQuations)
            { 
                Button btn = new Button();
                btn.Width = pnl.Width - 18;
                btn.Height = pnl.Height;
                btn.Top = top;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                using (FileStream s = new FileStream(Extentions.GetPath() + "\\Quations_Images\\" + item.Image, FileMode.Open))
                {
                    btn.BackgroundImage = Image.FromStream(s); 
                }
                pnl.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Name = item.Id.ToString();
                top += pnl.Height;
            }

           this.markImage(pnl);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Panel parent = btn.Parent as Panel;
            parent.Parent.Name = "selected-" + btn.Name;

            this.markImage(parent);

            btn.FlatAppearance.BorderColor = Color.LawnGreen;
            btn.FlatAppearance.BorderSize = 5;
        }
         
        void selectAllForTable( string table)
        {
            string sql = "SELECT * FROM " + table;
            SQLiteCommand com = new SQLiteCommand(sql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = com;
            da.Fill(dt);
             
           if(table == "Quations")
            {
                foreach (DataRow row in dt.Rows)
                {
                    this.quations.Add(new Quation()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Category_id = Convert.ToInt32(row["category_id"]),
                        Image = row["image"].ToString(),
                        Answer = row["answer"].ToString()
                    });
                }
            }
           if(table == "Categories")
            {
                foreach (DataRow row in dt.Rows)
                {
                    this.categories.Add(new Category()
                    {
                        Id = Convert.ToInt32(row["id"]), 
                        Name = row["name"].ToString()
                    });
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (this.txtTicketName.Text == "")
            {
                this.lblTicketName.Text = "Type ticket name !!!";
                return;
            }

            foreach (Control item in this.grpMain.Controls)
            {
                if(item is GroupBox)
                {
                    GroupBox grp = item as GroupBox;
                    if (grp.Name.Contains("selected"))
                    {
                        count++;
                    }
                }
            }

            if (count != 10)
            {
                this.lblQuations.Text = "Select 10 quation !!!";
                return;
            }
             
            using (SQLiteConnection con = new SQLiteConnection(Login.connection))
            {
                con.Open();
                string selectSql = "SELECT * FROM Tickets WHERE name = '" + this.txtTicketName.Text + "'";
                SQLiteCommand com = new SQLiteCommand(selectSql, con);
                SQLiteDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[1].ToString() == this.txtTicketName.Text)
                    {
                        this.lblTicketName.Text = "This ticket added !!!";
                        return;
                    }
                }
            }

            foreach (Control item in this.grpMain.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox grp = item as GroupBox;
                    int id = Convert.ToInt32(grp.Name.Split('-').ToArray()[1]);
                    this.quation_ids.Add(id);
                }
            }

            this.btnSave.Enabled = false;
            int tickedId =  this.insertToTicket();
            this.insertToPivot(tickedId, this.quation_ids);
            this.Close();
            Tickets.ThisForm.Show();
        }

        int insertToTicket()
        {

            string sql = "INSERT INTO Tickets(name) VALUES('" + this.txtTicketName.Text + "')";
            SQLiteCommand com = new SQLiteCommand(sql, con);
            con.Open();
            com.ExecuteNonQuery();
           

            com.CommandText = "SELECT * FROM Tickets WHERE name = '" + this.txtTicketName.Text + "'";
            com.Connection = con;
            SQLiteDataReader dr = com.ExecuteReader();
            int ticketId = 0;
            while (dr.Read())
            {
               ticketId = Convert.ToInt32(dr["id"]);
            }
           
            con.Close();
            return ticketId;
        }

        void insertToPivot(int ticketId, List<int> quationIds)
        {
            foreach (int q_id in quationIds)
            {
                using(SQLiteConnection con =new SQLiteConnection(Login.connection))
                {
                    con.Open();
                    string sql = "INSERT INTO P_TicketAndQuation(ticket_id, quation_id) values(" + ticketId + ", " + q_id + ")";
                    SQLiteCommand com = new SQLiteCommand(sql,con);
                    com.ExecuteNonQuery();
                }
            }
        }

        void markImage(Panel parentPanel)
        {
            foreach (Control ctrl in parentPanel.Controls)
            {
                Button btn = ctrl as Button;

                int id = Convert.ToInt32(btn.Name);
             
                using(SQLiteConnection con = new SQLiteConnection(Login.connection))
                {
                    con.Open();
                    string sql = "SELECT * FROM P_TicketAndQuation WHERE quation_id = " + id;
                    SQLiteCommand com = new SQLiteCommand(sql, con);
                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = com;
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        btn.FlatAppearance.BorderColor = Color.Gold;
                        btn.FlatAppearance.BorderSize = 5;
                    }
                    else
                    {
                        btn.FlatAppearance.BorderColor = Color.Black;
                        btn.FlatAppearance.BorderSize = 1;
                    }
                } 
            }
        }

        public void update(int ticketId)
        {
            using (SQLiteConnection con = new SQLiteConnection(Login.connection))
            {
                con.Open();
                string sql = "SELECT * FROM Tickets WHERE id = " + ticketId;
                SQLiteCommand com = new SQLiteCommand(sql, con);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = com;
                da.Fill(dt);
                this.txtTicketName.Text = dt.Rows[0]["name"].ToString();
            }

            using (SQLiteConnection con =new SQLiteConnection(Login.connection))
            {
                con.Open();
                string sql = "SELECT * FROM P_TicketAndQuation";
                SQLiteCommand com = new SQLiteCommand(sql, con);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = com;
                da.Fill(dt);

                int index = 0;
                foreach (Control ctrl in this.grpMain.Controls)
                {
                    if (ctrl is GroupBox)
                    {
                        foreach (Control cmb in ctrl.Controls)
                        {
                            if (cmb is ComboBox)
                            {
                                ComboBox combo = cmb as ComboBox;
                                int id = Convert.ToInt32(dt.Rows[index]["quation_id"]);
                                int cat_id = this.quations.FirstOrDefault(q => q.Id == id).Category_id;
                                foreach (ComboboxItem item in combo.Items)
                                {
                                    if(cat_id == Convert.ToInt32(item.Value))
                                    {
                                        combo.SelectedItem = item;
                                    }
                                }
                            }
                        }
                        index++;
                    }
                }


            }

        }
    }
}
