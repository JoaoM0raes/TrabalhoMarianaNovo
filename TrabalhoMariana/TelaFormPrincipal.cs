using GestãoTeste.Compartilhado;
using GestãoTeste.Disciplina;
using GestãoTeste.Matéria;
using GestaoTeste.Questões;
using GestaoTeste.Teste;
using GestãoTestes.Infra.Compartilhado;
using GestaoTestes.Infra.Infra_Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMariana
{
    public partial class TelaFormPrincipal : Form
    {

        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;
        public TelaFormPrincipal(DataContext contextoDados)
        {
            InitializeComponent();
            


            Instancia = this;

            this.contextoDados = contextoDados;

            InicializarControladores();
        }
        public static TelaFormPrincipal Instancia
        {
            get;
            private set;
        }
        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void matériaMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void questõesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
            toolTipPdf.Enabled = configuracao.AdicionarItensPdf;
            
       
        }
        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
            toolTipPdf.ToolTipText = configuracao.TooltipPdf;
         
           
        }
        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
               toolBox1.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }
        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }
        private void ConfigurarListagem()
        {
           

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock= DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }
        private void InicializarControladores()
        {
            var repositorioDisciplina = new RepositorioDisiciplinaBancoDeDados();
            var repositorioMatéria = new RepositorioMatériaEmArquivo(contextoDados);
            var repositorioQuestao = new RepositorioQuestaoEmArquivo(contextoDados);
            var repositorioTeste = new RepositorioTesteEmArquivo(contextoDados);

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Disciplinas", new ControladorDisciplina(repositorioDisciplina));
            controladores.Add("Matéria", new ControladorMatéria(repositorioDisciplina,repositorioMatéria));
            controladores.Add("Questões", new ControladorQuestao( repositorioMatéria, repositorioQuestao, repositorioDisciplina));
            controladores.Add("Testes ", new ControladorTeste( repositorioQuestao, repositorioMatéria, repositorioDisciplina, repositorioTeste));

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void toolTipPdf_Click(object sender, EventArgs e)
        {
            controlador.InserirPdf();
        }
    }
}
