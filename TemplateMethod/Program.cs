using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PDFDataMiner pdfDataMiner = new PDFDataMiner();
            pdfDataMiner.mine("pdf path");

            CSVDataMiner csvDataMiner = new CSVDataMiner();
            csvDataMiner.mine("csv path");
        }
    }
}
