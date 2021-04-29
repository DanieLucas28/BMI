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
        public static string percentualSD;
        public static string densidadeSD;
        private void percentual_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(percentual.Text.Trim()) >= 23 && (Convert.ToDecimal(percentual.Text.Trim()) <= 45))
            {
                percentualSD = percentual.Text;
                percrecbox.Visible = true;
                linkpercrec.Visible = true;
                linkpercrec.Text = "Percentual de recheio de acordo com o indicado por Manley. Este parâmetro pode variar de fabricante a fabricante de acordo com o aspecto comercial desejado. Percentual de recheio de acordo com o indicado por Manley. Este parâmetro pode variar de fabricante a fabricante de acordo com o aspecto comercial desejado.";
                linkpercrec.LinkArea = new LinkArea(0, 0);
                linkpercrec.Links.Add(51,6,"#");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            densidadeSD = densidade.Text;
            if (Convert.ToDecimal(densidade.Text.Trim()) >= 0.75m && (Convert.ToDecimal(densidade.Text.Trim()) <= 1.15m))
            {
                percrecbox.Visible = true;
                linkdensidade.Visible = true;
                linkdensidade.Text = "Densidade do recheio de acordo com o indicado por Manley. A densidade está relacionada a consistência do recheio e visibilidade no biscoito sanduíche (diretamente proporcional ao volume).";
                linkdensidade.LinkArea = new LinkArea(0, 0);
                linkdensidade.Links.Add(50, 6, "#");
            }
            if (Convert.ToDecimal(densidade.Text.Trim()) > 1.15m)
            {
                percrecbox.Visible = true;
                linkdensidade.Visible = true;
                linkdensidade.Text = "Densidade fora do range indicado por Manley. A densidade está relacionada a consistência do recheio e sua visibilidade no biscoito sanduíche. Avaliar se a consistência do recheio está de acordo com o desejado e se a visibilidade do recheio condiz com a imagem comercial do produto.";
                linkdensidade.LinkArea = new LinkArea(0, 0);
                linkdensidade.Links.Add(37, 6, "#");
            }
            if (Convert.ToDecimal(densidade.Text.Trim()) < 0.75m)
            {
                percrecbox.Visible = true;
                linkdensidade.Visible = true;
                linkdensidade.Text = "Densidade fora do range indicado por Manley. A densidade está relacionada a consistência do recheio e sua visibilidade no biscoito sanduíche. Avaliar se a consistência do recheio está de acordo com o desejado e se a visibilidade do recheio condiz com a imagem comercial do produto.";
                linkdensidade.LinkArea = new LinkArea(0, 0);
                linkdensidade.Links.Add(37, 6, "#");
            }
        }
    }
}
