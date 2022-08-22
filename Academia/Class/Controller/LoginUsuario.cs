using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Class.Connection;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Academia.Class.Controller
{
    public class LoginUsuario
    {
        readonly ConexaoDB conexao = new ConexaoDB();
        readonly SqlCommand cmd = new SqlCommand();
        //SqlDataReader leitor = new SqlDataReader();
        public string mensagem;

        public void VerificaLogin(Hash hash)
        {
            cmd.CommandText = "SELECT COUNT(*) AS EXISTENCIA FROM tblAluno WHERE CPF = '@CPF'";
            if (hash. != "" && aluno.CPF != null)
            {
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = aluno.CPF;
            }
            else
            {
                mensagem = "É obrigatório informar o CPF!";
                return false;
            }
            try
            {
                cmd.Connection = conexao.Conectar();//ABRINDO CONEXÃO
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.Desconectar();//FECHANDO A CONEXÃO
                mensagem = "Aluno deletado com sucesso!";//INFORMANDO A MENSAGEM DE CONCLUSÃO
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Falha ao consultar a existência aluno! \n" + error;//INFORMANDO A MENSAGEM DE ERRO NO PROCESSO, E MOSTRANDO O ERRO
                return false;
            }
        }

        public void CadastrarLogin()
        {
        
        }

        public void ApagarLogin()
        {
        
        }

        public void AtualzaLogin()
        {
        
        }


    }
}
