using GestãoTeste.Compartilhado;
using GestãoTeste.Disciplina;
using GestaoTeste.Matéria;
using GestãoTestes.Dominio.ModuloMatéria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestãoTeste.Matéria
{
    public class ControladorMatéria:ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private tabelaMatéria tabelaMaterias;
        private IRepositorioMateria repositorioMateria;

        public ControladorMatéria(IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria)
        {
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
        }
        public override void Editar()
        {
            Materia materia = ObtemMateriaSelecionada();
            if (materia == null)
            {
                MessageBox.Show("Selecione uma Materia primeiro",
                "Edição de Materias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            cadastroMateria cadastro = new cadastroMateria(repositorioDisciplina.SelecionarTodos());
            cadastro.Materia = materia; 
            cadastro.GravarRegistro = repositorioMateria.Editar;
            DialogResult dialogResult = cadastro.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Excluir()
        {
            Materia MateriaSelecionada = ObtemMateriaSelecionada();


            repositorioMateria.Excluir(MateriaSelecionada);
            CarregarMaterias();

        }

        public override void Inserir()
        {
            cadastroMateria cadastro = new cadastroMateria(repositorioDisciplina.SelecionarTodos());
            cadastro.Materia = new Materia();

            cadastro.GravarRegistro = repositorioMateria.Inserir;

            DialogResult resultado = cadastro.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        private void CarregarMaterias()
        {
            List<Materia> Materias = repositorioMateria.SelecionarTodos();

            tabelaMaterias.AtualizarRegistros(Materias);
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxMateria();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaMaterias == null)
                tabelaMaterias = new tabelaMatéria();

            CarregarMaterias();

            return tabelaMaterias;
        }
        private Materia ObtemMateriaSelecionada()
        {
            var numero = tabelaMaterias.ObtemNumeroMateriaSelecionado();

            return repositorioMateria.SelecionarPorNumero(numero);
        }
    }
}
