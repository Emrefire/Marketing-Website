using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exposa.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategory_Id { get; set; }
        [Display(Name = "Alt Kategori Adı")]
        public string SubCategory_Name { get; set; } = string.Empty;
        [Display(Name = "Kategori Adı")]
        [ForeignKey("Category")]

        public int Category_Id { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Product>? Product { get; set; }
    }
}