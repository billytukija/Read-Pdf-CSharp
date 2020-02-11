using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;

namespace readPdf
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = "your dir";

            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            
            reader.Close();
            
            Console.WriteLine("Hello World!");
        }
    }
}
