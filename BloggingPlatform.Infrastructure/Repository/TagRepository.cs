using BloggingPlatform.Core.Entities;
using BloggingPlatform.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggingPlatform.Infrastructure.Repository
{
    public class TagRepository : ITagRepository
    {
        private readonly EFContext _efcontext;
        public TagRepository(EFContext efcontext)
        {
            _efcontext = efcontext;
        }

        public Tag GetTagByTitle(string title)
        {
            var tag = _efcontext.Tag.Where(t => t.Title == title).FirstOrDefault();
            return tag;
        }

        public IEnumerable<Tag> GetTags()
        {
            var tags = _efcontext.Tag.ToList();
            return tags;
        }
    }
}
