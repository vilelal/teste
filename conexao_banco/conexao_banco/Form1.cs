using System.Drawing.Text;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
namespace conexao_banco
{
    public partial class Form1 : Form
    {
        private string textoparaconexao = "server=127.0.0.1;database=Aluno;user=root;password=root;"; //criando uma variavel do tipo string para as conexoes do banco de dados
        //o server usa os numeros(127.0.0.1) pois sao melhores do que os nomes ,sempre ter preferencia por nome
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            nome.Clear();
            telefone.Clear();
            rua.Clear();
            bairro.Clear();
            cidade.Clear();
            estado.Clear();
            cep.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;

            textBox9.Clear();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string id;
            string nome;
            string telefone;
            string rua;
            string bairro;
            string cidade;
            string estado;
            string cep;//Quando carregar o formulario irá carregar todas essas variaveis
        }

        private void pesquisa_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conechao = new MySqlConnection(textoparaconexao)) //Criando uma nova instancia do mysql conection que vai acessar a private string (server=127.0.0.1;database=Aluno;user=root;password=root;) 
            {
                conechao.Open();//Mandando abrir a nova instancia
                string oiaum = "SELECT * FROM Cliente WHERE ID_Cli = @ID";//criando uma variavel chamada oiaum que tem um select, aonde o id do cliente for igual ao @id
                MySqlCommand comandito = new MySqlCommand(oiaum, conechao);//Vai ter um novo objeto do mysql commnado guardando um novo comando pro oiaum ate o conechao
                comandito.Parameters.AddWithValue("@ID", id.Text);//Aonde que ele encontrou o @id ele vai trocar o conteudo da text box1
                MySqlDataReader reader = comandito.ExecuteReader();//Serve para ler o comando do comandito sendo o novo leitor,sendo um novo separador tambem
                if (reader.Read())//se foi feito a leitura
                {
                    nome.Text = reader["Nom_Cli"].ToString(); // a textbox nome vai ser atualizada com as novas informacoes
                    telefone.Text = reader["Tel_Cli"].ToString(); //extraindo cada um desses campos e colocando nas textboxs
                    rua.Text = reader["Rua_Cli"].ToString();
                    bairro.Text = reader["Bai_Cli"].ToString();
                    cidade.Text = reader["Cid_Cli"].ToString();
                    estado.Text = reader["Est_Cli"].ToString();
                    cep.Text = reader["CEP_Cli"].ToString();
                }
                else //se nao ele vai falar que nao foi encontrado
                {
                    MessageBox.Show("Cliente não encontrado!");
                    //LimparCampos();
                }
                reader.Close(); //fechando a leitura
                conechao.Close(); //fechando a conechao, sempre feche isso 

            }
        }



        private void inserir_Click_1(object sender, EventArgs e)
        {
            //Tentar englobar tudo em uma unica variavel

            var facilidade = nome.Text.Length > 0 && telefone.Text.Length > 0 && rua.Text.Length > 0 && bairro.Text.Length > 0 && cidade.Text.Length > 0 && estado.Text.Length > 0 && cep.Text.Length > 0;

            //terminar o if 
            if (facilidade)
            {

                {
                    using (MySqlConnection conechao = new MySqlConnection(textoparaconexao))
                    {
                        conechao.Open();
                        string botalah = "INSERT INTO Cliente (Nom_Cli, Tel_Cli, Rua_Cli, Bai_Cli, Cid_Cli, Est_Cli, CEP_Cli) " +
                            "VALUES (@nome, @telefone, @rua, @bairro, @cidade, @estado, @cep)";
                        MySqlCommand comandito = new MySqlCommand(botalah, conechao);
                        comandito.Parameters.AddWithValue("@Nome", nome.Text);
                        comandito.Parameters.AddWithValue("@Telefone", telefone.Text);
                        comandito.Parameters.AddWithValue("@Rua", rua.Text);
                        comandito.Parameters.AddWithValue("@Bairro", bairro.Text);
                        comandito.Parameters.AddWithValue("@Cidade", cidade.Text);
                        comandito.Parameters.AddWithValue("@Estado", estado.Text);
                        comandito.Parameters.AddWithValue("@CEP", cep.Text);
                        comandito.ExecuteNonQuery();
                        MessageBox.Show("Cliente inserido com sucesso!");
                        conechao.Close();
                        LimparCampos();
                    }
                }
            }
        }
        private void limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void tudo_Click(object sender, EventArgs e)
        {
            {
                string oiala = "";
                string tudo = "";
                string id_var = id.Text;
                string nome_var = nome.Text;
                string telefone_var = telefone.Text;
                string rua_var = rua.Text;
                string bairro_var = bairro.Text;
                string cidade_var = cidade.Text;
                string estado_var = estado.Text;
                string cep_var = cep.Text;
                textBox9.Multiline = true;
                using (MySqlConnection conechao = new MySqlConnection(textoparaconexao))
                {
                    conechao.Open();
                    MySqlCommand comandito = new MySqlCommand(oiala, conechao);
                    if (checkBox1.Checked)
                    {
                        oiala = "SELECT* FROM Cliente WHERE ID_Cli = @ID";
                        comandito = new MySqlCommand(oiala, conechao);
                        comandito.Parameters.AddWithValue("@ID", id.Text);
                    }
                    else if (checkBox2.Checked)
                    {
                        oiala = "SELECT* FROM Cliente WHERE Nom_Cli = @Nome";
                        comandito = new MySqlCommand(oiala, conechao);
                        comandito.Parameters.AddWithValue("@Nome", nome.Text);
                    }
                    else if (checkBox3.Checked)
                    {
                        oiala = "SELECT* FROM Cliente WHERE Tel_Cli = @Telefone";
                        comandito = new MySqlCommand(oiala, conechao);
                        comandito.Parameters.AddWithValue("@Telefone", telefone.Text);
                    }
                    else if (checkBox4.Checked)
                    {
                        oiala = "SELECT* FROM Cliente WHERE Rua_Cli = @Rua";
                        comandito = new MySqlCommand(oiala, conechao);
                        comandito.Parameters.AddWithValue("@Rua", rua.Text);
                    }
                    else if (checkBox5.Checked)
                    {
                        oiala = "SELECT* FROM Cliente WHERE Bai_Cli = @Bairro";
                        comandito = new MySqlCommand(oiala, conechao);
                        comandito.Parameters.AddWithValue("@Bairro", bairro.Text);
                    }
                    else if (checkBox6.Checked)
                    {
                        oiala = "SELECT* FROM Cliente WHERE Cid_Cli = @Cidade";
                        comandito = new MySqlCommand(oiala, conechao);
                        comandito.Parameters.AddWithValue("@Cidade", cidade.Text);
                    }
                    else if (checkBox7.Checked)
                    {
                        oiala = "SELECT* FROM Cliente WHERE Est_Cli = @Estado";
                        comandito = new MySqlCommand(oiala, conechao);
                        comandito.Parameters.AddWithValue("@Estado", estado.Text);
                    }
                    else if (checkBox8.Checked)
                    {
                        oiala = "SELECT* FROM Cliente WHERE CEP_Cli = @CEP";
                        comandito = new MySqlCommand(oiala, conechao);
                        comandito.Parameters.AddWithValue("@CEP", cep.Text);
                    }
                    else
                    {
                        oiala = "SELECT * FROM Cliente";
                        comandito = new MySqlCommand(oiala, conechao);

                    }

                    using (MySqlDataReader reader = comandito.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_var = reader.GetInt32("ID_Cli").ToString();
                            nome_var = reader.GetString("Nom_Cli");
                            telefone_var = reader.GetString("Tel_Cli");
                            rua_var = reader.GetString("Rua_Cli");
                            bairro_var = reader.GetString("Bai_Cli");
                            cidade_var = reader.GetString("Cid_Cli");
                            estado_var = reader.GetString("Est_Cli");
                            cep_var = reader.GetString("CEP_Cli");


                            tudo = tudo + id_var + "\r\n" + nome_var + "\r\n" + telefone_var + "\r\n" + rua_var + "\r\n" + bairro_var + "\r\n" + cidade_var + "\r\n" + estado_var + "\r\n" + cep_var + "\r\n\r\n";

                        }
                        textBox9.Text = tudo;
                    }
                    conechao.Close();
                }


            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            var id_cliente = id.Text;
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conechao = new MySqlConnection(textoparaconexao))
                {
                    conechao.Open();
                    string excluir = $"DELETE FROM Cliente WHERE ID_Cli= @ID";

                    MySqlCommand comandito = new MySqlCommand(excluir, conechao);
                    comandito.Parameters.AddWithValue("@ID", id.Text);
                    int rowsAffected = comandito.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!");
                    }

                    conechao.Close();
                    LimparCampos();
                }
            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conechao = new MySqlConnection(textoparaconexao))
            {
                conechao.Open();
                string tualizala = "UPDATE Cliente SET Nom_Cli = @Nome, Tel_Cli = @Telefone, Rua_Cli = @Rua, " +
                                     "Bai_Cli = @Bairro, Cid_Cli = @Cidade, Est_Cli = @Estado, CEP_Cli = @CEP " +
                                     "WHERE ID_Cli = @ID";
                MySqlCommand comandito = new MySqlCommand(tualizala, conechao);
                comandito.Parameters.AddWithValue("@Nome", nome.Text);
                comandito.Parameters.AddWithValue("@Telefone", telefone.Text);
                comandito.Parameters.AddWithValue("@Rua", rua.Text);
                comandito.Parameters.AddWithValue("@Bairro", bairro.Text);
                comandito.Parameters.AddWithValue("@Cidade", cidade.Text);
                comandito.Parameters.AddWithValue("@Estado", estado.Text);
                comandito.Parameters.AddWithValue("@CEP", cep.Text);
                comandito.Parameters.AddWithValue("@ID", id.Text);
                comandito.ExecuteNonQuery();
                MessageBox.Show("Cliente atualizado com sucesso!");
                conechao.Close();
                LimparCampos();
            }
        }
    }
}
