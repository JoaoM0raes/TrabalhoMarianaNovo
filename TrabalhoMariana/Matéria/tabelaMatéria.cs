using GestãoTeste.Compartilhado;
using GestãoTestes.Dominio.ModuloMatéria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestãoTeste.Matéria
{
    public partial class tabelaMatéria : UserControl
    {
       
        public tabelaMatéria()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},
                 new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Serie"},
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Materia> Matérias)
        {
            grid.Rows.Clear();

            foreach (Materia matéria in Matérias)
            {
                grid.Rows.Add(matéria.Numero, matéria.Nome,matéria.Disciplina,matéria.Serie);
            }
        }
        public int ObtemNumeroMateriaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }
    }
}
