using CoreBusness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class AddCategory : IAddCategory
    {
        private readonly ICatrogryRepository repository;

        public AddCategory(ICatrogryRepository repository)
        {
            this.repository = repository;
        }
        public async void Execute(Category category)
        {
            
            await Task.Run(() => repository.AddCategory(category));
        }
    }
}
