using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF.ViewModels
{
    public class KiraViewModel
    {
        public int KiraId { get; set; }
        public DateTime AlisTarihi { get; private set; } = DateTime.Now.Date;
        public DateTime VerisTarihi { get; set; }
        //public static short GunSayisi { get; set; } = (short)(VerisTarihi.Date - AlisTarihi.Date).Days;
        //public decimal CezaTutar { get; set; } = CezaHesapla(AlisTarihi, VerisTarihi);
        public int UyeId { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public int KitapId { get; set; }
        public string KitapAd { get; set; }

        public override string ToString() => $"{KiraId} - {UyeAd} {UyeSoyad} - {KitapAd}";

        public decimal CezaHesapla(DateTime alis, DateTime veris)
        {
            short gunSayisi = (short)(veris.Date - alis.Date).Days;
            return gunSayisi > 5 ? (gunSayisi - 5) * 5 : 0;
        }
    }
}
