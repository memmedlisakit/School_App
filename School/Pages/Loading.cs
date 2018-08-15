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
    public partial class Loading : Form
    {
        public static Form ThisForm { get; set; }
        public Loading()
        {
            InitializeComponent();
            ThisForm = this;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public void setImage()
        {
            this.BackgroundImage = School.Properties.Resources.initial;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
