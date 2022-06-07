using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Class.Model
{
    public class MedicoesModel
    {
        private int id;
        private string cpf;
        private string peso;
        private string altura;
        private string bracoD;
        private string anteBracoD;
        private string coxaD;
        private string panturrilhaD;
        private string bracoE;
        private string anteBracoE;
        private string coxaE;
        private string panturrilhaE;
        private string peitoral;
        private string cintura;
        private string quadril;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string CPF
        {
            get => cpf;
            set => cpf = value;
        }
        public string Peso
        {
            get => peso;
            set => peso = value;
        }
        public string Altura
        {
            get => altura;
            set => altura = value;
        }
        public string BracoD
        {
            get => bracoD;
            set => bracoD = value;
        }
        public string AnteBracoD
        {
            get => anteBracoD;
            set => anteBracoD = value;
        }
        public string CoxaD
        {
            get => coxaD;
            set => coxaD = value;
        }
        public string PanturrilhaD
        {
            get => panturrilhaD;
            set => panturrilhaD = value;
        }
        public string BracoE
        {
            get => bracoE;
            set => bracoE = value;
        }
        public string AnteBracoE
        {
            get => anteBracoE;
            set => anteBracoE = value;
        }
        public string CoxaE
        {
            get => coxaE;
            set => coxaE = value;
        }
        public string PanturrilhaE
        {
            get => panturrilhaE;
            set => panturrilhaE = value;
        }
        public string Peitoral
        {
            get => peitoral;
            set => peitoral = value;
        }
        public string Cintura
        {
            get => cintura;
            set => cintura = value;
        }
        public string Quadril
        {
            get => quadril;
            set => quadril = value;
        }
    }
}