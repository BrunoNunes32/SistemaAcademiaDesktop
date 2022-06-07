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
    public class MedicoesController
    {
        ConexaoDB conexao = new ConexaoDB();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public bool Cadastro(MedicoesModel medicoes)
        {
            cmd.CommandText = "insert into tblMedicoes(peso,altura,bracoD,anteBracoD,coxaD,panturrilhaD,bracoE,anteBracoE,coxaE,panturrilhaE,peitoral,cintura,quadril,CPF) Values           (@peso,@altura,@bracoD,@anteBracoD,@coxaD,@panturrilhaD,@bracoE,@anteBracoE,@coxaE,@panturrilhaE,                  @peitoral,@cintura,@quadril,@CPF)";

            if(medicoes.Peso != "" || medicoes.Peso != null)
            {
                cmd.Parameters.Add("@peso", SqlDbType.VarChar).Value = medicoes.Peso;
            }
            else
            {
                cmd.Parameters.Add("@peso", SqlDbType.VarChar).Value = "";

            }

            if (medicoes.Altura != "" || medicoes.Altura != null)
            {
                cmd.Parameters.Add("@altura", SqlDbType.VarChar).Value = medicoes.Altura;
            }
            else
            {
                cmd.Parameters.Add("@altura", SqlDbType.VarChar).Value = "";

            }

            if (medicoes.BracoD != "" || medicoes.BracoD != null)
            {
                cmd.Parameters.Add("@bracoD", SqlDbType.VarChar).Value = medicoes.BracoD;
            }
            else
            {
                cmd.Parameters.Add("@bracoD", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.BracoE != "" || medicoes.BracoE != null)
            {
                cmd.Parameters.Add("@bracoE", SqlDbType.VarChar).Value = medicoes.BracoE;
            }
            else
            {
                cmd.Parameters.Add("@", SqlDbType.VarChar).Value = "";
            }


            if (medicoes.CPF != ""  || medicoes.CPF != null)
            {
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = medicoes.CPF;
            }
            else{
                mensagem = "Campo CPF é obrigatório!";
                return false;
            }

            try
            {
                cmd.Connection = conexao.conectar();//ABRINDO CONEXÃO
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.desconectar();//FECHANDO A CONEXÃO
                mensagem = "Medições inseridas com sucesso!";
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Falha na inserção das medidas! " + error;
                return false;
            }

        }

    }
}
