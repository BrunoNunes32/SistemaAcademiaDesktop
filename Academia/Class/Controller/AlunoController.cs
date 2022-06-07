using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Class.Connection;
using Academia.Class.Model;
using System.Windows.Forms;

namespace Academia.Class.Controller
{

    public class AlunoController
    {
        ConexaoDB conexao = new ConexaoDB();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;


        public bool Cadastro(AlunoModel aluno)
        {
            //DANDO O COMANDO QUE SERÁ EXECUTADO NO BANCO DE DADOS              |       //BITATIVO 1 POIS SE ESTA CADASTRANDO, ELE ESTA ATIVO
            cmd.CommandText = "insert into tblAluno(nome,CPF,dtNascimento,telefone,celular,sexo,altura,peso,bitAtivo) Values(@nome,@CPF,@dtNascimento,@telefone,@celular,@sexo,@medicoes,1)";
            //PARAMETROS
            if (aluno.Nome != "" && aluno.Nome != null)
            {
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = aluno.Nome;
            }
            else
            {
                mensagem = "Campo NOME é obrigatório!";
                return false;
            }

            if (aluno.CPF != "" && aluno.CPF != null)
            {
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = aluno.CPF;
            }
            else
            {
                mensagem = "Campo CPF é obrigatório!";
                return false;
            }

            if (aluno.DtNascimento != "" && aluno.DtNascimento != null)
            {
                cmd.Parameters.Add("@dtNascimento", SqlDbType.VarChar).Value = aluno.DtNascimento;
            }
            else
            {
                mensagem = "Campo DATA DE NASCIMENTO é obrigatório!";
                return false;
            }

            if (aluno.Sexo != "" && aluno.Sexo != null)
            {
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = aluno.Sexo;
            }
            else
            {
                mensagem = "Campo SEXO é obrigatório!";
                return false;
            }

            if (aluno.Telefone != "" && aluno.Telefone != null)
            {
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = aluno.Telefone;
            }
            else
            {
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = "";
            }

            if (aluno.Celular != "" && aluno.Celular != null)
            {
                cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = aluno.Celular;
            }
            else
            {
                cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = "";
            }

            if (aluno.Altura != "" && aluno.Altura != null)
            {
                cmd.Parameters.Add("@altura", SqlDbType.VarChar).Value = aluno.Altura;
            }
            else
            {
                cmd.Parameters.Add("@altura", SqlDbType.VarChar).Value = "";
            }

            try
            {
                cmd.Connection = conexao.conectar();//ABRINDO CONEXÃO
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.desconectar();//FECHANDO A CONEXÃO
                mensagem = "Aluno inserido com sucesso!";
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "" + error;
                return false;
            }


        }

    }
    


}
