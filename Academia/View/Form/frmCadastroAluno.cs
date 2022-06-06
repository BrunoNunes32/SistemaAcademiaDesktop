using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Class.Controller;
using Academia.Class.Model;

namespace Academia.Window
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        AlunoModel          modelAluno = new AlunoModel();
        AlunoController     controllerAluno = new AlunoController();
        MedicoesModel       modelMedicoes = new MedicoesModel();
        MedicoesController  controllerMedicoes = new MedicoesController();

        private void btnSalvar_Click(object sender, EventArgs e)
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

            if (controllerAluno.Cadastro(modelAluno) == true)
            {
                MessageBox.Show(controllerAluno.mensagem);

                modelMedicoes.Altura = txtAltura.Text;
                modelMedicoes.Peso = txtPeso.Text;
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

                controllerMedicoes.Cadastro(modelMedicoes);
                MessageBox.Show(controllerMedicoes.mensagem);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
