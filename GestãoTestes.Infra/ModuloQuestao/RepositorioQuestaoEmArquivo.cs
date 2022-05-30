using FluentValidation;
using GestãoTestes.Dominio.ModuloMatéria;
using GestãoTestes.Dominio.ModuloQuestões;
using GestaoTestes.Dominio.ModuloQuestões;
using GestãoTestes.Infra.Compartilhado;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoMariana
{
    public class RepositorioQuestaoEmArquivo : RepositorioEmArquivoBase<Questão>, IrepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Questões.Count > 0)
                contador = dataContext.Questões.Max(x => x.Numero);
        }

        public override List<Questão> ObterRegistros()
        {
            return dataContext.Questões;
        }

        public override AbstractValidator<Questão> ObterValidador()
        {
            return new ValidadorQuestao();
        }
    }
}