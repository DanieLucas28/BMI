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
    public partial class FormForneamentoSD : Form
    {
        public FormForneamentoSD()
        {
            InitializeComponent();
            var objchart = gráficoforno.ChartAreas[0];


            #region dados do gráfico
            objchart.AxisX.Minimum = 1;
            objchart.AxisX.Maximum = 7;                       
            gráficoforno.Series["Manley"].Points.AddXY(z1.Text, mt1.Text) ;
            gráficoforno.Series["Manley"].Points.AddXY(z2.Text, mt2.Text);
            gráficoforno.Series["Manley"].Points.AddXY(z3.Text, mt3.Text);
            gráficoforno.Series["Davidson"].Points.AddXY(z1.Text, dt1.Text);
            gráficoforno.Series["Davidson"].Points.AddXY(z2.Text, dt2.Text);
            gráficoforno.Series["Davidson"].Points.AddXY(z3.Text, dt3.Text);
            gráficoforno.Series["Davidson"].Points.AddXY(z4.Text, dt4.Text);
            gráficoforno.Series["Davidson"].Points.AddXY(z5.Text, dt5.Text);
            gráficoforno.Series["Bertolino & Braga"].Points.AddXY(z1.Text, bt1.Text);
            gráficoforno.Series["Bertolino & Braga"].Points.AddXY(z2.Text, bt2.Text);
            gráficoforno.Series["Bertolino & Braga"].Points.AddXY(z3.Text, bt3.Text);
            gráficoforno.Series["Bertolino & Braga"].Points.AddXY(z4.Text, bt4.Text);
            gráficoforno.Series["Bertolino & Braga"].Points.AddXY(z5.Text, bt5.Text);
            gráficoforno.Series["Bertolino & Braga"].Points.AddXY(z6.Text, bt6.Text);
            #endregion
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int qtdzona = Convert.ToInt32(comboBox1.SelectedItem.ToString()) - 1;

            tempfornobox.Size = new Size(1162, 335 + (10 * qtdzona));

            if (Convert.ToInt32(comboBox1.SelectedItem.ToString()) == 1)
            {
                Tempforno1.Visible = true;
                labelforno1.Visible = true;
                tempforno2.Visible = false;
                labelforno2.Visible =false;
                tempforno3.Visible = false;
                labelforno3.Visible =false;
                tempforno4.Visible = false;
                labelforno4.Visible =false;
                tempforno5.Visible = false;
                labelforno5.Visible =false;
                tempforno6.Visible = false;
                labelforno6.Visible =false;
                tempforno7.Visible = false;
                labelforno7.Visible =false;



            }
            else if (Convert.ToInt32(comboBox1.SelectedItem.ToString()) == 2)
            {
                Tempforno1.Visible = true;
                labelforno1.Visible = true;
                tempforno2.Visible = true;
                labelforno2.Visible = true;
                tempforno3.Visible = false;
                labelforno3.Visible = false;
                tempforno4.Visible = false;
                labelforno4.Visible = false;
                tempforno5.Visible = false;
                labelforno5.Visible = false;
                tempforno6.Visible = false;
                labelforno6.Visible = false;
                tempforno7.Visible = false;
                labelforno7.Visible = false;
            }
            else if (Convert.ToInt32(comboBox1.SelectedItem.ToString()) == 3)
            {
                Tempforno1.Visible = true;
                labelforno1.Visible = true;
                tempforno2.Visible = true;
                labelforno2.Visible = true;
                tempforno3.Visible = true;
                labelforno3.Visible = true;
                tempforno4.Visible = false;
                labelforno4.Visible = false;
                tempforno5.Visible = false;
                labelforno5.Visible = false;
                tempforno6.Visible = false;
                labelforno6.Visible = false;
                tempforno7.Visible = false;
                labelforno7.Visible = false;
            }
            else if (Convert.ToInt32(comboBox1.SelectedItem.ToString()) == 4)
            {
                Tempforno1.Visible = true;
                labelforno1.Visible = true;
                tempforno2.Visible = true;
                labelforno2.Visible = true;
                tempforno3.Visible = true;
                labelforno3.Visible = true;
                tempforno4.Visible = true;
                labelforno4.Visible = true;
                tempforno5.Visible = false;
                labelforno5.Visible = false;
                tempforno6.Visible = false;
                labelforno6.Visible = false;
                tempforno7.Visible = false;
                labelforno7.Visible = false;
            }
            else if (Convert.ToInt32(comboBox1.SelectedItem.ToString()) == 5)
            {
                Tempforno1.Visible = true;
                labelforno1.Visible = true;
                tempforno2.Visible = true;
                labelforno2.Visible = true;
                tempforno3.Visible = true;
                labelforno3.Visible = true;
                tempforno4.Visible = true;
                labelforno4.Visible = true;
                tempforno5.Visible = true;
                labelforno5.Visible = true;
                tempforno6.Visible = false;
                labelforno6.Visible = false;
                tempforno7.Visible = false;
                labelforno7.Visible = false;
            }
            else if (Convert.ToInt32(comboBox1.SelectedItem.ToString()) == 6)
            {
                Tempforno1.Visible = true;
                labelforno1.Visible = true;
                tempforno2.Visible = true;
                labelforno2.Visible = true;
                tempforno3.Visible = true;
                labelforno3.Visible = true;
                tempforno4.Visible = true;
                labelforno4.Visible = true;
                tempforno5.Visible = true;
                labelforno5.Visible = true;
                tempforno6.Visible = true;
                labelforno6.Visible = true;
                tempforno7.Visible = false;
                labelforno7.Visible = false;
            }
            else if (Convert.ToInt32(comboBox1.SelectedItem.ToString()) == 7)
            {
                Tempforno1.Visible = true;
                labelforno1.Visible = true;
                tempforno2.Visible = true;
                labelforno2.Visible = true;
                tempforno3.Visible = true;
                labelforno3.Visible = true;
                tempforno4.Visible = true;
                labelforno4.Visible = true;
                tempforno5.Visible = true;
                labelforno5.Visible = true;
                tempforno6.Visible = true;
                labelforno6.Visible = true;
                tempforno7.Visible = true;
                labelforno7.Visible = true;
            }
            else
            {
                linkforno.Text = "Digite um valor válido para a quantidade de zonas no forno";
                linkforno.Visible = true;
                Tempforno1.Visible = false;
                labelforno1.Visible = false;
                tempforno2.Visible = false;
                labelforno2.Visible = false;
                tempforno3.Visible = false;
                labelforno3.Visible = false;
                tempforno4.Visible = false;
                labelforno4.Visible = false;
                tempforno5.Visible = false;
                labelforno5.Visible = false;
                tempforno6.Visible = false;
                labelforno6.Visible = false;
                tempforno7.Visible = false;
                labelforno7.Visible = false;
            }

        }

        //ações dos texts boxes e alterações no gráfico

        private void Tempforno1_TextChanged(object sender, EventArgs e)
        {
            if (tempforno2.Visible == false)
            {
                linkforno.Visible = true;
                linkforno.Text = "Para este tipo de biscoito, nota-se um comportamento crescente das temperaturas das zonas até atingimento do pico e posterior decaimento. Esse comportamento é característico para a formação da estrutura desse tipo de biscoito.Deve - se evitar altas temperaturas ou picos nas primeiras zonas do forno.";
                linkforno.LinkArea = new LinkArea(0, 0);
                dadosrefext.Visible = true;
                gráficoforno.Series["Utilizado"].Points.AddXY(z1.Text, Tempforno1.Text);
                gráficoforno.Visible = true;
            }
            else { 
            }
        }

        private void tempforno2_TextChanged(object sender, EventArgs e)
        {
            if (tempforno3.Visible == false)
            {
                linkforno.Visible = true;
                linkforno.Text = "Para este tipo de biscoito, nota-se um comportamento crescente das temperaturas das zonas até atingimento do pico e posterior decaimento. Esse comportamento é característico para a formação da estrutura desse tipo de biscoito.Deve - se evitar altas temperaturas ou picos nas primeiras zonas do forno.";
                linkforno.LinkArea = new LinkArea(0, 0);
                dadosrefext.Visible = true;
                gráficoforno.Series["Utilizado"].Points.AddXY(z1.Text, Tempforno1.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z2.Text, tempforno2.Text);
                gráficoforno.Visible = true;
            }
            else { }
        }

        private void tempforno3_TextChanged(object sender, EventArgs e)
        {
            if (tempforno4.Visible == false)
            {
                linkforno.Visible = true;
                linkforno.Text = "Para este tipo de biscoito, nota-se um comportamento crescente das temperaturas das zonas até atingimento do pico e posterior decaimento. Esse comportamento é característico para a formação da estrutura desse tipo de biscoito.Deve - se evitar altas temperaturas ou picos nas primeiras zonas do forno.";
                linkforno.LinkArea = new LinkArea(0, 0);
                dadosrefext.Visible = true;
                gráficoforno.Series["Utilizado"].Points.AddXY(z1.Text, Tempforno1.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z2.Text, tempforno2.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z3.Text, tempforno3.Text);
                gráficoforno.Visible = true;
            }
            else { }
        }

        private void tempforno4_TextChanged(object sender, EventArgs e)
        {
            if (tempforno5.Visible == false)
            {
                linkforno.Visible = true;
                linkforno.Text = "Para este tipo de biscoito, nota-se um comportamento crescente das temperaturas das zonas até atingimento do pico e posterior decaimento. Esse comportamento é característico para a formação da estrutura desse tipo de biscoito.Deve - se evitar altas temperaturas ou picos nas primeiras zonas do forno.";
                linkforno.LinkArea = new LinkArea(0, 0);
                dadosrefext.Visible = true;
                gráficoforno.Series["Utilizado"].Points.AddXY(z1.Text, Tempforno1.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z2.Text, tempforno2.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z3.Text, tempforno3.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z4.Text, tempforno4.Text);
                gráficoforno.Visible = true;
            }
            else { }
        }

        private void tempforno5_TextChanged(object sender, EventArgs e)
        {
            if (tempforno6.Visible == false)
            {
                linkforno.Visible = true;
                linkforno.Text = "Para este tipo de biscoito, nota-se um comportamento crescente das temperaturas das zonas até atingimento do pico e posterior decaimento. Esse comportamento é característico para a formação da estrutura desse tipo de biscoito.Deve - se evitar altas temperaturas ou picos nas primeiras zonas do forno.";
                linkforno.LinkArea = new LinkArea(0, 0);
                dadosrefext.Visible = true;
                gráficoforno.Series["Utilizado"].Points.AddXY(z1.Text, Tempforno1.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z2.Text, tempforno2.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z3.Text, tempforno3.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z4.Text, tempforno4.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z5.Text, tempforno5.Text);
                gráficoforno.Visible = true;
            }
            else { }
        }

        private void tempforno6_TextChanged(object sender, EventArgs e)
        {
            if (tempforno7.Visible == false)
            {
                linkforno.Visible = true;
                linkforno.Text = "Para este tipo de biscoito, nota-se um comportamento crescente das temperaturas das zonas até atingimento do pico e posterior decaimento. Esse comportamento é característico para a formação da estrutura desse tipo de biscoito.Deve - se evitar altas temperaturas ou picos nas primeiras zonas do forno.";
                linkforno.LinkArea = new LinkArea(0, 0);
                dadosrefext.Visible = true;
                gráficoforno.Series["Utilizado"].Points.AddXY(z1.Text, Tempforno1.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z2.Text, tempforno2.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z3.Text, tempforno3.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z4.Text, tempforno4.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z5.Text, tempforno5.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z6.Text, tempforno6.Text);
                gráficoforno.Visible = true;
            }
            else { }
        }

        private void tempforno7_TextChanged(object sender, EventArgs e)
        {
         
                linkforno.Visible = true;
                linkforno.Text = "Para este tipo de biscoito, nota-se um comportamento crescente das temperaturas das zonas até atingimento do pico e posterior decaimento. Esse comportamento é característico para a formação da estrutura desse tipo de biscoito.Deve - se evitar altas temperaturas ou picos nas primeiras zonas do forno.";
                linkforno.LinkArea = new LinkArea(0, 0);
                dadosrefext.Visible = true;
                gráficoforno.Series["Utilizado"].Points.AddXY(z1.Text, Tempforno1.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z2.Text, tempforno2.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z3.Text, tempforno3.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z4.Text, tempforno4.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z5.Text, tempforno5.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z6.Text, tempforno6.Text);
                gráficoforno.Series["Utilizado"].Points.AddXY(z7.Text, tempforno7.Text);

                gráficoforno.Visible = true;
            
        }

        private void Tempcoz_TextChanged(object sender, EventArgs e)
        {
            linktempcozimento.Visible = true;
            dadosreftempcozimento.Visible = true;
            if (Int32.TryParse(Tempcoz.Text.Trim(), out _))
            {

                if (Convert.ToInt32(Tempcoz.Text.Trim()) >= 5.1 && (Convert.ToInt32(Tempcoz.Text.Trim()) <= 5.6))
                {
                    this.linktempcozimento.LinkArea = new LinkArea(0, 0);
                    this.linktempcozimento.UseMnemonic = false;
                    this.linktempcozimento.Text = "A temperatura indicada está dentro dos critérios estabelecidos por Manley e Davidson.";
                    this.linktempcozimento.Links.Add(67, 6, "#");
                    this.linktempcozimento.Links.Add(76, 8, "#");
                }
                else if (Convert.ToInt32(Tempcoz.Text.Trim()) == 5)
                {
                    this.linktempcozimento.LinkArea = new LinkArea(0, 0);
                    this.linktempcozimento.UseMnemonic = false;
                    this.linktempcozimento.Text = "Tempo dentro dos critérios estabelecidos por todos os autores.";
                }
                else if (Convert.ToInt32(Tempcoz.Text.Trim()) >= 4 && (Convert.ToInt32(Tempcoz.Text.Trim()) < 5))
                {
                    this.linktempcozimento.LinkArea = new LinkArea(0, 0);
                    this.linktempcozimento.UseMnemonic = false;
                    this.linktempcozimento.Text = "Tempo dentro do critério estabelecido por Moretto e Bertolino & Braga.";
                    this.linktempcozimento.Links.Add(43, 7, "#");
                    this.linktempcozimento.Links.Add(53, 17, "#");
                }
                else if (Convert.ToInt32(Tempcoz.Text.Trim()) >= 3.4 && (Convert.ToInt32(Tempcoz.Text.Trim()) < 4))
                {
                    this.linktempcozimento.LinkArea = new LinkArea(0, 0);
                    this.linktempcozimento.UseMnemonic = false;
                    this.linktempcozimento.Text = "Tempo dentro do critério estabelecido por Moretto.";
                    this.linktempcozimento.Links.Add(43, 7, "#");

                }
                else if (Convert.ToInt32(Tempcoz.Text.Trim()) > 20 && (Convert.ToInt32(Tempcoz.Text.Trim()) < 3.5))
                {
                    this.linktempcozimento.LinkArea = new LinkArea(0, 0);
                    this.linktempcozimento.UseMnemonic = false;
                    this.linktempcozimento.Text = "Tempo divergente ao estabelecido pelos autores. O tempo de cozimento é correlacionado ao tamanho do forno, temperatura das zonas e tipo da massa. Estes fatores alteram de acordo com o estudo de cada autor, e, por este motivo, caso o tempo de cozimento utilizado forneça as especificações desejadas ao produto final, pode ser mantido.";


                }
                else if (Convert.ToInt32(Tempcoz.Text.Trim()) > 5.5 && (Convert.ToInt32(Tempcoz.Text.Trim()) <= 20))
                {
                    this.linktempcozimento.LinkArea = new LinkArea(0, 0);
                    this.linktempcozimento.UseMnemonic = false;
                    this.linktempcozimento.Text = "Tempo dentro do critério estabelecido por Manley.";
                    this.linktempcozimento.Links.Add(43, 6, "#");

                }
            }
            else
            {
                this.linktempcozimento.Text = "Digite um valor válido para a temperatura.";
            }
        




    }

        private void umidade_TextChanged(object sender, EventArgs e)
        {
            linkumidade.Visible = true;
            dadosrefumidade.Visible = true;
            if (Int32.TryParse(Tempcoz.Text.Trim(), out _))
            {

                if (Convert.ToInt32(Tempcoz.Text.Trim()) >= 2.5 && (Convert.ToInt32(Tempcoz.Text.Trim()) <= 3))
                {
                    this.linkumidade.LinkArea = new LinkArea(0, 0);
                    this.linkumidade.UseMnemonic = false;
                    this.linkumidade.Text = "Umidade dentro dos critérios estabelecidos por Manley e Davidson.";
                    this.linkumidade.Links.Add(48, 6, "#");
                    this.linkumidade.Links.Add(57, 8, "#");
                }
                else if (Convert.ToInt32(Tempcoz.Text.Trim()) == 3)
                {
                    this.linkumidade.LinkArea = new LinkArea(0, 0);
                    this.linkumidade.UseMnemonic = false;
                    this.linkumidade.Text = "Umidade dentro dos critérios estabelecidos por Davidson.";
                    this.linkumidade.Links.Add(48, 8, "#");
                }
                // else if (Convert.ToInt32(Tempcoz.Text.Trim()) >= 4 && (Convert.ToInt32(Tempcoz.Text.Trim()) < 5))
                // {
                //     this.linkumidade.LinkArea = new LinkArea(0, 0);
                //     this.linkumidade.UseMnemonic = false;
                //     this.linkumidade.Text = "Tempo dentro do critério estabelecido por Moretto e Bertolino & Braga.";
                //     this.linkumidade.Links.Add(43, 7, "#");
                //     this.linkumidade.Links.Add(53, 17, "#");
                // }
                // else if (Convert.ToInt32(Tempcoz.Text.Trim()) >= 3.4 && (Convert.ToInt32(Tempcoz.Text.Trim()) < 4))
                // {
                //     this.linkumidade.LinkArea = new LinkArea(0, 0);
                //     this.linkumidade.UseMnemonic = false;
                //     this.linkumidade.Text = "Tempo dentro do critério estabelecido por Moretto.";
                //     this.linkumidade.Links.Add(43, 7, "#");
                //
                // }
                // else if (Convert.ToInt32(Tempcoz.Text.Trim()) > 20 && (Convert.ToInt32(Tempcoz.Text.Trim()) < 3.5))
                // {
                //     this.linkumidade.LinkArea = new LinkArea(0, 0);
                //     this.linkumidade.UseMnemonic = false;
                //     this.linkumidade.Text = "Tempo divergente ao estabelecido pelos autores. O tempo de cozimento é correlacionado ao tamanho do forno, temperatura das zonas e tipo da massa. Estes fatores alteram de acordo com o estudo de cada autor, e, por este motivo, caso o tempo de cozimento utilizado forneça as especificações desejadas ao produto final, pode ser mantido.";
                //
                //
                // }
                // else if (Convert.ToInt32(Tempcoz.Text.Trim()) > 5.5 && (Convert.ToInt32(Tempcoz.Text.Trim()) <= 20))
                // {
                //     this.linkumidade.LinkArea = new LinkArea(0, 0);
                //     this.linkumidade.UseMnemonic = false;
                //     this.linkumidade.Text = "Tempo dentro do critério estabelecido por Manley.";
                //     this.linkumidade.Links.Add(43, 6, "#");
                //
                // }

            }
            else
            {
                this.linkumidade.Text = "Digite um valor válido para a temperatura.";
            }
            
        }
    }
}


