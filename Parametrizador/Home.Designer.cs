
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.CookieButton = new System.Windows.Forms.Button();
            this.HSbutton = new System.Windows.Forms.Button();
            this.SDbutton = new System.Windows.Forms.Button();
            this.CCbutton = new System.Windows.Forms.Button();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.BtnResfriamentoHS = new FontAwesome.Sharp.IconButton();
            this.BtnForneamentoHS = new FontAwesome.Sharp.IconButton();
            this.BtnFormaçãoHS = new FontAwesome.Sharp.IconButton();
            this.BtnMisturaHS = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.IconPanel.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(77)))), ((int)(((byte)(135)))));
            this.PanelMenu.Controls.Add(this.BtnResfriamentoHS);
            this.PanelMenu.Controls.Add(this.BtnForneamentoHS);
            this.PanelMenu.Controls.Add(this.BtnFormaçãoHS);
            this.PanelMenu.Controls.Add(this.BtnMisturaHS);
            this.PanelMenu.Controls.Add(this.IconPanel);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 509);
            this.PanelMenu.TabIndex = 2;
            // 
            // IconPanel
            // 
            this.IconPanel.Controls.Add(this.pictureBox1);
            this.IconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconPanel.Location = new System.Drawing.Point(0, 0);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(220, 141);
            this.IconPanel.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(77)))), ((int)(((byte)(135)))));
            this.panelTitleBar.Controls.Add(this.MaximizeButton);
            this.panelTitleBar.Controls.Add(this.MinimizeButton);
            this.panelTitleBar.Controls.Add(this.CloseButton);
            this.panelTitleBar.Controls.Add(this.User);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(703, 107);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // User
            // 
            this.User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.User.Location = new System.Drawing.Point(649, 54);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(42, 21);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            // 
            // panelDesktop
            // 
            this.panelDesktop.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(152)))));
            this.panelDesktop.Controls.Add(this.CookieButton);
            this.panelDesktop.Controls.Add(this.HSbutton);
            this.panelDesktop.Controls.Add(this.SDbutton);
            this.panelDesktop.Controls.Add(this.CCbutton);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 107);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(703, 402);
            this.panelDesktop.TabIndex = 4;
            // 
            // CookieButton
            // 
            this.CookieButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CookieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(77)))), ((int)(((byte)(135)))));
            this.CookieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CookieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CookieButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookieButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CookieButton.Image = global::Parametrizador.Properties.Resources.cookiew;
            this.CookieButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CookieButton.Location = new System.Drawing.Point(382, 217);
            this.CookieButton.Name = "CookieButton";
            this.CookieButton.Size = new System.Drawing.Size(247, 146);
            this.CookieButton.TabIndex = 49;
            this.CookieButton.Text = "Cookie";
            this.CookieButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CookieButton.UseVisualStyleBackColor = false;
            // 
            // HSbutton
            // 
            this.HSbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HSbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(77)))), ((int)(((byte)(135)))));
            this.HSbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HSbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HSbutton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HSbutton.Image = global::Parametrizador.Properties.Resources.hsw;
            this.HSbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HSbutton.Location = new System.Drawing.Point(84, 217);
            this.HSbutton.Name = "HSbutton";
            this.HSbutton.Size = new System.Drawing.Size(247, 146);
            this.HSbutton.TabIndex = 48;
            this.HSbutton.Text = "Hard Sweet";
            this.HSbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HSbutton.UseVisualStyleBackColor = false;
            this.HSbutton.Click += new System.EventHandler(this.HSbutton_Click);
            // 
            // SDbutton
            // 
            this.SDbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SDbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(77)))), ((int)(((byte)(135)))));
            this.SDbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SDbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SDbutton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SDbutton.Image = global::Parametrizador.Properties.Resources.sdw;
            this.SDbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SDbutton.Location = new System.Drawing.Point(382, 37);
            this.SDbutton.Name = "SDbutton";
            this.SDbutton.Size = new System.Drawing.Size(247, 146);
            this.SDbutton.TabIndex = 47;
            this.SDbutton.Text = "Short Dough";
            this.SDbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SDbutton.UseVisualStyleBackColor = false;
            // 
            // CCbutton
            // 
            this.CCbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(77)))), ((int)(((byte)(135)))));
            this.CCbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CCbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CCbutton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CCbutton.Image = global::Parametrizador.Properties.Resources.ccw;
            this.CCbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CCbutton.Location = new System.Drawing.Point(84, 37);
            this.CCbutton.Name = "CCbutton";
            this.CCbutton.Size = new System.Drawing.Size(247, 146);
            this.CCbutton.TabIndex = 46;
            this.CCbutton.Text = "Cream Cracker";
            this.CCbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CCbutton.UseVisualStyleBackColor = false;
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.AutoSize = true;
            this.MaximizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeButton.IconColor = System.Drawing.Color.White;
            this.MaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeButton.IconSize = 20;
            this.MaximizeButton.Location = new System.Drawing.Point(648, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(28, 28);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 20;
            this.MinimizeButton.Location = new System.Drawing.Point(621, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(28, 28);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 20;
            this.CloseButton.Location = new System.Drawing.Point(675, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // BtnResfriamentoHS
            // 
            this.BtnResfriamentoHS.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnResfriamentoHS.FlatAppearance.BorderSize = 0;
            this.BtnResfriamentoHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResfriamentoHS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResfriamentoHS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnResfriamentoHS.IconChar = FontAwesome.Sharp.IconChar.TemperatureLow;
            this.BtnResfriamentoHS.IconColor = System.Drawing.Color.White;
            this.BtnResfriamentoHS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnResfriamentoHS.IconSize = 32;
            this.BtnResfriamentoHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResfriamentoHS.Location = new System.Drawing.Point(0, 321);
            this.BtnResfriamentoHS.Name = "BtnResfriamentoHS";
            this.BtnResfriamentoHS.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnResfriamentoHS.Size = new System.Drawing.Size(220, 60);
            this.BtnResfriamentoHS.TabIndex = 4;
            this.BtnResfriamentoHS.Text = "Resfriamento";
            this.BtnResfriamentoHS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResfriamentoHS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnResfriamentoHS.UseVisualStyleBackColor = true;
            this.BtnResfriamentoHS.Click += new System.EventHandler(this.BtnResfriamento_Click);
            // 
            // BtnForneamentoHS
            // 
            this.BtnForneamentoHS.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnForneamentoHS.FlatAppearance.BorderSize = 0;
            this.BtnForneamentoHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForneamentoHS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnForneamentoHS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnForneamentoHS.IconChar = FontAwesome.Sharp.IconChar.DumpsterFire;
            this.BtnForneamentoHS.IconColor = System.Drawing.Color.White;
            this.BtnForneamentoHS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnForneamentoHS.IconSize = 32;
            this.BtnForneamentoHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnForneamentoHS.Location = new System.Drawing.Point(0, 261);
            this.BtnForneamentoHS.Name = "BtnForneamentoHS";
            this.BtnForneamentoHS.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnForneamentoHS.Size = new System.Drawing.Size(220, 60);
            this.BtnForneamentoHS.TabIndex = 3;
            this.BtnForneamentoHS.Text = "Forneamento";
            this.BtnForneamentoHS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnForneamentoHS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnForneamentoHS.UseVisualStyleBackColor = true;
            this.BtnForneamentoHS.Click += new System.EventHandler(this.BtnForneamento_Click);
            // 
            // BtnFormaçãoHS
            // 
            this.BtnFormaçãoHS.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFormaçãoHS.FlatAppearance.BorderSize = 0;
            this.BtnFormaçãoHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFormaçãoHS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFormaçãoHS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFormaçãoHS.IconChar = FontAwesome.Sharp.IconChar.Xbox;
            this.BtnFormaçãoHS.IconColor = System.Drawing.Color.White;
            this.BtnFormaçãoHS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFormaçãoHS.IconSize = 32;
            this.BtnFormaçãoHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFormaçãoHS.Location = new System.Drawing.Point(0, 201);
            this.BtnFormaçãoHS.Name = "BtnFormaçãoHS";
            this.BtnFormaçãoHS.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnFormaçãoHS.Size = new System.Drawing.Size(220, 60);
            this.BtnFormaçãoHS.TabIndex = 2;
            this.BtnFormaçãoHS.Text = "Formação";
            this.BtnFormaçãoHS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFormaçãoHS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFormaçãoHS.UseVisualStyleBackColor = true;
            this.BtnFormaçãoHS.Click += new System.EventHandler(this.BtnFormação_Click);
            // 
            // BtnMisturaHS
            // 
            this.BtnMisturaHS.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMisturaHS.FlatAppearance.BorderSize = 0;
            this.BtnMisturaHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMisturaHS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMisturaHS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMisturaHS.IconChar = FontAwesome.Sharp.IconChar.Blender;
            this.BtnMisturaHS.IconColor = System.Drawing.Color.White;
            this.BtnMisturaHS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMisturaHS.IconSize = 32;
            this.BtnMisturaHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMisturaHS.Location = new System.Drawing.Point(0, 141);
            this.BtnMisturaHS.Name = "BtnMisturaHS";
            this.BtnMisturaHS.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnMisturaHS.Size = new System.Drawing.Size(220, 60);
            this.BtnMisturaHS.TabIndex = 1;
            this.BtnMisturaHS.Text = "Mistura";
            this.BtnMisturaHS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMisturaHS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMisturaHS.UseVisualStyleBackColor = true;
            this.BtnMisturaHS.Click += new System.EventHandler(this.BtnMistura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Parametrizador.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(923, 509);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            this.IconPanel.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel IconPanel;
        private FontAwesome.Sharp.IconButton BtnResfriamentoHS;
        private FontAwesome.Sharp.IconButton BtnForneamentoHS;
        private FontAwesome.Sharp.IconButton BtnFormaçãoHS;
        private FontAwesome.Sharp.IconButton BtnMisturaHS;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Button CCbutton;
        private System.Windows.Forms.Button CookieButton;
        private System.Windows.Forms.Button HSbutton;
        private System.Windows.Forms.Button SDbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

