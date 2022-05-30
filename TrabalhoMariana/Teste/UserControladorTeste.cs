using GestãoTeste.Compartilhado;
using GestãoTestes.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTeste.Teste
{
    public partial class UserControladorTeste : UserControl
    {
        public UserControladorTeste()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplinas", HeaderText = "Disciplinas"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Qtd Questões", HeaderText = "Qtd Questões"},
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Testes> Testes)
        {
            grid.Rows.Clear();

            foreach (Testes testes in Testes)
            {
                grid.Rows.Add(testes.Numero, testes.DataCriação,testes.Nome,testes.Disciplinas,testes.Materias,testes.Quantidade);
            }
        }
        public int ObtemNumeroTesteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }
    }
}
