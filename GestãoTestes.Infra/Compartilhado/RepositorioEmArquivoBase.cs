using GestãoTestes.Dominio;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace GestãoTestes.Infra.Compartilhado
{
    public abstract class RepositorioEmArquivoBase<T> where T: EntidadeBase<T>
    {
        protected DataContext dataContext;

        protected int contador = 0;
        public RepositorioEmArquivoBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public abstract List<T> ObterRegistros();

        public abstract AbstractValidator<T> ObterValidador();
        public ValidationResult Inserir(T Entidade)
        {
            var validador = ObterValidador();
            var resultadoValidacao = validador.Validate(Entidade);
            if (resultadoValidacao.IsValid)
            {
                Entidade.Numero = ++contador;

                var registros = ObterRegistros();

                registros.Add(Entidade);
            }
            return resultadoValidacao; 

        }
        public ValidationResult Editar(T Entidade)
        {
            var validador = ObterValidador();
            var resultadoValidacao = validador.Validate(Entidade);
            if (resultadoValidacao.IsValid)
            {
                var registros = ObterRegistros();
                foreach (var item in registros)
                {
                    if (item.Numero == Entidade.Numero)
                    {
                        item.Atualizar(Entidade);
                        break;
                    }

                }
            }
            return resultadoValidacao;
        }
        public ValidationResult Excluir(T Entidade)
        {
            var resultadoValidacao = new ValidationResult();

            var registros = ObterRegistros();

            if (registros.Remove(Entidade) == false)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));

            return resultadoValidacao;

        }
        public virtual List<T> SelecionarTodos()
        {
            return ObterRegistros().ToList();
        }

        public virtual T SelecionarPorNumero(int numero)
        {
            return ObterRegistros()
                .FirstOrDefault(x => x.Numero == numero);
        }
    }
}
