using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTestes.Dominio.ModuloQuestões
{
    public class Respostas
    {
        public string Resposta { get; set; }
        public bool Correta { get; set; }
        public override string ToString()
        {
            return $"{Resposta}";
        }
    }
}
