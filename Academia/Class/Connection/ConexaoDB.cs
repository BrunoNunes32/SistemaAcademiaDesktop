using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academia.Class.Connection
{
    public class ConexaoDB
    {


            SqlConnection con = new SqlConnection();

            //CONSTRUTOR
            public ConexaoDB(){
            //CONECTANDO AO BANCO DE DADOS LOCAL
            con.ConnectionString = @"Data Source=BHAN-ACER;Initial Catalog=SistemaAcademia;Integrated Security=True";
            //CONECTANDO AO BANCO DE DADOS INTERNO NA REDE
            /*SqlConnection con = new SqlConnection(@"Persist Security Info=False;User ID=USUARIO_SQL;password=SENHA_USUARIO;Initial Catalog=DATABASE;Data Source=localhost");*/
        }

        public SqlConnection conectar()
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                return con;

            }
            public SqlConnection desconectar()
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                return con;

            }
        }
    
}
