using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parametrizador
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
            User.Text = Environment.UserName;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PictureCC_MouseEnter(object sender, EventArgs e)
        {
            PictureCC.Image = Properties.Resources.ccb;
        }
        private void PictureCC_MouseLeave(object sender, EventArgs e)
        {
           PictureCC.Image = Properties.Resources.cc;
        }
        private void PictureHS_MouseEnter(object sender, EventArgs e)
        {
            PictureCC.Image = Properties.Resources.hsb;
        }
        private void PictureHS_MouseLeave(object sender, EventArgs e)
        {
            PictureCC.Image = Properties.Resources.hs;
        }

     
    }
}
