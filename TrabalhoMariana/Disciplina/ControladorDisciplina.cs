using GestãoTeste.Compartilhado;
using GestãoTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestãoTeste.Disciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private DisciplinaControl tabelaDisciplinas;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }
        public override void Editar()
        {
            Disciplinas disciplina = ObtemDisciplinaSelecionada();
            if (disciplina == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Edição de disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
              CadastroDisciplina cadastro = new CadastroDisciplina();
            cadastro.Disciplina = disciplina;
            cadastro.GravarRegistro = repositorioDisciplina.Editar;
           DialogResult dialogResult = cadastro.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override void Excluir()
        {
            Disciplinas DisciplinaSelecionada = ObtemDisciplinaSelecionada();

            
                repositorioDisciplina.Excluir(DisciplinaSelecionada);
            CarregarDisciplinas();

        }

        public override void Inserir()
        {
           CadastroDisciplina cadastro =new CadastroDisciplina();
            cadastro.Disciplina = new Disciplinas();

            cadastro.GravarRegistro = repositorioDisciplina.Inserir;

            DialogResult resultado = cadastro.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }
        
        private void CarregarDisciplinas()
        {
            List<Disciplinas> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplinas.AtualizarRegistros(disciplinas);
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxDisciplina();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaDisciplinas == null)
                tabelaDisciplinas = new DisciplinaControl();

            CarregarDisciplinas();

            return tabelaDisciplinas;
        }
        private Disciplinas ObtemDisciplinaSelecionada()
        {
            var numero = tabelaDisciplinas.ObtemNumeroDisciplinaSelecionado();

            return repositorioDisciplina.SelecionarPorNumero(numero);
        }
    }
}
