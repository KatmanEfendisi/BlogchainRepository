using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //ViewBag.v1 = bm.GetList().Count();
            Blog blog= c.Blogs.OrderByDescending(x=>x.BlogID).Take(1).FirstOrDefault();
            ViewBag.v2 = blog.BlogTitle;
            ViewBag.v3 = c.Writers.Where(x => x.WriterID == blog.WriterID).Select(x => x.WriterName).FirstOrDefault();
            //ViewBag.v3 = c.Comments.Count();
            return View();
        }
    }
}
