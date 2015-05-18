using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CommonUtils
{
    public static class PrintUtil
    {
        public static MemoryStream CreatePDF(string html, string css)
        {
            var msOutput = new MemoryStream();
            var htmlStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(html));
            var cssStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(css));

            // step 1: creation of a document-object
            var document = new Document();
            document.SetPageSize(PageSize.A4);

            // step 2:
            // we create a writer that listens to the document
            // and directs a XML-stream to a file
            PdfWriter writer = PdfWriter.GetInstance(document, msOutput);

            document.Open();

            // step 3: we create a worker parse the document
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, htmlStream, cssStream);

            document.Close();

            return msOutput;
        }
    }
}