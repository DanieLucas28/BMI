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
    public partial class FormFormaçãoSD : Form
    {
        public FormFormaçãoSD()
        {
            InitializeComponent();
        }

        private void radioButtonmisturafluxo1_CheckedChanged(object sender, EventArgs e)
        {
            dadosrefext.Visible = true;
            linklona.LinkArea = new LinkArea(0, 0);
            linklona.Visible = true;
            linklona.Text = "Lona pouco utilizada para este tipo de biscoito/formação. Emendas da costura fazem com que os biscoitos desmoldados quebrem na transferência de lona.";
            
            
        }

        private void radioButtonlona2_CheckedChanged(object sender, EventArgs e)
        {
            dadosrefext.Visible = true;
            linklona.LinkArea = new LinkArea(0, 0);
            linklona.Visible = true;
            linklona.Text = "Lona amplamente utilizada para este tipo de biscoito/formação. Previne a quebra dos biscoitos durante o desmolde na transferência de lona.";
            
        }

        private void durezarolo_TextChanged(object sender, EventArgs e)
        {
            linkrolo.Visible = true;
            dadosrefrolo.Visible = true;
            
            if (Decimal.TryParse(durezarolo.Text.Trim(), out _))
            {

                if (Convert.ToDecimal(durezarolo.Text.Trim()) >= 70M && (Convert.ToDecimal(durezarolo.Text.Trim()) <= 80M))
                {
                    this.linkrolo.LinkArea = new LinkArea(0, 0);
                    this.linkrolo.UseMnemonic = false;
                    this.linkrolo.Text = "Dureza conforme indicado por Bertolino & Braga para o eficiente desmolde da massa.";
                    this.linkrolo.Links.Add(29, 17, "#");
                    
                }
                else if (Convert.ToDecimal(durezarolo.Text.Trim()) > 80M)
                {
                    this.linkrolo.LinkArea = new LinkArea(0, 0);
                    this.linkrolo.UseMnemonic = false;
                    this.linkrolo.Text = "Dureza acima do indicado. Avaliar se há interferência no desmolde da massa.";

                }
                else if (Convert.ToDecimal(durezarolo.Text.Trim()) < 18M)
                {
                    this.linkrolo.LinkArea = new LinkArea(0, 0);
                    this.linkrolo.UseMnemonic = false;
                    this.linkrolo.Text = "Dureza abaixo do indicado. Este rolo deve possuir a dureza necessária para ocasionar a aderência da massa na lona pelo efeito da pressão realizada. A dureza abaixo do indicado pode ocasionar perdas de eficiência no desmolde da massa.";
                }
            }
            else
            {
                this.linkrolo.Text = "Digite um valor válido para a dureza do rolo.";
            }
        }
    }
    }

