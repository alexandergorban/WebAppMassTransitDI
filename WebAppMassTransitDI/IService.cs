using System.Threading.Tasks;

namespace WebAppMassTransitDI
{
    public interface IService
    {
        Task ServiceTheThing(string value);
    }
}