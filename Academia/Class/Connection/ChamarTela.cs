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
using Academia.View;

namespace Academia.Class.Connection
{
    public class ChamarTela
    {

        Thread thread;

        private void CalculadoraTMB()
        {
            Application.Run(new FrmCalculadoraTMB());
        }

        private void AdicionarAluno()
        {
            Application.Run(new FrmAluno());
        }

        private void Login()
        {
            Application.Run(new FrmLogin());
        }

        private void MedicoesAluno()
        {
            Application.Run(new FrmMedicoes());
        }

        private void BtnCalcauladoraTMB_Click(object sender, EventArgs e)
        {
          //  this.Close();
            thread = new Thread(CalculadoraTMB);//INFORMANDO A TELA A SER CHAMADA LOGO EM SEGUIDA
            //STA = SINGLE THREAD: THREAD SIMPLES | MTA = MULTI THREAD: VARIAS THREADS
            thread.SetApartmentState(ApartmentState.STA);//ESTADO DA THREAD
            thread.Start();//INICIANDO A TELA QUE FOI INFORMADA
        }

        private void BtnAdicionarAluno_Click(object sender, EventArgs e)
        {
           // this.Close();
            thread = new Thread(AdicionarAluno);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void BtnMedicoes_Click(object sender, EventArgs e)
        {
            // this.Close();
            thread = new Thread(MedicoesAluno);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           // this.Close();
            thread = new Thread(Login);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

    }
}
