using System.Threading.Tasks;
using GreenPipes.Util;

namespace WebAppMassTransitDI
{
    public class Service :
        IService
    {
        public Task ServiceTheThing(string value)
        {
            return TaskUtil.Completed;
        }
    }
}