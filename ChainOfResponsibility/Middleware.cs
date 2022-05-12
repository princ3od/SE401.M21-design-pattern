using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Middleware
    {
        IMiddleware first;
        IMiddleware last;

        public void Use(IMiddleware middleware)
        {
            if (first == null)
            {
                first = middleware;
            }
            else
            {
                last.Next = middleware;
            }
            last = middleware;
        }

        public void Invoke(object param)
        {
            first.Invoke(param);
        }
    }
}