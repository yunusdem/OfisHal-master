using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalKunye
    {
        public TohalKunye()
        {
            TohalFaturaSatiris = new HashSet<TohalFaturaSatiri>();
            TohalKullanilanKunyeSatisKunyes = new HashSet<TohalKullanilanKunye>();
            TohalKullanilanKunyeStokKunyes = new HashSet<TohalKullanilanKunye>();
            TohalStokHareketiAlisKunyes = new HashSet<TohalStokHareketi>();
            TohalStokHareketiStokKunyes = new HashSet<TohalStokHareketi>();
        }

        public int KunyeId { get; set; }
        public string Kod { get; set; }
        public byte Tur { get; set; }
        public DateTime KunyeZamani { get; set; }
        public int? UretimYeriId { get; set; }
        public string UreticiAdi { get; set; }
        public string MalSahibiAdi { get; set; }
        public string BildirimciAdi { get; set; }
        public double? Rusum { get; set; }
        public string PlakaNo { get; set; }
        public byte? Sifat { get; set; }
        public string BelgeNo { get; set; }

        public virtual TohalYer UretimYeri { get; set; }
        public virtual ICollection<TohalFaturaSatiri> TohalFaturaSatiris { get; set; }
        public virtual ICollection<TohalKullanilanKunye> TohalKullanilanKunyeSatisKunyes { get; set; }
        public virtual ICollection<TohalKullanilanKunye> TohalKullanilanKunyeStokKunyes { get; set; }
        public virtual ICollection<TohalStokHareketi> TohalStokHareketiAlisKunyes { get; set; }
        public virtual ICollection<TohalStokHareketi> TohalStokHareketiStokKunyes { get; set; }
    }
}