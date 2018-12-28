using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF.Entities
{
    [Table("KiraDetaylar")]
    public class KiraDetay
    {
        [Key]
        public int KiraDetayId { get; set; }

        [Required]
        public int KiraId { get; set; }
        [Required]
        [ForeignKey("KiraId")]
        public virtual Kira Kira { get; set; }

        public TimeSpan GunSayisi { get; set; } = (TimeSpan)(Kira.VerisTarihi - Kira.AlisTarihi);
    }
}
