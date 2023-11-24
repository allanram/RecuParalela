using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RecuperacaoParalela.View
{
    public partial class ContatoView : Form
    {
        public ContatoView()
        {
            InitializeComponent();
        }



        private void btnNovoContato_Click(object sender, EventArgs e)
        {
            try
            {
                // String de conexão
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Recuperacao;Persist Security Info=True;User ID=sa;Password=sql2022;Trusted_Connection=False;TrustServerCertificate=True";

                // Conectar ao banco de dados
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string inserirContatoQuery = "INSERT INTO Contatos (Nome, Telefone, Email, Endereco, DataNascimento) " +
                                     "VALUES (@Nome, @Telefone, @Email, @Endereco, @DataNascimento); " +
                                     "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(inserirContatoQuery, conexao))
                    {
                        // Substitua os valores abaixo pelos valores reais do novo contato
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@DataNascimento", dtpnascimento.Text);

                        // Executar a consulta e obter o ID do novo contato
                        int novoContatoID = Convert.ToInt32(cmd.ExecuteScalar());

                        // Agora você pode usar o novoContatoID conforme necessário
                        MessageBox.Show("Novo Contato adicionado com sucesso! ID: " + novoContatoID.ToString());
                    }

                    // Certifique-se de fechar a conexão, independentemente do resultado
                    conexao.Close();
                }

                // Exibir mensagem de sucesso ou realizar outras ações necessárias
                MessageBox.Show("Novo Contato adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar novo contato: " + ex.Message);
            }
        }
    }
}
