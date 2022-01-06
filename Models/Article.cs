using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace securitypractice.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        [DisplayName("Post Content")]
        public string? ArticleBody { get; set; }

        public string? Author { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Created { get; set; } = DateTime.Now;
    }
}
