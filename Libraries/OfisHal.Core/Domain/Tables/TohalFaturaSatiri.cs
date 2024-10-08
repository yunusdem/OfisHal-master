using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalFaturaSatiri
    {
        public TohalFaturaSatiri()
        {
            TohalKullanilanKunyes = new HashSet<TohalKullanilanKunye>();
            TohalSatisMakbuzSatiris = new HashSet<TohalSatisMakbuzSatiri>();
        }

        public int FaturaSatiriId { get; set; }
        public int FaturaId { get; set; }
        public int SatirNo { get; set; }
        public int MarkaId { get; set; }
        public byte? SatisTipi { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public int KapMiktari { get; set; }
        public double Darali { get; set; }
        public double Dara { get; set; }
        public double MalMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public string Aciklama { get; set; }
        public string Guid { get; set; }
        public double RusumOrani { get; set; }
        public double Rusum { get; set; }
        public int? AlisKunyeId { get; set; }
        public bool? RusumHesaplanmasin { get; set; }
        public int? AlisFatSatId { get; set; }
        public bool? TutarHesaplanmasin { get; set; }
        public double IskontoPayi { get; set; }
        public double IskontoOrani { get; set; }
        public double Iskonto { get; set; }
        public bool? IskontoHesaplanmasin { get; set; }
        public int? FisSatiriId { get; set; }
        public double MalKapFiyati { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public int? KdvTevkifatPayi { get; set; }
        public int? KdvTevkifatPaydasi { get; set; }
        public double Yukleme { get; set; }

        public virtual TohalKunye AlisKunye { get; set; }
        public virtual TohalFatura Fatura { get; set; }
        public virtual TohalFisSatiri FisSatiri { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalKdvTevkifatTanimi KdvTevkifatTanimi { get; set; }
        public virtual TohalMal Mal { get; set; }
        public virtual TohalMarka Marka { get; set; }
        public virtual ICollection<TohalKullanilanKunye> TohalKullanilanKunyes { get; set; }
        public virtual ICollection<TohalSatisMakbuzSatiri> TohalSatisMakbuzSatiris { get; set; }
    }
}