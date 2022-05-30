using FluentValidation.Results;
using GestãoTeste.Disciplina;
using GestãoTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTestes.Infra.Infra_Db
{
    public class RepositorioDisiciplinaBancoDeDados : IRepositorioDisciplina
    {
        private const string EndereçoBanco = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = TestesMariana; Integrated Security = True; Pooling=False";
        private const string InserirSql = @"INSERT INTO [TBDISCIPLINA] 
                                               (
                                               [NOME]
	                                           )
	                                       VALUES
                                               (
                                                @NOME
                                                )
                                               ;SELECT SCOPE_IDENTITY();";
        private const string EditarSql = @"UPDATE [TBDISCIPLINA]	
		                                  SET
			                                [NOME] = @NOME
		                                  WHERE
			                                [NUMERO] = @NUMERO";

        private const string ExcluirSql = @"  DELETE FROM [TBDISCIPLINA]                              
		                                        WHERE
			                                     [NUMERO] = @NUMERO";
        private const string SelecionarTodosSql = @"SELECT 
		                                           [NUMERO], 
		                                           [NOME]
	                                             FROM 
		                                           [TBDISCIPLINA]";
        private const string sqlSelecionarPorNumero =
                                                     @"SELECT 
		                                                [NUMERO], 
		                                                [NOME]
	                                                   FROM [TBDISCIPLINA]      
		                                                WHERE  [NUMERO] = @NUMERO";


        public ValidationResult Editar(Disciplinas registro)
        {
            var validador = new ValidadorDisciplina();

            var resultadoValidacao = validador.Validate(registro);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(EndereçoBanco);

            SqlCommand comandoEdicao = new SqlCommand(EditarSql, conexaoComBanco);

            ConfigurarParametrosDisciplina(registro, comandoEdicao);

            conexaoComBanco.Open();
            comandoEdicao.ExecuteNonQuery();
            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Excluir(Disciplinas registro)
        {
            var validador = new ValidadorDisciplina();

            var resultadoValidacao = validador.Validate(registro);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(EndereçoBanco);

            SqlCommand comandoExcluir = new SqlCommand(ExcluirSql, conexaoComBanco);

            comandoExcluir.Parameters.AddWithValue("NUMERO",registro.Numero);

            conexaoComBanco.Open();
            comandoExcluir.ExecuteNonQuery();
            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public ValidationResult Inserir(Disciplinas novoRegistro)
        {
            var validador = new ValidadorDisciplina();

            var resultadoValidacao = validador.Validate(novoRegistro);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(EndereçoBanco);

            SqlCommand comandoInsercao = new SqlCommand(InserirSql, conexaoComBanco);

            ConfigurarParametrosDisciplina(novoRegistro, comandoInsercao);

            conexaoComBanco.Open();
            var id = comandoInsercao.ExecuteScalar();
            novoRegistro.Numero = Convert.ToInt32(id);

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        private void ConfigurarParametrosDisciplina(Disciplinas disciplina, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("NOME",disciplina.Nome);
            comandoInsercao.Parameters.AddWithValue("NUMERO", disciplina.Numero);
        }

        public Disciplinas SelecionarPorNumero(int numero)
        {
            SqlConnection conexaoComBanco = new SqlConnection(EndereçoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorNumero, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("NUMERO", numero);

            conexaoComBanco.Open();
            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();

            Disciplinas disciplina = null;
            if (leitorDisciplina.Read())
                disciplina = ConverterParaDisciplina(leitorDisciplina);

            conexaoComBanco.Close();

            return disciplina;
        }

        public List<Disciplinas> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(EndereçoBanco);

            SqlCommand comandoSelecao = new SqlCommand(SelecionarTodosSql, conexaoComBanco);

            conexaoComBanco.Open();

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();

            List<Disciplinas> disciplinas = new List<Disciplinas>();

            while (leitorDisciplina.Read())
            {
                Disciplinas disciplina = ConverterParaDisciplina(leitorDisciplina);

                disciplinas.Add(disciplina);
            }

            conexaoComBanco.Close();

            return disciplinas;
        }

        private Disciplinas ConverterParaDisciplina(SqlDataReader leitorDisciplina)
        {
            int numero = Convert.ToInt32(leitorDisciplina["NUMERO"]);
            string nome = Convert.ToString(leitorDisciplina["NOME"]);

            var disciplina = new Disciplinas
            {
                Numero = numero,
                Nome = nome
            };

            return disciplina;
        }
    }
}
