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
        //INSTANCIANDO A THREAD
        Thread thread;

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
            Application.Run(new frmCadastroAluno());
        }
        private void btnCalcauladoraTMB_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(CalculadoraTMB);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(AdicionarAluno);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
