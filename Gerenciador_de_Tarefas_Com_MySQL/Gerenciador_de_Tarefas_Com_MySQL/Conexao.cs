using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// Material para consulta
/* https://www.macoratti.net/17/06/c_crudgdv1.htm */

namespace Gerenciador_de_Tarefas_Com_MySQL
{

    
    internal class Conexao
    {
        public class DadosGlobais
        {

            public static int vId { get; set; } = 0;
            public static DateTime vData { get; set; } = DateTime.Now;
            public static string vNome { get; set; } = "";
            public static string vDesc { get; set; } = "";
            public static string vStatus { get; set; } = "";
        }

        private readonly string _connectionString;
        public Conexao()
        {
            // Idealmente, a string de conexão deve ser armazenada em um arquivo de configuração.
            _connectionString = "Server=localhost;Database=Gerenciador_tarefas;Uid=root;Pwd=root;";
        }

        public MySqlConnection Conectar()
        {
            try
            {
                var conexao = new MySqlConnection(_connectionString);
                conexao.Open(); // Abre a conexão para verificar se está funcional
                return conexao;
            }
            catch (MySqlException ex)
            {
                // Log de erro ou tratamento apropriado
                throw new Exception("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        public void FecharConexao(MySqlConnection conexao)
        {
            if (conexao != null && conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public DataTable ExecutarConsulta(string query)
        {
            using (var conexao = Conectar()) // Reutiliza o método Conectar
            {
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        return tabela;
                    }
                }
            }
        }

        public void ExecutarUmaConsulta(int idlocal)
        {
            using (var conexao = Conectar()) // Reutiliza o método Conectar
            {
                string query = $"SELECT * FROM tarefas WHERE id = @ID";
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@ID", idlocal); // Adiciona o parâmetro para evitar SQL Injection
                    MySqlDataReader guardeium = cmd.ExecuteReader();
                    guardeium.Read();
                    DadosGlobais.vId = guardeium.GetInt32(0);      // Pega o ID da tarefa
                    DadosGlobais.vData = guardeium.GetDateTime(1); // Pega a data da tarefa
                    DadosGlobais.vNome = guardeium.GetString(2);   // Pega o nome da tarefa
                    DadosGlobais.vDesc = guardeium.GetString(3);   // Pega a descrição da tarefa
                    DadosGlobais.vStatus = guardeium.GetString(4); // Pega o status da tarefa
                }
            }
        }

        public void ExecutarComando(string query)
        {
            using (var conexao = Conectar()) // Reutiliza o método Conectar
            {
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int contarTarefas()
        {
            using (var conexao = Conectar()) // Reutiliza o método Conectar
            {
                string query = "SELECT COUNT(*) FROM tarefas";
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}