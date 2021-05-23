using BloggingPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggingPlatform.Core.Interfaces
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTags();
        Tag GetTagByTitle(string title);
    }
}
