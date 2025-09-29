namespace Gerenciador_de_Tarefas_Com_MySQL
{
    public partial class Principal : Form
    {



        public Principal()
        {
            InitializeComponent();
        }

        //Cria um renderiza��o customizada para o menustrip
        public class MeuRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                // Verifica se o mouse est� sobre o item
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
                    // Cor de fundo padr�o (quando o mouse n�o est� em cima)
                    using (SolidBrush brush = new SolidBrush(Color.MidnightBlue))
                    {
                        e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                    }
                }
            }
        }


        public void CarregarnoPainel(string nomeFormulario)
        {
            // M�todo para carregar o formul�rio especificado no painel2
            // O nome do formul�rio deve ser passado como uma string, por exemplo: "FormBoasVindas", "FormCriar", etc.
            Form formulario = nomeFormulario switch
            {
                "FormBoasVindas" => new FormBoasVindas(),
                "FormCriar" => new FormCriar(),
                "FormEditar" => new FormEditar(),
                "FormTarefas" => new FormTarefas(),
                // Adicione outros formul�rios aqui
                _ => throw new ArgumentException("Formul�rio n�o reconhecido.")
            };

            formulario.TopLevel = false;                       // Define que o objeto do Form atualizar n�o � um formul�rio de n�vel superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            formulario.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(formulario);                   // Adiciona o objeto do Form atualizar ao painel 3
            formulario.Show();                                 // Exibe o conte�do do objeto do Form atualizar
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormBoasVindas"); // Chama o m�todo inicial para carregar o formul�rio de boas-vindas
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // chama a redenriza��o customizada.
            menuStrip1.Renderer = new MeuRenderer();

            CarregarnoPainel("FormBoasVindas"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormCriar"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormTarefas"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormEditar"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }



        private void principalToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            // agora n�o precisa mais desse o render j� faz isso
            //principalToolStripMenuItem.BackColor = Color.Goldenrod;
        }

        private void principalToolStripMenuItem_MouseLeave_1(object sender, EventArgs e)
        {
            // agora n�o precisa mais desse o render j� faz isso
            //principalToolStripMenuItem.BackColor = Color.MidnightBlue; // a cor original
        }
        private void principalToolStripMenuItem_BackColorChanged(object sender, EventArgs e)
        {
            //nada
        }


        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormBoasVindas"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormTarefas"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormEditar"); // Chama o m�todo inicial ao carregar o formul�rio principal

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gerenciador de Tarefas v1.0\nDesenvolvido por Cristiano Teixeira\n2024\nLicen�a: Apache License 2.0", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
