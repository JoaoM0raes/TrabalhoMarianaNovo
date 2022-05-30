using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTestes.Dominio.ModuloDisciplina
{
    public class ValidadorDisciplina: AbstractValidator<Disciplinas>
    {
        public ValidadorDisciplina()
        {
            RuleFor(x => x.Nome)
                .NotNull().NotEmpty();
        }
    }
}
