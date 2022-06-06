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

        public string Cadastro(MedicoesModel model)
        {
            cmd.CommandText = "insert into tblMedicoes(peso,altura,bracoD,anteBracoD,coxaD,panturrilhaD,bracoE,anteBracoE,coxaE,panturrilhaE,peitoral,cintura,quadril,CPF)" +
                                   "Values(@peso,@altura,@bracoD,@anteBracoD,@coxaD,@panturrilhaD,@bracoE,@anteBracoE,@coxaE,@panturrilhaE," +
                                           "@peitoral,@cintura,@quadril,@CPF)";


            return mensagem;
        }

    }
}
