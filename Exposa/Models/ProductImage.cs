using System.ComponentModel.DataAnnotations;

namespace Exposa.Models
{
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }
        
        public string ImageName { get; set; } =string.Empty;
        public int ProductId { get; set; }


    }
}
