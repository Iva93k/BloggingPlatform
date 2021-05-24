using BloggingPlatform.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BloggingPlatform.Infrastructure
{
    public static class SlugifyManager
    {
        //Removes all accents from the input string.  
        public static string RemoveAccents(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Normalize(NormalizationForm.FormD);
            char[] chars = text
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c)
                != UnicodeCategory.NonSpacingMark).ToArray();

            return new string(chars).Normalize(NormalizationForm.FormC);
        }

        // Turn a string into a slug by removing all accents,   
        // special characters, additional spaces, substituting   
        // spaces with hyphens & making it lower-case.  
        public static string Slugify(this string phrase)
        {
            // Remove all accents and make the string lower case.  
            string output = phrase.RemoveAccents().ToLower();

            // Remove all special characters from the string.  
            output = Regex.Replace(output, @"[^A-Za-z0-9\s-]", "");

            // Remove all additional spaces in favour of just one.  
            output = Regex.Replace(output, @"\s+", " ").Trim();

            // Replace all spaces with the hyphen.  
            output = Regex.Replace(output, @"\s", "-");

            // Return the slug.  
            return output;
        }

        //Increments given slug if it already exists
        public static string IncrementSlug(string slug, List<string> existingSlugs)
        {
            string original = slug;
            int count = 2;

            while (existingSlugs.Contains(slug))
            {
                slug = original + "-" + count;
                count++;
            }

            return slug;
        }
    }
}
