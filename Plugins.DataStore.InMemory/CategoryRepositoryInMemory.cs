using CoreBusness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryRepositoryInMemory : ICatrogryRepository
    {
        private List<Category> _categoryes;
        public CategoryRepositoryInMemory()
        {
            _categoryes = new List<Category>()
            {
                new Category() { CategoryId = 1, Name = "Beverage", Description = "Beverage Desck" },
                new Category() { CategoryId = 2, Name = "Bakery", Description = "Bakery Desk" },
                new Category() { CategoryId = 3, Name = "Meat", Description = "Meat Desk" }
            };
        }

        public void AddCategory(Category category)
        {
            if (_categoryes.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;

            var maxId = _categoryes.Max(x => x.CategoryId);
            category.CategoryId = ++maxId;
            _categoryes.Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            foreach (var c in _categoryes)
                yield return c;
        }

        public Category GetCategory(int id)
        {
            return _categoryes.FirstOrDefault(x => x.CategoryId == id);
        }

        public async void UpdateCategory(Category category)
        {
            var ct = await Task.Run(()=> _categoryes.FirstOrDefault(x => x.CategoryId == category.CategoryId));
            if (ct != null)
                ct = category;
        }
    }
}
