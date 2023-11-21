using BlogApplicationWebAPI.Database;
using BlogApplicationWebAPI.Entitys;

namespace BlogApplicationWebAPI.Services
{
    public class CommentService : ICommentService
    {
        private readonly BlogContext Context = null;
        public CommentService(BlogContext context)
        {
            Context = context;  
        }

        public void AddComment(Comment comment)
        {
            try
            {
                Context.Comments.Add(comment);
                Context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void  DeleteComment(int commentId)
        {
            try
            {
                var commentToDelete = Context.Comments.SingleOrDefault(c => c.Id == commentId);
                if (commentToDelete != null)
                {
                    Context.Comments.Remove(commentToDelete);
                    Context.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public List<Comment> GetComment()
        {
            try
            {
                var res = Context.Comments.ToList();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Comment GetCommentById(int commentId)
        {
            try
            {
                var res = Context.Comments.Find(commentId);
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        public void UpdateComment(Comment comment)
        {
            try
            {
                if (comment != null)
                {
                    Context.Comments.Update(comment);
                    Context.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
