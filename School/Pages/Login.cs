using System; 
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite; 
using School.Settings;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace School.Pages
{
    partial class Login : Form
    {
        public static Models.Student LoginedUser = new Models.Student();
        public static Form ThisForm;
        public static string connection = null;
        public static LinkLabel LinkLabel = null;

        static HttpClient client = new HttpClient();

        public Login()
        {
            InitializeComponent();
            connection = "Data Source=" + Extentions.GetPath() + @"DB\StoreDb.db;Version=3;";
            LinkLabel = this.linkSignUp;
            hideSignUp();
        }
         
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ThisForm = this;
            if (this.ckbAdmin.Checked)
            {
                if (this.isNotEmpty(this.txtUsername.Text, this.txtPassword.Text))
                {
                    this.cleaner();
                    if (this.hasAdmin(this.txtUsername.Text, this.txtPassword.Text))
                    {
                        this.Hide(); 
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
                        this.Hide();
                        if (isActivated())
                        {
                            new Dashboard().Show();
                        }
                        else
                        {
                            new CheckActivation().Show();
                        }
                    }
                }
            }
            if(this.ckbRememberMe.Checked && LoginedUser != null)
            {
                this.updateRemeber(1);
            }
            else if (!ckbRememberMe.Checked)
            {
                this.updateRemeber(0);
            }
        }

        bool isActivated()
        {
            using(SQLiteConnection con = new SQLiteConnection(connection))
            {
                string sql = "SELECT * FROM Activations";
                SQLiteCommand com = new SQLiteCommand(sql, con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        void rememberMe()
        {
            using (SQLiteConnection con = new SQLiteConnection(connection))
            {
                string sql = "SELECT * FROM Remember_Me";
                SQLiteCommand com = new SQLiteCommand(sql, con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    int status = Convert.ToInt32(row["status"]);
                    if (status == 1)
                    {
                        this.txtUsername.Text = row["username"].ToString();
                        this.txtPassword.Text = row["password"].ToString();
                        this.ckbRememberMe.Checked = true;
                    }
                }
            }
        }

        void updateRemeber(int status)
        {
            using(SQLiteConnection con =new SQLiteConnection(connection))
            {
                string sql = "UPDATE Remember_Me SET username = '" + LoginedUser.Username + "', password = '" + LoginedUser.Password + "', status = " + status;
                SQLiteCommand com = new SQLiteCommand(sql, con);
                con.Open();
                com.ExecuteNonQuery();
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
                LoginedUser = new Models.Student()
                {
                    Id = Convert.ToInt32(Dt.Rows[0]["id"]),
                    Name = Dt.Rows[0]["name"].ToString(),
                    Username = Dt.Rows[0]["username"].ToString(),
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

        public static void hideSignUp()
        {
            string query = "SELECT * FROM Students";
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
                LinkLabel.Visible = false;
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
            ThisForm = this;
            this.Hide();
            new Register().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           this.rememberMe(); 
        }  
    } 
}
