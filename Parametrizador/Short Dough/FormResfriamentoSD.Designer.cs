
namespace Parametrizador.Short_Dough
{
    partial class FormResfriamentoSD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rolobox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tempresf = new System.Windows.Forms.TextBox();
            this.dadosrefresf = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkresfr = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tempcoz = new System.Windows.Forms.TextBox();
            this.rolobox.SuspendLayout();
            this.dadosrefresf.SuspendLayout();
            this.SuspendLayout();
            // 
            // rolobox
            // 
            this.rolobox.Controls.Add(this.label2);
            this.rolobox.Controls.Add(this.tempresf);
            this.rolobox.Controls.Add(this.dadosrefresf);
            this.rolobox.Controls.Add(this.linkresfr);
            this.rolobox.Controls.Add(this.label1);
            this.rolobox.Controls.Add(this.tempcoz);
            this.rolobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rolobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolobox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolobox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rolobox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rolobox.Location = new System.Drawing.Point(0, 0);
            this.rolobox.Margin = new System.Windows.Forms.Padding(10);
            this.rolobox.Name = "rolobox";
            this.rolobox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rolobox.Size = new System.Drawing.Size(966, 230);
            this.rolobox.TabIndex = 10;
            this.rolobox.TabStop = false;
            this.rolobox.Text = "Tempo de resfriamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tempo de resfriamento utilizado";
            // 
            // tempresf
            // 
            this.tempresf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tempresf.Location = new System.Drawing.Point(302, 61);
            this.tempresf.Name = "tempresf";
            this.tempresf.Size = new System.Drawing.Size(30, 27);
            this.tempresf.TabIndex = 7;
            this.tempresf.TextChanged += new System.EventHandler(this.tempresf_TextChanged);
            // 
            // dadosrefresf
            // 
            this.dadosrefresf.Controls.Add(this.label28);
            this.dadosrefresf.Controls.Add(this.label29);
            this.dadosrefresf.Controls.Add(this.label25);
            this.dadosrefresf.Controls.Add(this.label27);
            this.dadosrefresf.Controls.Add(this.label3);
            this.dadosrefresf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(152)))));
            this.dadosrefresf.Location = new System.Drawing.Point(472, 0);
            this.dadosrefresf.Margin = new System.Windows.Forms.Padding(0);
            this.dadosrefresf.Name = "dadosrefresf";
            this.dadosrefresf.Size = new System.Drawing.Size(381, 118);
            this.dadosrefresf.TabIndex = 6;
            this.dadosrefresf.TabStop = false;
            this.dadosrefresf.Visible = false;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(191, 54);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(189, 64);
            this.label28.TabIndex = 13;
            this.label28.Text = "Proporção de 1,5:1 em relação ao tempo de cozimento";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(191, 33);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(189, 21);
            this.label29.TabIndex = 12;
            this.label29.Text = "Davidson";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.UseMnemonic = false;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(1, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(189, 64);
            this.label25.TabIndex = 11;
            this.label25.Text = "Proporção de 0,5:1 a 2:1 em relação ao tempo de cozimento";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(1, 33);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(189, 21);
            this.label27.TabIndex = 10;
            this.label27.Text = "Manley";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dados de referência (Shore)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkresfr
            // 
            this.linkresfr.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkresfr.AutoEllipsis = true;
            this.linkresfr.BackColor = System.Drawing.Color.Transparent;
            this.linkresfr.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.linkresfr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkresfr.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkresfr.Location = new System.Drawing.Point(3, 148);
            this.linkresfr.Name = "linkresfr";
            this.linkresfr.Size = new System.Drawing.Size(960, 79);
            this.linkresfr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo de cozimento utilizado";
            // 
            // tempcoz
            // 
            this.tempcoz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tempcoz.Location = new System.Drawing.Point(302, 27);
            this.tempcoz.Name = "tempcoz";
            this.tempcoz.Size = new System.Drawing.Size(30, 27);
            this.tempcoz.TabIndex = 0;
            // 
            // FormResfriamentoSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.rolobox);
            this.Name = "FormResfriamentoSD";
            this.Text = "FormResfriamento";
            this.rolobox.ResumeLayout(false);
            this.rolobox.PerformLayout();
            this.dadosrefresf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rolobox;
        private System.Windows.Forms.GroupBox dadosrefresf;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkresfr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tempcoz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tempresf;
    }
}