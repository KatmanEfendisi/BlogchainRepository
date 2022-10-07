using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        private BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke(int id)
        {
            //Context c = new Context();

            //var writerID = c.Blogs.Where(x=>x.BlogID == id).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetBlogListByWriter(id);
            return View(values);
        }
    }
}