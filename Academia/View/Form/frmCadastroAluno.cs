using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Class.Controller;
using Academia.Class.Model;

namespace Academia.Window
{
    public partial class FrmCadastroAluno : Form
    {
        public FrmCadastroAluno()
        {
            InitializeComponent();
        }

        Thread thread;
        AlunoModel modelAluno = new AlunoModel();
        AlunoController controllerAluno = new AlunoController();
        MedicoesModel modelMedicoes = new MedicoesModel();
        MedicoesController controllerMedicoes = new MedicoesController();

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            modelAluno.Nome = txtNomeAluno.Text;
            modelAluno.Celular = mskCelular.Text;
            modelAluno.CPF = mskCPF.Text;
            modelAluno.Celular = mskCelular.Text;
            modelAluno.Telefone = mskTelefone.Text;
            modelAluno.DtNascimento = mskDataNascimento.Text;

            
            if(rdbFeminino.Checked == true)
            {
                modelAluno.Sexo = "F";
            }
            if (rdbMasculino.Checked == true)
            {
                modelAluno.Sexo = "M";
            }

            if (controllerAluno.Inserir(modelAluno) == true)
            {
                MessageBox.Show(controllerAluno.mensagem);

                modelMedicoes.Altura = txtAltura.Text;
                modelMedicoes.Peso = txtPeso.Text;
                modelMedicoes.Peitoral = txtPeitoral.Text;
                modelMedicoes.Cintura = txtCintura.Text;
                modelMedicoes.Quadril = txtQuadril.Text;
                modelMedicoes.BracoD = txtBracoD.Text;
                modelMedicoes.BracoE = txtBracoE.Text;
                modelMedicoes.AnteBracoD = txtAntebracoD.Text;
                modelMedicoes.AnteBracoE = txtAntebracoE.Text;
                modelMedicoes.CoxaD = txtCoxaD.Text;
                modelMedicoes.CoxaE = txtCoxaE.Text;
                modelMedicoes.PanturrilhaD = txtPanturrilhaD.Text;
                modelMedicoes.PanturrilhaE = txtPanturrilhaE.Text;

                if (controllerMedicoes.Cadastro(modelMedicoes) == true)
                {
                    MessageBox.Show(controllerMedicoes.mensagem);
                }
                else
                {
                    MessageBox.Show(controllerMedicoes.mensagem);
                    controllerAluno.Deletar(modelAluno);
                    MessageBox.Show(controllerAluno.mensagem);
                }

            }


        }
        private void VoltarMenu()
        {
            Application.Run(new FrmMenu());
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(VoltarMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
