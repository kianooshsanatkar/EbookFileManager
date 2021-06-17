using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entity
{
    class EBook
    {
        //Type
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }
        public int Size { get; set; }
        public string Path { get; set; }
        public string Publisher { get; set; }
        public string Writer { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public Uri GoodReadLink { get; set; }
        public byte[] Image { get; set; }
    }
}
