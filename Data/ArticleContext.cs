using Microsoft.EntityFrameworkCore;
using securitypractice.Models;

namespace securitypractice.Data
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) : base (options)
        {
          /*  //resolves the null warning on the constructor. The exclamation point tells the compiler I know what I'm doing.'
            Articles = null!;*/
        }

        public DbSet<Article> Articles { get; set; }
    }
}
