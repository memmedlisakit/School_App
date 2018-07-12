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
            new Students().Show();
            ThisForm = this;
            this.Hide();
        } 

        private void aCtivationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Activations().Show();
            ThisForm = this;
            this.Hide();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThisForm = this;
            new Category().Show();
        }

        private void quationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThisForm = this;
            new Quation().Show();
            this.Hide();
        }
    }
}
