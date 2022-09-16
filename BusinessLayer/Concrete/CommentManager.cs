using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentdal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return _commentdal.GetListAll(x => x.BlogID == id);
        }
    }
}