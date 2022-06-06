﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Class;

namespace Academia.Class.Model
{
    public class AlunoModel
    {
        private string bitAtivo;
        private string nome;
        private string cpf;
        private string dtNascimento;
        private string telefone;
        private string celular;
        private string sexo;
        private string altura;
        private string peso;
        private int idAluno;

        public string BitAtivo
        {
            get => bitAtivo;
            set => bitAtivo = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string CPF
        {
            get => cpf;
            set => cpf = value;
        }
        public string DtNascimento
        {
            get => dtNascimento;
            set => dtNascimento = value;
        }
        public string Telefone
        {
            get => telefone;
            set => telefone = value;
        }
        public string Celular
        {
            get => celular;
            set => celular = value;
        }
        public string Sexo
        {
            get => sexo;
            set => sexo = value;
        }
        public string Altura
        {
            get => altura;
            set => altura = value;
        }
        public string Peso
        {
            get => peso;
            set => peso = value;
        }
        public int IdAluno
        {
            get => idAluno;
            set => idAluno = value;
        }
    }
}
