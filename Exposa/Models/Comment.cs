using System.ComponentModel.DataAnnotations;

namespace Exposa.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }

        public string Message { get; set; }

        public int ProductId { get; set; }
        
        public Product? Product { get; set; }
    }
}
