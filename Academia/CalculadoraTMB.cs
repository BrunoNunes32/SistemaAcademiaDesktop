using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmCalculadorTMB : Form
    {
        public frmCalculadorTMB()
        {
            InitializeComponent();


        }
        public int peso, altura, idade;
        public float total;

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Convertendo o dado no txt- válido para conversão para inteiros
            peso = Convert.ToInt32(txtPeso.Text);
            altura = Convert.ToInt32(txtAltura.Text);
            idade = Convert.ToInt32(txtIdade.Text);

            if(rdbMasculino.Checked)
            {
                /*vresultado = parseFloat(66 + (13.7 * vpeso) + (5 * valtura) - (6.8 * vidade));
                form.resultado.value = vresultado.toFixed(2);
                var total = vresultado + (vresultado * 0.25);
                vnenhuma = parseFloat(total);
                form.nenhuma.value = vnenhuma.toFixed(2);

                total = vresultado + (vresultado * 0.35);
                vmoderada = parseFloat(total);
                form.moderada.value = vmoderada.toFixed(2);

                total = vresultado + (vresultado * 0.45);
                vintensa = parseFloat(total);
                form.intensa.value = vintensa.toFixed(2);*/
                //Determinando o dado como float
                total = (float)(66 + (13.7 * peso) + (5 * altura) - (6.8 * idade));
                txtIMC.Text = total.ToString();

            }
            if (rdbFeminino.Checked)
            {

            }
        }
    }
}
