using FontAwesome.Sharp;
using Parametrizador.Main;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
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
            public static Color color1 = Color.FromArgb(249, 118, 176); //rosa
            public static Color color2 = Color.FromArgb(255, 69, 0); //laranja
            public static Color color3 = Color.FromArgb(176, 0, 0); //vermelho escuro
            public static Color color4 = Color.FromArgb(255, 255, 0);
            public static Color branco = Color.FromArgb(255, 255, 255); //branco
        }

        public void Toppa(string s, Image d)
        {
            currentimg.Visible = true;
            currentlabel.Visible = true;
            currentlabel.Text = s;
            currentimg.Image = d;
        }

        //Meth
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(7, 87, 152);
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
                currentBtn.BackColor = Color.FromArgb(6, 77, 135);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
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

            if (String.Equals(currentChildForm.Name, "Fontes"))
             {
                Toppa("Referências", Parametrizador.Properties.Resources.hsw);
                Visiblefalse();
             }

        }

        private void Visiblefalse()
        {
            BtnMisturaHS.Visible = false;
            BtnResfriamentoHS.Visible = false;
            BtnForneamentoHS.Visible = false;
            BtnFormaçãoHS.Visible = false;
            BtnResfriamentoCookie.Visible = false;
            BtnForneamentoCookie.Visible = false;
            BtnFormaçãoCookie.Visible = false;
            BtnMisturaCookie.Visible = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

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

        // funções dos botões centrais


        private void HSbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hard_Sweet.HSMain());
            Toppa("Hard Sweet", Parametrizador.Properties.Resources.hsw);
            BtnResfriamentoHS.Visible = true;
            BtnForneamentoHS.Visible = true;
            BtnFormaçãoHS.Visible = true;
            BtnMisturaHS.Visible = true;
           

        }

        private void CookieButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cookies.CookieMain());
            BtnResfriamentoCookie.Visible = true;
            BtnForneamentoCookie.Visible = true;
            BtnFormaçãoCookie.Visible = true;
            BtnMisturaCookie.Visible = true;
        }


        private void SDbutton_Click(object sender, EventArgs e)
        {
            Toppa("Teste", Parametrizador.Properties.Resources.hsw);
        }

        // botão home

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visiblefalse();
            DisableButton();
            
            leftBorderBtn.Visible = false;
            currentChildForm.Close();
        }

        // menu
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void conteúdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Fontes());
        }

        // funções dos botões laterais

        private void BtnMistura_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormMistura());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;

        }

        private void BtnFormação_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormFormaçãoHS());

        }

        private void BtnForneamento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormForneamentoHS());

        }

        private void BtnResfriamento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormResfriamento());

        }

        private void BtnFormaçãoCookie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnMisturaCookie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnForneamentoCookie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnResfriamentoCookie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }
    }   


}
