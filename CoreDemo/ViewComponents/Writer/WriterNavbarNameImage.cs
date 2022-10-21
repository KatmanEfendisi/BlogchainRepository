using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNavbarNameImage:ViewComponent
    {
        WriterManager writermanager = new WriterManager(new EfWriterRepository());

        Context c = new Context(); public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;

            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = writermanager.GetWriterById(writerID);
            return View(values);
        }
    }
}
