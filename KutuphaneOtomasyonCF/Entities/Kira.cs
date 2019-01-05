using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF.Entities
{
    [Table("Kiralar")]
    public class Kira
    {
        [Key]
        public int KiraId { get; set; }

        //[Required]
        //public int UyeId { get; set; }
        //[Required]
        //[ForeignKey("UyeId")]
        //public virtual Uye Uye { get; set; }

        //[Required]
        //public int KitapId { get; set; }
        //[Required]
        //[ForeignKey("KitapId")]
        //public virtual Kitap Kitap { get; set; }


        //[Key, Column(Order = 0)]
        //public int UyeId { get; set; }

        //[Key, Column(Order = 1)]
        //public int KitapId { get; set; }

        [Required]
        [Column(TypeName = "smalldatetime")]
        public static DateTime AlisTarihi { get; set; } = DateTime.Now;
        public static DateTime? VerisTarihi { get; set; }
        public int UyeId { get; set; }
        public int KitapId { get; set; }

        //navigation property
        [ForeignKey("UyeId")]
        public virtual Uye Uye { get; set; }
        [ForeignKey("KitapId")]
        public virtual Kitap Kitap { get; set; }

        //public virtual ICollection<Kitap> Kitaplar { get; set; } = new HashSet<Kitap>();

    }
}
