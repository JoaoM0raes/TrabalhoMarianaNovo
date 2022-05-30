using GestãoTeste.Compartilhado;

namespace GestãoTeste.Disciplina
{
    public class ConfiguracaoToolboxDisciplina : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Disciplinas";

        public override string TooltipInserir => "Inserir uma nova Disciplina";

        public override string TooltipEditar => "Editar uma Despesa Disciplina";

        public override string TooltipExcluir => "Excluir uma Despesa Disciplina";

        public override string TooltipPdf => "";
    }
}