using Parametrizador.Short_Dough;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

      
        
    }
}
