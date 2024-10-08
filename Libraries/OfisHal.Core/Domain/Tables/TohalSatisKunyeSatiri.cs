using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalSatisKunyeSatiri
    {
        public TohalSatisKunyeSatiri()
        {
            TohalKullanilanKunyes = new HashSet<TohalKullanilanKunye>();
        }

        public int SatisKunyeSatiriId { get; set; }
        public int? BildirimciSifatKodu { get; set; }
        public string BildirimciSifatAdi { get; set; }
        public int? BildirimciTurKodu { get; set; }
        public string BildirimciTurAdi { get; set; }
        public DateTime Tarih { get; set; }
        public int? ReferansKunyeId { get; set; }
        public string ReferansKunyeNo { get; set; }
        public int? SatisKunyeId { get; set; }
        public string SatisKunyeNo { get; set; }
        public int? GyIsletmeTuruId { get; set; }
        public string GyIsletmeTuruAdi { get; set; }
        public int? GyIsyeriId { get; set; }
        public string GyIsyeriKodu { get; set; }
        public int? GyIlId { get; set; }
        public string GyIlAdi { get; set; }
        public int? GyIlceId { get; set; }
        public string GyIlceAdi { get; set; }
        public int? GyBeldeId { get; set; }
        public string GyBeldeAdi { get; set; }
        public string GyAracPlakaNo { get; set; }
        public string GyBelgeNo { get; set; }
        public int? AliciCariKartId { get; set; }
        public int? AliciSifatKodu { get; set; }
        public string AliciSifatAdi { get; set; }
        public string AliciVergiNo { get; set; }
        public string AliciKodu { get; set; }
        public string AliciUnvani { get; set; }
        public string AliciEposta { get; set; }
        public string AliciTelefonNo { get; set; }
        public bool? AliciYurtdisi { get; set; }
        public int? MalUretimIlId { get; set; }
        public string MalUretimIlAdi { get; set; }
        public int? MalUretimIlceId { get; set; }
        public string MalUretimIlceAdi { get; set; }
        public int? MalUretimBeldeId { get; set; }
        public string MalUretimBeldeAdi { get; set; }
        public byte? MalNiteligi { get; set; }
        public string MalNiteligiAdi { get; set; }
        public int? MalId { get; set; }
        public string MalAdi { get; set; }
        public byte? MalUretimSekli { get; set; }
        public string MalUretimSekliAdi { get; set; }
        public int? MalCinsiId { get; set; }
        public string MalCinsiAdi { get; set; }
        public int? MalBirimId { get; set; }
        public string MalBirimAdi { get; set; }
        public double? MalMiktari { get; set; }
        public double? MalSatisFiyati { get; set; }
        public Guid? Guid { get; set; }
        public int? TakipId { get; set; }
        public string TakipNo { get; set; }

        public virtual ICollection<TohalKullanilanKunye> TohalKullanilanKunyes { get; set; }
    }
}