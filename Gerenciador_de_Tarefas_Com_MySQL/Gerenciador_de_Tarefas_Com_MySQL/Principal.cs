namespace Gerenciador_de_Tarefas_Com_MySQL
{
    public partial class Principal : Form
    {



        public Principal()
        {
            InitializeComponent();
        }

        //Cria um renderização customizada para o menustrip
        public class MeuRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                // Verifica se o mouse está sobre o item
                if (e.Item.Selected)
                {
                    // Aplica a cor personalizada
                    using (SolidBrush brush = new SolidBrush(Color.Goldenrod))
                    {
                        e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                    }
                }
                else
                {
                    // Cor de fundo padrão (quando o mouse não está em cima)
                    using (SolidBrush brush = new SolidBrush(Color.MidnightBlue))
                    {
                        e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                    }
                }
            }
        }


        public void CarregarnoPainel(string nomeFormulario)
        {
            // Método para carregar o formulário especificado no painel2
            // O nome do formulário deve ser passado como uma string, por exemplo: "FormBoasVindas", "FormCriar", etc.
            Form formulario = nomeFormulario switch
            {
                "FormBoasVindas" => new FormBoasVindas(),
                "FormCriar" => new FormCriar(),
                "FormEditar" => new FormEditar(),
                "FormTarefas" => new FormTarefas(),
                // Adicione outros formulários aqui
                _ => throw new ArgumentException("Formulário não reconhecido.")
            };

            formulario.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            formulario.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(formulario);                   // Adiciona o objeto do Form atualizar ao painel 3
            formulario.Show();                                 // Exibe o conteúdo do objeto do Form atualizar
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormBoasVindas"); // Chama o método inicial para carregar o formulário de boas-vindas
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // chama a redenrização customizada.
            menuStrip1.Renderer = new MeuRenderer();

            CarregarnoPainel("FormBoasVindas"); // Chama o método inicial ao carregar o formulário principal
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormCriar"); // Chama o método inicial ao carregar o formulário principal
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormTarefas"); // Chama o método inicial ao carregar o formulário principal
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormEditar"); // Chama o método inicial ao carregar o formulário principal
        }



        private void principalToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            // agora não precisa mais desse o render já faz isso
            //principalToolStripMenuItem.BackColor = Color.Goldenrod;
        }

        private void principalToolStripMenuItem_MouseLeave_1(object sender, EventArgs e)
        {
            // agora não precisa mais desse o render já faz isso
            //principalToolStripMenuItem.BackColor = Color.MidnightBlue; // a cor original
        }
        private void principalToolStripMenuItem_BackColorChanged(object sender, EventArgs e)
        {
            //nada
        }


        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormBoasVindas"); // Chama o método inicial ao carregar o formulário principal
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormTarefas"); // Chama o método inicial ao carregar o formulário principal
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormEditar"); // Chama o método inicial ao carregar o formulário principal

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gerenciador de Tarefas v1.0\nDesenvolvido por Cristiano Teixeira\n2024\nLicença: Apache License 2.0", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
