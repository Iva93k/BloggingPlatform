using BloggingPlatform.API.Interfaces;
using BloggingPlatform.API.Models.DTOModels;
using BloggingPlatform.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingPlatform.API.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public TagDTO GetAllTags()
        {
            var tags = _tagRepository.GetTags().ToList();

            TagDTO tagDTO = new TagDTO();
            List<string> list = new List<string>();

            foreach (var tag in tags)
            {
                list.Add(tag.Title);
            }

            tagDTO.Tags = list.ToArray();
            //string[] titlesOfTags = list.ToArray();
            //tagDTO.Tags = titlesOfTags;

            return tagDTO;
        }
    }
}
