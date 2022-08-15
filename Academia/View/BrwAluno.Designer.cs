namespace Academia.View
{
    partial class BrwAluno
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
            this.components = new System.ComponentModel.Container();
            this.dtgAluno = new System.Windows.Forms.DataGridView();
            this.tblAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaAcademiaDataSet = new Academia.SistemaAcademiaDataSet();
            this.tblAlunoTableAdapter = new Academia.SistemaAcademiaDataSetTableAdapters.tblAlunoTableAdapter();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.BtnConsultarmedicoes = new System.Windows.Forms.Button();
            this.BtnAdicionarMedicoes = new System.Windows.Forms.Button();
            this.BtnConsultarAluno = new System.Windows.Forms.Button();
            this.BtnAdicionarAluno = new System.Windows.Forms.Button();
            this.BtnEditarAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAcademiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAluno
            // 
            this.dtgAluno.AllowUserToAddRows = false;
            this.dtgAluno.AllowUserToDeleteRows = false;
            this.dtgAluno.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAluno.Location = new System.Drawing.Point(12, 138);
            this.dtgAluno.Name = "dtgAluno";
            this.dtgAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAluno.Size = new System.Drawing.Size(776, 258);
            this.dtgAluno.TabIndex = 0;
            // 
            // tblAlunoBindingSource
            // 
            this.tblAlunoBindingSource.DataMember = "tblAluno";
            this.tblAlunoBindingSource.DataSource = this.sistemaAcademiaDataSet;
            // 
            // sistemaAcademiaDataSet
            // 
            this.sistemaAcademiaDataSet.DataSetName = "SistemaAcademiaDataSet";
            this.sistemaAcademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAlunoTableAdapter
            // 
            this.tblAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Location = new System.Drawing.Point(646, 47);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisa.TabIndex = 1;
            this.BtnPesquisa.Text = "Pesquisar";
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(89, 56);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 8;
            // 
            // BtnConsultarmedicoes
            // 
            this.BtnConsultarmedicoes.Location = new System.Drawing.Point(632, 402);
            this.BtnConsultarmedicoes.Name = "BtnConsultarmedicoes";
            this.BtnConsultarmedicoes.Size = new System.Drawing.Size(75, 36);
            this.BtnConsultarmedicoes.TabIndex = 9;
            this.BtnConsultarmedicoes.Text = "Consultar Medições";
            this.BtnConsultarmedicoes.UseVisualStyleBackColor = true;
            this.BtnConsultarmedicoes.Click += new System.EventHandler(this.BtnConsultarmedicoes_Click);
            // 
            // BtnAdicionarMedicoes
            // 
            this.BtnAdicionarMedicoes.Location = new System.Drawing.Point(713, 402);
            this.BtnAdicionarMedicoes.Name = "BtnAdicionarMedicoes";
            this.BtnAdicionarMedicoes.Size = new System.Drawing.Size(75, 36);
            this.BtnAdicionarMedicoes.TabIndex = 10;
            this.BtnAdicionarMedicoes.Text = "Adicionar Medições";
            this.BtnAdicionarMedicoes.UseVisualStyleBackColor = true;
            this.BtnAdicionarMedicoes.Click += new System.EventHandler(this.BtnAdicionarMedicoes_Click);
            // 
            // BtnConsultarAluno
            // 
            this.BtnConsultarAluno.Location = new System.Drawing.Point(551, 402);
            this.BtnConsultarAluno.Name = "BtnConsultarAluno";
            this.BtnConsultarAluno.Size = new System.Drawing.Size(75, 36);
            this.BtnConsultarAluno.TabIndex = 11;
            this.BtnConsultarAluno.Text = "Consultar Aluno";
            this.BtnConsultarAluno.UseVisualStyleBackColor = true;
            this.BtnConsultarAluno.Click += new System.EventHandler(this.BtnConsultarAluno_Click);
            // 
            // BtnAdicionarAluno
            // 
            this.BtnAdicionarAluno.Location = new System.Drawing.Point(470, 402);
            this.BtnAdicionarAluno.Name = "BtnAdicionarAluno";
            this.BtnAdicionarAluno.Size = new System.Drawing.Size(75, 36);
            this.BtnAdicionarAluno.TabIndex = 12;
            this.BtnAdicionarAluno.Text = "Adicionar Aluno";
            this.BtnAdicionarAluno.UseVisualStyleBackColor = true;
            this.BtnAdicionarAluno.Click += new System.EventHandler(this.BtnAdicionarAluno_Click);
            // 
            // BtnEditarAluno
            // 
            this.BtnEditarAluno.Location = new System.Drawing.Point(389, 402);
            this.BtnEditarAluno.Name = "BtnEditarAluno";
            this.BtnEditarAluno.Size = new System.Drawing.Size(75, 36);
            this.BtnEditarAluno.TabIndex = 13;
            this.BtnEditarAluno.Text = "Editar Aluno";
            this.BtnEditarAluno.UseVisualStyleBackColor = true;
            this.BtnEditarAluno.Click += new System.EventHandler(this.BtnEditarAluno_Click);
            // 
            // BrwAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEditarAluno);
            this.Controls.Add(this.BtnAdicionarAluno);
            this.Controls.Add(this.BtnConsultarAluno);
            this.Controls.Add(this.BtnAdicionarMedicoes);
            this.Controls.Add(this.BtnConsultarmedicoes);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.dtgAluno);
            this.Name = "BrwAluno";
            this.Text = "Consulta Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaAcademiaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAluno;
        private SistemaAcademiaDataSet sistemaAcademiaDataSet;
        private System.Windows.Forms.BindingSource tblAlunoBindingSource;
        private SistemaAcademiaDataSetTableAdapters.tblAlunoTableAdapter tblAlunoTableAdapter;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Button BtnConsultarmedicoes;
        private System.Windows.Forms.Button BtnAdicionarMedicoes;
        private System.Windows.Forms.Button BtnConsultarAluno;
        private System.Windows.Forms.Button BtnAdicionarAluno;
        private System.Windows.Forms.Button BtnEditarAluno;
    }
}