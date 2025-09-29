namespace Gerenciador_de_Tarefas_Com_MySQL
{
    partial class FormCriar
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
            cbStatus = new ComboBox();
            tbDesc = new TextBox();
            dateTimePickerData = new DateTimePicker();
            tbNome = new TextBox();
            lStatus = new Label();
            lDesc = new Label();
            lData = new Label();
            lNome = new Label();
            btCriar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.DarkGray;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Pendente", "Atrasada", "Concluída" });
            cbStatus.Location = new Point(293, 102);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(263, 23);
            cbStatus.TabIndex = 20;
            // 
            // tbDesc
            // 
            tbDesc.BackColor = Color.DarkGray;
            tbDesc.Location = new Point(12, 102);
            tbDesc.Multiline = true;
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(275, 93);
            tbDesc.TabIndex = 19;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.CalendarMonthBackground = Color.DarkGray;
            dateTimePickerData.Checked = false;
            dateTimePickerData.Location = new Point(293, 27);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(263, 23);
            dateTimePickerData.TabIndex = 18;
            dateTimePickerData.Value = new DateTime(2025, 6, 25, 11, 0, 32, 0);
            // 
            // tbNome
            // 
            tbNome.BackColor = Color.DarkGray;
            tbNome.Location = new Point(12, 27);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(275, 23);
            tbNome.TabIndex = 17;
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.Location = new Point(293, 84);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(90, 15);
            lStatus.TabIndex = 16;
            lStatus.Text = "Status da Tarefa";
            // 
            // lDesc
            // 
            lDesc.AutoSize = true;
            lDesc.Location = new Point(12, 84);
            lDesc.Name = "lDesc";
            lDesc.Size = new Size(109, 15);
            lDesc.TabIndex = 15;
            lDesc.Text = "Descrição da Tarefa";
            // 
            // lData
            // 
            lData.AutoSize = true;
            lData.Location = new Point(293, 9);
            lData.Name = "lData";
            lData.Size = new Size(82, 15);
            lData.TabIndex = 14;
            lData.Text = "Data da Tarefa";
            // 
            // lNome
            // 
            lNome.AutoSize = true;
            lNome.Location = new Point(12, 9);
            lNome.Name = "lNome";
            lNome.Size = new Size(91, 15);
            lNome.TabIndex = 13;
            lNome.Text = "Nome da Tarefa";
            // 
            // btCriar
            // 
            btCriar.FlatAppearance.BorderColor = Color.White;
            btCriar.FlatAppearance.BorderSize = 0;
            btCriar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btCriar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btCriar.FlatStyle = FlatStyle.Flat;
            btCriar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCriar.ForeColor = Color.White;
            btCriar.Location = new Point(12, 246);
            btCriar.Name = "btCriar";
            btCriar.Size = new Size(182, 63);
            btCriar.TabIndex = 21;
            btCriar.Text = "Criar";
            btCriar.UseVisualStyleBackColor = true;
            btCriar.Click += btCriar_Click;
            // 
            // btCancelar
            // 
            btCancelar.FlatAppearance.BorderColor = Color.White;
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btCancelar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = Color.White;
            btCancelar.Location = new Point(201, 246);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(182, 63);
            btCancelar.TabIndex = 22;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // FormCriar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(566, 390);
            Controls.Add(btCancelar);
            Controls.Add(btCriar);
            Controls.Add(cbStatus);
            Controls.Add(tbDesc);
            Controls.Add(dateTimePickerData);
            Controls.Add(tbNome);
            Controls.Add(lStatus);
            Controls.Add(lDesc);
            Controls.Add(lData);
            Controls.Add(lNome);
            Name = "FormCriar";
            Text = "FormCriar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStatus;
        private TextBox tbDesc;
        private DateTimePicker dateTimePickerData;
        private TextBox tbNome;
        private Label lStatus;
        private Label lDesc;
        private Label lData;
        private Label lNome;
        private Button btCriar;
        private Button btCancelar;
    }
}