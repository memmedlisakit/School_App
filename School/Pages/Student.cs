using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System;
using System.Drawing;
using School.Settings;
using System.Net.Http;
using System.Net.Http.Headers;
using School.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace School.Pages
{
    public partial class Student : Form
    {
        private static string message = "";

        public Student()
        {
            InitializeComponent();
            this.getData();
            if(message != "")
            {
                this.lblError.Text = message;
            }
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            AdminPanel.ThisForm.Show();
        }

        //static async void deleteData(string data)
        //{
        //    try
        //    {
        //        string code = data;
        //        string username = "delete";
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("http://sakit.azurewebsites.net/");
        //            client.DefaultRequestHeaders.Accept.Clear();
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            HttpResponseMessage response = await client.GetAsync($"api/activations?data={code}&username={username}");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        message = "An error accourd connecting with database";
        //    }
        //}

        void getData()
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
                    int index = 0;
                    this.lblCount.Text = activations.Count.ToString();
                    foreach (Activation_C a in activations)
                    {
                        this.dgvData.Rows.Add();
                        this.dgvData.Rows[index].Cells[0].Value = a.activation_code;
                        this.dgvData.Rows[index].Cells[1].Value = a.username;
                        this.dgvData.Rows[index].Cells[2].Value = a.status ? "Activated" : "No Activated";
                        index++;
                    }
                }
            }
            catch (Exception)
            {
                message = "An error occurred connecting with database please check your internet connection";
            }
        }

    }
}
