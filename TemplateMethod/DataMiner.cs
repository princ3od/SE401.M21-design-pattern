using System;
abstract class DataMiner
{
    string file;
    public string File { get => file; set => file = value; }

    string rawData;
    public string RawData { get => rawData; set => rawData = value; }

    public virtual void OpenFile(string path)
    {
        Console.WriteLine("Open " + path);
    }
    public virtual void CloseFile()
    {
        Console.WriteLine("Close file\n");
    }
    public abstract void ExtractData();
    public abstract void ParseData();

    public void mine(string path)
    {
        OpenFile(path);
        ExtractData();
        ParseData();
        CloseFile();
    }

}
