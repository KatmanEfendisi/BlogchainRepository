using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);

        //void CommentyDelete(Category category);
        // void CommentUpdate(Category category);
        List<Comment> GetList(int id);

        // Comment GetById(int id);
    }
}