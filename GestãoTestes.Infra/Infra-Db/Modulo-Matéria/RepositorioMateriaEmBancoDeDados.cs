using FluentValidation.Results;
using GestãoTestes.Dominio.ModuloMatéria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTestes.Infra.Infra_Db.Modulo_Matéria
{
    public class RepositorioMateriaEmBancoDeDados : IRepositorioMateria
    {
        private const string EndereçoBanco = @"";
        private const string InserirSql = @"";
        private const string EditarSql = @"";
        private const string ExcluirSql = @"";
        private const string SelecionarTodosSql = @"";
        private const string SelecionarNumeroSql = @"";

        public ValidationResult Editar(Materia registro)
        {
            
        }

        public ValidationResult Excluir(Materia registro)
        {
           
        }

        public ValidationResult Inserir(Materia novoRegistro)
        {
            ;
        }

        public Materia SelecionarPorNumero(int numero)
        {
            
        }

        public List<Materia> SelecionarTodos()
        {
           
        }
    }
}
