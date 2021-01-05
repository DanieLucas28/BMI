
namespace Parametrizador
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Cookies = new System.Windows.Forms.Label();
            this.PictureCookies = new System.Windows.Forms.PictureBox();
            this.PictureSD = new System.Windows.Forms.PictureBox();
            this.hardsweet = new System.Windows.Forms.Label();
            this.PictureCC = new System.Windows.Forms.PictureBox();
            this.PictureHS = new System.Windows.Forms.PictureBox();
            this.creamcracker = new System.Windows.Forms.Label();
            this.shortdough = new System.Windows.Forms.Label();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCookies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHS)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.IconPanel);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 543);
            this.PanelMenu.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.User);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(948, 75);
            this.panelTitleBar.TabIndex = 3;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.User.Location = new System.Drawing.Point(852, 31);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(42, 21);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.Cookies);
            this.panelDesktop.Controls.Add(this.PictureCookies);
            this.panelDesktop.Controls.Add(this.PictureSD);
            this.panelDesktop.Controls.Add(this.hardsweet);
            this.panelDesktop.Controls.Add(this.PictureCC);
            this.panelDesktop.Controls.Add(this.PictureHS);
            this.panelDesktop.Controls.Add(this.creamcracker);
            this.panelDesktop.Controls.Add(this.shortdough);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(948, 468);
            this.panelDesktop.TabIndex = 4;
            // 
            // Cookies
            // 
            this.Cookies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cookies.AutoSize = true;
            this.Cookies.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cookies.Location = new System.Drawing.Point(687, 269);
            this.Cookies.Name = "Cookies";
            this.Cookies.Size = new System.Drawing.Size(70, 21);
            this.Cookies.TabIndex = 44;
            this.Cookies.Text = "Cookies";
            // 
            // PictureCookies
            // 
            this.PictureCookies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureCookies.Image = ((System.Drawing.Image)(resources.GetObject("PictureCookies.Image")));
            this.PictureCookies.Location = new System.Drawing.Point(682, 182);
            this.PictureCookies.Name = "PictureCookies";
            this.PictureCookies.Size = new System.Drawing.Size(84, 84);
            this.PictureCookies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureCookies.TabIndex = 43;
            this.PictureCookies.TabStop = false;
            // 
            // PictureSD
            // 
            this.PictureSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureSD.Image = global::Parametrizador.Properties.Resources.sd;
            this.PictureSD.Location = new System.Drawing.Point(357, 182);
            this.PictureSD.Name = "PictureSD";
            this.PictureSD.Size = new System.Drawing.Size(84, 84);
            this.PictureSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureSD.TabIndex = 39;
            this.PictureSD.TabStop = false;
            // 
            // hardsweet
            // 
            this.hardsweet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hardsweet.AutoSize = true;
            this.hardsweet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardsweet.Location = new System.Drawing.Point(515, 269);
            this.hardsweet.Name = "hardsweet";
            this.hardsweet.Size = new System.Drawing.Size(101, 21);
            this.hardsweet.TabIndex = 42;
            this.hardsweet.Text = "Hard Sweet";
            // 
            // PictureCC
            // 
            this.PictureCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureCC.Image = global::Parametrizador.Properties.Resources.cc;
            this.PictureCC.Location = new System.Drawing.Point(194, 182);
            this.PictureCC.Name = "PictureCC";
            this.PictureCC.Size = new System.Drawing.Size(84, 84);
            this.PictureCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureCC.TabIndex = 37;
            this.PictureCC.TabStop = false;
            this.PictureCC.MouseEnter += new System.EventHandler(this.PictureCC_MouseEnter);
            this.PictureCC.MouseLeave += new System.EventHandler(this.PictureCC_MouseLeave);
            // 
            // PictureHS
            // 
            this.PictureHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureHS.Image = global::Parametrizador.Properties.Resources.hs;
            this.PictureHS.Location = new System.Drawing.Point(519, 182);
            this.PictureHS.Name = "PictureHS";
            this.PictureHS.Size = new System.Drawing.Size(84, 84);
            this.PictureHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureHS.TabIndex = 41;
            this.PictureHS.TabStop = false;
            // 
            // creamcracker
            // 
            this.creamcracker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creamcracker.AutoSize = true;
            this.creamcracker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamcracker.Location = new System.Drawing.Point(173, 269);
            this.creamcracker.Name = "creamcracker";
            this.creamcracker.Size = new System.Drawing.Size(130, 21);
            this.creamcracker.TabIndex = 38;
            this.creamcracker.Text = "Cream Cracker";
            // 
            // shortdough
            // 
            this.shortdough.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shortdough.AutoSize = true;
            this.shortdough.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortdough.Location = new System.Drawing.Point(344, 269);
            this.shortdough.Name = "shortdough";
            this.shortdough.Size = new System.Drawing.Size(107, 21);
            this.shortdough.TabIndex = 40;
            this.shortdough.Text = "Short Dough";
            // 
            // IconPanel
            // 
            this.IconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconPanel.Location = new System.Drawing.Point(0, 0);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(220, 120);
            this.IconPanel.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1168, 543);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCookies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label Cookies;
        private System.Windows.Forms.PictureBox PictureCookies;
        private System.Windows.Forms.PictureBox PictureSD;
        private System.Windows.Forms.Label hardsweet;
        private System.Windows.Forms.PictureBox PictureCC;
        private System.Windows.Forms.PictureBox PictureHS;
        private System.Windows.Forms.Label creamcracker;
        private System.Windows.Forms.Label shortdough;
        private System.Windows.Forms.Panel IconPanel;
    }
}

