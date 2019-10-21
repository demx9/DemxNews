﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RNN.Models
{
    public class Article
    {
        public int Id { get; set; }
        public Title Title { get; set; }
        public int? TitleId { get; set; }
        public string HeadLine { get; set; }
        public string Url { get; set; }
        public string Paragraph { get; set; }
        public string Img { get; set; }
        public string Body { get; set; }
        public int? AuthorId { get; set; }
        public Author Author { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime Date { get; set; }

        public ICollection<ArticleToTopic> ArticleToTopics { get; set; }
    }
}
