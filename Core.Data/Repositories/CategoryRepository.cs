using Core.Data.Context;
using Core.Domain.Entity;
using Core.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EBookDbContext _ctx;
        public CategoryRepository(EBookDbContext ctx)
        {
            _ctx = ctx;
        }
        public void AddCategory(Category category)
        {
            _ctx.Categories.Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _ctx.Categories;
        }

        public void UpdateCategory(Category category)
        {
            var _category = _ctx.Categories.Find(category.Id);
            if (_category != null)
                _ctx.Entry(_category).CurrentValues.SetValues(category);
        }
    }
}
