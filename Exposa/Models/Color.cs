using System.ComponentModel.DataAnnotations;

namespace Exposa.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public List<ProductColor>? ProductColors
        {
            get; set;

        }
    }
}