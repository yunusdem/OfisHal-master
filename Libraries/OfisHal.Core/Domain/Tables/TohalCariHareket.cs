using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalCariHareket
    {
        public TohalCariHareket()
        {
            Faturas = new HashSet<TohalFatura>();
        }

        public int CariHareketId { get; set; }
        public int CariKartId { get; set; }
        public DateTime Tarih { get; set; }
        public byte IslemTipi { get; set; }
        public string Aciklama { get; set; }
        public double Meblag { get; set; }
        public byte Tip { get; set; }
        public int? FaturaId { get; set; }
        public int EkleyenId { get; set; }
        public DateTime EklemeZamani { get; set; }
        public int GuncelleyenId { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public string RefNo { get; set; }
        public string Aciklama2 { get; set; }
        public int? PosCihaziId { get; set; }
        public int? KarsiCariKartId { get; set; }
        public bool? RehinCari { get; set; }

        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalFatura Fatura { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual TohalCariKart KarsiCariKart { get; set; }
        public virtual TohalPosCihazi PosCihazi { get; set; }

        public virtual ICollection<TohalFatura> Faturas { get; set; }
    }
}