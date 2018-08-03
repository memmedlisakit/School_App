using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Windows.Forms;
using School.Models;
using System.Linq;
using System.Data.SQLite;

namespace School.Pages
{
    public partial class CheckActivation : Form
    { 
        public static Label Error { get; set; }

        public static Form ThisForm { get; set; }

        public CheckActivation()
        {
            InitializeComponent();
            Error = this.lblError;
            ThisForm = this;
        }



        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;
            string code = this.txtActivation.Text;
            string username = Login.LoginedUser.Username;
            UpdateData(code, username); 
        }
         
        static async void UpdateData(string _code, string _username)
        {
            try
            {
                string code = _code.Trim();
                string username = _username;
                using (var client = new HttpClient())
                { 
                    client.BaseAddress = new Uri("http://sakit.azurewebsites.net/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync($"api/activations?data={code}&username={username}");
                    insertLocalActivation(code, username, 1, response.StatusCode.ToString().ToLower());
                }
            }
            catch (Exception)
            {
                Error.Text = "An error accourd with connecting server";
            }
        }
         
        static void insertLocalActivation(string _code, string _username, int _status, string status_code)
        {
            if (status_code == "ok")
            {
                using (SQLiteConnection con = new SQLiteConnection(Login.connection))
                {
                    string sql = $"INSERT INTO Activations(activation_code, username, status) VALUES('{_code}', '{_username}', {_status})";
                    SQLiteCommand com = new SQLiteCommand(sql, con);
                    con.Open();
                    com.ExecuteNonQuery();

                    ThisForm.Close();
                    new Dashboard().Show();
                }; 
            }
            else
            {
                Error.Text = "Actiation code is used !!!";
            }
           
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Login.ThisForm.Show();
        }
    }
}
