using System;

class PDFDataMiner : DataMiner
{
    public override void OpenFile(string path)
    {
        base.OpenFile(path);
        this.File = "PDF";
    }
    public override void ExtractData()
    {
        Console.WriteLine("Extract " + this.File);
        this.RawData = "PDF";
    }

    public override void ParseData()
    {
        Console.WriteLine("Parse " + this.RawData);
    }
}