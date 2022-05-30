using GestãoTeste.Compartilhado;
using GestãoTeste.Disciplina;
using GestãoTeste.Questões;
using GestãoTestes.Dominio.ModuloMatéria;
using GestaoTestes.Dominio.ModuloQuestões;
using GestãoTestes.Dominio.ModuloQuestões;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTeste.Questões
{
    public class ControladorQuestao : ControladorBase
    {
        private IrepositorioQuestao repositorioQuestao;
        private UserControladorQuestao UserControladorQuestao;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorQuestao(IRepositorioMateria repositorioMateria, IrepositorioQuestao repositorioQuestao, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }
        public override void Editar()
        {
            Questão questao = ObtemQuestãoSelecionada();
            if (questao == null)
            {
                MessageBox.Show("Selecione uma Questão primeiro",
                "Edição de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CadastroQuestão cadastro = new CadastroQuestão(repositorioMateria.SelecionarTodos(), repositorioDisciplina.SelecionarTodos());
            cadastro.Questao = questao;
            cadastro.GravarRegistro = repositorioQuestao.Editar;
            DialogResult dialogResult = cadastro.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override void Excluir()
        {
            Questão questao = ObtemQuestãoSelecionada();
            if (questao == null)
            {
                MessageBox.Show("Selecione uma Questão primeiro",
                "Excluir Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            repositorioQuestao.Excluir(questao);
            CarregarQuestoes();

        }

        public override void Inserir()
        {
            CadastroQuestão cadastro = new CadastroQuestão(repositorioMateria.SelecionarTodos(), repositorioDisciplina.SelecionarTodos());
            cadastro.Questao = new Questão();

            cadastro.GravarRegistro = repositorioQuestao.Inserir;

            DialogResult resultado = cadastro.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        private void CarregarQuestoes()
        {
            List<Questão> Questoes = repositorioQuestao.SelecionarTodos();

            UserControladorQuestao.AtualizarRegistros(Questoes);
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxQuestao();
        }

        public override UserControl ObtemListagem()
        {
            if (UserControladorQuestao == null)
                UserControladorQuestao = new UserControladorQuestao();

            CarregarQuestoes();

            return UserControladorQuestao;
        }
        private Questão ObtemQuestãoSelecionada()
        {
            var numero = UserControladorQuestao.ObtemNumeroMateriaSelecionado();

            return repositorioQuestao.SelecionarPorNumero(numero);
        }
    }
}
