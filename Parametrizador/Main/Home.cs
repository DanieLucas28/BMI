 using FontAwesome.Sharp;
using Parametrizador.Cookies;
using Parametrizador.Impressão;
using Parametrizador.Main;
using Parametrizador.Properties;
using Parametrizador.Short_Dough;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Parametrizador
{
    public partial class Home : Form
    {

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static string tipobiscoito;

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
            childForm.AutoScroll = true;
            childForm.AutoScrollMinSize = new Size(1200,500);
            

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
            BtnFormaçãoCookie.Visible =false;
            BtnMisturaCookie.Visible = false;
            BtnResfriamentoSD.Visible =false;
            BtnRecheioSD.Visible =     false;
            BtnForneamentoSD.Visible = false;
            BtnFormaçãoSD.Visible =    false;
            BtnMisturaSD.Visible = false;

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

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
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

        #region funções dos botões centrais

        private void CCbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cream_Cracker.CCMain());
            Toppa("Cream Cracker", Parametrizador.Properties.Resources.ccw);
        }

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
            Toppa("Soft Dough", Parametrizador.Properties.Resources.cookiew);
            OpenChildForm(new Cookies.CookieMain());
            BtnResfriamentoCookie.Visible = true;
            BtnForneamentoCookie.Visible = true;
            BtnFormaçãoCookie.Visible = true;
            BtnMisturaCookie.Visible = true;
        }

        private void SDbutton_Click(object sender, EventArgs e)
        {
            tipobiscoito = "SD";
            Toppa("Short Dough", Parametrizador.Properties.Resources.sdw);
            OpenChildForm(new Short_Dough.SDMain());
            BtnResfriamentoSD.Visible =true;
            BtnRecheioSD.Visible =     true;
            BtnForneamentoSD.Visible = true;
            BtnFormaçãoSD.Visible =    true;
            BtnMisturaSD.Visible = true;
        }
        #endregion
        
        // botão home

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visiblefalse();
            DisableButton();
            
            leftBorderBtn.Visible = false;
            currentChildForm.Close();
            currentimg.Visible = false;
            currentlabel.Visible = false;

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

        private void shortDoughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Short_Dough.SDMain());
            Toppa("Short Dough", Resources.sdw);
        }

        #region Botões laterais

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
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;

        }

        private void BtnForneamento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormForneamentoHS());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;

        }

        private void BtnResfriamento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormResfriamento());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;

        }

        private void BtnFormaçãoCookie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormFormaçãoCookie());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void BtnMisturaCookie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormMisturaCookie());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void BtnForneamentoCookie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormForneamentoCookie());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void BtnResfriamentoCookie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormResfriamentoCookie());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void BtnFormaçãoSD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormFormaçãoSD());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void BtnMisturaSD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormMisturaSD());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void BtnForneamentoSD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormForneamentoSD());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void BtnResfriamentoSD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormResfriamentoSD());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void BtnRecheioSD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormRecheioSD());
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        #endregion


        #region Impressão

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImpressãoSD sf = new ImpressãoSD();
            sf.ShowDialog();
        }

        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (System.Drawing.Printing.PrintDocument print = new System.Drawing.Printing.PrintDocument())
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                print.PrintPage += Print_PrintPage;
                dialog.Document = print;
                dialog.ShowDialog();
            }
        }

        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Image image = Parametrizador.Properties.Resources.logotiny;
            Font fonttexto = new Font("Trebuchet MS", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
          
            using (Font font = new Font("Arial", 16))
            {
                g.DrawString("Relatório Biscuits Manufacturing Intelligence", new Font("Trebuchet MS", 18, FontStyle.Bold), Brushes.Black, new Point(20,50));
                g.DrawImage(image, new Point(580, 0));

            }
            if (tipobiscoito == "SD")
            {
                g.DrawString("______________________________________________________________________________________________________________________________", new Font("Trebuchet MS", 14, FontStyle.Bold), Brushes.Black, new Point(0, 80));
                Rectangle rect = new Rectangle(new Point(0, 110), new Size(5000,30));
                g.FillRectangle(Brushes.LightSteelBlue, rect);
                g.DrawString("Mistura", new Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.RoyalBlue, new Point(20, 110));
                g.DrawString("Temperatura da massa: " + FormMisturaSD.tempmassateste, new Font("Trebuchet MS", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.Black, new Point(20, 140));
                g.DrawString("Fluxo de adição utilizado: " + FormMisturaSD.fluxoaddprint, new Font("Trebuchet MS", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.Black, new Point(20, 160));
                g.DrawString("Tempo de mistura do 1° estágio: " + FormMisturaSD.tempo1print, new Font("Trebuchet MS", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.Black, new Point(20, 180));
                g.DrawString("Tempo de mistura do 2° estágio: " + FormMisturaSD.tempo2print, new Font("Trebuchet MS", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.Black, new Point(20, 200));


                Rectangle rect2 = new Rectangle(new Point(0, 230), new Size(5000, 30));
                g.FillRectangle(Brushes.LightSteelBlue, rect2);
                g.DrawString("Formação", new Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.RoyalBlue, new Point(20, 230));
                g.DrawString("Tipo de lona de extração: " + FormFormaçãoSD.lonaexSD, new Font("Trebuchet MS", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.Black, new Point(20, 260));
                g.DrawString("Dureza do rolo utilizada: " + FormFormaçãoSD.durezaSD + " shores", new Font("Trebuchet MS", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.Black, new Point(20, 280));

                Rectangle rect3 = new Rectangle(new Point(0, 310), new Size(5000, 30));
                g.FillRectangle(Brushes.LightSteelBlue, rect3);
                g.DrawString("Forneamento", new Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.RoyalBlue, new Point(20, 310));
                
                if (FormForneamentoSD.zonasSD == "4") {
                    Rectangle zona = new Rectangle(new Point(20, 342), new Size(46, 22));
                    Rectangle temp = new Rectangle(new Point(68, 342), new Size(45, 22));
                    g.FillRectangle(Brushes.LightSteelBlue, zona);
                    g.FillRectangle(Brushes.LightSteelBlue, temp);
                    g.DrawString("°C", fonttexto, Brushes.Black, new Point(72, 342));
                    g.DrawString("Zona", fonttexto, Brushes.Black, new Point(21, 342));

                    Rectangle z1 = new Rectangle(new Point(21, 365), new Size(45, 20));
                    Rectangle border = new Rectangle(new Point(20, 364), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border);
                    g.FillRectangle(Brushes.White, z1);
                    Rectangle t1 = new Rectangle(new Point(67, 365), new Size(45,20));
                    Rectangle bordert1 = new Rectangle(new Point(66, 364), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert1);
                    g.FillRectangle(Brushes.White, t1);
                    g.DrawString(FormForneamentoSD.zona1, fonttexto, Brushes.Black, new Point(28, 365));
                    g.DrawString("1", fonttexto, Brushes.Black, new Point(32, 365));

                    Rectangle z2 = new Rectangle(new Point(21, 385), new Size(45, 20));
                    Rectangle border2 = new Rectangle(new Point(20, 384), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border2);
                    g.FillRectangle(Brushes.White, z2);                    
                    Rectangle t2 = new Rectangle(new Point(67, 385), new Size(45, 20));
                    Rectangle bordert2 = new Rectangle(new Point(66, 384), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert2);
                    g.FillRectangle(Brushes.White, t2);
                    g.DrawString(FormForneamentoSD.zona2, fonttexto, Brushes.Black, new Point(28, 385));
                    g.DrawString("2", fonttexto, Brushes.Black, new Point(32, 385));

                    Rectangle z3 = new Rectangle(new Point(21, 405), new Size(45, 20));
                    Rectangle border3 = new Rectangle(new Point(20, 404), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border3);
                    g.FillRectangle(Brushes.White, z3);
                    Rectangle t3 = new Rectangle(new Point(67, 405), new Size(45, 20));
                    Rectangle bordert3 = new Rectangle(new Point(66, 404), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert3);
                    g.FillRectangle(Brushes.White, t3);
                    g.DrawString(FormForneamentoSD.zona3, fonttexto, Brushes.Black, new Point(28, 405));
                    g.DrawString("3", fonttexto, Brushes.Black, new Point(32, 405));

                    Rectangle z4 = new Rectangle(new Point(21, 425), new Size(45, 20));
                    Rectangle border4 = new Rectangle(new Point(20, 424), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border4);
                    g.FillRectangle(Brushes.White, z4);
                    Rectangle t4 = new Rectangle(new Point(67, 425), new Size(45, 20));
                    Rectangle bordert4 = new Rectangle(new Point(66, 424), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert4);
                    g.FillRectangle(Brushes.White, t4);
                    g.DrawString(FormForneamentoSD.zona4, fonttexto, Brushes.Black, new Point(28, 425));
                    g.DrawString("4", fonttexto, Brushes.Black, new Point(32, 425));
                }
                if (FormForneamentoSD.zonasSD == "5")
                {
                    Rectangle zona = new Rectangle(new Point(20, 342), new Size(46, 22));
                    Rectangle temp = new Rectangle(new Point(68, 342), new Size(45, 22));
                    g.FillRectangle(Brushes.LightSteelBlue, zona);
                    g.FillRectangle(Brushes.LightSteelBlue, temp);
                    g.DrawString("°C", fonttexto, Brushes.Black, new Point(72, 342));
                    g.DrawString("Zona", fonttexto, Brushes.Black, new Point(21, 342));

                    Rectangle z1 = new Rectangle(new Point(21, 365), new Size(45, 20));
                    Rectangle border = new Rectangle(new Point(20, 364), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border);
                    g.FillRectangle(Brushes.White, z1);
                    Rectangle t1 = new Rectangle(new Point(67, 365), new Size(45, 20));
                    Rectangle bordert1 = new Rectangle(new Point(66, 364), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert1);
                    g.FillRectangle(Brushes.White, t1);
                    g.DrawString(FormForneamentoSD.zona1, fonttexto, Brushes.Black, new Point(28, 365));
                    g.DrawString("1", fonttexto, Brushes.Black, new Point(32, 365));

                    Rectangle z2 = new Rectangle(new Point(21, 385), new Size(45, 20));
                    Rectangle border2 = new Rectangle(new Point(20, 384), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border2);
                    g.FillRectangle(Brushes.White, z2);
                    Rectangle t2 = new Rectangle(new Point(67, 385), new Size(45, 20));
                    Rectangle bordert2 = new Rectangle(new Point(66, 384), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert2);
                    g.FillRectangle(Brushes.White, t2);
                    g.DrawString(FormForneamentoSD.zona2, fonttexto, Brushes.Black, new Point(28, 385));
                    g.DrawString("2", fonttexto, Brushes.Black, new Point(32, 385));

                    Rectangle z3 = new Rectangle(new Point(21, 405), new Size(45, 20));
                    Rectangle border3 = new Rectangle(new Point(20, 404), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border3);
                    g.FillRectangle(Brushes.White, z3);
                    Rectangle t3 = new Rectangle(new Point(67, 405), new Size(45, 20));
                    Rectangle bordert3 = new Rectangle(new Point(66, 404), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert3);
                    g.FillRectangle(Brushes.White, t3);
                    g.DrawString(FormForneamentoSD.zona3, fonttexto, Brushes.Black, new Point(28, 405));
                    g.DrawString("3", fonttexto, Brushes.Black, new Point(32, 405));

                    Rectangle z4 = new Rectangle(new Point(21, 425), new Size(45, 20));
                    Rectangle border4 = new Rectangle(new Point(20, 424), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border4);
                    g.FillRectangle(Brushes.White, z4);
                    Rectangle t4 = new Rectangle(new Point(67, 425), new Size(45, 20));
                    Rectangle bordert4 = new Rectangle(new Point(66, 424), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert4);
                    g.FillRectangle(Brushes.White, t4);
                    g.DrawString(FormForneamentoSD.zona4, fonttexto, Brushes.Black, new Point(28, 425));
                    g.DrawString("4", fonttexto, Brushes.Black, new Point(32, 425));

                    Rectangle z5 = new Rectangle(new Point(21, 445), new Size(45, 20));
                    Rectangle border5 = new Rectangle(new Point(20, 444), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border5);
                    g.FillRectangle(Brushes.White, z5);
                    Rectangle t5 = new Rectangle(new Point(67, 445), new Size(45, 20));
                    Rectangle bordert5 = new Rectangle(new Point(66, 444), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert5);
                    g.FillRectangle(Brushes.White, t5);
                    g.DrawString(FormForneamentoSD.zona4, fonttexto, Brushes.Black, new Point(28, 445));
                    g.DrawString("5", fonttexto, Brushes.Black, new Point(32, 445));
                }
                if (FormForneamentoSD.zonasSD == "6")
                {
                    Rectangle zona = new Rectangle(new Point(20, 342), new Size(46, 22));
                    Rectangle temp = new Rectangle(new Point(68, 342), new Size(45, 22));
                    g.FillRectangle(Brushes.LightSteelBlue, zona);
                    g.FillRectangle(Brushes.LightSteelBlue, temp);
                    g.DrawString("°C", fonttexto, Brushes.Black, new Point(72, 342));
                    g.DrawString("Zona", fonttexto, Brushes.Black, new Point(21, 342));

                    Rectangle z1 = new Rectangle(new Point(21, 365), new Size(45, 20));
                    Rectangle border = new Rectangle(new Point(20, 364), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border);
                    g.FillRectangle(Brushes.White, z1);
                    Rectangle t1 = new Rectangle(new Point(67, 365), new Size(45, 20));
                    Rectangle bordert1 = new Rectangle(new Point(66, 364), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert1);
                    g.FillRectangle(Brushes.White, t1);
                    g.DrawString(FormForneamentoSD.zona1, fonttexto, Brushes.Black, new Point(28, 365));
                    g.DrawString("1", fonttexto, Brushes.Black, new Point(32, 365));

                    Rectangle z2 = new Rectangle(new Point(21, 385), new Size(45, 20));
                    Rectangle border2 = new Rectangle(new Point(20, 384), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border2);
                    g.FillRectangle(Brushes.White, z2);
                    Rectangle t2 = new Rectangle(new Point(67, 385), new Size(45, 20));
                    Rectangle bordert2 = new Rectangle(new Point(66, 384), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert2);
                    g.FillRectangle(Brushes.White, t2);
                    g.DrawString(FormForneamentoSD.zona2, fonttexto, Brushes.Black, new Point(28, 385));
                    g.DrawString("2", fonttexto, Brushes.Black, new Point(32, 385));

                    Rectangle z3 = new Rectangle(new Point(21, 405), new Size(45, 20));
                    Rectangle border3 = new Rectangle(new Point(20, 404), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border3);
                    g.FillRectangle(Brushes.White, z3);
                    Rectangle t3 = new Rectangle(new Point(67, 405), new Size(45, 20));
                    Rectangle bordert3 = new Rectangle(new Point(66, 404), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert3);
                    g.FillRectangle(Brushes.White, t3);
                    g.DrawString(FormForneamentoSD.zona3, fonttexto, Brushes.Black, new Point(28, 405));
                    g.DrawString("3", fonttexto, Brushes.Black, new Point(32, 405));

                    Rectangle z4 = new Rectangle(new Point(21, 425), new Size(45, 20));
                    Rectangle border4 = new Rectangle(new Point(20, 424), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border4);
                    g.FillRectangle(Brushes.White, z4);
                    Rectangle t4 = new Rectangle(new Point(67, 425), new Size(45, 20));
                    Rectangle bordert4 = new Rectangle(new Point(66, 424), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert4);
                    g.FillRectangle(Brushes.White, t4);
                    g.DrawString(FormForneamentoSD.zona4, fonttexto, Brushes.Black, new Point(28, 425));
                    g.DrawString("4", fonttexto, Brushes.Black, new Point(32, 425));

                    Rectangle z5 = new Rectangle(new Point(21, 445), new Size(45, 20));
                    Rectangle border5 = new Rectangle(new Point(20, 444), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border5);
                    g.FillRectangle(Brushes.White, z5);
                    Rectangle t5 = new Rectangle(new Point(67, 445), new Size(45, 20));
                    Rectangle bordert5 = new Rectangle(new Point(66, 444), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert5);
                    g.FillRectangle(Brushes.White, t5);
                    g.DrawString(FormForneamentoSD.zona4, fonttexto, Brushes.Black, new Point(28, 445));
                    g.DrawString("5", fonttexto, Brushes.Black, new Point(32, 445));

                    Rectangle z6 = new Rectangle(new Point(21, 465), new Size(45, 20));
                    Rectangle border6 = new Rectangle(new Point(20, 464), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border6);
                    g.FillRectangle(Brushes.White, z6);
                    Rectangle t6 = new Rectangle(new Point(67, 465), new Size(45, 20));
                    Rectangle bordert6 = new Rectangle(new Point(66, 464), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert6);
                    g.FillRectangle(Brushes.White, t6);
                    g.DrawString(FormForneamentoSD.zona4, fonttexto, Brushes.Black, new Point(28, 465));
                    g.DrawString("6", fonttexto, Brushes.Black, new Point(32, 465));

                }
                if (FormForneamentoSD.zonasSD == "7")
                {
                    Rectangle zona = new Rectangle(new Point(20, 342), new Size(46, 22));
                    Rectangle temp = new Rectangle(new Point(68, 342), new Size(45, 22));
                    g.FillRectangle(Brushes.LightSteelBlue, zona);
                    g.FillRectangle(Brushes.LightSteelBlue, temp);
                    g.DrawString("°C", fonttexto, Brushes.Black, new Point(72, 342));
                    g.DrawString("Zona", fonttexto, Brushes.Black, new Point(21, 342));

                    Rectangle z1 = new Rectangle(new Point(21, 365), new Size(45, 20));
                    Rectangle border = new Rectangle(new Point(20, 364), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border);
                    g.FillRectangle(Brushes.White, z1);
                    Rectangle t1 = new Rectangle(new Point(67, 365), new Size(45, 20));
                    Rectangle bordert1 = new Rectangle(new Point(66, 364), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert1);
                    g.FillRectangle(Brushes.White, t1);
                    g.DrawString(FormForneamentoSD.zona1, fonttexto, Brushes.Black, new Point(74, 365));
                    g.DrawString("1", fonttexto, Brushes.Black, new Point(32, 365));

                    Rectangle z2 = new Rectangle(new Point(21, 385), new Size(45, 20));
                    Rectangle border2 = new Rectangle(new Point(20, 384), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border2);
                    g.FillRectangle(Brushes.White, z2);
                    Rectangle t2 = new Rectangle(new Point(67, 385), new Size(45, 20));
                    Rectangle bordert2 = new Rectangle(new Point(66, 384), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert2);
                    g.FillRectangle(Brushes.White, t2);
                    g.DrawString(FormForneamentoSD.zona2, fonttexto, Brushes.Black, new Point(74, 385));
                    g.DrawString("2", fonttexto, Brushes.Black, new Point(32, 385));

                    Rectangle z3 = new Rectangle(new Point(21, 405), new Size(45, 20));
                    Rectangle border3 = new Rectangle(new Point(20, 404), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border3);
                    g.FillRectangle(Brushes.White, z3);
                    Rectangle t3 = new Rectangle(new Point(67, 405), new Size(45, 20));
                    Rectangle bordert3 = new Rectangle(new Point(66, 404), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert3);
                    g.FillRectangle(Brushes.White, t3);
                    g.DrawString(FormForneamentoSD.zona3, fonttexto, Brushes.Black, new Point(74, 405));
                    g.DrawString("3", fonttexto, Brushes.Black, new Point(32, 405));

                    Rectangle z4 = new Rectangle(new Point(21, 425), new Size(45, 20));
                    Rectangle border4 = new Rectangle(new Point(20, 424), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border4);
                    g.FillRectangle(Brushes.White, z4);
                    Rectangle t4 = new Rectangle(new Point(67, 425), new Size(45, 20));
                    Rectangle bordert4 = new Rectangle(new Point(66, 424), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert4);
                    g.FillRectangle(Brushes.White, t4);
                    g.DrawString(FormForneamentoSD.zona4, fonttexto, Brushes.Black, new Point(74, 425));
                    g.DrawString("4", fonttexto, Brushes.Black, new Point(32, 425));

                    Rectangle z5 = new Rectangle(new Point(21, 445), new Size(45, 20));
                    Rectangle border5 = new Rectangle(new Point(20, 444), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border5);
                    g.FillRectangle(Brushes.White, z5);
                    Rectangle t5 = new Rectangle(new Point(67, 445), new Size(45, 20));
                    Rectangle bordert5 = new Rectangle(new Point(66, 444), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert5);
                    g.FillRectangle(Brushes.White, t5);
                    g.DrawString(FormForneamentoSD.zona5, fonttexto, Brushes.Black, new Point(74, 445));
                    g.DrawString("5", fonttexto, Brushes.Black, new Point(32, 445));

                    Rectangle z6 = new Rectangle(new Point(21, 465), new Size(45, 20));
                    Rectangle border6 = new Rectangle(new Point(20, 464), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border6);
                    g.FillRectangle(Brushes.White, z6);
                    Rectangle t6 = new Rectangle(new Point(67, 465), new Size(45, 20));
                    Rectangle bordert6 = new Rectangle(new Point(66, 464), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert6);
                    g.FillRectangle(Brushes.White, t6);
                    g.DrawString(FormForneamentoSD.zona6, fonttexto, Brushes.Black, new Point(74, 465));
                    g.DrawString("6", fonttexto, Brushes.Black, new Point(32, 465));

                    Rectangle z7 = new Rectangle(new Point(21, 485), new Size(45, 20));
                    Rectangle border7 = new Rectangle(new Point(20, 484), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, border7);
                    g.FillRectangle(Brushes.White, z7);
                    Rectangle t7 = new Rectangle(new Point(67, 485), new Size(45, 20));
                    Rectangle bordert7 = new Rectangle(new Point(66, 484), new Size(47, 22));
                    g.FillRectangle(Brushes.Black, bordert7);
                    g.FillRectangle(Brushes.White, t7);
                    g.DrawString(FormForneamentoSD.zona7, fonttexto, Brushes.Black, new Point(74, 485));
                    g.DrawString("7", fonttexto, Brushes.Black, new Point(32, 485));

                    Rectangle rect4 = new Rectangle(new Point(0, 515), new Size(5000, 30));
                    g.FillRectangle(Brushes.LightSteelBlue, rect4);
                    g.DrawString("Recheio", new Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.RoyalBlue, new Point(20, 515));
                    g.DrawString("Percentual de recheio: " + FormRecheioSD.percentualSD, fonttexto, Brushes.Black, new Point(20, 545));
                    g.DrawString("Densidade do recheio: " + FormRecheioSD.densidadeSD + " (g/cm³)", fonttexto, Brushes.Black, new Point(20, 565));
                }




            }
            

        }
    }

        #endregion
}



