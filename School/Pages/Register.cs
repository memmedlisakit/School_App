using System; 
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Data;

namespace School.Pages
{
    public partial class Register : Form
    {

        string connection = null;

        public Register()
        {
            InitializeComponent();
            connection = "Data Source=" + GetPath() + @"DB\StoreDb.db;Version=3;";
        }

        public static string GetPath()
        {
            string path = Application.StartupPath; 
            List<string> splited = Regex.Split(path, "bin").ToList();
            return splited[0];

        }
         
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int gender = Convert.ToInt32(txtGender.Text);

            SQLiteConnection con = new SQLiteConnection(connection);
            con.Open();
            string sql = "INSERT INTO Students(name, surname, email, password, gender) VALUES('" + name+"', '"+surname+"', '"+email+"', '"+password+"', "+gender+")";
            SQLiteCommand com = new SQLiteCommand(sql, con);
            com.ExecuteNonQuery();
            con.Close();
            SelectAll();
        }
         
        public void SelectAll()
        {
            txtData.Text = "";
            SQLiteConnection con = new SQLiteConnection(connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM Students", con);
            da.SelectCommand = com;
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                txtData.Text += row["name"] + " - " + row["surname"] + " - " + row["email"] + "\r\n";
            }
        }
    }
}
