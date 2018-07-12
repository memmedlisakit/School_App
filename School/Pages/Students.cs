using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System;
using System.Drawing;

namespace School.Pages
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            this.FillData(null);
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            AdminPanel.ThisForm.Show();
        }

        private void FillData(int? id)
        {
            this.dgvData.Rows.Clear();
            SQLiteConnection con = new SQLiteConnection(Login.connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            SQLiteCommand com = new SQLiteCommand();
            string sql = "SELECT * FROM Students";
            DataTable dt = new DataTable();

            if (id == null)
            {
                com.CommandText = sql;
                com.Connection = con;
                da.SelectCommand = com;
                da.Fill(dt);
                int index = 0;
                foreach (DataRow row in dt.Rows)
                {
                    this.dgvData.Rows.Add();
                    this.dgvData.Rows[index].Cells[0].Value = row["id"];
                    this.dgvData.Rows[index].Cells[1].Value = row["name"];
                    this.dgvData.Rows[index].Cells[2].Value = row["surname"];
                    this.dgvData.Rows[index].Cells[3].Value = row["username"];
                    this.dgvData.Rows[index].Cells[4].Value = row["email"];
                    this.dgvData.Rows[index].Cells[5].Value = row["gender"].ToString() == "1" ? "Male" : "Female";
                    index++;
                }
                this.lblCount.Text = dt.Rows.Count.ToString();
            }
            else
            {
                sql += " WHERE id = " + id;
                com.CommandText = sql;
                com.Connection = con;
                da.SelectCommand = com;
                da.Fill(dt);
                this.lblName.Text = dt.Rows[0]["name"].ToString();
                this.lblSurname.Text = dt.Rows[0]["surname"].ToString();
                this.lblEmail.Text = dt.Rows[0]["email"].ToString();
                this.lblGender.Text = dt.Rows[0]["gender"].ToString() == "1" ? "Male" : "Female";
                string image = dt.Rows[0]["image"].ToString();
                if (image == "")
                {
                    this.pckStudent.Image = Image.FromFile(Login.GetPath() + @"Uploads\default.png");
                }
                else
                {
                    this.pckStudent.Image = Image.FromFile(Login.GetPath() + @"Uploads\"+image);
                }

            }
        }

        private void SelectStudent(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvData.Rows[e.RowIndex].Cells[0].Value);
            this.FillData(id);
            this.FillData(null);
            this.grpData.Visible = true;
        }
    }
}
