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
        readonly ConexaoDB conexao = new ConexaoDB();
        readonly SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public bool Cadastro(MedicoesModel medicoes)
        {
            cmd.CommandText = "insert into tblMedicoes(peso, altura, bracoD, anteBracoD, coxaD, panturrilhaD, bracoE, anteBracoE, coxaE, panturrilhaE, peitoral, cintura, quadril, CPF, dataMedicao) Values(@peso, @altura, @bracoD, @anteBracoD, @coxaD, @panturrilhaD, @bracoE, @anteBracoE, @coxaE, @panturrilhaE, @peitoral,@cintura, @quadril, @CPF, GETDATE())";


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

            if (medicoes.Peitoral != "" || medicoes.Peitoral != null)
            {
                cmd.Parameters.Add("@peitoral", SqlDbType.VarChar).Value = medicoes.Peitoral;
            }
            else
            {
                cmd.Parameters.Add("@peitoral", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.Cintura != "" || medicoes.Cintura != null)
            {
                cmd.Parameters.Add("@cintura", SqlDbType.VarChar).Value = medicoes.Cintura;
            }
            else
            {
                cmd.Parameters.Add("@cintura", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.Quadril != "" || medicoes.Quadril != null)
            {
                cmd.Parameters.Add("@quadril", SqlDbType.VarChar).Value = medicoes.Quadril;
            }
            else
            {
                cmd.Parameters.Add("@quadril", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.CPF != ""  || medicoes.CPF != null)
            {
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = medicoes.CPF;
            }
            else{
                mensagem = "Campo CPF é obrigatório!";
                return false;
            }

            if (medicoes.BracoD != "" || medicoes.BracoD != null)
            {
                cmd.Parameters.Add("@bracoD", SqlDbType.VarChar).Value = medicoes.BracoD;
            }
            else
            {
                cmd.Parameters.Add("@bracoD", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.AnteBracoD != "" || medicoes.AnteBracoD != null)
            {
                cmd.Parameters.Add("@antebracoD", SqlDbType.VarChar).Value = medicoes.AnteBracoD;
            }
            else
            {
                cmd.Parameters.Add("@antebracoD", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.CoxaD != "" || medicoes.CoxaD != null)
            {
                cmd.Parameters.Add("@coxaD", SqlDbType.VarChar).Value = medicoes.CoxaD;
            }
            else
            {
                cmd.Parameters.Add("@coxaD", SqlDbType.VarChar).Value = "";
            }
                        
            if (medicoes.PanturrilhaD != "" || medicoes.PanturrilhaD != null)
            {
                cmd.Parameters.Add("@panturrilhaD", SqlDbType.VarChar).Value = medicoes.PanturrilhaD;
            }
            else
            {
                cmd.Parameters.Add("@panturrilhaD", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.BracoE != "" || medicoes.BracoE != null)
            {
                cmd.Parameters.Add("@bracoE", SqlDbType.VarChar).Value = medicoes.BracoE;
            }
            else
            {
                cmd.Parameters.Add("@bracoE", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.AnteBracoE != "" || medicoes.AnteBracoE != null)
            {
                cmd.Parameters.Add("@antebracoE", SqlDbType.VarChar).Value = medicoes.AnteBracoE;
            }
            else
            {
                cmd.Parameters.Add("@antebracoE", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.CoxaE != "" || medicoes.CoxaE != null)
            {
                cmd.Parameters.Add("@coxaE", SqlDbType.VarChar).Value = medicoes.CoxaE;
            }
            else
            {
                cmd.Parameters.Add("@coxaE", SqlDbType.VarChar).Value = "";
            }

            if (medicoes.PanturrilhaE != "" || medicoes.PanturrilhaE != null)
            {
                cmd.Parameters.Add("@panturrilhaE", SqlDbType.VarChar).Value = medicoes.PanturrilhaE;
            }
            else
            {
                cmd.Parameters.Add("@panturrilhaE", SqlDbType.VarChar).Value = "";
            }

            try
            {
                cmd.Connection = conexao.Conectar();//ABRINDO CONEXÃO
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.Desconectar();//FECHANDO A CONEXÃO
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