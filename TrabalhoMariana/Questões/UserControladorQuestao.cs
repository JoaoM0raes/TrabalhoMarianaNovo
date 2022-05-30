using GestãoTeste.Compartilhado;
using GestãoTestes.Dominio.ModuloQuestões;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTeste.Questões
{
    public partial class UserControladorQuestao : UserControl
    {
        public UserControladorQuestao()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia"},
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Questão> questoes)
        {
            grid.Rows.Clear();

            foreach (Questão questao in questoes)
            {
                grid.Rows.Add(questao.Numero, questao.Enunciado, questao.Materias);
            }
        }
        public int ObtemNumeroMateriaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }
    }
}
