namespace Academia.Window
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.btnCalcauladoraTMB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarAluno.Image")));
            this.btnAdicionarAluno.Location = new System.Drawing.Point(157, 61);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(70, 73);
            this.btnAdicionarAluno.TabIndex = 1;
            this.btnAdicionarAluno.UseVisualStyleBackColor = false;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionarAluno_Click);
            // 
            // btnCalcauladoraTMB
            // 
            this.btnCalcauladoraTMB.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcauladoraTMB.Image = global::Academia.Properties.Resources.calculadora;
            this.btnCalcauladoraTMB.Location = new System.Drawing.Point(67, 61);
            this.btnCalcauladoraTMB.Name = "btnCalcauladoraTMB";
            this.btnCalcauladoraTMB.Size = new System.Drawing.Size(71, 73);
            this.btnCalcauladoraTMB.TabIndex = 0;
            this.btnCalcauladoraTMB.UseVisualStyleBackColor = false;
            this.btnCalcauladoraTMB.Click += new System.EventHandler(this.btnCalcauladoraTMB_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.btnCalcauladoraTMB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcauladoraTMB;
        private System.Windows.Forms.Button btnAdicionarAluno;
    }
}