using GestãoTeste.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTeste.Questões
{
    public class ConfiguracaoToolboxQuestao : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro Questão";

        public override string TooltipInserir => "Inserir Nova Questão";

        public override string TooltipEditar => "Editar Questão";

        public override string TooltipExcluir => "Excluir Questão";

        public override string TooltipPdf => "";
    }
}
