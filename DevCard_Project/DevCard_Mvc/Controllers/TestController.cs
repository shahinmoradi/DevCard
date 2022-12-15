using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_Mvc.Controllers
{
    public class TestController : Controller
    {
        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}
        //public ContentResult Index()
        //{
        //    return Content("<h1 style='color:red;'>shahin moradi ax </h1><script>confirm('سوال دارید بپرسید ')</script>", contentType: "text/html");
        //}

        //public FileResult Index()
        //{
        //    return File(virtualPath: "~/text.txt", contentType: "text/html");
        //}

        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes(path: "wwwroot/text.txt");
        //    const string fileName = "filename.txt";
        //    return File(fileByte, contentType: MediaTypeNames.Text.Plain, fileName);
        //}
        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id=12,
        //        name="shahin",
        //        age=12,
        //        family="moradi"

        //    });
        //}
        public javascriptresult Index()
        {
            return new javascriptresult("alert('salam shahin moradi darmarani')");
        }
    }

    public class javascriptresult : ContentResult
    {
        public javascriptresult(string data)
        {
            Content = data;
            ContentType = "application/javascript";
                    
        }
    }
}
