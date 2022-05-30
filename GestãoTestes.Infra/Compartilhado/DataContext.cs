using GestãoTestes.Dominio.ModuloDisciplina;
using GestãoTestes.Dominio.ModuloMatéria;
using GestãoTestes.Dominio.ModuloQuestões;
using GestãoTestes.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTestes.Infra.Compartilhado
{
    public class DataContext
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Disciplinas = new List<Disciplinas>();

            Matérias = new List<Materia>();

            Questões = new List<Questão>();

            Testes= new List<Testes>();
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Disciplinas> Disciplinas { get; set; }

        public List<Materia> Matérias { get; set; }

        public List<Questão> Questões { get; set; }

        public List<Testes> Testes { get; set; }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);
            if(ctx.Matérias.Any())
                this.Matérias.AddRange(ctx.Matérias);
            if (ctx.Questões.Any())
                this.Questões.AddRange(ctx.Questões);
            if (ctx.Testes.Any())
                this.Testes.AddRange(ctx.Testes);


        }
    }
}
