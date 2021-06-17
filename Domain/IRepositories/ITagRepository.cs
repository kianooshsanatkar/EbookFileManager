﻿using Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.IRepositories
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTags();
        void AddTags(Tag tag);
    }
}
