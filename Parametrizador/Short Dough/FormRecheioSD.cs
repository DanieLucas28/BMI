using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parametrizador.Short_Dough
{
    public partial class FormRecheioSD : Form
    {
        public FormRecheioSD()
        {
            InitializeComponent();
        }

        private void percentual_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(percentual.Text.Trim()) >= 23 && (Convert.ToInt32(percentual.Text.Trim()) <= 45))
            {
                percrecbox.Visible = true;
                linkpercrec.Visible = true;
                linkpercrec.Text = "Percentual de recheio de acordo com o indicado por Manley. Este parâmetro pode variar de fabricante a fabricante de acordo com o aspecto comercial desejado. Percentual de recheio de acordo com o indicado por Manley. Este parâmetro pode variar de fabricante a fabricante de acordo com o aspecto comercial desejado.";
                linkpercrec.LinkArea = new LinkArea(0, 0);
                linkpercrec.Links.Add(51,6,"#");
            }

        }
    }
}
