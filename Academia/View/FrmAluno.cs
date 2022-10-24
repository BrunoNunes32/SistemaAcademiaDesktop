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

namespace Academia.View
{
    public partial class FrmAluno : Form
    {
        Thread thread;
        readonly AlunoModel modelAluno = new AlunoModel();
        readonly AlunoController controllerAluno = new AlunoController();
        //O MODO É PARA DEFINIR SE A TELA IRÁ ABRIR COMO MODO DE INSERÇÃO, CONSULTA E CONFIRMAÇÃO DE DELETAR OS DADOS.
        //ISSO PARA EVITAR A CONSTRUÇÃO DE OUTRAS TELAS COM OS MESMOS DADOS
        public FrmAluno()
        {
            InitializeComponent();
        }

        //TELA PARA CADASTRAR O ALUNO, ONDE IRÁ ARMAZENAR OS DADOS, CAMINHO DA IMAGEM(VERIFICAR UMA FORMA DE ARMAZENAR DE ARMAZENAR NO BANCO)


        //0: inserir    | 1: Consulta   | 2: Alterar    | 3: Confirmar exclusão/desativação
        public int modo = 0;

        private void MedicoesAluno()
        {
            Application.Run(new FrmMedicoes());
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            ////INSERIR
            //if (modelAluno.CPF.Length > 0)
            //{
            //    modo = 0;
            //}
            ////CONSULTAR
            //if (modelAluno.CPF.Length > 0)
            //{
            //   modo = 1;
            //}
            ////ALTERAR
            //if (modelAluno.CPF.Length > 0)
            //{
            //    modo = 2;
            //}
        }
                
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            modelAluno.Nome = txtNomeAluno.Text;
            modelAluno.Celular = mskCelular.Text;
            modelAluno.CPF = mskCPF.Text;
            modelAluno.Celular = mskCelular.Text;
            modelAluno.Telefone = mskTelefone.Text;
            modelAluno.DtNascimento = mskDataNascimento.Text;

            if (rdbFeminino.Checked == true)
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