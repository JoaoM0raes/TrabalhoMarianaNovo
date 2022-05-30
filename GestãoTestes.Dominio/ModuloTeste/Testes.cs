using GestãoTestes.Dominio.ModuloDisciplina;
using GestãoTestes.Dominio.ModuloMatéria;
using GestãoTestes.Dominio.ModuloQuestões;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTestes.Dominio.ModuloTeste
{
    public class Testes : EntidadeBase<Testes>
    {
        public Testes()
        {
            this.DataCriação = DateTime.Today;
        }
        public Disciplinas Disciplinas { get; set; }
        public List<Questão> Questãos { get; set; }
        public DateTime DataCriação { get; set; }
        public Materia Materias { get; set; }
        public int Quantidade { get; set; }
        public string Nome { get; set; }

        public override void Atualizar(Testes registro)
        {
            
        }
    }
}
