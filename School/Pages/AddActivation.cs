using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using School.Settings; 
using System.Web.Script.Serialization;
using Newtonsoft.Json; 
using School.Models;
using System.Net.Http;
using System.Net.Http.Headers; 

namespace School.Pages
{
    public partial class AddActivation : Form
    {
        List<string> activations = new List<string>();

        public static string message { get; set; } = "";
         
        public AddActivation()
        {
            InitializeComponent();
            btnExel.Enabled = false;
        }




        private void btnActivation_Click(object sender, EventArgs e)
        { 
            int count = 0;
            if (txtActivation.Text == ""||(!int.TryParse(this.txtActivation.Text, out count))|| txtActivation.Text == "0")
            {
                this.lblCount.Text = "Enter count of activation !!!";
                return;
            }
            else
            {
                if (count > 1000)
                {
                    this.lblCount.Text = "Maximim count 1000 !!!";
                    return;
                }
                btnActivation.Enabled = false;
                this.lblCount.Text = "";
                this.dgvData.Rows.Clear(); 
                this.activations = this.ActivateGenerator(count);
                int i = 0;

                foreach (string activate in this.activations)
                {
                    this.dgvData.Rows.Add();
                    this.dgvData.Rows[i].Cells[0].Value = activate;
                    i++;
                }
            }
            btnExel.Enabled = true;
        }

        public void btnExel_Click(object sender, EventArgs e)
        {
            btnExel.Enabled = false;
            btnExel.Text = "Wait...";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                addData(this.activations);
                if (message != "")
                {
                    this.lblError.ForeColor = Color.Red;
                    this.lblError.Text = message;
                    return;
                }
                this.lblError.ForeColor = Color.LawnGreen;
                this.lblError.Text = "Added Succesfuly"; 
                Extentions.Export_data(this.dgvData, sfd.FileName);
            }
            btnExel.Text = "Finish";
        }

        static void addData(List<string> activations)
        {
            try
            {
                foreach (string code in activations)
                {
                    Activation_C activation = new Activation_C { activation_code = code, status = false };
                    string json = new JavaScriptSerializer().Serialize(activation);
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://sakit.azurewebsites.net/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        HttpResponseMessage response = client.GetAsync("api/activations?data=" + json).Result; 
                    }
                }
            }
            catch (Exception)
            {
                message = "An error accourd connecting with database";
            }
        }

        private List<string> ActivateGenerator(int count)
        {
            List<string> activations = new List<string>();
            while(true)
            {
                string activate = "";
                Random rnd = new Random();
                MD5 md5 = new MD5CryptoServiceProvider();
                string text = rnd.Next(0, 5000).ToString();
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
                foreach (var c in md5.Hash)
                {
                    activate += c;
                }
                activate = activate.Substring(0, 12);
                activations.Add(activate);
                activations = activations.Distinct().ToList();
                if (activations.Count == count) break;
            }
            return activations;
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            AdminPanel.ThisForm.Show();
            this.Hide();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            getData();
            if(message != "")
            {
                this.lblError.ForeColor = Color.Red;
                this.lblError.Text = message;
            }
            else
            {
                this.lblError.ForeColor = Color.LawnGreen;
                this.lblError.Text = "Deleted all activations succesfuly";
            }
        }

        static async void deleteData(string data)
        {
            try
            {
                string code = data;
                string username = "delete";
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://sakit.azurewebsites.net/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync($"api/activations?data={code}&username={username}");
                }
            }
            catch (Exception)
            {
                message = "An error accourd connecting with database";
            }
        }
         
        static void getData()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://sakit.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/activations").Result;
                if (response.IsSuccessStatusCode)
                {
                    var products = response.Content.ReadAsStringAsync().Result;
                    List<Activation_C> activations = JsonConvert.DeserializeObject<List<Activation_C>>(products);
                    foreach (Activation_C a in activations)
                    {
                        deleteData(a.activation_code);
                    }
                }
            }
            catch (Exception)
            {
                message = "An error accourd connecting with database";
            } 
        }
    }
}
