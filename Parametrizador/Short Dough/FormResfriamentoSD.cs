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
    public partial class FormResfriamentoSD : Form
    {
        
        public FormResfriamentoSD()
        {
            InitializeComponent();
        }

        private void tempresf_TextChanged(object sender, EventArgs e)
        {
            if (tempcoz.Text.Trim() == "" && tempresf.Text.Trim() == "")
            {
                linkresfr.Visible = true;
                linkresfr.Text = "Digite um valor para o tempo de cozimento";
            }
            else if (Convert.ToDecimal(tempresf.Text.Trim()) == 0) 
            {
                linkresfr.Visible = true;
                linkresfr.Text = "Digite um valor válido para o tempo de resfriamento";
                linkresfr.LinkArea = new LinkArea(0, 0);
            }
            else
            {
                
                if (Convert.ToDecimal(tempresf.Text.Trim()) / Convert.ToDecimal(tempcoz.Text.Trim()) >= 0.5M && Convert.ToDecimal(tempresf.Text.Trim()) / Convert.ToDecimal(tempcoz.Text.Trim()) <= 1.2M)
                {
                    dadosrefresf.Visible = true;
                    linkresfr.Visible = true;
                    linkresfr.Text = "Tempo de resfriamento dentro dos critérios estabelecidos por Manley. Atenção para a temperatura do biscoito ao final da etapa. Manley considera este range abrangendo possíveis resfriamentos naturais e/ou forçados.";
                    linkresfr.LinkArea = new LinkArea(0, 0);
                    linkresfr.Links.Add(62, 6, "#"); 
                }
                if (Convert.ToDecimal(tempresf.Text.Trim()) / Convert.ToDecimal(tempcoz.Text.Trim()) == 1.5M)
                {
                    dadosrefresf.Visible = true;
                    linkresfr.Visible = true;
                    linkresfr.Text = "Tempo de resfriamento dentro dos critérios estabelecidos pelos dois autores.";
                    linkresfr.LinkArea = new LinkArea(0, 0);
                  
                }
                if (Convert.ToDecimal(tempresf.Text.Trim()) / Convert.ToDecimal(tempcoz.Text.Trim()) > 1.5M && Convert.ToDecimal(tempresf.Text.Trim()) / Convert.ToDecimal(tempcoz.Text.Trim()) <= 2)
                {
                    dadosrefresf.Visible = true;
                    linkresfr.Visible = true;
                    linkresfr.Text = "Tempo de resfriamento dentro dos critérios estabelecidos por Manley.";
                    linkresfr.LinkArea = new LinkArea(0, 0);
                    linkresfr.Links.Add(62, 6, "#");
                }
                if (Convert.ToDecimal(tempresf.Text.Trim()) / Convert.ToDecimal(tempcoz.Text.Trim()) > 2)
                {
                    dadosrefresf.Visible = true;
                    linkresfr.Visible = true;
                    linkresfr.Text = "Tempo de resfriamento acima do indicado. Possível superdimensionamento da etapa de resfriamento.";
                    linkresfr.LinkArea = new LinkArea(0, 0);

                }
                if (Convert.ToDecimal(tempresf.Text.Trim()) / Convert.ToDecimal(tempcoz.Text.Trim()) < 0.5M)
                {
                    dadosrefresf.Visible = true;
                    linkresfr.Visible = true;
                    linkresfr.Text = "Tempo de resfriamento abaixo ao indicado pelos autores. Atenção para a temperatura do biscoito ao final da etapa.";
                    linkresfr.LinkArea = new LinkArea(0, 0);

                }

            }
        }
    }
}
