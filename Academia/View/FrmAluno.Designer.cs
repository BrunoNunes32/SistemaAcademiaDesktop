namespace Academia.Window
{
    partial class FrmAluno
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.BtnImportarImagem = new System.Windows.Forms.Button();
            this.PcbImagemAluno = new System.Windows.Forms.PictureBox();
            this.grpStatus.SuspendLayout();
            this.grpSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagemAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(122, 222);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(225, 222);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // mskEmail
            // 
            this.mskEmail.Location = new System.Drawing.Point(150, 81);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.Size = new System.Drawing.Size(178, 20);
            this.mskEmail.TabIndex = 26;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(147, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "E-mail:";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdbInativo);
            this.grpStatus.Controls.Add(this.rdbAtivo);
            this.grpStatus.Location = new System.Drawing.Point(44, 160);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(124, 42);
            this.grpStatus.TabIndex = 30;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(61, 19);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbInativo.TabIndex = 1;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(6, 18);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAtivo.TabIndex = 0;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(40, 81);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(104, 20);
            this.mskDataNascimento.TabIndex = 22;
            this.mskDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(44, 134);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(118, 20);
            this.mskTelefone.TabIndex = 23;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(183, 134);
            this.mskCelular.Mask = "(99) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(117, 20);
            this.mskCelular.TabIndex = 25;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(228, 29);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 20;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(181, 118);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 29;
            this.lblCelular.Text = "Celular:";
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbFeminino);
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Location = new System.Drawing.Point(243, 160);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(85, 42);
            this.grpSexo.TabIndex = 28;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(46, 16);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(31, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.Text = "F";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 16);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(34, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "M";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeAluno.Location = new System.Drawing.Point(40, 29);
            this.txtNomeAluno.MaxLength = 60;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(182, 20);
            this.txtNomeAluno.TabIndex = 19;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(41, 118);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 27;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(37, 65);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 21;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(221, 12);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 24;
            this.lblCPF.Text = "CPF:";
            // 
            // BtnImportarImagem
            // 
            this.BtnImportarImagem.Location = new System.Drawing.Point(450, 137);
            this.BtnImportarImagem.Name = "BtnImportarImagem";
            this.BtnImportarImagem.Size = new System.Drawing.Size(100, 23);
            this.BtnImportarImagem.TabIndex = 33;
            this.BtnImportarImagem.Text = "Importar Imagem";
            this.BtnImportarImagem.UseVisualStyleBackColor = true;
            // 
            // PcbImagemAluno
            // 
            this.PcbImagemAluno.BackgroundImage = global::Academia.Properties.Resources.imgFoto3x4;
            this.PcbImagemAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcbImagemAluno.Location = new System.Drawing.Point(450, 16);
            this.PcbImagemAluno.Name = "PcbImagemAluno";
            this.PcbImagemAluno.Size = new System.Drawing.Size(100, 115);
            this.PcbImagemAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbImagemAluno.TabIndex = 32;
            this.PcbImagemAluno.TabStop = false;
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 323);
            this.Controls.Add(this.BtnImportarImagem);
            this.Controls.Add(this.PcbImagemAluno);
            this.Controls.Add(this.mskEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.mskDataNascimento);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "FrmAluno";
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.FrmAluno_Load);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagemAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.PictureBox PcbImagemAluno;
        private System.Windows.Forms.Button BtnImportarImagem;
    }
}