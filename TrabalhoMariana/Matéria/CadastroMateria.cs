using GestãoTestes.Dominio.ModuloDisciplina;
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
using FluentValidation.Results;

namespace GestãoTeste.Matéria
{
    public partial class cadastroMateria : Form
    {
        private Materia materia;
        public cadastroMateria(List<Disciplinas> disciplinas)
        {
            InitializeComponent();
            atualizarDisciplinas(disciplinas);
        }
        public void atualizarDisciplinas(List<Disciplinas> disciplinas)
        {
            comboDisciplina.Items.Clear();
            foreach (var item in disciplinas)
            {
               comboDisciplina.Items.Add(item);
            }
        }
        public Func<Materia, ValidationResult> GravarRegistro { get; set; }
        public Materia Materia
        {
            get { return materia; }
            set
            {
                this.materia = value;
                
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            materia.Nome = textBoxName.Text;
            if (checkPrimeiraSerie.Checked)
            {
                materia.Serie = 1;
            }else if (checkSegundaSerie.Checked)
            {
                materia.Serie = 2;
            }

            materia.Disciplina = (Disciplinas)comboDisciplina.SelectedItem;

            var resultadoValidacao = GravarRegistro(Materia);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;
                DialogResult = DialogResult.None;
            }

        }
    }
}
