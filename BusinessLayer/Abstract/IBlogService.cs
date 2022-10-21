using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();

        List<Blog> GetBlogListByWriter(int id);
        List<Blog> GetBlogListByWriterExceptOneBlog(int writerID,int blogID);
    }
}