using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Login.ThisForm.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StuTicket().Show();
        }

        private void btnQuation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StuQuation().Show();
        }
    }
}
