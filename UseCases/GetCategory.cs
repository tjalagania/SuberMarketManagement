using CoreBusness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetCategory : IGetCategory
    {
        private readonly ICatrogryRepository repository;

        public GetCategory(ICatrogryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Category> Execute(int id)
        {
            return await Task.Run(() => repository.GetCategory(id));
        }
    }
}
