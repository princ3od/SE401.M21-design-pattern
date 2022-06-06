using System;

class CSVDataMiner : DataMiner
{
    public override void ExtractData()
    {
        Console.WriteLine("Extract CSV");
    }

    public override void ParseData()
    {
        Console.WriteLine("Parse CSV");
    }
}