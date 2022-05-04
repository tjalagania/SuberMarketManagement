using CoreBusness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICatrogryRepository
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        Category GetCategory(int id);
        void UpdateCategory(Category category);
    }
}
