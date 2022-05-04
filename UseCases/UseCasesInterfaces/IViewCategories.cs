using CoreBusness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewCategories
    {
        
        IAsyncEnumerable<Category> Execute();
    }
}