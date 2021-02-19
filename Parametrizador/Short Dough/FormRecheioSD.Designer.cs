
namespace Parametrizador.Short_Dough
{
    partial class FormRecheioSD
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
            this.percrecbox = new System.Windows.Forms.GroupBox();
            this.dadosperc = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkpercrec = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.percentual = new System.Windows.Forms.TextBox();
            this.percrecbox.SuspendLayout();
            this.dadosperc.SuspendLayout();
            this.SuspendLayout();
            // 
            // percrecbox
            // 
            this.percrecbox.Controls.Add(this.dadosperc);
            this.percrecbox.Controls.Add(this.linkpercrec);
            this.percrecbox.Controls.Add(this.label1);
            this.percrecbox.Controls.Add(this.percentual);
            this.percrecbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.percrecbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percrecbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percrecbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.percrecbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.percrecbox.Location = new System.Drawing.Point(0, 0);
            this.percrecbox.Margin = new System.Windows.Forms.Padding(10);
            this.percrecbox.Name = "percrecbox";
            this.percrecbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.percrecbox.Size = new System.Drawing.Size(1162, 200);
            this.percrecbox.TabIndex = 10;
            this.percrecbox.TabStop = false;
            this.percrecbox.Text = "Percentual de recheio";
            // 
            // dadosperc
            // 
            this.dadosperc.Controls.Add(this.label25);
            this.dadosperc.Controls.Add(this.label27);
            this.dadosperc.Controls.Add(this.label3);
            this.dadosperc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(152)))));
            this.dadosperc.Location = new System.Drawing.Point(472, 0);
            this.dadosperc.Margin = new System.Windows.Forms.Padding(0);
            this.dadosperc.Name = "dadosperc";
            this.dadosperc.Size = new System.Drawing.Size(219, 77);
            this.dadosperc.TabIndex = 6;
            this.dadosperc.TabStop = false;
            this.dadosperc.Visible = false;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(1, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(218, 21);
            this.label25.TabIndex = 11;
            this.label25.Text = "23~45";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(1, 33);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(218, 21);
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
            this.label3.Size = new System.Drawing.Size(219, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dados de referência (%)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // linkpercrec
            // 
            this.linkpercrec.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkpercrec.AutoEllipsis = true;
            this.linkpercrec.BackColor = System.Drawing.Color.Transparent;
            this.linkpercrec.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.linkpercrec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkpercrec.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkpercrec.Location = new System.Drawing.Point(3, 118);
            this.linkpercrec.Name = "linkpercrec";
            this.linkpercrec.Size = new System.Drawing.Size(1156, 79);
            this.linkpercrec.TabIndex = 3;
            this.linkpercrec.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Percentual de recheio utilizado";
            // 
            // percentual
            // 
            this.percentual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.percentual.Location = new System.Drawing.Point(260, 24);
            this.percentual.Name = "percentual";
            this.percentual.Size = new System.Drawing.Size(30, 27);
            this.percentual.TabIndex = 0;
            this.percentual.TextChanged += new System.EventHandler(this.percentual_TextChanged);
            // 
            // FormRecheioSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1162, 400);
            this.Controls.Add(this.percrecbox);
            this.Name = "FormRecheioSD";
            this.Text = "FormFormação";
            this.percrecbox.ResumeLayout(false);
            this.percrecbox.PerformLayout();
            this.dadosperc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox percrecbox;
        private System.Windows.Forms.GroupBox dadosperc;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkpercrec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox percentual;
    }
}