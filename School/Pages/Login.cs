using System; 
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using School.Models;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using School.Settings;

namespace School.Pages
{
    public partial class Login : Form
    {
        static Student LoginedUser = new Student();
        public static Form ThisForm;
        public static string connection = null;
         
        public Login()
        {
            InitializeComponent();
            connection = "Data Source=" + Extentions.GetPath() + @"DB\StoreDb.db;Version=3;";

        }

       
         
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (this.ckbAdmin.Checked)
            {
                if (this.isNotEmpty(this.txtUsername.Text, this.txtPassword.Text))
                {
                    this.cleaner();
                    if (this.hasAdmin(this.txtUsername.Text, this.txtPassword.Text))
                    {
                        this.Hide();
                        ThisForm = this;
                        this.lblError.Text = "";
                        new AdminPanel().Show();
                    } 
                } 
            }
            else
            {
                if (this.isNotEmpty(this.txtUsername.Text, this.txtPassword.Text))
                {
                    this.cleaner();
                    if (hasStudent(txtUsername.Text, txtPassword.Text))
                    {
                        this.lblError.Text = "";
                        MessageBox.Show(LoginedUser.Name);
                    }
                }
            }
        }

        private bool hasAdmin(string username, string  password)
        {
            SQLiteConnection con = new SQLiteConnection(connection);
            string sql = "SELECT * FROM Admin WHERE username = '" + username + "' AND password = '" + password + "'";
            SQLiteCommand com = new SQLiteCommand(sql, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = com;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                LoginedUser.Username = dt.Rows[0]["username"].ToString();
                LoginedUser.Password = dt.Rows[0]["password"].ToString();
                return true;
            }
            else
            {
                this.lblError.Text = "Username or Password incorrect !";
                return false;
            }
        }

        private bool hasStudent(string username, string password)
        {
            string query = "SELECT * FROM Students WHERE username = '" + username + "' AND password = '" + password + "'";
            SQLiteConnection Con = new SQLiteConnection(connection);
            SQLiteCommand Com = new SQLiteCommand(query, Con);
            SQLiteDataAdapter Da = new SQLiteDataAdapter();
            DataTable Dt = new DataTable();
            Com.Connection = Con;
            Com.CommandText = query;
            Da.SelectCommand = Com;
            Da.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                LoginedUser = new Student()
                {
                    Id = Convert.ToInt32(Dt.Rows[0]["id"]),
                    Name = Dt.Rows[0]["name"].ToString(),
                    Surname = Dt.Rows[0]["surname"].ToString(),
                    Email = Dt.Rows[0]["email"].ToString(),
                    Password = Dt.Rows[0]["password"].ToString(),
                    Image = Dt.Rows[0]["image"].ToString()
                };
                return true;
            }
            else
            {
                this.lblError.Text = "Username or Password incorrect !";
                return false;
            }
        }

        private void cleaner()
        {
            this.lblPassword.Text = "";
            this.lblUsername.Text = ""; 
        }

        private bool isNotEmpty(string username, string password)
        {
            this.cleaner();
            if (username == "")
            {
                this.lblError.Text = "";
                this.lblUsername.Text = "username is required !!!";
                this.ActiveControl = this.txtUsername;
                return false;
            }
            if(password == "")
            {
                this.lblError.Text = "";
                this.lblPassword.Text = "password is required !!!";
                this.ActiveControl = this.txtPassword;
                return false;
            }
            return true;
        }
         
        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
        }

         
    }
}
