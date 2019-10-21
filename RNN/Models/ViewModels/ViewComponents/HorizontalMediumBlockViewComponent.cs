﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RNN.Models.ViewModels.ViewComponents
{
    public class HorizontalMediumBlockViewComponent : ViewComponent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string HeadLine { get; set; }
        public string Url { get; set; }
        public string Img { get; set; }
        public string Author { get; set; }
        public string Topic { get; set; }

        public static HorizontalMediumBlockViewComponent ToViewModel(Article model)
        {
            return new HorizontalMediumBlockViewComponent()
            {
                Url = model.Url,
                Title = model.Title.Name,
                HeadLine = model.HeadLine,
                Author = model.Author.Name,
                Img = model.Img,
                Topic = model.ArticleToTopics?.First().Topic.Name
            };
        }

        public async Task<IViewComponentResult> InvokeAsync(HorizontalMediumBlockViewComponent component)
        {
            return View(component);
        }
    }
}
