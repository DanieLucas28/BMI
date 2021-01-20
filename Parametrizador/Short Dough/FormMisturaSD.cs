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
    public partial class FormMistura : Form
    {
        public FormMistura()
        {
            InitializeComponent();

            //this.dataGridView1.Rows.Add("40 a 42", "40 a 42", "Máx. 36", "39 a 42") ;

        }

        private void Tempmassa_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Tempmassa.Text.Trim(), out _))
            {

                if (Convert.ToInt32(Tempmassa.Text.Trim()) >= 40 && (Convert.ToInt32(Tempmassa.Text.Trim()) <= 42))
                {
                    this.linktempmassa.LinkArea = new LinkArea(0, 0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "A temperatura indicada está dentro dos critérios estabelecidos por Manley, Davidson e Bertolino & Braga.";
                    this.linktempmassa.Links.Add(67, 6, "#");
                    this.linktempmassa.Links.Add(75, 8, "#");
                    this.linktempmassa.Links.Add(86, 17, "#");
                }
                else if (Convert.ToInt32(Tempmassa.Text.Trim()) >= 42)
                {
                    this.linktempmassa.LinkArea = new LinkArea(0, 0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "A temperatura está acima do previsto pelos autores. Quanto mais alta for a temperatura, mais macia e amolecida é a massa. Ou seja, altas temperaturas podem ocasionar modificações na estrutura da massa desejada e torná-la mais difícil de ser manuseada. Temperaturas elevadas podem ocasionar uma massa escaldada.";

                }
                else if (Convert.ToInt32(Tempmassa.Text.Trim()) >= 30 && (Convert.ToInt32(Tempmassa.Text.Trim()) <= 36))
                {
                    this.linktempmassa.LinkArea = new LinkArea(0, 0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "Temperatura de acordo apenas com Moretto. Atenção para a estrutura da massa: laminados doces possuem massa caracterizada como macia, ou seja, uma massa com bastante ''liga''. Baixas temperaturas não favorecem a formação desse tipo de estrutura da massa. ";
                    this.linktempmassa.Links.Add(33, 7, "#");
                }
                else if (Convert.ToInt32(Tempmassa.Text.Trim()) < 30)
                {
                    this.linktempmassa.LinkArea = new LinkArea(0,0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "Baixa temperatura. Massa para laminados doces deve caracterizar-se como macia, ou seja, com bastante 'liga'. Baixas temperaturas não favorecem a formação desse tipo de estrutura da massa.";                  
                }
            }
            else
            {
                this.linktempmassa.Text = "Digite um valor válido para a temperatura.";

            }
        }

    }
}
