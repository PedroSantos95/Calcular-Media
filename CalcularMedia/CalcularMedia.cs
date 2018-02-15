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
        }

        private void carregarCadeirasRamoUtilizador()
        {
            string ramoUtilizador = textBoxRamoUtilizadorAtivo.Text;

            /*
             * Cadeiras de Tronco Comum
             */

            //1 Ano 1 Semestre
            label1_1_1.Text = "Análise Mat.: ";
            label1_1_1.Visible = true;
            textBox1_1_1.Visible = true;
            label1_1_2.Text = "Álgebra Lin.: ";
            label1_1_2.Visible = true;
            textBox1_1_2.Visible = true;
            label1_1_3.Text = "Sist. Comp: ";
            label1_1_3.Visible = true;
            textBox1_1_3.Visible = true;
            label1_1_4.Text = "Física Apl.: ";
            label1_1_4.Visible = true;
            textBox1_1_4.Visible = true;
            label1_1_5.Text = "Prog. I: ";
            label1_1_5.Visible = true;
            textBox1_1_5.Visible = true;
            labelPreencherDados1.Visible = false;

            //1 Ano 2 Semestre
            label1_2_1.Text = "Mat. Discreta: ";
            label1_2_1.Visible = true;
            textBox1_2_1.Visible = true;
            label1_2_2.Text = "Estatística: ";
            label1_2_2.Visible = true;
            textBox1_2_2.Visible = true;
            label1_2_3.Text = "Tec. Internet: ";
            label1_2_3.Visible = true;
            textBox1_2_3.Visible = true;
            label1_2_4.Text = "Sist. Operat.: ";
            label1_2_4.Visible = true;
            textBox1_2_4.Visible = true;
            label1_2_5.Text = "Prog. II: ";
            label1_2_5.Visible = true;
            textBox1_2_5.Visible = true;
            label1_2_6.Text = "Inglês: ";
            label1_2_6.Visible = true;
            textBox1_2_6.Visible = true;
            labelPreencherDados2.Visible = false;

            //2 Ano 1 Semestre
            label2_1_1.Text = "SGInt.: ";
            label2_1_1.Visible = true;
            textBox2_1_1.Visible = true;
            label2_1_2.Text = "AED: ";
            label2_1_2.Visible = true;
            textBox2_1_2.Visible = true;
            label2_1_3.Text = "Bases Dados:";
            label2_1_3.Visible = true;
            textBox2_1_3.Visible = true;
            label2_1_4.Text = "Redes Comp.:";
            label2_1_4.Visible = true;
            textBox2_1_4.Visible = true;
            label2_1_5.Text = "Prog. Avanc.: ";
            label2_1_5.Visible = true;
            textBox2_1_5.Visible = true;
            labelPreencherDados3.Visible = false;

            //2 Ano 2 Semestre
            label2_2_1.Text = "Ap. Internet.: ";
            label2_2_1.Visible = true;
            textBox2_2_1.Visible = true;
            label2_2_2.Text = "Eng. Soft.: ";
            label2_2_2.Visible = true;
            textBox2_2_2.Visible = true;
            labelPreencherDados4.Visible = false;

            //3 Ano 1 Semestre
            label3_1_1.Text = "DAD: ";
            label3_1_1.Visible = true;
            textBox3_1_1.Visible = true;
            label3_1_2.Text = "Int. Sist.: ";
            label3_1_2.Visible = true;
            textBox3_1_2.Visible = true;
            labelPreencherDados5.Visible = false;

            //3 Ano 2 Semestre
            label3_2_1.Text = "Proj. Infor.: ";
            label3_2_1.Visible = true;
            textBox3_2_1.Visible = true;
            label3_2_2.Text = "Inovação: ";
            label3_2_2.Visible = true;
            textBox3_2_2.Visible = true;
            label3_2_3.Text = "Seminário: ";
            label3_2_3.Visible = true;
            textBox3_2_3.Visible = true;
            labelPreencherDados6.Visible = false;

            if (ramoUtilizador == "TI")
            {

            }
            else
            {

            }
        }

        private void buttonCarregarUtilizador_Click(object sender, EventArgs e)
        {
            carregarCadeirasRamoUtilizador();
        }

        private void buttonCriarNovoUtilizador_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcularMedia_Click(object sender, EventArgs e)
        {

        }
    }
}
