using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab11movies
{
    class Movie
    {
        //public string GetTitle { get; set; }

        //public string GetCategory { get; set; }

        //private string Title()
        //{
        //    return "In theory this is a title";
        //}

        //private string Category()
        //{
        //    return "In theory this is a Cate";
        //}

        public Movie(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }

        private string Title;
        private string Genre;

        public string GetTitle()
        {
            return Title;
        }

        public string GetGenre()
        {
            return Genre;
        }
    }
}
