using GestãoTeste.Compartilhado;
using GestãoTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestãoTeste.Disciplina
{
    public partial class DisciplinaControl : UserControl
    {
        public DisciplinaControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Numero"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText ="Nome"},
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Disciplinas> Disciplinas)
        {
            grid.Rows.Clear();

            foreach (Disciplinas Disciplina in Disciplinas)
            {
                grid.Rows.Add( Disciplina.Numero,Disciplina.Nome);
            }
        }
        public int ObtemNumeroDisciplinaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }
    }

}
