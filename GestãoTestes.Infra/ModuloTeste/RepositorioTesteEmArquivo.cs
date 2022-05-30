using FluentValidation;
using GestãoTestes.Dominio.ModuloTeste;
using GestaoTestes.Dominio.ModuloTeste;
using GestãoTestes.Infra.Compartilhado;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoMariana
{
    public class RepositorioTesteEmArquivo : RepositorioEmArquivoBase<Testes>, IrepositorioTeste
    {
        public RepositorioTesteEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Testes.Count > 0)
                contador = dataContext.Testes.Max(x => x.Numero);
        }

        public override List<Testes> ObterRegistros()
        {
            return dataContext.Testes;
        }

        public override AbstractValidator<Testes> ObterValidador()
        {
            return new ValidadorTeste();
        }
    }
}