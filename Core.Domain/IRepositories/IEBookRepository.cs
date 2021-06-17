using Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.IRepositories
{
    public interface IEBookRepository
    {
        IEnumerable<EBook> GetEBooks();
        EBook GetEBook(int id);
        void AddEbook(EBook eBook);
        void AddEBooks(IEnumerable<EBook> eBooks);
        void UpdateEbook(EBook ebook);
    }
}
