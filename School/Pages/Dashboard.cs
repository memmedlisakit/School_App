using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace School.Pages
{
    public partial class Dashboard : Form
    {
        public static Form ThisForm { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            ThisForm = this;
            this.pctMain.Image = School.Properties.Resources.dashboard;
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Login.ThisForm.Show();
        }

        private void QuationClick(object sender, EventArgs e)
        {
            this.Hide();
            new StuQuation().Show();
        }

        private void TicketClick(object sender, EventArgs e)
        {
            this.Hide();
            new StuTicket().ShowDialog();
        }

        private void UpdateProfile(object sender, EventArgs e)
        {
            this.txtEmail.Text = Login.LoginedUser.Email;
            this.txtName.Text = Login.LoginedUser.Name;
            this.txtSurname.Text = Login.LoginedUser.Surname;
            if (Login.LoginedUser.Gender)
            {
                this.ckbMale.Checked = true;
            }
            else
            {
                this.ckbFemale.Checked = true;
            }
            this.grpStuProfile.Visible = !this.grpStuProfile.Visible;
            this.grpInfo.Visible = !this.grpStuProfile.Visible;
            this.pnlAbout.Visible = false;
        }



        private void FormResize(object sender, EventArgs e)
        { 
            this.grpStuProfile.Left = ((this.Width - this.grpStuProfile.Width) / 2 - 8);
            this.grpInfo.Left = ((this.Width - this.grpInfo.Width) / 2 - 8);
            this.pnlAbout.Left = ((this.Width - this.pnlAbout.Width) / 2 - 8);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        { 
            this.grpStuProfile.Left = ((this.Width - this.grpStuProfile.Width) / 2 - 8);
            this.grpInfo.Left = ((this.Width - this.grpInfo.Width) / 2 - 8);
            this.grpInfo.Top = 50;
            this.pnlAbout.Left = ((this.Width - this.pnlAbout.Width) / 2 - 8);
            this.pnlAbout.Top = 100;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grpStuProfile.Visible = false;
            this.grpInfo.Visible = false;
            this.pnlAbout.Visible = true;
        } 
    }
}
