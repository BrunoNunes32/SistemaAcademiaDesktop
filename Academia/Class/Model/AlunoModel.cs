using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Academia.Class;

namespace Academia.Class.Model
{
    

    public class AlunoModel
    {
        private string bitAtivo, nome, cpf, dtNascimento, telefone, celular, sexo, email, dataCadastro;

        public string BitAtivo { get => bitAtivo; set => bitAtivo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CPF { get => cpf; set => cpf = value; }
        public string DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Email { get => email; set => email = value; }
        public string DataCadastro { get => dataCadastro; set => dataCadastro = value; }

        public void EnviaDados(string nome, string cpf, string dtNascimento, char sexo, string email, string celular, string telefone, string bitAtivo)
        {
            this.nome = nome;
            this.CPF = cpf;
            this.dtNascimento = dtNascimento;
            this.sexo = Convert.ToString(sexo);
            this.email = email;
            this.celular = celular;
            this.telefone = telefone;
            this.BitAtivo = bitAtivo;
        }

    }
}