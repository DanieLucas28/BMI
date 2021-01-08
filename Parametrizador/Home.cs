using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace Parametrizador
{
    public partial class Home : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public Home()
        {
            InitializeComponent();
            User.Text = Environment.UserName;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        //Structs
        private struct RGBColors
        { 
             public static Color color1 = Color.FromArgb(249, 118, 176);
             public static Color color2 = Color.FromArgb(255, 69, 0);
             public static Color color3 = Color.FromArgb(95, 77, 221);
             public static Color color4 = Color.FromArgb(172, 126, 241);
        }

        //Meth
        private void ActivateButton(object senderBtn, Color color)
        { 
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        { 
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only 1 form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            PictureHS.Image = Properties.Resources.hsb;
        }
        private void PictureHS_MouseLeave(object sender, EventArgs e)
        {
            PictureHS.Image = Properties.Resources.hs;
        }

        private void PictureSD_MouseEnter(object sender, EventArgs e)
        {
            PictureSD.Image = Properties.Resources.sdb;
        }
        private void PictureSD_MouseLeave(object sender, EventArgs e)
        {
            PictureSD.Image = Properties.Resources.sd;

        }
        private void PictureCookies_MouseEnter(object sender, EventArgs e)
        {
            PictureCookies.Image = Properties.Resources.cookieb;
        }
        private void PictureCookies_MouseLeave(object sender, EventArgs e)
        {
            PictureCookies.Image = Properties.Resources.cookie;

        }

        private void BtnMistura_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormMistura());
        }

        private void BtnFormação_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormFormação());
        }

        private void BtnForneamento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormForneamento());
        }

        private void BtnResfriamento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormResfriamento());
        }

        //drag form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        //Close, maximize and minimize

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(26, 25, 62);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

}
