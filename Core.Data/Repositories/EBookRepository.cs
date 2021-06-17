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
    class EBookRepository : IEBookRepository
    {
        private readonly EBookDbContext _ctx;
        public EBookRepository(EBookDbContext ctx)
        {
            _ctx = ctx;
        }
        public void AddEbook(EBook eBook)
        {
            _ctx.EBooks.Add(eBook);
        }

        public void AddEBooks(IEnumerable<EBook> eBooks)
        {
            _ctx.EBooks.AddRange(eBooks);
        }

        public EBook GetEBook(int id)
        {
            return _ctx.EBooks.Find(id);
        }

        public IEnumerable<EBook> GetEBooks()
        {
            return _ctx.EBooks;
        }

        public void UpdateEbook(EBook ebook)
        {
            var _ebook = _ctx.EBooks.Find(ebook.Id);
            _ctx.Entry(_ebook).CurrentValues.SetValues(ebook);
        }
    }
}
