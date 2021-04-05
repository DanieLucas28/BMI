using Parametrizador.Short_Dough;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parametrizador.Impressão
{
    
    public partial class ImpressãoSD : Form
    {
        public string Tempmassas;
        public ImpressãoSD()
        {
            InitializeComponent();
            Tempmassa.Text = FormMisturaSD.tempmassateste;
            fluxoadd.Text = FormMisturaSD.fluxoaddprint;
            mistura1.Text = FormMisturaSD.tempo1print;
            mistura2.Text = FormMisturaSD.tempo2print;

        }



        Bitmap bitmap;
        private void ImpressãoSD_Load(object sender, EventArgs e)
        {
          


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
