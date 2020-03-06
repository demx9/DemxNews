﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RNN.Models.ViewModels.ViewComponents
{
    public class HorizontalLargeBlockViewComponent : ViewComponent
    {
        public string Slug { get; set; }
        //public string Title { get; set; }
        public string HeadLine { get; set; }
        public string Url { get; set; }
        public string Paragraph { get; set; }
        public string Img { get; set; }
        //public string Author { get; set; }
        public string Topic { get; set; }
        public bool HasBorder { get; set; }

        public static HorizontalLargeBlockViewComponent ToViewModel(Entry model, bool hasBorder)
        {
            return new HorizontalLargeBlockViewComponent()
            {
                Slug = model.Slug,
                Url = model.Url,
                HeadLine = model.HeadLine,
                Paragraph = model.Paragraph,
                Img = model.Img,
                Topic = model.EntryToTopics.Any() ? model.EntryToTopics.First(et => et.IsPrimary).Topic.Name : null,
                HasBorder = hasBorder
            };
        }

        public async Task<IViewComponentResult> InvokeAsync(HorizontalLargeBlockViewComponent component)
        {
            return View(component);
        }
    }
}
