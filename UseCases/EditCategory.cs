using CoreBusness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class EditCategory : IEditCategory
    {
        private readonly ICatrogryRepository rpository;

        public EditCategory(ICatrogryRepository rpository)
        {
            this.rpository = rpository;
        }
        public void Execute(Category category)
        {
            rpository.UpdateCategory(category);
        }
    }
}
