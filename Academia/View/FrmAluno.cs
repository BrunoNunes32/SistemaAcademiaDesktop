using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Class.Model;
using Academia.Class.Controller;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace Academia.View
{
    public partial class FrmAluno : Form
    {
        Thread thread;
        readonly AlunoModel modelAluno = new AlunoModel();
        readonly AlunoController controllerAluno = new AlunoController();

        public FrmAluno()
        {
            InitializeComponent();
        }

        private void MedicoesAluno()
        {
            Application.Run(new FrmMedicoes());
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            if(modelAluno.CPF != "" || modelAluno.CPF != null)
            {
                controllerAluno.Consultar(modelAluno);
            }
        }

        string sexo, status;
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (rdbInativo.Checked)
            {
                status = "0";
            }
            if (rdbAtivo.Checked)
            {
                status = "1";
            }


            if (rdbFeminino.Checked == true)
            {
               this.sexo = "F";
            }
            if (rdbMasculino.Checked == true)
            {
               this.sexo = "M";
            }

            modelAluno.EnviaDados(txtNomeAluno.Text, mskCPF.Text, mskDataNascimento.Text, Convert.ToChar(this.sexo), mskEmail.Text,mskCelular.Text,mskTelefone.Text, this.status);

            if (controllerAluno.Inserir(modelAluno) == true)
            {
                MessageBox.Show(controllerAluno.mensagem);
                if (MessageBox.Show("Deseja cadastrar as medições do aluno?", "Deseja continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();//FECHANDO A TELA ATUAL
                    thread = new Thread(MedicoesAluno);//INFORMANDO A TELA A SER CHAMADA LOGO EM SEGUIDA
                    thread.SetApartmentState(ApartmentState.STA);//ESTADO DA THREAD
                    thread.Start();//INICIANDO A TELA QUE FOI INFORMADA
                }
            }
            else
            {
                MessageBox.Show(controllerAluno.mensagem);
            }
            LimparCampos();
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

        private void LimparCampos()
        {
            //DADOS ALUNO
            mskCPF.Text = "";
            mskCelular.Text = "";
            mskDataNascimento.Text = "";
            mskTelefone.Text = "";
            txtNomeAluno.Text = "";
            mskEmail.Text = "";
        }

    }
}