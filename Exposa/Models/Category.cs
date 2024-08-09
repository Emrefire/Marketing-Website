using System.ComponentModel.DataAnnotations;

namespace Exposa.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; } = string.Empty;
        public virtual List<SubCategory>? SubCategories { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
