using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalStokHareketi
    {
        public TohalStokHareketi()
        {
            TohalStokIades = new HashSet<TohalStokIade>();
        }

        public int StokHareketiId { get; set; }
        public int MakbuzId { get; set; }
        public int SatirNo { get; set; }
        public byte StokTipi { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public int SatilanKap { get; set; }
        public double SatilanMiktar { get; set; }
        public int? StokKunyeId { get; set; }
        public double? Fiyat { get; set; }
        public int? AlisKunyeId { get; set; }
        public string Aciklama { get; set; }
        public string Guid { get; set; }
        public DateTime GirisTarihi { get; set; }

        public virtual TohalKunye AlisKunye { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalMakbuz Makbuz { get; set; }
        public virtual TohalMal Mal { get; set; }
        public virtual TohalKunye StokKunye { get; set; }
        public virtual ICollection<TohalStokIade> TohalStokIades { get; set; }
    }
}