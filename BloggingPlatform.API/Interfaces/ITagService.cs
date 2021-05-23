using BloggingPlatform.API.Models.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingPlatform.API.Interfaces
{
    public interface ITagService
    {
        TagDTO GetAllTags();
    }
}
