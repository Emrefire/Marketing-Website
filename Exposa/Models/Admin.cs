using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exposa.Models
{
    public class Admin
    {
            [Key]
            public int AdminId { get; set; }
            [DisplayName("Kullanıcı Adı")]
            [Required(ErrorMessage ="Bu alan boş bırakılamaz!")]
            [MinLength(8,ErrorMessage ="8 karakterden az olamaz")]
            public string AdminName { get; set; }
              [DisplayName("Şifre")]
            [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
            public string AdminPass { get; set; }
          
    }
}
 