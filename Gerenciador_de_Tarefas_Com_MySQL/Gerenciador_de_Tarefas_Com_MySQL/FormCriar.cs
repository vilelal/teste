using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Gerenciador_de_Tarefas_Com_MySQL
{
    public partial class FormCriar : Form
    {
        //private readonly Conexao conexao; // Instância da classe Conexao
        private readonly Conexao conexao = new Conexao(); // Instância da classe Conexao
        public FormCriar()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //fecha o formulário atual e volta para o formulario de boas vindas
            this.Close(); // Fecha o formulário atual
            Principal principalForm = (Principal)this.ParentForm; // Obtém a instância do formulário principal
            if (principalForm != null)
            {
                principalForm.CarregarnoPainel("FormBoasVindas"); // Chama o método para carregar o formulário de boas-vindas
            }
            else
            {
                MessageBox.Show("Erro ao carregar o formulário principal.");
            }
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            // puxa os dados dos campos das textBox e guarda nas variaveis globais do Conexao.cs
            Conexao.DadosGlobais.vNome = tbNome.Text;
            Conexao.DadosGlobais.vDesc = tbDesc.Text;
            //
            // pegar valores do DateTimePicker no seguinte formato YYYY/MM/DD HH:MM:SS
            //
            Conexao.DadosGlobais.vData = dateTimePickerData.Value; // Pega a data selecionada no DateTimePicker
            Conexao.DadosGlobais.vStatus = cbStatus.SelectedItem != null ? cbStatus.SelectedItem.ToString() : "Pendente"; // Lambda: Pega o status selecionado ou define como "Pendente" se nada for selecionado

            // Verifica se os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(Conexao.DadosGlobais.vNome) || string.IsNullOrWhiteSpace(Conexao.DadosGlobais.vDesc))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // executa o comando de inserção no banco de dados
            try
            {
                // converte a informação de Conexao.DadosGlobais.vData de AAAA\MM\DD HH:MM:SS para AAAA-MM-DD HH:MM:SS
                string dataFormatada = Conexao.DadosGlobais.vData.ToString("yyyy-MM-dd HH:mm:ss");
                // fiz a string abaixo no formato de concatenação, para mostar o que vocês só devem fazer se odiarem a vida de vocês. No Editar estará no formado de parâmetros.
                string query = "INSERT INTO tarefas (data_hora, nome_tar, descricao_tar, status_tar) VALUES ('"+dataFormatada+"', '" + Conexao.DadosGlobais.vNome+"', '" + Conexao.DadosGlobais.vDesc + "', '" + Conexao.DadosGlobais.vStatus+"');";
                // MessageBox.Show(query); // Teste para checar a string comentar depois
                this.conexao.ExecutarComando(query);
               
                MessageBox.Show("Tarefa criada com sucesso!");


                
                // carrega o Formulário de Boas vindas  dentro do painel do Formulário Principal
                Principal principalForm = (Principal)this.ParentForm; // Obtém a instância do formulário principal
                principalForm.CarregarnoPainel("FormBoasVindas"); // Chama o método para carregar o formulário de boas-vindas
                

                this.Close(); // Fecha o formulário após a criação da tarefa
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar tarefa: {ex.Message}");
            }

        }
    }
}
