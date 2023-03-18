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
using Dapper;

namespace Academia.Class.Controller
{

    public class AlunoController
    {
        readonly ConexaoDB conexao = new ConexaoDB();
        readonly SqlCommand cmd = new SqlCommand();
        //SqlDataReader leitor = new SqlDataReader();
        public string mensagem;

        public bool Inserir(AlunoModel aluno)
        {
            //DANDO O COMANDO QUE SERÁ EXECUTADO NO BANCO DE DADOS | BITATIVO 1 POIS SE ESTA CADASTRANDO, ELE ESTA ATIVO
            cmd.CommandText = "INSERT INTO tblAluno(nome, CPF, dtNascimento, telefone, celular, sexo, bitAtivo, email, dataCadastro) VALUES(@nome, @CPF, @dtNascimento, @telefone, @celular, @sexo, 1, @email, GETDATE())"; 
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
            if (aluno.Email != "" && aluno.Email != null)
            {
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = aluno.Email;
            }
            else
            {
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = "";
            }
            try
            {
                cmd.Connection = conexao.Conectar();//ABRINDO CONEXÃO
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.Desconectar();//FECHANDO A CONEXÃO
                mensagem = "Aluno inserido com sucesso!";
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Falha na inserção do aluno! \n" + error;
                return false;
            }
        }

        public bool Deletar(AlunoModel aluno)
        {
            cmd.CommandText = "DELETE FROM tblAluno WHERE CPF = '@CPF'";
            if(aluno.CPF != "" && aluno.CPF != null)
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
                mensagem = "Falha ao deletar o aluno! \n" + error;//INFORMANDO A MENSAGEM DE ERRO NO PROCESSO, E MOSTRANDO O ERRO
                return false;
            }
        }

        //VERIFICANDO SE HÁ UM CADASTRO NO BANCO
        public bool ConsultarExistencia(AlunoModel aluno)
        {
            cmd.CommandText = "SELECT COUNT(*) AS EXISTENCIA FROM tblAluno WHERE CPF = '@CPF'";
            if (aluno.CPF != "" && aluno.CPF != null)
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
                int contador = cmd.Connection.QuerySingleOrDefault(cmd.CommandText);
                cmd.ExecuteNonQuery();//EXECUTANDO O COMANDO
                cmd.Connection = conexao.Desconectar();//FECHANDO A CONEXÃO
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                mensagem = "Aluno cadastrado com sucesso";
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Falha ao consultar a existência aluno! \n" + error;//INFORMANDO A MENSAGEM DE ERRO NO PROCESSO, E MOSTRANDO O ERRO
                return false;
            }
        }

        //CONSULTA GERAL SEM FILTRO
        public bool Consultar(DataGridView dataGrid)
        {
            cmd.CommandText = "SELECT nome as [Nome], CPF, dtNascimento as [Data de Nascimento], telefone as [Telefone], celular as [Celular], sexo as [Sexo], email as [E-mail], dataCadastro as [Data do Cadastro] FROM tblAluno";
            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tabelaAluno = new DataTable();
                da.Fill(tabelaAluno);
                dataGrid.DataSource = tabelaAluno;
                conexao.Desconectar();
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Erro na consulta!\n" + error;
                return false;
            }
        }

        //CONSULTA COM FILTRO PARA LEVAR EM UMA DATAGRID 
        public bool Consultar(DataGridView dataGrid, AlunoModel aluno)
        {
            cmd.CommandText = "SELECT nome as [Nome], CPF, dtNascimento as [Data de Nascimento], telefone as [Telefone], celular as [Celular], sexo[Sexo], email as [E-mail], dataCadastro as [Data do Cadastro] FROM tblAluno WHERE 1=1 ";
            if (aluno.CPF != "" && aluno.CPF != null)
            {
                cmd.CommandText += "\n AND CPF = @CPF ";
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = aluno.CPF;
            }
            if (aluno.Nome != "" && aluno.Nome != null)
            {
                cmd.CommandText += "\n AND nome = @NOME ";
                cmd.Parameters.Add("@NOME", SqlDbType.VarChar).Value = aluno.CPF;
            }
            if (aluno.DtNascimento != "" && aluno.DtNascimento != null)
            {
                cmd.CommandText += "\n AND dtNascimento = @DTNASCIMENTO ";
                cmd.Parameters.Add("@DTNASCIMENTO", SqlDbType.VarChar).Value = aluno.CPF;
            }
            if (aluno.Sexo != "" && aluno.Sexo != null)
            {
                cmd.CommandText += "\n AND sexo = @SEXO ";
                cmd.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = aluno.CPF;
            }
            if (aluno.Email != "" && aluno.Email != null)
            {
                cmd.CommandText += "\n AND email = @EMAIL ";
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = aluno.CPF;
            }

            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tabelaAluno = new DataTable();
                da.Fill(tabelaAluno);
                dataGrid.DataSource = tabelaAluno;
                conexao.Desconectar();
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Erro na consulta!\n" + error;
                return false;
            }
        }
        public bool Consultar(AlunoModel aluno)
        {
            cmd.CommandText = "SELECT nome as [Nome], CPF, dtNascimento as [Data de Nascimento], telefone as [Telefone], celular as [Celular], sexo as [Sexo], email as [E-mail], dataCadastro as [Data do Cadastro] FROM tblAluno WHERE CPF = @CPF";
            
            if (aluno.CPF != "" && aluno.CPF != null)
            {
                cmd.CommandText += "\n AND CPF = @CPF ";
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = aluno.CPF;
            }

            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tabelaAluno = new DataTable();
                da.Fill(tabelaAluno);
               // dataGrid.DataSource = tabelaAluno;
                conexao.Desconectar();
                return true;
            }
            catch (SqlException error)
            {
                mensagem = "Erro na consulta!\n" + error;
                return false;
            }
        }
    }    
}