namespace Gerenciador_de_Tarefas_Com_MySQL
{
    partial class FormEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lNome = new Label();
            lData = new Label();
            lDesc = new Label();
            lStatus = new Label();
            tbNome = new TextBox();
            dateTimePickerData = new DateTimePicker();
            tbDesc = new TextBox();
            btProx = new Button();
            btAnter = new Button();
            btAtu = new Button();
            btExcluir = new Button();
            cbStatus = new ComboBox();
            SuspendLayout();
            // 
            // lNome
            // 
            lNome.AutoSize = true;
            lNome.Location = new Point(12, 9);
            lNome.Name = "lNome";
            lNome.Size = new Size(91, 15);
            lNome.TabIndex = 0;
            lNome.Text = "Nome da Tarefa";
            // 
            // lData
            // 
            lData.AutoSize = true;
            lData.Location = new Point(293, 9);
            lData.Name = "lData";
            lData.Size = new Size(82, 15);
            lData.TabIndex = 1;
            lData.Text = "Data da Tarefa";
            // 
            // lDesc
            // 
            lDesc.AutoSize = true;
            lDesc.Location = new Point(12, 84);
            lDesc.Name = "lDesc";
            lDesc.Size = new Size(109, 15);
            lDesc.TabIndex = 2;
            lDesc.Text = "Descrição da Tarefa";
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.Location = new Point(293, 84);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(90, 15);
            lStatus.TabIndex = 3;
            lStatus.Text = "Status da Tarefa";
            // 
            // tbNome
            // 
            tbNome.BackColor = Color.DarkGray;
            tbNome.Location = new Point(12, 27);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(275, 23);
            tbNome.TabIndex = 4;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.CalendarMonthBackground = Color.DarkGray;
            dateTimePickerData.Location = new Point(293, 27);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(263, 23);
            dateTimePickerData.TabIndex = 5;
            // 
            // tbDesc
            // 
            tbDesc.BackColor = Color.DarkGray;
            tbDesc.Location = new Point(12, 102);
            tbDesc.Multiline = true;
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(275, 93);
            tbDesc.TabIndex = 6;
            // 
            // btProx
            // 
            btProx.FlatAppearance.BorderColor = Color.White;
            btProx.FlatAppearance.BorderSize = 0;
            btProx.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btProx.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btProx.FlatStyle = FlatStyle.Flat;
            btProx.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProx.ForeColor = Color.White;
            btProx.Location = new Point(204, 214);
            btProx.Name = "btProx";
            btProx.Size = new Size(186, 63);
            btProx.TabIndex = 8;
            btProx.Text = "Próximo ->";
            btProx.UseVisualStyleBackColor = true;
            btProx.Click += btProx_Click;
            // 
            // btAnter
            // 
            btAnter.FlatAppearance.BorderColor = Color.White;
            btAnter.FlatAppearance.BorderSize = 0;
            btAnter.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btAnter.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btAnter.FlatStyle = FlatStyle.Flat;
            btAnter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAnter.ForeColor = Color.White;
            btAnter.Location = new Point(12, 214);
            btAnter.Name = "btAnter";
            btAnter.Size = new Size(186, 63);
            btAnter.TabIndex = 9;
            btAnter.Text = "<- Anterior";
            btAnter.UseVisualStyleBackColor = true;
            btAnter.Click += btAnter_Click;
            // 
            // btAtu
            // 
            btAtu.FlatAppearance.BorderColor = Color.White;
            btAtu.FlatAppearance.BorderSize = 0;
            btAtu.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btAtu.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btAtu.FlatStyle = FlatStyle.Flat;
            btAtu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAtu.ForeColor = Color.White;
            btAtu.Location = new Point(12, 283);
            btAtu.Name = "btAtu";
            btAtu.Size = new Size(186, 63);
            btAtu.TabIndex = 10;
            btAtu.Text = "Atualizar";
            btAtu.UseVisualStyleBackColor = true;
            btAtu.Click += btAtu_Click;
            // 
            // btExcluir
            // 
            btExcluir.FlatAppearance.BorderColor = Color.White;
            btExcluir.FlatAppearance.BorderSize = 0;
            btExcluir.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btExcluir.FlatAppearance.MouseOverBackColor = Color.Red;
            btExcluir.FlatStyle = FlatStyle.Flat;
            btExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.ForeColor = Color.White;
            btExcluir.Location = new Point(197, 283);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(186, 63);
            btExcluir.TabIndex = 11;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.DarkGray;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Pendente", "Atrasada", "Concluída" });
            cbStatus.Location = new Point(293, 102);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(263, 23);
            cbStatus.TabIndex = 12;
            // 
            // FormEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(566, 390);
            Controls.Add(cbStatus);
            Controls.Add(btExcluir);
            Controls.Add(btAtu);
            Controls.Add(btAnter);
            Controls.Add(btProx);
            Controls.Add(tbDesc);
            Controls.Add(dateTimePickerData);
            Controls.Add(tbNome);
            Controls.Add(lStatus);
            Controls.Add(lDesc);
            Controls.Add(lData);
            Controls.Add(lNome);
            Name = "FormEditar";
            Text = "FormEditar";
            Load += FormEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNome;
        private Label lData;
        private Label lDesc;
        private Label lStatus;
        private TextBox tbNome;
        private DateTimePicker dateTimePickerData;
        private TextBox tbDesc;
        private Button btProx;
        private Button btAnter;
        private Button btAtu;
        private Button btExcluir;
        private ComboBox cbStatus;
    }
}