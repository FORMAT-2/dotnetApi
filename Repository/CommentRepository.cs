using api.Data;
using api.Interfaces;
using api.Models;


namespace api.Repository
{
    public class CommentRepository : ICommentRepository
    {
         private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context){
            _context = context;
        }
        public Task<List<Comment>> GetAllAsync()
        {
            throw new NotSupportedException();
        }
    }
}