using GestãoTestes.Dominio;
using GestãoTestes.Dominio.ModuloTeste;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace GestaoTestes.Infra.Compartilhado.Serializadores
{
    public class SerializadorEmPdf  
    {
        private const string Arquivo = @"C:/testes.pdf";

        public void CriarDocumentoPdf(Testes Testes)
        {
            FileStream arquivoPdf = new FileStream(Arquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritor = PdfWriter.GetInstance(doc, arquivoPdf);

            string registros = "";
            doc.Open();

            var fonte = new iTextSharp.text.Font((Font.FontFamily)iTextSharp.text.Font.BOLD, 25);
            var fontePergunta = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20);
            var fonteResposta = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16);
            var titulo = new Paragraph($"Teste Criado Em: {DateTime.Now.ToShortDateString()} \n\n", fonte);

            var Segundotitulo = new Paragraph($"{Testes.Nome} \n\n", fonte);
            titulo.Alignment = Element.ALIGN_CENTER;
            Segundotitulo.Alignment = Element.ALIGN_CENTER;

            doc.Add(titulo);
            doc.Add(Segundotitulo);
            foreach(var item in Testes.Questãos)
            {
                Paragraph novo = new Paragraph($"{item.Numero}){item.Enunciado}\n",fonte);
                novo.Alignment = Element.ALIGN_LEFT;
                doc.Add(novo);
                foreach (var itens in item.Respostas)
                {
                    Paragraph respostas = new Paragraph($"{itens}\n", fonteResposta);
                    doc.Add(respostas);
                }
            }
              doc.Close();



        }
    }
}
