using FluentValidation;
using GestãoTeste.Disciplina;
using GestãoTestes.Dominio.ModuloDisciplina;
using GestãoTestes.Infra.Compartilhado;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoMariana
{
    public class RepositorioDisciplinaEmArquivo:RepositorioEmArquivoBase<Disciplinas>, IRepositorioDisciplina
    {
        

        public RepositorioDisciplinaEmArquivo(DataContext dataContext) : base(dataContext)
        {

            if (dataContext.Disciplinas.Count > 0)
                contador = dataContext.Disciplinas.Max(x => x.Numero);
        }
        public override List<Disciplinas> ObterRegistros()
        {
            return dataContext.Disciplinas;
        }
        public override AbstractValidator<Disciplinas> ObterValidador()
        {
            return new ValidadorDisciplina();
        }
    }
}