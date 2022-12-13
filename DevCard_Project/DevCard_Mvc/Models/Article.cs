﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Article(long id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }
    }
}
