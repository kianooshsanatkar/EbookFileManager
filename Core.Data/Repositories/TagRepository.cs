using Core.Data.Context;
using Core.Domain.Entity;
using Core.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    class TagRepository : ITagRepository
    {
        private readonly EBookDbContext _ctx;
        public TagRepository(EBookDbContext ctx)
        {
            _ctx = ctx;
        }

        public void AddTags(Tag tag)
        {
            _ctx.Tags.Add(tag);
        }

        public IEnumerable<Tag> GetTags()
        {
            return _ctx.Tags;
        }
    }
}
