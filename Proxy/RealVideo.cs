
using System;
public class RealVideo : Video
{

    private string _fileName;

    public RealVideo(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk(_fileName);
    }

    public void Display()
    {
        Console.WriteLine("> Displaying " + _fileName);
    }

    private void LoadFromDisk(string fileName)
    {
        Console.WriteLine(">> Loading " + fileName);
    }
}