using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonCF.ViewModels
{
    public class UyeViewModel
    {
        public int UyeId { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string UyeTckn { get; set; }
        public string UyeTelefon { get; set; }
        public string UyeEmail { get; set; }

        public override string ToString() => $"{UyeAd} {UyeSoyad}";
    }
}
