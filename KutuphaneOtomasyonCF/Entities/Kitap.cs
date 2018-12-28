using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF.Entities
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }

        [Required]
        [StringLength(50)]
        public string KitapAd { get; set; }

        [Required]
        public short Stok { get; set; }

        [Required]
        public int YazarId { get; set; }
        [Required]
        [ForeignKey("YazarId")]
        public virtual Yazar Yazar { get; set; }
    }
}
