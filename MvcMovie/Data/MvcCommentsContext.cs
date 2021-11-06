using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcCommentsContext:DbContext
    {
        public MvcCommentsContext(DbContextOptions<MvcCommentsContext> options)
            : base(options)
        {
        }

        public DbSet<Comments> Comments { get; set; }
    }
}
