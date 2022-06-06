public class ProxyVideo : Video
{
    private RealVideo realVideo;
    private string fileName;

    public ProxyVideo(string fileName)
    {
        this.fileName = fileName;
    }
    public void Display()
    {
        if (realVideo == null)
        {
            realVideo = new RealVideo(fileName);
        }
        realVideo.Display();
    }
}