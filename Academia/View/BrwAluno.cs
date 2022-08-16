using Academia.Class.Controller;
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
using Academia.Class.Model;

namespace Academia.View
{
    public partial class BrwAluno : Form
    {
        Thread thread;
        readonly AlunoController alunoController = new AlunoController();
        readonly AlunoModel modelAluno = new AlunoModel();

        public BrwAluno()
        {
            InitializeComponent();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            alunoController.Consultar(dtgAluno);
        }

        private void BtnEditarAluno_Click(object sender, EventArgs e)
        {
            this.Close();//FECHANDO A TELA ATUAL
            thread = new Thread(TelaAluno);//INFORMANDO A TELA A SER CHAMADA LOGO EM SEGUIDA
            thread.SetApartmentState(ApartmentState.STA);//ESTADO DA THREAD
            thread.Start();//INICIANDO A TELA QUE FOI INFORMADA
        }

        private void BtnAdicionarAluno_Click(object sender, EventArgs e)
        {
            this.Close();//FECHANDO A TELA ATUAL
            thread = new Thread(TelaAluno);//INFORMANDO A TELA A SER CHAMADA LOGO EM SEGUIDA
            thread.SetApartmentState(ApartmentState.STA);//ESTADO DA THREAD
            thread.Start();//INICIANDO A TELA QUE FOI INFORMADA
        }

        private void BtnConsultarAluno_Click(object sender, EventArgs e)
        {
            modelAluno.CPF = dtgAluno.CurrentRow.Cells[2].Value.ToString();
            if (modelAluno.CPF != "" || modelAluno.CPF != null)
            {
                this.Close();//FECHANDO A TELA ATUAL
                thread = new Thread(TelaAluno);//INFORMANDO A TELA A SER CHAMADA LOGO EM SEGUIDA
                thread.SetApartmentState(ApartmentState.STA);//ESTADO DA THREAD
                thread.Start();//INICIANDO A TELA QUE FOI INFORMADA
            }
        }

        private void BtnConsultarmedicoes_Click(object sender, EventArgs e)
        {
            //chamar a futura tela de medicoess
        }

        private void BtnAdicionarMedicoes_Click(object sender, EventArgs e)
        {
            //chamar a futura tela de medicoes
        }

        private void TelaAluno()
        {
            Application.Run(new FrmAluno());//INFORMANDO QUAL TELA SERÁ INICIADA NA THREAD
        }

        //private void BrwAluno_Load(object sender, EventArgs e)
        //{
        //    // TODO: esta linha de código carrega dados na tabela 'sistemaAcademiaDataSet.tblAluno'. Você pode movê-la ou removê-la conforme necessário.
        //    this.tblAlunoTableAdapter.Fill(this.sistemaAcademiaDataSet.tblAluno);

        //}

    }
}
