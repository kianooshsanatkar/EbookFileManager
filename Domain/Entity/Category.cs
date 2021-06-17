using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entity
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Parent { get; set; }
        public IEnumerable<EBook> EBooks { get; set; }
    }
}
