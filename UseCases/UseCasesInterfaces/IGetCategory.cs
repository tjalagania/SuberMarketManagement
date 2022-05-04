using CoreBusness;
using System.Threading.Tasks;

namespace UseCases
{
    public interface IGetCategory
    {
        Task<Category> Execute(int id);
    }
}