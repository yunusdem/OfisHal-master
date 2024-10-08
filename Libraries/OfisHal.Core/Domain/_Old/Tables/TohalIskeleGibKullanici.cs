using System;

namespace OfisHal.Web.Models
{
    public class TohalIskeleGibKullanici
    {
        public string Vkn { get; set; }
        public string PostaKutusu { get; set; }
        public string Unvan { get; set; }
        public byte Tip { get; set; }
        public DateTime KayitZamani { get; set; }
        public byte PkTipi { get; set; }
        public byte DokumanTipi { get; set; }
        public bool? Silindi { get; set; }
        public DateTime? IslemZamani { get; set; }
    }
}