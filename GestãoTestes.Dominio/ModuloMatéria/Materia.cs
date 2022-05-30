using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestãoTestes.Dominio.ModuloDisciplina;
using GestãoTestes.Dominio.ModuloQuestões;

namespace GestãoTestes.Dominio.ModuloMatéria
{
    public class Materia : EntidadeBase<Materia>
    {
        private Disciplinas disciplina;

        public List<Questão> questoes;
        public string Nome { get; set; }
       
        public Disciplinas Disciplina
        {
            get
            { 
                return disciplina; 
            }
            set
            {
                disciplina = value;
               
            }
        }

        public int Serie { get; set; }
        internal void AdicionarQuestão(Questão questão)
        {
            if (questoes == null)
                questoes = new List<Questão>();


            questoes.Add(questão);
        }

        public override void Atualizar(Materia registro)
        {
            this.Nome = registro.Nome;
            this.Disciplina = registro.Disciplina;
            this.Serie = registro.Serie;
        }
        public override string ToString()
        {
            return $"{this.Nome}";
        }
    }
}
