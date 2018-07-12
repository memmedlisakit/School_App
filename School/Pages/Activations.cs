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

namespace School.Pages
{
    public partial class Activations : Form
    {
        List<string> activations = new List<string>();
        public Activations()
        {
            InitializeComponent();
        }

        private void btnActivation_Click(object sender, EventArgs e)
        {
            if (txtActivation.Value == 0)
            {
                this.lblCount.Text = "Enter count of activation !!!";
            }
            else
            {
                this.lblCount.Text = "";
                this.dgvData.Rows.Clear(); 
                this.activations = this.ActivateGenerator((int)this.txtActivation.Value);
                int i = 0;

                foreach (string activate in this.activations)
                {
                    this.dgvData.Rows.Add();
                    this.dgvData.Rows[i].Cells[0].Value = activate;
                    i++;
                }
            }
        }

        private void btnExel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(this.dgvData, sfd.FileName);
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
                if (activations.Count == count) break;
                activations = activations.Distinct().ToList();
            }
            return activations;
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            AdminPanel.ThisForm.Show();
            this.Hide();
        } 
    }
}
