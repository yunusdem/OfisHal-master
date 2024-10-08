

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMuhHesapEkstre
    {
        public string Kod { get; set; }
        public DateTime Tarih { get; set; }
        public string FisNo { get; set; }
        public string YevmiyeNo { get; set; }
        public string Aciklama { get; set; }
        public byte Tip { get; set; }
        public double Meblag { get; set; }
        public int KurusBasamakSayisi { get; set; }
    }
}