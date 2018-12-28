using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF.Entities
{
    [Table("Uyeler")]
    public class Uye
    {
        [Key]
        public int UyeId { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]+$",ErrorMessage ="Uye ad girisi sadece harf ile yapilabilir")]
        [StringLength(20, ErrorMessage = "Uye adi 20 karakterden fazla olamaz")]
        public string UyeAd { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Uye soyad girisi sadece harf ile yapilabilir")]
        [StringLength(20, ErrorMessage = "Uye soyadi 20 karakterden fazla olamaz")]
        public string UyeSoyad { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "TCKN sadece sayilardan olusmalidir")]
        [StringLength(11, ErrorMessage = "TCKN 11 haneden fazla olamaz")]
        public string UyeTckn { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefon numarasi sadece sayilardan olusmalidir")]
        [StringLength(10, ErrorMessage = "Telefon numarasi 10 haneden fazla olamaz")]
        public string UyeTelefon { get; set; }

        [StringLength(30, ErrorMessage = "Email adresi 30 karakterden fazla olamaz")]
        [EmailAddress(ErrorMessage = "Gecersiz email adres girisi yapilmistir")]
        public string UyeEmail { get; set; }

        public virtual ICollection<Kira> Kiralar { get; set; } = new HashSet<Kira>();
    }
}
