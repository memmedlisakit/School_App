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
    public partial class Quation : Form
    {
        int top = 0;
        public Quation()
        {
            InitializeComponent();
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            AdminPanel.ThisForm.Show();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            CheckBox chkb = new CheckBox();
            chkb.Text = this.txtAnswer.Text;
            chkb.Checked = false;
            chkb.Top = top;
            this.pnlAnswer.Controls.Add(chkb);
            this.txtAnswer.Text = "";
            top += 20;
        }
    }
}
