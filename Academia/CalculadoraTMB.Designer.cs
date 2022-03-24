
namespace Academia
{
    partial class frmCalculadorTMB
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.grpNDC = new System.Windows.Forms.GroupBox();
            this.txtAFI = new System.Windows.Forms.TextBox();
            this.txtAFM = new System.Windows.Forms.TextBox();
            this.txtNAF = new System.Windows.Forms.TextBox();
            this.lblAFI = new System.Windows.Forms.Label();
            this.lblAFM = new System.Windows.Forms.Label();
            this.lblNAF = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.grpGenero.SuspendLayout();
            this.grpDadosBasicos.SuspendLayout();
            this.grpNDC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbFeminino);
            this.grpGenero.Controls.Add(this.rdbMasculino);
            this.grpGenero.Location = new System.Drawing.Point(196, 19);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(88, 42);
            this.grpGenero.TabIndex = 0;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Gênero";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(47, 19);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(31, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "F";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(7, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(34, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "M";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(44, 28);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(44, 55);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 2;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(44, 82);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(6, 31);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(6, 58);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(6, 85);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Idade:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(218, 165);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(88, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.txtIMC);
            this.grpDadosBasicos.Controls.Add(this.lblIMC);
            this.grpDadosBasicos.Controls.Add(this.txtPeso);
            this.grpDadosBasicos.Controls.Add(this.txtAltura);
            this.grpDadosBasicos.Controls.Add(this.txtIdade);
            this.grpDadosBasicos.Controls.Add(this.grpGenero);
            this.grpDadosBasicos.Controls.Add(this.lblIdade);
            this.grpDadosBasicos.Controls.Add(this.lblPeso);
            this.grpDadosBasicos.Controls.Add(this.lblAltura);
            this.grpDadosBasicos.Location = new System.Drawing.Point(56, 26);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(290, 116);
            this.grpDadosBasicos.TabIndex = 9;
            this.grpDadosBasicos.TabStop = false;
            this.grpDadosBasicos.Text = "Dados Básicos";
            // 
            // grpNDC
            // 
            this.grpNDC.Controls.Add(this.txtAFI);
            this.grpNDC.Controls.Add(this.txtAFM);
            this.grpNDC.Controls.Add(this.txtNAF);
            this.grpNDC.Controls.Add(this.lblAFI);
            this.grpNDC.Controls.Add(this.lblAFM);
            this.grpNDC.Controls.Add(this.lblNAF);
            this.grpNDC.Location = new System.Drawing.Point(379, 26);
            this.grpNDC.Name = "grpNDC";
            this.grpNDC.Size = new System.Drawing.Size(286, 116);
            this.grpNDC.TabIndex = 10;
            this.grpNDC.TabStop = false;
            this.grpNDC.Text = "Necessidades Diárias de Caloria";
            // 
            // txtAFI
            // 
            this.txtAFI.Location = new System.Drawing.Point(163, 82);
            this.txtAFI.Name = "txtAFI";
            this.txtAFI.Size = new System.Drawing.Size(100, 20);
            this.txtAFI.TabIndex = 5;
            // 
            // txtAFM
            // 
            this.txtAFM.Location = new System.Drawing.Point(163, 55);
            this.txtAFM.Name = "txtAFM";
            this.txtAFM.Size = new System.Drawing.Size(100, 20);
            this.txtAFM.TabIndex = 4;
            // 
            // txtNAF
            // 
            this.txtNAF.Location = new System.Drawing.Point(163, 28);
            this.txtNAF.Name = "txtNAF";
            this.txtNAF.Size = new System.Drawing.Size(100, 20);
            this.txtNAF.TabIndex = 3;
            // 
            // lblAFI
            // 
            this.lblAFI.AutoSize = true;
            this.lblAFI.Location = new System.Drawing.Point(7, 85);
            this.lblAFI.Name = "lblAFI";
            this.lblAFI.Size = new System.Drawing.Size(124, 13);
            this.lblAFI.TabIndex = 2;
            this.lblAFI.Text = "Atividade Física Intensa:";
            // 
            // lblAFM
            // 
            this.lblAFM.AutoSize = true;
            this.lblAFM.Location = new System.Drawing.Point(7, 58);
            this.lblAFM.Name = "lblAFM";
            this.lblAFM.Size = new System.Drawing.Size(137, 13);
            this.lblAFM.TabIndex = 1;
            this.lblAFM.Text = "Atividade Física Moderada:";
            // 
            // lblNAF
            // 
            this.lblNAF.AutoSize = true;
            this.lblNAF.Location = new System.Drawing.Point(6, 31);
            this.lblNAF.Name = "lblNAF";
            this.lblNAF.Size = new System.Drawing.Size(135, 13);
            this.lblNAF.TabIndex = 0;
            this.lblNAF.Text = "Nenhuma Atividade Física:";
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(161, 82);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(29, 13);
            this.lblIMC.TabIndex = 11;
            this.lblIMC.Text = "IMC:";
            // 
            // txtIMC
            // 
            this.txtIMC.Enabled = false;
            this.txtIMC.Location = new System.Drawing.Point(196, 78);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(90, 20);
            this.txtIMC.TabIndex = 12;
            // 
            // frmCalculadorTMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 392);
            this.Controls.Add(this.grpNDC);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmCalculadorTMB";
            this.Text = "Calculadora TMB";
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpDadosBasicos.ResumeLayout(false);
            this.grpDadosBasicos.PerformLayout();
            this.grpNDC.ResumeLayout(false);
            this.grpNDC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.GroupBox grpNDC;
        private System.Windows.Forms.TextBox txtAFI;
        private System.Windows.Forms.TextBox txtAFM;
        private System.Windows.Forms.TextBox txtNAF;
        private System.Windows.Forms.Label lblAFI;
        private System.Windows.Forms.Label lblAFM;
        private System.Windows.Forms.Label lblNAF;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtIMC;
    }
}

