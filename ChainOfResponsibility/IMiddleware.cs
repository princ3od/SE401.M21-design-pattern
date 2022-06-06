
namespace ChainOfResponsibility
{
    public interface IMiddleware
    {
        public IMiddleware Next { get; set; }

        public void Invoke(object param);
    }
}