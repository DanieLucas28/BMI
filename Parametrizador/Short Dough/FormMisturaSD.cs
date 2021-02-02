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

        }

<<<<<<< HEAD
=======
        private void Tempmassa_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Tempmassa.Text.Trim(), out _))
            {

                if (Convert.ToInt32(Tempmassa.Text.Trim()) >= 18 && (Convert.ToInt32(Tempmassa.Text.Trim()) <= 22))
                {
                    this.linktempmassa.LinkArea = new LinkArea(0, 0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "A temperatura indicada está dentro dos critérios estabelecidos por Manley e Davidson.";
                    this.linktempmassa.Links.Add(67, 6, "#");
                    this.linktempmassa.Links.Add(76, 8, "#");                  
                }
                else if (Convert.ToInt32(Tempmassa.Text.Trim()) > 22)
                {
                    this.linktempmassa.LinkArea = new LinkArea(0, 0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "A temperatura está acima do previsto pelos autores. O elevado aumento de temperatura favorece a formação da rede de glúten. Esse tipo de biscoito possui uma massa com característica de farofa, ou seja, com pouca formação de glúten. Elevadas temperaturas podem ocasionar uma formação indesejada à massa e dificultar a etapa subjacente do processo. Além disso, pode ocorrer a volatização de importantes matérias primas como o bicarbonato de amônio, utilizado como fermento químico, que deve somente ser dissociado em alta velocidade durante a etapa de forneamento.";

                }
                else if (Convert.ToInt32(Tempmassa.Text.Trim()) < 18))
                {
                    this.linktempmassa.LinkArea = new LinkArea(0, 0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "Baixa temperatura. Baixas temperaturas podem não fornecer a estrutura de rede de glúten necessária, deve-se obeservar o desempenho da massa na etapa de formação.";
                }
            }
            else
            {
                this.linktempmassa.Text = "Digite um valor válido para a temperatura.";
            }
        }
>>>>>>> 0e313a5be0d0aae8db6c383034a827e22b6d4969

    }
}
