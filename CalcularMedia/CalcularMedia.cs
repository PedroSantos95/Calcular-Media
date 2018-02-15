using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMedia
{
    public partial class CalcularMedia : Form
    {
        private int count = 0;

        public CalcularMedia()
        {
            InitializeComponent();
            preencherComboBox();
        }

        private void carregarCadeirasRamoUtilizador()
        {
            string ramoUtilizador = textBoxRamoUtilizadorAtivo.Text;

            if (count%2 == 0)
            {
                ramoUtilizador = "TI";
            }
            else
            {
                ramoUtilizador = "SI";
            }
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
                /*
                 *  Cadeiras do Ramo de Tecnologias de Informação
                 */
                
                //2 Ano 2 Semestre
                label2_2_3.Text = "Tec. Virtual.: ";
                label2_2_3.Visible = true;
                textBox2_2_3.Visible = true;
                label2_2_4.Text = "Redes Dados:";
                label2_2_4.Visible = true;
                textBox2_2_4.Visible = true;
                label2_2_5.Text = "Admin. Sis.: ";
                label2_2_5.Visible = true;
                textBox2_2_5.Visible = true;

                //3 Ano 1 Semestre
                label3_1_3.Text = "Cent. Dados: ";
                label3_1_3.Visible = true;
                textBox3_1_3.Visible = true;
                label3_1_4.Text = "Top. Redes: ";
                label3_1_4.Visible = true;
                textBox3_1_4.Visible = true;
                label3_1_5.Text = "Seg. Sistemas: ";
                label3_1_5.Visible = true;
                textBox3_1_5.Visible = true;

                //3 Ano 2 Semestre
                label3_2_4.Text = "Lab. Tec. Inf: ";
                label3_2_4.Visible = true;
                textBox3_2_4.Visible = true;
                label3_2_5.Text = "Eng. Sis. Serv.:";
                label3_2_5.Visible = true;
                textBox3_2_5.Visible = true;

            }
            else
            {
                /*
                 *  Cadeiras do Ramo de Sistemas de Informação
                 */

                //2 Ano 2 Semestre
                label2_2_3.Text = "Int. Artificial:";
                label2_2_3.Visible = true;
                textBox2_2_3.Visible = true;
                label2_2_4.Text = "Sist. B. Dados:";
                label2_2_4.Visible = true;
                textBox2_2_4.Visible = true;
                label2_2_5.Text = "Seg. Informacao:";
                label2_2_5.Visible = true;
                textBox2_2_5.Visible = true;

                //3 Ano 1 Semestre
                label3_1_3.Text = "Top. Soft.:";
                label3_1_3.Visible = true;
                textBox3_1_3.Visible = true;
                label3_1_4.Text = "DAE:";
                label3_1_4.Visible = true;
                textBox3_1_4.Visible = true;
                label3_1_5.Text = "Sist. A. Dec.:";
                label3_1_5.Visible = true;
                textBox3_1_5.Visible = true;

                //3 Ano 2 Semestre
                label3_2_4.Text = "E. Conhecim.:";
                label3_2_4.Visible = true;
                textBox3_2_4.Visible = true;
                label3_2_5.Text = "Sist. Inf. Emp.:";
                label3_2_5.Visible = true;
                textBox3_2_5.Visible = true;
            }
        }

        private void buttonCarregarUtilizador_Click(object sender, EventArgs e)
        {
            count++;
            carregarCadeirasRamoUtilizador();
        }

        private void buttonCriarNovoUtilizador_Click(object sender, EventArgs e)
        {
            if(textBoxNomeUtilizador.Text == "" || textBoxNumeroUtilizador.Text == "" || comboBoxRamoCurso.SelectedItem == null)
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Erro ao Criar Utilizador");
            }
            else
            {
                bool letrasNome = textBoxNomeUtilizador.Text.All(Char.IsLetter);
                bool numerosNumero = textBoxNumeroUtilizador.Text.All(Char.IsDigit);

                if (letrasNome == false || numerosNumero == false)
                {
                    MessageBox.Show("Por favor verifique se os campos estão bem preenchidos!", "Erro ao Criar Utilizador");
                }
                else
                {
                    if(textBoxNumeroUtilizador.Text.Length != 7)
                    {
                        MessageBox.Show("Por favor verifique o numero de aluno!", "Erro ao Criar Utilizador");
                    }
                    else
                    {
                        string nomeAluno = textBoxNomeUtilizador.Text;
                        int numeroAluno = Int32.Parse(textBoxNumeroUtilizador.Text);
                        string ramoAluno = comboBoxRamoCurso.SelectedItem.ToString();

                        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
                        SqlDataAdapter da = new SqlDataAdapter();

                        da.InsertCommand = new SqlCommand("INSERT INTO Aluno VALUES(@numero,@nome,@ramo,NULL)", sqlConn);
                        da.InsertCommand.Parameters.Add("@numero", SqlDbType.Int).Value = numeroAluno;
                        da.InsertCommand.Parameters.Add("@nome", SqlDbType.NVarChar).Value = nomeAluno;
                        da.InsertCommand.Parameters.Add("@ramo", SqlDbType.NVarChar).Value = ramoAluno;

                        sqlConn.Open();
                        da.InsertCommand.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("Adicionado com sucesso!", "Sucesso");
                        preencherComboBox();
                    }
                }
            }
        }

        private void buttonCalcularMedia_Click(object sender, EventArgs e)
        {

        }

        private void preencherComboBox()
        {
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT [Numero], [Nome] FROM [Aluno]", sqlConn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        comboBoxUtilizadoresExistentes.DisplayMember = "Nome";
                        comboBoxUtilizadoresExistentes.ValueMember = "Numero";
                        comboBoxUtilizadoresExistentes.DataSource = dt;
                    }
                }
            }
        }
    }
}
