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

namespace Academia.View
{
    public partial class FrmMedicoes : Form
    {
        MedicoesController medicoesController = new MedicoesController();

        public FrmMedicoes()
        {
            InitializeComponent();
        }

        //TELA FEITA PARA CADASTRAR AS MEDIÇOES DOS ALUNOS
        //DATAGRID IRÁ PUXAR AS MEDIÇOES REGISTRADAS ANTERIORMENTE, PARA UMA FORMA DE VERIFICAR A EVOLUÇÃO DO ALUNO
       

    }
}
