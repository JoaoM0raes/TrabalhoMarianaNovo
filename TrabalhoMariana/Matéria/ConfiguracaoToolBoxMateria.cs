using GestãoTeste.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTeste.Matéria
{
    internal class ConfiguracaoToolBoxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro Materia";

        public override string TooltipInserir => "Inserir Materia";

        public override string TooltipEditar => "Editar Materia";

        public override string TooltipExcluir => "Exlcuir Materia";

        public override string TooltipPdf => "";
    }
}
