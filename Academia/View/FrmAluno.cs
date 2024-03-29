﻿using Academia.Class.Controller;
using Academia.Class.Model;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Academia.Window
{
    public partial class FrmAluno : Form
    {
        Thread thread;
        readonly AlunoModel modelAluno = new AlunoModel();
        readonly AlunoController controllerAluno = new AlunoController();
        readonly MedicoesModel modelMedicoes = new MedicoesModel();
        readonly MedicoesController controllerMedicoes = new MedicoesController();
        //O MODO É PARA DEFINIR SE A TELA IRÁ ABRIR COMO MODO DE INSERÇÃO, CONSULTA E CONFIRMAÇÃO DE DELETAR OS DADOS.
        //ISSO PARA EVITAR A CONSTRUÇÃO DE OUTRAS TELAS COM OS MESMOS DADOS
        public FrmAluno(/*string MODO*/)
        {
            InitializeComponent();
        }
        //0: inserir    | 1: Consulta   | 2: Alterar    | 3: Confirmar exclusão/desativação
        public int modo = 0;        
        private void FrmAluno_Load(object sender, EventArgs e)
        {
            //INSERIR
            if (modelAluno.CPF.Length > 0)
            {
                modo = 0;
            }
            //CONSULTAR
            if (modelAluno.CPF.Length > 0)
            {
               modo = 1;
            }
            //ALTERAR
            if (modelAluno.CPF.Length > 0)
            {
                modo = 2;
            }
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
                modelMedicoes.CPF = mskCPF.Text;
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

            //DADOS MEDIÇÕES
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtPeitoral.Text = "";
            txtQuadril.Text = "";
            txtCintura.Text = "";
            txtAntebracoD.Text = "";
            txtAntebracoE.Text = "";
            txtBracoD.Text = "";
            txtBracoE.Text = "";
            txtCoxaD.Text = "";
            txtCoxaE.Text = "";
            txtPanturrilhaD.Text = "";
            txtPanturrilhaE.Text = "";
            txtTornozeloD.Text = "";
            txtTornozeloE.Text = "";
        }
    }
}