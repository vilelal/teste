using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Tarefas_Com_MySQL
{
    public partial class FormTarefas : Form
    {
        private readonly Conexao conexao; // Instância da classe Conexao

        public FormTarefas()
        {
            InitializeComponent();
            conexao = new Conexao();                            // Inicializa a conexão com o banco de dados
            dataGridView1.CellClick += dataGridView1_CellClick; // Associa o evento CellClick do DataGridView ao método dataGridView1_CellClick. Deveria estar no arquivo com FormTarefas.Designer.cs mas preferi deixar aqui para ficar mais evidente
        }
        private void CarregarDados()
        {
            try
            {
                string query = "SELECT * FROM tarefas";         // Evite isso em tabelas muito grandes já disse isso em aula.
                var dados = conexao.ExecutarConsulta(query);    // Chama o método ExecutarConsulta
                dataGridView1.DataSource = dados;               // guarda dentro dataGridView1 a resposta da consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        private void FormTarefas_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // exibe a caixa de mensagem apenas para testar
            // MessageBox.Show("Célula clicada: " + e.RowIndex + ", " + e.ColumnIndex);

            // Verifica se o índice da linha é válido
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; // Retorna se a célula clicada não for válida
            }

            int _linhaIndice = -1; // Variável para armazenar o índice da linha clicada

            //Retorna o indice da linha no qual a célula foi clicada
            _linhaIndice = e.RowIndex;

            //Se _linhaIndice é menor que -1 então retorna
            if (_linhaIndice == -1)
            {
                return;
            }

            //Cria um objeto DataGridViewRow de um indice particular
            DataGridViewRow rowData = dataGridView1.Rows[_linhaIndice];

            //Envia todos os valores da linha clicada para as variáveis globais dentro do COonexao.cs
            Conexao.DadosGlobais.vId = rowData.Cells[0].Value != null ? Convert.ToInt32(rowData.Cells[0].Value) : 0;                    // Verifica se o valor é nulo antes de converter caso contrário manda 0
            // enviar o valor da data para o formato já convertido 
            Conexao.DadosGlobais.vData = rowData.Cells[1].Value != null ? Convert.ToDateTime(rowData.Cells[1].Value) : DateTime.Now;    // Verifica se o valor é nulo antes de converter caso contrário manda a data atual
            Conexao.DadosGlobais.vNome = rowData.Cells[2].Value != null ? rowData.Cells[2].Value.ToString() : string.Empty;             // Verifica se o valor é nulo antes de converter caso contrário manda uma string vazia
            Conexao.DadosGlobais.vDesc = rowData.Cells[3].Value != null ? rowData.Cells[3].Value.ToString() : string.Empty;             // Verifica se o valor é nulo antes de converter case contrário manda uma string vazia
            Conexao.DadosGlobais.vStatus = rowData.Cells[4].Value != null ? rowData.Cells[4].Value.ToString() : string.Empty;           // Verifica se o valor é nulo antes de converter caso contrário manda uma string vazia

            // carrega o formulário de edição com os dados selecionados dentro do panel2 presente no formulário Principal.cs
            Principal principalForm = (Principal)this.ParentForm; // Obtém a instância do formulário principal
            if (principalForm != null)
            {
                principalForm.CarregarnoPainel("FormEditar"); // Chama o método para carregar o formulário de edição
            }
            else
            {
                MessageBox.Show("Erro ao carregar o formulário principal.");
            }
        }

        // quando esse formulário for fechado encerra a conexão com o banco de dados
        private void FormTarefas_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.FecharConexao(conexao.Conectar()); // Fecha a conexão com o banco de dados
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

