
namespace Parametrizador.Short_Dough
{
    partial class FormMistura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tempmassabox = new System.Windows.Forms.GroupBox();
            this.linktempmassa = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Tempmassa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tempmassabox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 519);
            this.panel1.TabIndex = 3;
            // 
            // tempmassabox
            // 
            this.tempmassabox.Controls.Add(this.linktempmassa);
            this.tempmassabox.Controls.Add(this.label1);
            this.tempmassabox.Controls.Add(this.Tempmassa);
            this.tempmassabox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tempmassabox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tempmassabox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempmassabox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tempmassabox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tempmassabox.Location = new System.Drawing.Point(28, 0);
            this.tempmassabox.Margin = new System.Windows.Forms.Padding(10);
            this.tempmassabox.Name = "tempmassabox";
            this.tempmassabox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tempmassabox.Size = new System.Drawing.Size(1134, 173);
            this.tempmassabox.TabIndex = 5;
            this.tempmassabox.TabStop = false;
            this.tempmassabox.Text = "Temperatura da massa";
            // 
            // linktempmassa
            // 
            this.linktempmassa.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linktempmassa.AutoEllipsis = true;
            this.linktempmassa.BackColor = System.Drawing.Color.Transparent;
            this.linktempmassa.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.linktempmassa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linktempmassa.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linktempmassa.Location = new System.Drawing.Point(3, 91);
            this.linktempmassa.Name = "linktempmassa";
            this.linktempmassa.Size = new System.Drawing.Size(1128, 79);
            this.linktempmassa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura da massa nesse estágio";
            // 
            // Tempmassa
            // 
            this.Tempmassa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tempmassa.Location = new System.Drawing.Point(314, 44);
            this.Tempmassa.Name = "Tempmassa";
            this.Tempmassa.Size = new System.Drawing.Size(43, 27);
            this.Tempmassa.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(28, 346);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(1134, 173);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tempo de mistura";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(28, 173);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1134, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fluxo de adição";
            // 
            // FormMistura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1162, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tempmassabox);
            this.Controls.Add(this.panel1);
            this.Name = "FormMistura";
            this.Text = "FormMistura";
            this.tempmassabox.ResumeLayout(false);
            this.tempmassabox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox tempmassabox;
        private System.Windows.Forms.LinkLabel linktempmassa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tempmassa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}