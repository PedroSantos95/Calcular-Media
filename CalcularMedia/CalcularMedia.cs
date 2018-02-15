using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMedia
{
    public partial class CalcularMedia : Form
    {
        public CalcularMedia()
        {
            InitializeComponent();
            carregarCadeirasRamoUtilizador();
        }

        private void carregarCadeirasRamoUtilizador()
        {
            string ramoUtilizador = textBoxRamoUtilizadorAtivo.Text;

            if (ramoUtilizador == "SI")
            {

            }
            else
            {
                
            }
        }

        private void buttonCarregarUtilizador_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
