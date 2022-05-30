using GestãoTestes.Dominio.ModuloMatéria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTestes.Dominio.ModuloDisciplina
{
    public  class Disciplinas:EntidadeBase<Disciplinas>
    {
       
        public string Nome { get; set; }
        public override void Atualizar(Disciplinas registro)
        {
            this.Nome = registro.Nome;
        }
        public List<Materia> Materias { get; set; }

        internal void AdicionarMateria(Materia materia)
        {
            if (Materias == null)
                Materias = new List<Materia>();

            Materias.Add(materia);
        }

        public override string ToString()
        {
            return $"disciplina: {Nome}";
        }

    }
}
