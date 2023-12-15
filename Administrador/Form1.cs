using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using System.Threading;

namespace Administrador
{
    public partial class Form1 : Form
    {
        Thread t1;
        MySqlConnection conexao;

        public Form1()
        {
            InitializeComponent();
            try
            {
                string strconexao = "datasource=localhost;username=root;pwd=123;database=helpdesk";
                conexao = new MySqlConnection(strconexao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void VerificadorLogin(string usuario, string senha)
        {
            try
            {
                // Fazendo uma consulta na minha tabela passando item por item.
                // Usuario e senha devem corresponder aos parâmetros
                string query = "SELECT * FROM administrador WHERE usuario = @Usuario AND senha = @Senha;";

                // cmd cria um objeto pro comando SQL ser executado
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                // Referencia dos valores dos parametros
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Senha", senha);

                //Abrindo a conexao com o banco
                conexao.Open();

                var resultado = cmd.ExecuteScalar();

                if(resultado != null)
                {
                    // Exibir a proxima interface e fechar essa
                    this.Close();
                    t1 = new Thread(abrirJanela);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                    
                }
                else
                {
                    MessageBox.Show("Login incorreto", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new TelaDeChamado());
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            VerificadorLogin(usuario, senha);
          
        }
    }
}
