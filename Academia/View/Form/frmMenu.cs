using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Academia;


namespace Academia.Window
{
    public partial class frmMenu : Form
    {
       
        Thread thread; //INSTANCIANDO A THREAD

        public frmMenu()
        {
            InitializeComponent();
        }

        private void CalculadoraTMB()
        {
            Application.Run(new frmCalculadoraTMB());
        }

        private void AdicionarAluno()
        {
            Application.Run(new frmCadastroAluno());//INFORMANDO QUAL TELA SERÁ INICIADA NA THREAD
        }
        private void btnCalcauladoraTMB_Click(object sender, EventArgs e)
        {
            this.Close();//FECHANDO A TELA ATUAL
            thread = new Thread(CalculadoraTMB);//INFORMANDO A TELA A SER CHAMADA LOGO EM SEGUIDA
            thread.SetApartmentState(ApartmentState.STA);//ESTADO DA THREAD
            thread.Start();//INICIANDO A TELA QUE FOI INFORMADA
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(AdicionarAluno);
            thread.SetApartmentState(ApartmentState.STA);//STA = SINGLE THREAD: THREAD SIMPLES | MTA = MULTI THREAD: VARIAS THREADS
            thread.Start();
        }
    }
}
