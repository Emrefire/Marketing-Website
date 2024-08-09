using System.ComponentModel.DataAnnotations;

namespace Exposa.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        public String SizeName { get; set; }

        public List<ProductSize>? ProductSize { get; set; }
    }
}