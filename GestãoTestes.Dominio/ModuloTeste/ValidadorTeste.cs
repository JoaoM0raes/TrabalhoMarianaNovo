using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTestes.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Testes>
    {
        public ValidadorTeste()
        {
            RuleFor(x => x.Questãos)
                .NotNull().NotEmpty();
            RuleFor(x => x.Disciplinas)
                   .NotNull();
            RuleFor(x => x.Materias)
                   .NotNull();
        }
        
    }
}
