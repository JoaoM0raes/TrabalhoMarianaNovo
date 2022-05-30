using FluentValidation.Results;
using GestãoTestes.Dominio.ModuloDisciplina;
using GestãoTestes.Dominio.ModuloMatéria;
using GestãoTestes.Dominio.ModuloQuestões;
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

namespace GestãoTeste.Teste
{
    public partial class AdicionarTeste : Form
    {
        private Testes teste;
        private List<Questão> questoes = new List<Questão>();
        private List<Questão> questoesAleatorioas =new List<Questão>();

        public AdicionarTeste(List<Materia> materias, List<Disciplinas> disciplinas,List<Questão>questões)
        {
            InitializeComponent();
            AtualizarDisciplinas(disciplinas);
        }
        private void AtualizarDisciplinas(List<Disciplinas> disciplinas)
        {
            comboDisciplina.Items.Clear();
            foreach (var item in disciplinas)
            {
                comboDisciplina.Items.Add(item);
            }
        }
        public Func<Testes, ValidationResult> GravarRegistro { get; set; }

        public Testes Teste
        {
            get { return teste; }
            set
            {
                this.teste = value;
            }
        }

        

        private void comboDisciplina_SelectedValueChanged(object sender, EventArgs e)
        {
            Disciplinas disciplinaSelecionada = (Disciplinas)comboDisciplina.SelectedItem;
            foreach (var item in disciplinaSelecionada.Materias)
            {
                comboMateria.Items.Add(item);
            }
        }

        private void comboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia)comboMateria.SelectedItem;
            questoes = materia.questoes;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            listQuestões.Items.Clear();
            Random rd=new Random();
            int numero=Convert.ToInt32(textQuantidade.Text);
            for (int i = 0; i <numero; i++)
            {
                questoesAleatorioas.Add(questoes[rd.Next(questoes.Count)]);
            }
            foreach (var item in questoesAleatorioas)
            {
                listQuestões.Items.Add(item);
            }
          
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Disciplinas disciplina = (Disciplinas)comboDisciplina.SelectedItem;
            Materia materia= (Materia)comboMateria.SelectedItem;
            teste.Nome=textTitulo.Text;
            teste.Questãos = questoesAleatorioas;
            teste.Quantidade = questoesAleatorioas.Count;
            teste.Disciplinas=disciplina;
            teste.Materias=materia;
            var resultadoValidacao = GravarRegistro(Teste);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;
                DialogResult = DialogResult.None;
            }

        }
    }
}
