using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace HelpDeskDotNetCore
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            try
            {
                //Conexão com o MySQL

                var strconexao = "datasource=localhost;username=root;pwd=123;database=helpdesk";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
                MessageBox.Show("Conexão com BD realizada");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de:" + ex.Message);
            }
            finally
            {
                conexao?.Close();
            }

        }

        private void VerificarIdParaPreenchimento()
        {
            try
            {
                conexao.Open();
                // Código para auto preenchimento do email de acordo com o ID do usuário

                string query = "SELECT email, nome FROM cliente WHERE id = " + txtId.Text + ";";
                MySqlCommand cmdquery = new MySqlCommand(query, conexao);
                MySqlDataReader leitura = cmdquery.ExecuteReader();
                if (leitura.Read())
                {
                    string email = leitura["email"].ToString();
                    txtEmail.Text = email;
                    string nome = leitura["nome"].ToString();
                    txtNome.Text = nome;

                }
                else
                {
                    MessageBox.Show("ID nao encontrado no BD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            VerificarIdParaPreenchimento();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Inserir dados na cabela 'chamado' ao clicar no botão enviar
                conexao.Open();

                if(txtId.Text == ""||txtAssunto.Text == "" || txtDescricao.Text == "")
                {
                    MessageBox.Show("Complete os campos faltantes","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Lembrar de usar parâmetros para melhor segurança
                    string sql = "INSERT INTO chamado (id_cliente, email, nome, assunto, descricao) " +
                        "VALUES (@IdCliente, @Email, @Nome, @Assunto, @Descricao)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@IdCliente", txtId.Text);
                    comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@Assunto", txtAssunto.Text);
                    comando.Parameters.AddWithValue("@Descricao", txtDescricao.Text);

                    //Para inserir dados numa tabela é recomendavel esse comando
                    //Execução da instrução SQL
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro inserido com sucesso");

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //MessageBox.Show("Conexão finalizada");
                conexao.Close();
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
