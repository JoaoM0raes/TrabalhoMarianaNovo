using FluentValidation;
using GestãoTeste.Disciplina;
using GestãoTestes.Dominio.ModuloMatéria;
using GestãoTestes.Infra.Compartilhado;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoMariana
{
    public class RepositorioMatériaEmArquivo : RepositorioEmArquivoBase<Materia>, IRepositorioMateria
    {
     

        public RepositorioMatériaEmArquivo(DataContext dataContext) : base(dataContext)
        {

            if (dataContext.Matérias.Count > 0)
                contador = dataContext.Matérias.Max(x => x.Numero);
        }

        public override List<Materia> ObterRegistros()
        {
            return dataContext.Matérias;
        }

        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidadorMateria();
        }
    }
}