using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Administrador
{
    public partial class TelaDeChamado : Form
    {
        MySqlConnection conexao;
        public TelaDeChamado()
        {
            InitializeComponent();
            try
            {
                string strconexao = "datasource=localhost;user=root;pwd=123;database=helpdesk";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
                MessageBox.Show("Conexao feita");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao?.Close();
            }

        }
        private void TelaDeChamado_Load(object sender, EventArgs e)
        {

        }

        private void CarregarDadosChamado()
        {
            try
            {
                //Abrindo conexao com o BD
                conexao.Open();

                //String de busca no Banco de dados
                string query = "SELECT id_cliente, nome, email, assunto, descricao FROM chamado"; //WHERE id = @Id AND email = @Email" +                                                                                 // "AND nome = @Nome AND assunto = @Assunto AND descricao = @Descricao";

                //Execução de comando MySql
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                //Recupera os dados da busca no BD
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                //Cria uma tabela de dados para armazenas os valores da consulta
                DataTable dt = new DataTable();

                //Preence a tabela de dados com os itens da consulta
                adapter.Fill(dt);

                //Limpa o ListView para evitar dados duplicados
                lvwChamado.Items.Clear();

                //Preenchendo o ListView com os dados da tabela
                foreach (DataRow dr in dt.Rows)
                {
                    //Coluna ID
                    ListViewItem item = new ListViewItem(dr["id_cliente"].ToString());

                    //Vai colocar esses subItens(linha reta)
                    item.SubItems.Add(dr["nome"].ToString());
                    item.SubItems.Add(dr["email"].ToString());
                    item.SubItems.Add(dr["assunto"].ToString());
                    item.SubItems.Add(dr["descricao"].ToString());

                    //Preenche a coluna ID com o "id_cliente"
                    lvwChamado.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("houve um erro" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void lvwChamado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregaDados_Click(object sender, EventArgs e)
        {
            CarregarDadosChamado();
        }
    }
}
