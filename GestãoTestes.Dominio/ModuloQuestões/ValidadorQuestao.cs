using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace GestãoTestes.Dominio.ModuloQuestões
{
    public class ValidadorQuestao : AbstractValidator<Questão>
    {
        public ValidadorQuestao()
        {
            RuleFor(x => x.Enunciado)
               .NotNull().NotEmpty();
            RuleFor(x => x.Respostas)
               .NotNull();
            RuleFor(x => x.Materias)
               .NotNull();

        }
    }
}
