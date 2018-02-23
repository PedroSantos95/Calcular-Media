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
        public int contadorTeste = 0;
        
        public CalcularMedia()
        {
            InitializeComponent();
            preencherComboBox();
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

            if (ramoUtilizador == "Tecnlogias Informação")
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
                label2_2_5.Text = "Seg. Inform:";
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
            string ramoUtilizadorAtivo = "";
            int numeroUtilizadorAtivo = Int32.Parse(comboBoxUtilizadoresExistentes.SelectedValue.ToString());
            textBoxNomeUtilizadorAtivo.Text = comboBoxUtilizadoresExistentes.Text;
            textBoxNumeroUtilizadorAtivo.Text = comboBoxUtilizadoresExistentes.SelectedValue.ToString();
            ramoUtilizadorAtivo = ramoUtilizador(numeroUtilizadorAtivo);
            textBoxRamoUtilizadorAtivo.Text = ramoUtilizadorAtivo;
            buttonCarregarNotas.Visible = true;
            limparMediaECreditos();
            progressBarCurso.Value = 0;
            carregarMediaECreditosUtilizador(numeroUtilizadorAtivo);

            carregarCadeirasRamoUtilizador();
            resetNotasCadeiras();
            carregarNotasUtilizador(numeroUtilizadorAtivo);
        }

        private void buttonCriarNovoUtilizador_Click(object sender, EventArgs e)
        {
            if (textBoxNomeUtilizador.Text == "" || textBoxNumeroUtilizador.Text == "" || comboBoxRamoCurso.SelectedItem == null)
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Erro ao Criar Utilizador");
            }
            else
            {
                string nomeUtilizadorTeste = textBoxNomeUtilizador.Text;
                nomeUtilizadorTeste = nomeUtilizadorTeste.Replace(" ", String.Empty);
                bool letrasNome = nomeUtilizadorTeste.All(Char.IsLetter);
                bool numerosNumero = textBoxNumeroUtilizador.Text.All(Char.IsDigit);

                if (letrasNome == false || numerosNumero == false)
                {
                    MessageBox.Show("Por favor verifique se os campos estão bem preenchidos!", "Erro ao Criar Utilizador");
                }
                else
                {
                    if (textBoxNumeroUtilizador.Text.Length != 7)
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

                        da.InsertCommand = new SqlCommand("INSERT INTO Aluno VALUES(@numero,@nome,@ramo,@creditosEfetuados, @media)", sqlConn);
                        da.InsertCommand.Parameters.Add("@numero", SqlDbType.Int).Value = numeroAluno;
                        da.InsertCommand.Parameters.Add("@nome", SqlDbType.NVarChar).Value = nomeAluno;
                        da.InsertCommand.Parameters.Add("@ramo", SqlDbType.NVarChar).Value = ramoAluno;
                        da.InsertCommand.Parameters.Add("@creditosEfetuados", SqlDbType.Int).Value = 0;
                        da.InsertCommand.Parameters.Add("@media", SqlDbType.NVarChar).Value = 0;

                        sqlConn.Open();
                        da.InsertCommand.ExecuteNonQuery();
                        sqlConn.Close();
                        MessageBox.Show("Adicionado com sucesso! Selecione agora dos existentes.", "Sucesso");
                        preencherComboBox();
                        textBoxNumeroUtilizador.Clear();
                        textBoxNomeUtilizador.Clear();
                        comboBoxRamoCurso.SelectedItem = null;
                    }
                }
            }
        }

        private void buttonCarregarNotas_Click(object sender, EventArgs e)
        {

            //Buscar Valores
            bool utilizadorJaNaBaseDeDados = false;
            int numeroAluno = Int32.Parse(textBoxNumeroUtilizadorAtivo.Text);
            utilizadorJaNaBaseDeDados = cadeirasPreviamenteGuardadas(numeroAluno);
            decimal analise = colocarValorZeroSeVazio(textBox1_1_1);
            decimal algebra = colocarValorZeroSeVazio(textBox1_1_2);
            decimal sistComp = colocarValorZeroSeVazio(textBox1_1_3);
            decimal fisicaApl = colocarValorZeroSeVazio(textBox1_1_4);
            decimal progI = colocarValorZeroSeVazio(textBox1_1_5);
            decimal matDiscreta = colocarValorZeroSeVazio(textBox1_2_1);
            decimal estatistica = colocarValorZeroSeVazio(textBox1_2_2);
            decimal tecInternet = colocarValorZeroSeVazio(textBox1_2_3);
            decimal sistOperativos = colocarValorZeroSeVazio(textBox1_2_4);
            decimal progII = colocarValorZeroSeVazio(textBox1_2_5);
            decimal ingles = colocarValorZeroSeVazio(textBox1_2_6);

            decimal sgint = colocarValorZeroSeVazio(textBox2_1_1);
            decimal aed = colocarValorZeroSeVazio(textBox2_1_2);
            decimal basesDados = colocarValorZeroSeVazio(textBox2_1_3);
            decimal redesComp = colocarValorZeroSeVazio(textBox2_1_4);
            decimal porgAvanc = colocarValorZeroSeVazio(textBox2_1_5);

            decimal apInternet = colocarValorZeroSeVazio(textBox2_2_1);
            decimal engSoftw = colocarValorZeroSeVazio(textBox2_2_2);

            decimal dad = colocarValorZeroSeVazio(textBox3_1_1);
            decimal intSistemas = colocarValorZeroSeVazio(textBox3_1_2);

            decimal projInfor = colocarValorZeroSeVazio(textBox3_2_1);
            decimal inov = colocarValorZeroSeVazio(textBox3_2_2);
            decimal seminario = colocarValorZeroSeVazio(textBox3_2_3);


            decimal tecVirtual = 0;
            decimal redesDados = 0;
            decimal adminSistemas = 0;
            decimal centDados = 0;
            decimal topRedes = 0;
            decimal segSistemas = 0;
            decimal labTecInf = 0;
            decimal engSistServ = 0;
            decimal intArtificial = 0;
            decimal sistBDados = 0;
            decimal segInformacao = 0;
            decimal topSoftware = 0;
            decimal dae = 0;
            decimal sistApDecisao = 0;
            decimal engConhec = 0;
            decimal sistInfEmp = 0;

            if (ramoUtilizador(numeroAluno) == "Tecnlogias Informação")
            {
                tecVirtual = colocarValorZeroSeVazio(textBox2_2_3);
                redesDados = colocarValorZeroSeVazio(textBox2_2_4);
                adminSistemas = colocarValorZeroSeVazio(textBox2_2_5);

                centDados = colocarValorZeroSeVazio(textBox3_1_3);
                topRedes = colocarValorZeroSeVazio(textBox3_1_4);
                segSistemas = colocarValorZeroSeVazio(textBox3_1_5);

                labTecInf = colocarValorZeroSeVazio(textBox3_2_4);
                engSistServ = colocarValorZeroSeVazio(textBox3_2_5);
            }
            else
            {
                intArtificial = colocarValorZeroSeVazio(textBox2_2_3);
                sistBDados = colocarValorZeroSeVazio(textBox2_2_4);
                segInformacao = colocarValorZeroSeVazio(textBox2_2_5);

                topSoftware = colocarValorZeroSeVazio(textBox3_1_3);
                dae = colocarValorZeroSeVazio(textBox3_1_4);
                sistApDecisao = colocarValorZeroSeVazio(textBox3_1_5);

                engConhec = colocarValorZeroSeVazio(textBox3_2_4);
                sistInfEmp = colocarValorZeroSeVazio(textBox3_2_5);
            }

            if (utilizadorJaNaBaseDeDados == false)
            {

                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter();

                da.InsertCommand = new SqlCommand("INSERT INTO Cadeiras VALUES(@NumeroAluno, @Analise, @Algebra, @Fisica, @SistComp, @ProgI, @MatDisc, @ProgII, @Ingles, @TecInternet," +
                    " @SistOperativos, @Estatistica, @SistGrafInt, @AlgEstDados, @BasesDados, @RedesComput, @ProgAvancada, @ApliInternet, @EngSoftware, @IntArtificial, @SistBasesDados," +
                    " @SegInformacao, @TecVirtualizacao, @RedesDados, @AdminSistemas, @DesenvAplicDistrib, @IntSistemas, @CentProcDados, @TopcRedes, @SegSistemas, @TopcSoftware," +
                    " @DesenvApliEmp, @SistApoioDecisao, @ProjInformatico, @Seminario, @InovEmpreendorismo, @EngConhecimento, @SistInfoEmpre, @LabTecInfo, @EngSistServicos)", sqlConn);
                da.InsertCommand.Parameters.Add("@NumeroAluno", SqlDbType.Int).Value = numeroAluno;
                da.InsertCommand.Parameters.Add("@Analise", SqlDbType.Decimal).Value = analise;
                da.InsertCommand.Parameters.Add("@Algebra", SqlDbType.Decimal).Value = algebra;
                da.InsertCommand.Parameters.Add("@Fisica", SqlDbType.Decimal).Value = fisicaApl;
                da.InsertCommand.Parameters.Add("@SistComp", SqlDbType.Decimal).Value = sistComp;
                da.InsertCommand.Parameters.Add("@ProgI", SqlDbType.Decimal).Value = progI;
                da.InsertCommand.Parameters.Add("@MatDisc", SqlDbType.Decimal).Value = matDiscreta;
                da.InsertCommand.Parameters.Add("@ProgII", SqlDbType.Decimal).Value = progII;
                da.InsertCommand.Parameters.Add("@Ingles", SqlDbType.Decimal).Value = ingles;
                da.InsertCommand.Parameters.Add("@TecInternet", SqlDbType.Decimal).Value = tecInternet;
                da.InsertCommand.Parameters.Add("@SistOperativos", SqlDbType.Decimal).Value = sistOperativos;
                da.InsertCommand.Parameters.Add("@Estatistica", SqlDbType.Decimal).Value = estatistica;
                da.InsertCommand.Parameters.Add("@SistGrafInt", SqlDbType.Decimal).Value = sgint;
                da.InsertCommand.Parameters.Add("@AlgEstDados", SqlDbType.Decimal).Value = aed;
                da.InsertCommand.Parameters.Add("@BasesDados", SqlDbType.Decimal).Value = basesDados;
                da.InsertCommand.Parameters.Add("@RedesComput", SqlDbType.Decimal).Value = redesComp;
                da.InsertCommand.Parameters.Add("@ProgAvancada", SqlDbType.Decimal).Value = porgAvanc;
                da.InsertCommand.Parameters.Add("@ApliInternet", SqlDbType.Decimal).Value = apInternet;
                da.InsertCommand.Parameters.Add("@EngSoftware", SqlDbType.Decimal).Value = engSoftw;
                da.InsertCommand.Parameters.Add("@IntArtificial", SqlDbType.Decimal).Value = intArtificial;
                da.InsertCommand.Parameters.Add("@SistBasesDados", SqlDbType.Decimal).Value = sistBDados;
                da.InsertCommand.Parameters.Add("@SegInformacao", SqlDbType.Decimal).Value = segInformacao;
                da.InsertCommand.Parameters.Add("@TecVirtualizacao", SqlDbType.Decimal).Value = tecVirtual;
                da.InsertCommand.Parameters.Add("@RedesDados", SqlDbType.Decimal).Value = redesDados;
                da.InsertCommand.Parameters.Add("@AdminSistemas", SqlDbType.Decimal).Value = adminSistemas;
                da.InsertCommand.Parameters.Add("@DesenvAplicDistrib", SqlDbType.Decimal).Value = dad;
                da.InsertCommand.Parameters.Add("@IntSistemas", SqlDbType.Decimal).Value = intSistemas;
                da.InsertCommand.Parameters.Add("@CentProcDados", SqlDbType.Decimal).Value = centDados;
                da.InsertCommand.Parameters.Add("@TopcRedes", SqlDbType.Decimal).Value = topRedes;
                da.InsertCommand.Parameters.Add("@SegSistemas", SqlDbType.Decimal).Value = segSistemas;
                da.InsertCommand.Parameters.Add("@TopcSoftware", SqlDbType.Decimal).Value = topSoftware;
                da.InsertCommand.Parameters.Add("@DesenvApliEmp", SqlDbType.Decimal).Value = dae;
                da.InsertCommand.Parameters.Add("@SistApoioDecisao", SqlDbType.Decimal).Value = sistApDecisao;
                da.InsertCommand.Parameters.Add("@ProjInformatico", SqlDbType.Decimal).Value = projInfor;
                da.InsertCommand.Parameters.Add("@Seminario", SqlDbType.Decimal).Value = seminario;
                da.InsertCommand.Parameters.Add("@InovEmpreendorismo", SqlDbType.Decimal).Value = inov;
                da.InsertCommand.Parameters.Add("@EngConhecimento", SqlDbType.Decimal).Value = engConhec;
                da.InsertCommand.Parameters.Add("@SistInfoEmpre", SqlDbType.Decimal).Value = sistInfEmp;
                da.InsertCommand.Parameters.Add("@LabTecInfo", SqlDbType.Decimal).Value = labTecInf;
                da.InsertCommand.Parameters.Add("@EngSistServicos", SqlDbType.Decimal).Value = engSistServ;

                sqlConn.Open();
                da.InsertCommand.ExecuteNonQuery();
                sqlConn.Close();
                resetNotasCadeiras();

                MessageBox.Show("As suas notas foram guardadas com sucesso.", "Notas Guardadas",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter();

                SqlCommand command = sqlConn.CreateCommand();
                command.CommandText = "UPDATE Cadeiras SET Analise = @Analise, Algebra = @Algebra, Fisica = @Fisica, SistComp = @SistComp, ProgI = @ProgI, MatDisc = @MatDisc," +
                    " ProgII = @ProgII, Ingles = @Ingles, TecInternet = @TecInternet, SistOperativos = @SistOperativos, Estatistica = @Estatistica, SistGrafInt = @SistGrafInt, " +
                    " AlgEstDados = @AlgEstDados, BasesDados = @BasesDados,RedesComput = @RedesComput, ProgAvancada= @ProgAvancada,ApliInternet = @ApliInternet," +
                    " EngSoftware = @EngSoftware,IntArtificial = @IntArtificial, SistBasesDados = @SistBasesDados, SegInformacao= @SegInformacao, TecVirtualizacao= @TecVirtualizacao," +
                    " RedesDados= @RedesDados,AdminSistemas = @AdminSistemas, DesenvAplicDistrib= @DesenvAplicDistrib,IntSistemas = @IntSistemas,CentProcDados = @CentProcDados," +
                    " TopcRedes= @TopcRedes, SegSistemas= @SegSistemas, TopcSoftware= @TopcSoftware,DesenvApliEmp = @DesenvApliEmp,SistApoioDecisao = @SistApoioDecisao," +
                    " ProjInformatico= @ProjInformatico, Seminario= @Seminario, InovEmpreendorismo= @InovEmpreendorismo, EngConhecimento= @EngConhecimento, " +
                    " SistInfoEmpre= @SistInfoEmpre,LabTecInfo = @LabTecInfo, EngSistServicos = @EngSistServicos WHERE [NumeroAluno] = '" + numeroAluno + "'";
                command.Parameters.AddWithValue("@Analise", analise);
                command.Parameters.AddWithValue("@Algebra", algebra);
                command.Parameters.AddWithValue("@Fisica", fisicaApl);
                command.Parameters.AddWithValue("@SistComp", sistComp);
                command.Parameters.AddWithValue("@ProgI", progI);
                command.Parameters.AddWithValue("@MatDisc", matDiscreta);
                command.Parameters.AddWithValue("@ProgII", progII);
                command.Parameters.AddWithValue("@Ingles", ingles);
                command.Parameters.AddWithValue("@TecInternet", tecInternet);
                command.Parameters.AddWithValue("@SistOperativos", sistOperativos);
                command.Parameters.AddWithValue("@Estatistica", estatistica);
                command.Parameters.AddWithValue("@SistGrafInt", sgint);
                command.Parameters.AddWithValue("@AlgEstDados", aed);
                command.Parameters.AddWithValue("@BasesDados", basesDados);
                command.Parameters.AddWithValue("@RedesComput", redesComp);
                command.Parameters.AddWithValue("@ProgAvancada", porgAvanc);
                command.Parameters.AddWithValue("@ApliInternet", apInternet);
                command.Parameters.AddWithValue("@EngSoftware", engSoftw);
                command.Parameters.AddWithValue("@IntArtificial", intArtificial);
                command.Parameters.AddWithValue("@SistBasesDados", sistBDados);
                command.Parameters.AddWithValue("@SegInformacao", segInformacao);
                command.Parameters.AddWithValue("@TecVirtualizacao", tecVirtual);
                command.Parameters.AddWithValue("@RedesDados", redesDados);
                command.Parameters.AddWithValue("@AdminSistemas", adminSistemas);
                command.Parameters.AddWithValue("@DesenvAplicDistrib", dad);
                command.Parameters.AddWithValue("@IntSistemas", intSistemas);
                command.Parameters.AddWithValue("@CentProcDados", centDados);
                command.Parameters.AddWithValue("@TopcRedes", topRedes);
                command.Parameters.AddWithValue("@SegSistemas", segSistemas);
                command.Parameters.AddWithValue("@TopcSoftware", topSoftware);
                command.Parameters.AddWithValue("@DesenvApliEmp", dae);
                command.Parameters.AddWithValue("@SistApoioDecisao", sistApDecisao);
                command.Parameters.AddWithValue("@ProjInformatico", projInfor);
                command.Parameters.AddWithValue("@Seminario", seminario);
                command.Parameters.AddWithValue("@InovEmpreendorismo", inov);
                command.Parameters.AddWithValue("@EngConhecimento", engConhec);
                command.Parameters.AddWithValue("@SistInfoEmpre", sistInfEmp);
                command.Parameters.AddWithValue("@LabTecInfo", labTecInf);
                command.Parameters.AddWithValue("@EngSistServicos", engSistServ);

                sqlConn.Open();
                command.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show("As suas notas foram atualizadas com sucesso.", "Notas Atualizadas",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonCalcularMedia.Visible = true;
            }

        }

        private void buttonCalcularMedia_Click(object sender, EventArgs e)
        {
            int numeroAluno = Int32.Parse(textBoxNumeroUtilizadorAtivo.Text);
            guardarMediaEMostrar(numeroAluno);
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

        private string ramoUtilizador(int numeroUtilizador)
        {
            string[] ramo = new string[10];
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Ramo] FROM [Aluno] WHERE [Numero] = '" + numeroUtilizador + "'", sqlConn);
            SqlDataReader myreader = cmd.ExecuteReader();

            while (myreader.Read())
            {
                ramo[0] = Convert.ToString(myreader[0]);
            }

            sqlConn.Close();

            return ramo[0];
        }

        IEnumerable<IDataRecord> GetFromReader(IDataReader reader)
        {
            while (reader.Read()) yield return reader;
        }

        private void carregarNotasUtilizador(int numeroAluno)
        {
            string ramo = ramoUtilizador(numeroAluno);
            int count = 0;

            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Analise], [Algebra], [Fisica], [SistComp], [ProgI], [MatDisc], [ProgII] , [Ingles], [TecInternet], [SistOperativos], " + //10
                "[Estatistica], [SistGrafInt], [AlgEstDados], [BasesDados], [RedesComput], [ProgAvancada], [ApliInternet], [EngSoftware], [IntArtificial], [SistBasesDados]," + //20
                "[SegInformacao], [TecVirtualizacao],  [RedesDados], [AdminSistemas], [DesenvAplicDistrib], [IntSistemas], [CentProcDados], [TopcRedes], [SegSistemas], [TopcSoftware]," + //30
                " [DesenvApliEmp],[SistApoioDecisao], [ProjInformatico], [Seminario], [InovEmpreendorismo], [EngConhecimento], [SistInfoEmpre],  [LabTecInfo], [EngSistServicos] " + //39
                " FROM [Cadeiras] WHERE [NumeroAluno] = '" + numeroAluno + "'", sqlConn);
            SqlDataReader myreader = cmd.ExecuteReader();

            foreach (IDataRecord record in GetFromReader(myreader))
            {
                carregarNotasTextBox(ramo, record);
                count++;
            }

            if(count == 0)
            {
                setTextBoxZero();
            }

            sqlConn.Close();

        }

        private bool cadeirasPreviamenteGuardadas(int numeroAlunoAtual)
        {
            bool utilizadorNaBaseDeDados = false;
            int numero = 0;
            string[] numerosUtilizador = new string[900];
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [NumeroAluno] FROM [Cadeiras]", sqlConn);
            SqlDataReader myreader = cmd.ExecuteReader();

            while (myreader.Read())
            {
                numerosUtilizador[0] = Convert.ToString(myreader[0]);
                if (Int32.Parse(numerosUtilizador[0]) == numeroAlunoAtual)
                {
                    utilizadorNaBaseDeDados = true;
                }
            }

            sqlConn.Close();

            return utilizadorNaBaseDeDados;
        }

        private decimal colocarValorZeroSeVazio(TextBox textBoxNotaCadeira)
        {
            decimal notaCadeira = 0;

            if (textBoxNotaCadeira.Text == "")
            {
                textBoxNotaCadeira.Text = "0";
            }

            notaCadeira = Decimal.Parse(textBoxNotaCadeira.Text);

            return notaCadeira;
        }

        private void resetNotasCadeiras()
        {
            textBox1_1_1.Text = "";
            textBox1_1_2.Text = "";
            textBox1_1_3.Text = "";
            textBox1_1_4.Text = "";
            textBox1_1_5.Text = "";

            textBox1_2_1.Text = "";
            textBox1_2_2.Text = "";
            textBox1_2_3.Text = "";
            textBox1_2_4.Text = "";
            textBox1_2_5.Text = "";
            textBox1_2_6.Text = "";

            textBox2_1_1.Text = "";
            textBox2_1_2.Text = "";
            textBox2_1_3.Text = "";
            textBox2_1_4.Text = "";
            textBox2_1_5.Text = "";

            textBox2_2_1.Text = "";
            textBox2_2_2.Text = "";
            textBox2_2_3.Text = "";
            textBox2_2_4.Text = "";
            textBox2_2_5.Text = "";

            textBox3_1_1.Text = "";
            textBox3_1_2.Text = "";
            textBox3_1_3.Text = "";
            textBox3_1_4.Text = "";
            textBox3_1_5.Text = "";

            textBox3_2_1.Text = "";
            textBox3_2_2.Text = "";
            textBox3_2_3.Text = "";
            textBox3_2_4.Text = "";
            textBox3_2_5.Text = "";

        }

        private void esconderLabels()
        {
            label1_1_1.Visible = false;
            label1_1_2.Visible = false;
            label1_1_3.Visible = false;
            label1_1_4.Visible = false;
            label1_1_5.Visible = false;
            label1_2_1.Visible = false;
            label1_2_2.Visible = false;
            label1_2_3.Visible = false;
            label1_2_4.Visible = false;
            label1_2_5.Visible = false;
            label1_2_6.Visible = false;
            label2_1_1.Visible = false;
            label2_1_2.Visible = false;
            label2_1_3.Visible = false;
            label2_1_4.Visible = false;
            label2_1_5.Visible = false;
            label2_2_1.Visible = false;
            label2_2_2.Visible = false;
            label2_2_3.Visible = false;
            label2_2_4.Visible = false;
            label2_2_5.Visible = false;
            label3_1_1.Visible = false;
            label3_1_2.Visible = false;
            label3_1_3.Visible = false;
            label3_1_4.Visible = false;
            label3_1_5.Visible = false;
            label3_2_1.Visible = false;
            label3_2_2.Visible = false;
            label3_2_3.Visible = false;
            label3_2_4.Visible = false;
            label3_2_5.Visible = false;
        }

        private void carregarNotasTextBox(string ramoUtilizador, IDataRecord record)
        {
            //1 ANO 1 SEMESTRE
            textBox1_1_1.Text = record.GetDecimal(0).ToString();
            textBox1_1_2.Text = record.GetDecimal(1).ToString();
            textBox1_1_3.Text = record.GetDecimal(3).ToString();
            textBox1_1_4.Text = record.GetDecimal(2).ToString();
            textBox1_1_5.Text = record.GetDecimal(4).ToString();

            //1 ANO 2 SEMESTRE
            textBox1_2_1.Text = record.GetDecimal(5).ToString();
            textBox1_2_2.Text = record.GetDecimal(10).ToString();
            textBox1_2_3.Text = record.GetDecimal(8).ToString();
            textBox1_2_4.Text = record.GetDecimal(9).ToString();
            textBox1_2_5.Text = record.GetDecimal(6).ToString();
            textBox1_2_6.Text = record.GetDecimal(7).ToString();

            //2 ANO 1 SEMESTRE
            textBox2_1_1.Text = record.GetDecimal(11).ToString();
            textBox2_1_2.Text = record.GetDecimal(12).ToString();
            textBox2_1_3.Text = record.GetDecimal(13).ToString();
            textBox2_1_4.Text = record.GetDecimal(14).ToString();
            textBox2_1_5.Text = record.GetDecimal(15).ToString();

            //2 ANO 2 SEMESTRE
            textBox2_2_1.Text = record.GetDecimal(16).ToString();
            textBox2_2_2.Text = record.GetDecimal(17).ToString();

            //3 ANO 1 SEMESTRE
            textBox3_1_1.Text = record.GetDecimal(24).ToString();
            textBox3_1_2.Text = record.GetDecimal(25).ToString();


            //3 ANO 2 SEMESTRE
            textBox3_2_1.Text = record.GetDecimal(32).ToString();
            textBox3_2_2.Text = record.GetDecimal(34).ToString();
            textBox3_2_3.Text = record.GetDecimal(33).ToString();





            if (ramoUtilizador == "Tecnlogias Informação")
            {
                //2 ANO 2 SEMESTRE
                textBox2_2_3.Text = record.GetDecimal(21).ToString();
                textBox2_2_4.Text = record.GetDecimal(22).ToString();
                textBox2_2_5.Text = record.GetDecimal(23).ToString();

                //3 ANO 1 SEMESTRE
                textBox3_1_3.Text = record.GetDecimal(26).ToString();
                textBox3_1_4.Text = record.GetDecimal(27).ToString();
                textBox3_1_5.Text = record.GetDecimal(28).ToString();

                //3 ANO 2 SEMESTRE
                textBox3_2_4.Text = record.GetDecimal(37).ToString();
                textBox3_2_5.Text = record.GetDecimal(38).ToString();




            }
            else
            {
                //2 ANO 2 SEMESTRE
                textBox2_2_3.Text = record.GetDecimal(18).ToString();
                textBox2_2_4.Text = record.GetDecimal(19).ToString();
                textBox2_2_5.Text = record.GetDecimal(20).ToString();

                //3 ANO 1 SEMESTRE
                textBox3_1_3.Text = record.GetDecimal(29).ToString();
                textBox3_1_4.Text = record.GetDecimal(30).ToString();
                textBox3_1_5.Text = record.GetDecimal(31).ToString();

                //3 ANO 1 SEMESTRE
                textBox3_2_4.Text = record.GetDecimal(35).ToString();
                textBox3_2_5.Text = record.GetDecimal(36).ToString();

            }
        }

        private void setTextBoxZero()
        {
            textBox1_1_1.Text = "0";
            textBox1_1_2.Text = "0";
            textBox1_1_3.Text = "0";
            textBox1_1_4.Text = "0";
            textBox1_1_5.Text = "0";
            textBox1_2_1.Text = "0";
            textBox1_2_2.Text = "0";
            textBox1_2_3.Text = "0";
            textBox1_2_4.Text = "0";
            textBox1_2_5.Text = "0";
            textBox1_2_6.Text = "0";

            textBox2_1_1.Text = "0";
            textBox2_1_2.Text = "0";
            textBox2_1_3.Text = "0";
            textBox2_1_4.Text = "0";
            textBox2_1_5.Text = "0";
            textBox2_2_1.Text = "0";
            textBox2_2_2.Text = "0";
            textBox2_2_3.Text = "0";
            textBox2_2_4.Text = "0";
            textBox2_2_5.Text = "0";

            textBox3_1_1.Text = "0";
            textBox3_1_2.Text = "0";
            textBox3_1_3.Text = "0";
            textBox3_1_4.Text = "0";
            textBox3_1_5.Text = "0";
            textBox3_2_1.Text = "0";
            textBox3_2_2.Text = "0";
            textBox3_2_3.Text = "0";
            textBox3_2_4.Text = "0";
            textBox3_2_5.Text = "0";


        }

        private int guardarMediaEMostrar(int numeroAluno)
        {
            string ramo = ramoUtilizador(numeroAluno);
            int count = 0;
            int mediaAlunoAtual = 0;

            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Analise], [Algebra], [Fisica], [SistComp], [ProgI], [MatDisc], [ProgII] , [Ingles], [TecInternet], [SistOperativos], " + //10
                "[Estatistica], [SistGrafInt], [AlgEstDados], [BasesDados], [RedesComput], [ProgAvancada], [ApliInternet], [EngSoftware], [IntArtificial], [SistBasesDados]," + //20
                "[SegInformacao], [TecVirtualizacao],  [RedesDados], [AdminSistemas], [DesenvAplicDistrib], [IntSistemas], [CentProcDados], [TopcRedes], [SegSistemas], [TopcSoftware]," + //30
                " [DesenvApliEmp],[SistApoioDecisao], [ProjInformatico], [Seminario], [InovEmpreendorismo], [EngConhecimento], [SistInfoEmpre],  [LabTecInfo], [EngSistServicos] " + //39
                " FROM [Cadeiras] WHERE [NumeroAluno] = '" + numeroAluno + "'", sqlConn);
            SqlDataReader myreader = cmd.ExecuteReader();

            foreach (IDataRecord record in GetFromReader(myreader))
            {
                calcularMediaPonderada(ramo, record);
                count++;
            }

            if (count == 0)
            {
                setTextBoxZero();
            }

            sqlConn.Close();

            return mediaAlunoAtual;
        }

        private void calcularMediaPonderada(string ramoUtilizador, IDataRecord record)
        {
            decimal mediaPonderada = 0;
            decimal creditosEfetuados = 0;

            decimal redesDados = 0;
            decimal adminSist = 0;
            decimal centroDados = 0;
            decimal topicosRedes = 0;
            decimal segurancaSist = 0;
            decimal engSistServ = 0;
            decimal labTecInfo = 0;
            decimal intArtifical = 0;
            decimal segurancaInfo = 0;
            decimal sistemasBD = 0;
            decimal topicosSoftware = 0;
            decimal dae = 0;
            decimal engCohecimento = 0;
            decimal sad = 0;
            decimal sie = 0;
            decimal tecVirt = 0;

            bool analiseEfetuado = false;
            bool algebraEfetuado = false;
            bool sistCompEfetuado = false;
            bool fisicaAplEfetuado = false;
            bool progIEfetuado = false;
            bool matDiscretaEfetuado = false;
            bool estatisticaEfetuado = false;
            bool tecInternetEfetuado = false;
            bool sistOperativosEfetuado = false;
            bool progIIEfetuado = false;
            bool inglesEfetuado = false;
            bool sgintEfetuado = false;
            bool aedEfetuado = false;
            bool basesDadosEfetuado = false;
            bool redesCompEfetuado = false;
            bool porgAvancEfetuado = false;
            bool apInternetEfetuado = false;
            bool engSoftwEfetuado = false;
            bool dadEfetuado = false;
            bool intSistemasEfetuado = false;
            bool projInforEfetuado = false;
            bool inovEfetuado = false;
            bool seminarioEfetuado = false;
            bool tecVirtualEfetuado = false;
            bool redesDadosEfetuado = false;
            bool adminSistemasEfetuado = false;
            bool centDadosEfetuado = false;
            bool topRedesEfetuado = false;
            bool segSistemasEfetuado = false;
            bool labTecInfEfetuado = false;
            bool engSistServEfetuado = false;
            bool intArtificialEfetuado = false;
            bool sistBDadosEfetuado = false;
            bool segInformacaoEfetuado = false;
            bool topSoftwareEfetuado = false;
            bool daeEfetuado = false;
            bool sistApDecisaoEfetuado = false;
            bool engConhecEfetuado = false;
            bool sistInfEmpEfetuado = false;

            //1 ANO 1 SEMESTRE
            decimal analise = Decimal.Parse(record.GetDecimal(0).ToString());
            if(analise > 0 )
            {
                creditosEfetuados += 6;
                analiseEfetuado = true;
            }

            decimal algebra = Decimal.Parse(record.GetDecimal(1).ToString());
            if (algebra > 0)
            {
                creditosEfetuados += 5;
                algebraEfetuado = true;
            }

            decimal fisica = Decimal.Parse(record.GetDecimal(3).ToString());
            if (fisica > 0)
            {
                creditosEfetuados += 6;
                fisicaAplEfetuado = true;
            }

            decimal sistComp = Decimal.Parse(record.GetDecimal(2).ToString());
            if (sistComp > 0)
            {
                creditosEfetuados += 6;
                sistCompEfetuado = true;
            }

            decimal progI = Decimal.Parse(record.GetDecimal(4).ToString());
            if (progI > 0)
            {
                creditosEfetuados += 7;
                progIEfetuado = true;
            }

            //1 ANO 2 SEMESTRE
            decimal matD = Decimal.Parse(record.GetDecimal(5).ToString());
            if (matD > 0)
            {
                creditosEfetuados += 6;
                matDiscretaEfetuado = true;
            }

            decimal estatistica = Decimal.Parse(record.GetDecimal(10).ToString());
            if (estatistica > 0)
            {
                creditosEfetuados += 3;
                estatisticaEfetuado = true;
            }

            decimal sistOpera = Decimal.Parse(record.GetDecimal(8).ToString());
            if (sistOpera > 0)
            {
                creditosEfetuados += 6;
                sistOperativosEfetuado = true;
            }

            decimal tecInternet = Decimal.Parse(record.GetDecimal(9).ToString());
            if (tecInternet > 0)
            {
                creditosEfetuados += 6;
                tecInternetEfetuado = true;
            }

            decimal progII = Decimal.Parse(record.GetDecimal(6).ToString());
            if (progII > 0)
            {
                creditosEfetuados += 7;
                progIIEfetuado = true;
            }

            decimal ingles = Decimal.Parse(record.GetDecimal(7).ToString());
            if (ingles > 0)
            {
                creditosEfetuados += 2;
                inglesEfetuado = true;
            }

            //2 ANO 1 SEMESTRE
            decimal sgi = Decimal.Parse(record.GetDecimal(11).ToString());
            if (sgi > 0)
            {
                creditosEfetuados += 5;
                sgintEfetuado = true;
            }

            decimal aed = Decimal.Parse(record.GetDecimal(12).ToString());
            if (aed > 0)
            {
                creditosEfetuados += 6;
                aedEfetuado = true;
            }

            decimal bd = Decimal.Parse(record.GetDecimal(13).ToString());
            if (bd > 0)
            {
                creditosEfetuados += 6;
                basesDadosEfetuado = true;
            }

            decimal rc = Decimal.Parse(record.GetDecimal(14).ToString());
            if (rc > 0)
            {
                creditosEfetuados += 6;
                redesCompEfetuado = true;
            }

            decimal progAvan = Decimal.Parse(record.GetDecimal(15).ToString());
            if (progAvan > 0)
            {
                creditosEfetuados += 7;
                porgAvancEfetuado = true;
            }


            //2 ANO 2 SEMESTRE
            decimal ainet = Decimal.Parse(record.GetDecimal(16).ToString());
            if (ainet > 0)
            {
                creditosEfetuados += 6;
                apInternetEfetuado = true;
            }

            decimal esoft = Decimal.Parse(record.GetDecimal(17).ToString());
            if (esoft > 0)
            {
                creditosEfetuados += 6;
                engSoftwEfetuado = true;
            }

            //3 ANO 1 SEMESTRE
            decimal dad = Decimal.Parse(record.GetDecimal(24).ToString());
            if (dad > 0)
            {
                creditosEfetuados += 6;
                dadEfetuado = true;
            }

            decimal intSist = Decimal.Parse(record.GetDecimal(25).ToString());
            if (intSist > 0)
            {
                creditosEfetuados += 6;
                intSistemasEfetuado = true;
            }


            //3 ANO 2 SEMESTRE
            decimal projInf = Decimal.Parse(record.GetDecimal(32).ToString());
            if (projInf > 0)
            {
                creditosEfetuados += 14;
                projInforEfetuado = true;
            }

            decimal inov = Decimal.Parse(record.GetDecimal(34).ToString());
            if (inov > 0)
            {
                creditosEfetuados += 2;
                inovEfetuado = true;
            }

            decimal seminario = Decimal.Parse(record.GetDecimal(33).ToString());
            if (seminario > 0)
            {
                creditosEfetuados += 3;
                seminarioEfetuado = true;
            }


            if (ramoUtilizador == "Tecnlogias Informação")
            {
                //2 ANO 2 SEMESTRE
                tecVirt = Decimal.Parse(record.GetDecimal(21).ToString());
                if (tecVirt > 0)
                {
                    creditosEfetuados += 6;
                    tecVirtualEfetuado = true;
                }

                redesDados = Decimal.Parse(record.GetDecimal(22).ToString());
                if (redesDados > 0)
                {
                    creditosEfetuados += 6;
                    redesDadosEfetuado = true;
                }
 
                adminSist = Decimal.Parse(record.GetDecimal(23).ToString());
                if (adminSist > 0)
                {
                    adminSistemasEfetuado = true;
                    creditosEfetuados += 6;
                }


                //3 ANO 1 SEMESTRE
                centroDados = Decimal.Parse(record.GetDecimal(26).ToString());
                if (centroDados > 0)
                {
                    centDadosEfetuado = true;
                    creditosEfetuados += 6;
                }

                topicosRedes = Decimal.Parse(record.GetDecimal(27).ToString());
                if (topicosRedes > 0)
                {
                    topRedesEfetuado = true;
                    creditosEfetuados += 6;
                }

                segurancaSist = Decimal.Parse(record.GetDecimal(28).ToString());
                if (segurancaSist > 0)
                {
                    segSistemasEfetuado = true;
                    creditosEfetuados += 6;
                }


                //3 ANO 2 SEMESTRE
                labTecInfo = Decimal.Parse(record.GetDecimal(37).ToString());
                if (labTecInfo > 0)
                {
                    labTecInfEfetuado = true;
                    creditosEfetuados += 6;
                }

                engSistServ = Decimal.Parse(record.GetDecimal(38).ToString());
                if (engSistServ > 0)
                {
                    engSistServEfetuado = true;
                    creditosEfetuados += 5;
                }


            }
            else
            {
                //2 ANO 2 SEMESTRE
                intArtifical = Decimal.Parse(record.GetDecimal(18).ToString());
                if (intArtifical > 0)
                {
                    intArtificialEfetuado = true;
                    creditosEfetuados += 6;

                }
                sistemasBD = Decimal.Parse(record.GetDecimal(19).ToString());
                if (sistemasBD > 0)
                {
                    sistBDadosEfetuado = true;
                    creditosEfetuados += 6;
                }

                segurancaInfo = Decimal.Parse(record.GetDecimal(20).ToString());
                if (segurancaInfo > 0)
                {
                    segInformacaoEfetuado = true;
                    creditosEfetuados += 6;
                }


                //3 ANO 1 SEMESTRE
                topicosSoftware = Decimal.Parse(record.GetDecimal(29).ToString());
                if (topicosSoftware > 0)
                {
                    topSoftwareEfetuado = true;
                    creditosEfetuados += 6;
                }

                dae = Decimal.Parse(record.GetDecimal(30).ToString());
                if (dae > 0)
                {
                    daeEfetuado = true;
                    creditosEfetuados += 6;
                }

                sad = Decimal.Parse(record.GetDecimal(31).ToString());
                if (sad > 0)
                {
                    sistApDecisaoEfetuado = true;
                    creditosEfetuados += 6;
                }


                //3 ANO 2 SEMESTRE
                engCohecimento = Decimal.Parse(record.GetDecimal(35).ToString());
                if (engCohecimento > 0)
                {
                    engConhecEfetuado = true;
                    creditosEfetuados += 6;
                }

                sie = Decimal.Parse(record.GetDecimal(36).ToString());
                if (sie > 0)
                {
                    sistInfEmpEfetuado = true;
                    creditosEfetuados += 5;
                }
            }

            //Media 1 Ano 1 Semestre
            if (analiseEfetuado)
            {
                Console.WriteLine(analise);
                mediaPonderada += (analise * (6 / creditosEfetuados));
                Console.WriteLine(mediaPonderada);
            }

            if (porgAvancEfetuado)
            {
                mediaPonderada += progAvan * (7 / creditosEfetuados);
            }

            if (dadEfetuado)
            {
                mediaPonderada += dad * (6 / creditosEfetuados);
            }

            if (algebraEfetuado)
            {
                mediaPonderada += algebra * (5 / creditosEfetuados);
            }

            if(fisicaAplEfetuado)
            {
                mediaPonderada += fisica * (6 / creditosEfetuados);
            }

            if (sistCompEfetuado)
            {
                mediaPonderada += sistComp * (6 / creditosEfetuados);
            }

            if (progIEfetuado)
            {
                mediaPonderada += progI * (7 / creditosEfetuados);
            }

            //Media 1 Ano 2 Semestre
            if (matDiscretaEfetuado)
            {
                mediaPonderada += matD * (6 / creditosEfetuados);
            }

            if (estatisticaEfetuado)
            {
                mediaPonderada += estatistica * (3 / creditosEfetuados);
            }

            if (progIIEfetuado)
            {
                mediaPonderada += progII * (7 / creditosEfetuados);
            }

            if (tecInternetEfetuado)
            {
                mediaPonderada += tecInternet * (6 / creditosEfetuados);
            }

            if (inglesEfetuado)
            {
                mediaPonderada += ingles * (2 / creditosEfetuados);
            }

            if (sistOperativosEfetuado)
            {
                mediaPonderada += sistOpera * (6 / creditosEfetuados);
            }

            if (sgintEfetuado)
            {
                mediaPonderada += sgi * (5 / creditosEfetuados);
            }

            if (aedEfetuado)
            {
                mediaPonderada += aed * (6 / creditosEfetuados);
            }

            if (basesDadosEfetuado)
            {
                mediaPonderada += bd * (6 / creditosEfetuados);
            }

            if (redesCompEfetuado)
            {
                mediaPonderada += rc * (6 / creditosEfetuados);
            }

            if (progIIEfetuado)
            {
                mediaPonderada += progII * (7 / creditosEfetuados);
            }

            if (apInternetEfetuado)
            {
                mediaPonderada += ainet * (6 / creditosEfetuados);
            }

            if (engSoftwEfetuado)
            {
                mediaPonderada += esoft * (6 / creditosEfetuados);
            }

            if (tecVirtualEfetuado)
            {
                mediaPonderada += tecVirt * (6 / creditosEfetuados);
            }

            if (redesDadosEfetuado)
            {
                mediaPonderada += redesDados * (6 / creditosEfetuados);
            }

            if (adminSistemasEfetuado)
            {
                mediaPonderada += adminSist * (6 / creditosEfetuados);
            }

            if (daeEfetuado)
            {
                mediaPonderada += dae * (6 / creditosEfetuados);
            }

            if (intSistemasEfetuado)
            {
                mediaPonderada += intSist * (6 / creditosEfetuados);
            }

            if (centDadosEfetuado )
            {
                mediaPonderada += centroDados * (6 / creditosEfetuados);
            }

            if (topRedesEfetuado)
            {
                mediaPonderada += topicosRedes * (6 / creditosEfetuados);
            }

            if (segSistemasEfetuado)
            {
                mediaPonderada += segurancaSist * (6 / creditosEfetuados);
            }

            if (projInforEfetuado)
            {
                mediaPonderada += projInf * (14 / creditosEfetuados);
            }

            if (seminarioEfetuado)
            {
                mediaPonderada += seminario * (3 / creditosEfetuados);
            }

            if (inovEfetuado)
            {
                mediaPonderada += inov * (2 / creditosEfetuados);
            }

            if (labTecInfEfetuado)
            {
                mediaPonderada += labTecInfo * (6 / creditosEfetuados);
            }

            if (engSistServEfetuado)
            {
                mediaPonderada += engSistServ * (5 / creditosEfetuados);
            }

            if(intArtificialEfetuado)
            {
                mediaPonderada += intArtifical * (6 / creditosEfetuados);
            }

            if (sistBDadosEfetuado)
            {
                mediaPonderada += sistemasBD * (6 / creditosEfetuados);
            }

            if (segInformacaoEfetuado)
            {
                mediaPonderada += segurancaInfo * (6 / creditosEfetuados);
            }

            if (topSoftwareEfetuado)
            {
                mediaPonderada += topicosSoftware * (6 / creditosEfetuados);
            }

            if (daeEfetuado)
            {
                mediaPonderada += dae * (6 / creditosEfetuados);
            }

            if (sistApDecisaoEfetuado)
            {
                mediaPonderada += sad * (6 / creditosEfetuados);
            }

            if (engConhecEfetuado)
            {
                mediaPonderada += engCohecimento * (6 / creditosEfetuados);
            }

            if (sistInfEmpEfetuado)
            {
                mediaPonderada += sie * (6 / creditosEfetuados);
            }

            textBoxCreditosEfetuados.Text = creditosEfetuados.ToString();
            System.Math.Round(mediaPonderada, 2);
            textBoxMediaUtilizador.Text = mediaPonderada.ToString("#.##"); 
            progressBarCurso.Value = Int32.Parse(creditosEfetuados.ToString());

            SqlConnection sqlConnTwo = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand command = sqlConnTwo.CreateCommand();
            command.CommandText = "UPDATE Aluno SET Media = @Media, CreditosEfetuados = @CreditosEfetuados WHERE [Numero] = '" + textBoxNumeroUtilizadorAtivo.Text + "'";
            command.Parameters.AddWithValue("@Media", mediaPonderada);
            command.Parameters.AddWithValue("@CreditosEfetuados", Int32.Parse(creditosEfetuados.ToString()));
            sqlConnTwo.Open();
            command.ExecuteNonQuery();
            sqlConnTwo.Close();

            MessageBox.Show("A sua média foi atualizada.", "Media Atualizada",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limparMediaECreditos()
        {
            textBoxMediaUtilizador.Text = "";
            textBoxCreditosEfetuados.Text = "";
        }

        private void carregarMediaECreditosUtilizador(int numeroAluno)
        {
            int count = 0;
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CalcularMedia\CalcularMedia\BaseDadosUtilizadores.mdf;Integrated Security=True");
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Media], [CreditosEfetuados] FROM [Aluno] WHERE [Numero] = '" + numeroAluno + "'", sqlConn);
            SqlDataReader myreader = cmd.ExecuteReader();

            foreach (IDataRecord record in GetFromReader(myreader))
            {
                //Console.WriteLine(record.GetDecimal(1).ToString());
                textBoxMediaUtilizador.Text = record.GetDecimal(0).ToString();
                textBoxCreditosEfetuados.Text = record.GetInt32(1).ToString();
                progressBarCurso.Value = Int32.Parse(textBoxCreditosEfetuados.Text);
                count++;
            }

            if (count == 0)
            {
                setTextBoxZero();
            }
          
            sqlConn.Close();
        }
    }
}
