using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF.ViewModels
{
    public class KitapViewModel
    {
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public string Yazar { get; set; }

        public override string ToString() => $"{KitapAd} - {Yazar}";
    }
}
