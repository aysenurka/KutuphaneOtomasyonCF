using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF.Entities
{
    [Table("Yazarlar")]
    public class Yazar
    {
        [Key]
        public int YazarId { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z]+$", ErrorMessage = "Yazar ad girisi sadece harf ile yapilabilir")]
        [StringLength(20,ErrorMessage = "Yazar adi 20 karakterden fazla olamaz")]
        public string YazarAd { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Yazar soyad girisi sadece harf ile yapilabilir")]
        [StringLength(20, ErrorMessage = "Yazar soyadi 20 karakterden fazla olamaz")]
        public string YazarSoyad { get; set; }

        public virtual ICollection<Kitap> Kitaplar { get; set; } = new HashSet<Kitap>();
    }
}
