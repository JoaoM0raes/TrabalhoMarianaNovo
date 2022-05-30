using GestãoTeste.Compartilhado;
using GestãoTeste.Disciplina;
using GestaoTeste.Questões;
using GestãoTeste.Teste;
using GestãoTestes.Dominio.ModuloMatéria;
using GestaoTestes.Dominio.ModuloQuestões;
using GestãoTestes.Dominio.ModuloTeste;
using GestaoTestes.Dominio.ModuloTeste;
using GestaoTestes.Infra.Compartilhado.Serializadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTeste.Teste
{
    public class ControladorTeste : ControladorBase
    {

        private IrepositorioQuestao repositorioQuestao;
        private UserControladorTeste controladorTeste;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;
        private IrepositorioTeste repositorioTeste;
        private SerializadorEmPdf serializadorPdf; 

        public ControladorTeste(IrepositorioQuestao repositorioQuestao,  IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IrepositorioTeste repositorioTeste)
        {
            this.serializadorPdf=new SerializadorEmPdf();
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioTeste = repositorioTeste;
        }

        public override void Editar()
        {
            Testes Teste = ObtemTesteSelecionada();
            if (Teste == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Edição de Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AdicionarTeste cadastro = new AdicionarTeste(repositorioMateria.SelecionarTodos(), repositorioDisciplina.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            cadastro.Teste = Teste;

            cadastro.GravarRegistro = repositorioTeste.Editar;

            DialogResult resultado = cadastro.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }

        public override void Excluir()
        {
            Testes Teste = ObtemTesteSelecionada();
            if (Teste == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Excluir Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            repositorioTeste.Excluir(Teste);
            CarregarTestes();
        }

        public override void Inserir()
        {
            AdicionarTeste cadastro = new AdicionarTeste(repositorioMateria.SelecionarTodos(), repositorioDisciplina.SelecionarTodos(),repositorioQuestao.SelecionarTodos());
            cadastro.Teste = new Testes();

            cadastro.GravarRegistro = repositorioTeste.Inserir;

            DialogResult resultado = cadastro.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }
        public override void InserirPdf()
        {
            Testes Teste = ObtemTesteSelecionada();
            if(Teste == null)
            {
                MessageBox.Show("Favor selecionar um teste primeiro",
                "Criação De Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            serializadorPdf.CriarDocumentoPdf(Teste);
        }
        private void CarregarTestes()
        {
            List<Testes> Teste = repositorioTeste.SelecionarTodos();

            controladorTeste.AtualizarRegistros(Teste);
        }
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxTeste();
        }

        public override UserControl ObtemListagem()
        {
            if (controladorTeste == null)
                controladorTeste = new UserControladorTeste();

            CarregarTestes();

            return controladorTeste; 
        }
        private Testes ObtemTesteSelecionada()
        {
            var numero = controladorTeste.ObtemNumeroTesteSelecionado();

            return repositorioTeste.SelecionarPorNumero(numero);
        }
    }
}
