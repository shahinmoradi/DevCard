

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DevCard_Mvc.Models;

namespace DevCard_Mvc.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(id:1 , name:"پروژه اسنپ", description:"خیلی جامع و کامل بود ",image:"project-1.jpg",client:"shahin"),

                new Project(id:2 , name:"پروژه اسنپ", description:"خیلی جامع و کامل بود ",image:"project-2.jpg",client:"shahin"),

                new Project(id:3 , name:"پروژه اسنپ", description:"خیلی جامع و کامل بود ",image:"project-3.jpg",client:"shahin"),

                new Project(id:3 , name:"پروژه اسنپ", description:"خیلی جامع و کامل بود ",image:"project-4.jpg",client:"shahin"),

            };
            return View("_Project",projects);
        }
    }
}
