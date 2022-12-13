using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(id:1, title:"عنوان بهترین مقاله ",description:"خیلی عالی و کامل بود ",image:"blog-post-thumb-card-1.jpg"),

                new Article(id:2, title:"عنوان بهترین مقاله ",description:"خیلی عالی و کامل بود ",image:"blog-post-thumb-card-2.jpg"),

                new Article(id:3, title:"عنوان بهترین مقاله ",description:"خیلی عالی و کامل بود ",image:"blog-post-thumb-card-3.jpg"),

                new Article(id:4, title:"عنوان بهترین مقاله ",description:"خیلی عالی و کامل بود ",image:"blog-post-thumb-card-4.jpg")




            };
            return View("_LatestArticles",articles);
        }
    }
}
