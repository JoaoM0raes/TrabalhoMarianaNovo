using FluentValidation.Results;
using GestãoTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoMariana;

namespace GestãoTeste.Disciplina
{ 
    public partial class CadastroDisciplina : Form
    {
        private Disciplinas disciplina;
        public CadastroDisciplina()
        {
            InitializeComponent();
        }
        public Disciplinas Disciplina
        {
            get
            {
                return disciplina;
            }
            set
            {
                disciplina = value;
                textNome.Text = disciplina.Nome;
            }
        }
        public Func<Disciplinas, ValidationResult> GravarRegistro { get; set; }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Disciplina.Nome = textNome.Text;

            var resultadoValidacao = GravarRegistro(Disciplina);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;
                DialogResult = DialogResult.None;
            }
        }
    }
}
