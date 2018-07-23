using System; 
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using School.Settings;

namespace School.Pages
{
    public partial class Categories : Form
    {
        SQLiteConnection con = new SQLiteConnection(Login.connection);
        int id;
        public Categories()
        {
            InitializeComponent();
            this.fillData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtCategory.Text == "")
            {
                this.lblCatError.Text = "Can not empty !!!";
            }
            else
            {
                string sql = "INSERT INTO Categories(name) VALUES ('"+ this.txtCategory.Text + "')";
                SQLiteCommand com = new SQLiteCommand(sql, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                this.fillData();
            }
        }

        void cleaner()
        {
            this.lblCatError.Text = "";
            this.txtCategory.Text = "";
            this.btnAdd.Visible = true;
            this.btnDelete.Visible = false;
            this.btnUpdate.Visible = false;
        }

        void fillData()
        {
            this.dgvData.Rows.Clear(); 
            int i = 0;
            foreach (DataRow row in this.select(null).Rows)
            {
                this.dgvData.Rows.Add();
                this.dgvData.Rows[i].Cells[0].Value = row["id"];
                this.dgvData.Rows[i].Cells[1].Value = row["name"];
                i++;
            }
            this.cleaner();
        }

        DataTable select(int? id)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Categories";
            sql += id != null ? " WHERE id = " + id : "";
            SQLiteCommand com = new SQLiteCommand(sql, con);
            da.SelectCommand = com;
            da.Fill(dt);
            return dt;
        }

        void deleteAllQuations(int catId)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Quations WHERE category_id = " + catId;
            SQLiteCommand com = new SQLiteCommand(sql, con);
            da.SelectCommand = com;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sql = "DELETE FROM Quations WHERE category_id = " + Convert.ToInt32(row["category_id"]);
                    com.CommandText = sql;
                    com.Connection = con;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    Extentions.DeleteFile(row["image"].ToString(), "Quations_Images");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Also 'Delete' all quations with releted this category", "Delete Category", MessageBoxButtons.YesNo))
            {
                string sql = "DELETE FROM Categories WHERE id = " + this.id;
                SQLiteCommand com = new SQLiteCommand(sql, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                this.fillData();
                this.deleteAllQuations(this.id);
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Categories SET name = '" + this.txtCategory.Text + "' WHERE id = " + this.id;
            SQLiteCommand com = new SQLiteCommand(sql, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            this.fillData();
        }

        private void Celect(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.id = Convert.ToInt32(this.dgvData.Rows[e.RowIndex].Cells[0].Value);
            if (this.id > 0)
            {
                this.btnAdd.Visible = false;
                this.btnDelete.Visible = true;
                this.btnUpdate.Visible = true;
                this.txtCategory.Text = this.select(id).Rows[0]["name"].ToString();
            }
            else
            {
                this.cleaner();
            }
        }

    }
}
