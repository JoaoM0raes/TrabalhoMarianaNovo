using GestãoTeste.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTeste.Teste
{
    public class ConfiguracaoToolBoxTeste : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro Teste";

        public override string TooltipInserir => "Inserir Teste";

        public override string TooltipEditar => " Editar Teste";

        public override string TooltipExcluir => " Excluir Teste";

        public override string TooltipPdf => " Pegar pdf";

        public override bool AdicionarItensPdf { get { return true; } }
    }
}
