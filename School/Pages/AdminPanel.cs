using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Pages
{
    public partial class AdminPanel : Form
    {
        public static Form ThisForm;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Login.ThisForm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Student().Show();
            ThisForm = this;
            this.Hide();
        } 

        private void aCtivationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddActivation().Show();
            ThisForm = this;
            this.Hide();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThisForm = this;
            new Categories().Show();
        }

        private void quationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThisForm = this;
            new AddQuation().Show();
            this.Hide();
        }

        private void quationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThisForm = this;
            new Quations().Show();
            this.Hide();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThisForm = this;
            new Tickets().Show();
            this.Hide();
        }
    }
}
