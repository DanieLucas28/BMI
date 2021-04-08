using Parametrizador.Impressão;
using Parametrizador.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace Parametrizador.Short_Dough
{
    public partial class FormMisturaSD : Form
    {
        public FormMisturaSD()
        {
            InitializeComponent();

        }
        
        public static string tempmassateste;
        public static string fluxoaddprint;
        public static string tempo1print;
        public static string tempo2print;
        // groupbox temperatura da massa
        
        private void Tempmassa_TextChanged(object sender, EventArgs e)
        {
            
            tempmassateste = Tempmassa.Text;
            linktempmassa.Visible = true;
            dadosreftempmassa.Visible = true;
            if (Decimal.TryParse(Tempmassa.Text.Trim(), out _))
            {

                if (Convert.ToDecimal(Tempmassa.Text.Trim()) >= 18 && (Convert.ToDecimal(Tempmassa.Text.Trim()) <= 22))
                {
                    this.linktempmassa.LinkArea = new LinkArea(0, 0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "A temperatura indicada está dentro dos critérios estabelecidos por Manley e Davidson.";
                    this.linktempmassa.Links.Add(67, 6, "#");
                    this.linktempmassa.Links.Add(76, 8, "#");
                }
                else if (Convert.ToDecimal(Tempmassa.Text.Trim()) > 22)
                {
                    this.linktempmassa.LinkArea = new LinkArea(0, 0);
                    this.linktempmassa.UseMnemonic = false;
                    this.linktempmassa.Text = "A temperatura está acima do previsto pelos autores. O elevado aumento de temperatura favorece a formação da rede de glúten. Esse tipo de biscoito possui uma massa com característica de farofa, ou seja, com pouca formação de glúten. Elevadas temperaturas podem ocasionar uma formação indesejada à massa e dificultar a etapa subjacente do processo. Além disso, pode ocorrer a volatização de importantes matérias primas como o bicarbonato de amônio, utilizado como fermento químico, que deve somente ser dissociado em alta velocidade durante a etapa de forneamento.";

                }
                else if (Convert.ToDecimal(Tempmassa.Text.Trim()) < 18)
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

        private void radioButtonmisturafluxo1_CheckedChanged(object sender, EventArgs e)
        {
            fluxoaddprint = "All-in";
            dadosreffluxo.Visible = true;
            linkfluxoadição.LinkArea = new LinkArea(0, 0);
            linkfluxoadição.Visible = true;
            linkfluxoadição.Text = "Fluxo pouco utilizado para este tipo de biscoito, indicado apenas por Manley. Pode prejudicar a homogeneidade da mistura e utiliza maior quantidade de água.";
            linkfluxoadição.Links.Add(70, 6, "#");
            boxtempomistura.Visible = true;
            Tempmistura2.Visible = false;
            label17.Text = "Tempo de mistura";
        }

        private void radioButtonmisturafluxo2_CheckedChanged(object sender, EventArgs e)
        {
            fluxoaddprint = "Creme em mais de um estágio";
            dadosreffluxo.Visible = true;
            linkfluxoadição.LinkArea = new LinkArea(0, 0);
            linkfluxoadição.Visible = true;
            linkfluxoadição.Text = "Fluxo amplamente utilizado para este tipo de biscoito e indicado por todos os autores. Deve ser utilizado por utilizar menor quantidade de água em relação aos outros métodos e permitir uma mistura mais homogênea dos ingredientes.";
            label23.Visible = true;
            Tempmistura2.Visible = true;
            boxtempomistura.Visible = true;
        }


        //groupbox Tempo de mistura

        private void TempMistura_TextChanged(object sender, EventArgs e)
        {
            tempo1print = TempMistura.Text;
            dadosreftempmistura.Visible = true;
            if (Decimal.TryParse(TempMistura.Text.Trim(), out _))
            {
                if (Tempmistura2.Visible==true)
                {
                    tempo2print = Tempmistura2.Text;
                    if (Convert.ToDecimal(TempMistura.Text.Trim()) > 0 && (Convert.ToDecimal(Tempmistura2.Text.Trim()) > 0))
                    {
                        linktempmistura.Visible = true;
                        linktempmistura.LinkArea = new LinkArea(0, 0);
                        linktempmistura.Text = "O tempo de mistura possui influência direta na formação de glúten, e portanto o tempo ótimo deve ser definido de acordo com a estrutura desejada da massa para a etapa de formação. É importante que o tempo seja o mínimo necessário para obtenção da temperatura indicada para a massa, juntamente com a consistência adequada. Excesso de mistura ocasiona maior formação de glúten e modificações na estrutura da massa.";
                    }
                }
                else
                {
                    if (Convert.ToDecimal(TempMistura.Text.Trim()) > 0)
                    {
                        linktempmistura.Visible = true;
                        linktempmistura.LinkArea = new LinkArea(0, 0);
                        linktempmistura.Text = "O tempo de mistura possui influência direta na formação de glúten, e portanto o tempo ótimo deve ser definido de acordo com a estrutura desejada da massa para a etapa de formação. É importante que o tempo seja o mínimo necessário para obtenção da temperatura indicada para a massa, juntamente com a consistência adequada. Excesso de mistura ocasiona maior formação de glúten e modificações na estrutura da massa.";
                    }

                }
            }
            else
            {
                this.linktempmassa.Text = "Digite um valor válido para a temperatura.";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Impressão.ImpressãoSD sf = new Impressão.ImpressãoSD();
            sf.Show();

        }

     

        //mudar cor do link label caso eu queria algum dia


    }
}
