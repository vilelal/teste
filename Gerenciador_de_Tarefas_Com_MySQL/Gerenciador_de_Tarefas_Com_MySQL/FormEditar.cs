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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gerenciador_de_Tarefas_Com_MySQL
{
    public partial class FormEditar : Form
    {
        private readonly Conexao conexao; // Instância da classe Conexao
        int idtemp = 1;
        public FormEditar()
        {
            InitializeComponent();
            conexao = new Conexao(); // Inicializa a conexão com o banco de dados
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            if (Conexao.DadosGlobais.vId > 0)
            {
                // Preenche os campos com os dados da tarefa selecionada
                tbNome.Text = Conexao.DadosGlobais.vNome;
                tbDesc.Text = Conexao.DadosGlobais.vDesc;
                dateTimePickerData.Value = Conexao.DadosGlobais.vData;
                cbStatus.SelectedItem = Conexao.DadosGlobais.vStatus;
            }
            else
            {
                idtemp = 1;
                try
                {
                    conexao.ExecutarUmaConsulta(idtemp);
                    tbNome.Text = Conexao.DadosGlobais.vNome;
                    tbDesc.Text = Conexao.DadosGlobais.vDesc;
                    dateTimePickerData.Value = Conexao.DadosGlobais.vData;
                    cbStatus.SelectedItem = Conexao.DadosGlobais.vStatus;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter o ID da tarefa: {ex.Message}");
                }


                //MessageBox.Show("Nenhuma tarefa selecionada para edição.");
            }
        }

        // quando esse formulário for fechado encerra a conexão com o banco de dados
        private void FormTarefas_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.FecharConexao(conexao.Conectar()); // Fecha a conexão com o banco de dados
        }

        private void btAnter_Click(object sender, EventArgs e)
        {
            idtemp = Conexao.DadosGlobais.vId - 1; // Pega o ID da tarefa selecionada
            if (Conexao.DadosGlobais.vId > 1)
            {

                try
                {
                    conexao.ExecutarUmaConsulta(idtemp);
                    tbNome.Text = Conexao.DadosGlobais.vNome;
                    tbDesc.Text = Conexao.DadosGlobais.vDesc;
                    dateTimePickerData.Value = Conexao.DadosGlobais.vData;
                    cbStatus.SelectedItem = Conexao.DadosGlobais.vStatus;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter o ID da tarefa: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Você já está na primeira tarefa.");
            }
        }

        private void btProx_Click(object sender, EventArgs e)
        {
            int maximo = conexao.contarTarefas(); // Obtém o número total de tarefas
            idtemp = Conexao.DadosGlobais.vId + 1; // Pega o ID da tarefa selecionada

            if (idtemp > maximo)
            {
                MessageBox.Show("Você já está na última tarefa.");
                return;
            }
            else
            {
                try
                {
                    conexao.ExecutarUmaConsulta(idtemp);
                    tbNome.Text = Conexao.DadosGlobais.vNome;
                    tbDesc.Text = Conexao.DadosGlobais.vDesc;
                    dateTimePickerData.Value = Conexao.DadosGlobais.vData;
                    cbStatus.SelectedItem = Conexao.DadosGlobais.vStatus;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter o ID da tarefa: {ex.Message}");
                }
            }
        }

        private void btAtu_Click(object sender, EventArgs e)
        {
            // Pega os dados dos campos e atualiza as variáveis globais

            string tDataHora = dateTimePickerData.Value.ToString("yyyy-MM-dd HH:mm:ss"); // Formata a data para o padrão MySQL
            string tNome = tbNome.Text;
            string tDesc = tbDesc.Text;
            string tStatus = cbStatus.SelectedItem.ToString(); // Pega o status selecionado

            int tId = Conexao.DadosGlobais.vId; // Pega o ID da tarefa selecionada
            //string tualizala = "UPDATE tarefas SET data_hora = '" + tDataHora + "', nome_tar = '" + tNome + "', descricao_tar = '" + tDesc + "', status_tar = '" + tStatus + "' WHERE id = " + tId + ";";
            // substitui a linha acima com concatenação para a abaixo com parâmetros para evitar SQL Injection
            string tualizala = "UPDATE tarefas SET data_hora = @DataHora, nome_tar = @Nome, descricao_tar = @Desc, status_tar = @Status WHERE id = @Id;";
            // preenche os parâmetros para enviar 
            tualizala = tualizala.Replace("@DataHora", $"'{tDataHora}'")
                                 .Replace("@Nome", $"'{tNome}'")
                                 .Replace("@Desc", $"'{tDesc}'")
                                 .Replace("@Status", $"'{tStatus}'")
                                 .Replace("@Id", tId.ToString());
            try
            {
                conexao.ExecutarComando(tualizala); // Executa o comando de atualização no banco de dados
                MessageBox.Show("Tarefa atualizada com sucesso!");
                this.Close(); // Fecha o formulário após a atualização da tarefa
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a tarefa: {ex.Message}");

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
