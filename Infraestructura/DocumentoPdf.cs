using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(IList<Persona> personas,string path)
        {
           
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion PracticaBD");
            document.Open();
            Paragraph parrafo = new Paragraph("Informe De Personas Registradas");
            parrafo.Alignment = Element.ALIGN_JUSTIFIED;
            document.Add(parrafo);
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(personas));
            document.Close();
        }


        private PdfPTable LlenarTabla(IList<Persona> Personas)
        {
            PdfPTable tabla = new PdfPTable(4);
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Identificacion"));
            tabla.AddCell(new Paragraph("Sexo"));
            tabla.AddCell(new Paragraph("Correo"));
            foreach (var item in Personas)
            {
                tabla.AddCell(new Paragraph(item.Nombre));
                tabla.AddCell(new Paragraph(item.Identificacion));
                tabla.AddCell(new Paragraph(item.Sexo));
                tabla.AddCell(new Paragraph(item.Email));

            }
            return tabla;
        }

    }
}
