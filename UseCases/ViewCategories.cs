using CoreBusness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewCategories : IViewCategories
    {
        private readonly ICatrogryRepository categoryRepositroy;

        public ViewCategories(ICatrogryRepository categoryRepositroy)
        {
            this.categoryRepositroy = categoryRepositroy;
        }
        public async IAsyncEnumerable<Category> Execute()
        {
            foreach (var c in categoryRepositroy.GetCategories())
            {
                yield return c;
            }
        }
        
    }
}
