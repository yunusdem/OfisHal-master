using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalMakbuz
    {
        public TohalMakbuz()
        {
            TohalMakbuzSatiris = new HashSet<TohalMakbuzSatiri>();
            TohalNavlunFaturasis = new HashSet<TohalNavlunFaturasi>();
            TohalStokHareketis = new HashSet<TohalStokHareketi>();
        }

        public int MakbuzId { get; set; }
        public string DokumNo { get; set; }
        public int CariKartId { get; set; }
        public int MarkaId { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public string GeldigiYer { get; set; }
        public string Plaka { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public string FaturaNo { get; set; }
        public double RusumOrani { get; set; }
        public double Rusum { get; set; }
        public double StopajOrani { get; set; }
        public double Stopaj { get; set; }
        public double BagkurOrani { get; set; }
        public double Bagkur { get; set; }
        public double BorsaOrani { get; set; }
        public double Borsa { get; set; }
        public double Navlun { get; set; }
        public double NavlunKdvOrani { get; set; }
        public double NavlunKdv { get; set; }
        public double KomisyonOrani { get; set; }
        public double Komisyon { get; set; }
        public double KomisyonKdvOrani { get; set; }
        public double KomisyonKdv { get; set; }
        public double IadesizKapTutari { get; set; }
        public double IadesizKapKdvOrani { get; set; }
        public double IadesizKapKdv { get; set; }
        public bool? IadesizKapKomisyonaDahil { get; set; }
        public string Aciklama { get; set; }
        public bool? Kesildi { get; set; }
        public int? OrtakId { get; set; }
        public double OrtaklikOrani { get; set; }
        public int? Vade { get; set; }
        public int EkleyenId { get; set; }
        public DateTime EklemeZamani { get; set; }
        public int GuncelleyenId { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public int MakbuzGuncelleyenId { get; set; }
        public DateTime MakbuzGuncellemeZamani { get; set; }
        public double IadeliKapTutari { get; set; }
        public int? YerId { get; set; }
        public int? UlkeId { get; set; }
        public byte? Sifati { get; set; }
        public int? TeslimatYeriId { get; set; }
        public byte? BildirimTuru { get; set; }
        public int? HalId { get; set; }
        public double? MalToplami { get; set; }
        public double? KdvToplami { get; set; }
        public double? MasrafToplami { get; set; }
        public double? MasrafKdvToplami { get; set; }
        public int? KapSayisi { get; set; }
        public byte CariyeIslemeSekli { get; set; }
        public byte? DigHksBildirimSekli { get; set; }
        public bool? BagkurHesaplanmasin { get; set; }
        public int? BagkurDosyaId { get; set; }
        public byte? HksMalinNiteligi { get; set; }
        public string EFaturaNot { get; set; }
        public string EFaturaBolgeKodu { get; set; }
        public int? GibFirmamizPostaKutusuId { get; set; }
        public int? GibMuhatapPostaKutusuId { get; set; }
        public byte? EFaturaDurumu { get; set; }
        public string EFaturaEttn { get; set; }
        public byte? EFaturaGibDurumu { get; set; }
        public string EFaturaHataAciklamasi { get; set; }
        public DateTime? FaturaZamani { get; set; }

        public virtual TohalBagkurDosyasi BagkurDosya { get; set; }
        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalGibKullanici GibFirmamizPostaKutusu { get; set; }
        public virtual TohalGibKullanici GibMuhatapPostaKutusu { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual TohalHal Hal { get; set; }
        public virtual TohalKullanici MakbuzGuncelleyen { get; set; }
        public virtual TohalMarka Marka { get; set; }
        public virtual TohalCariKart Ortak { get; set; }
        public virtual TohalTeslimatYeri TeslimatYeri { get; set; }
        public virtual TohalTabloMaddesi Ulke { get; set; }
        public virtual TohalYer Yer { get; set; }
        public virtual ICollection<TohalMakbuzSatiri> TohalMakbuzSatiris { get; set; }
        public virtual ICollection<TohalNavlunFaturasi> TohalNavlunFaturasis { get; set; }
        public virtual ICollection<TohalStokHareketi> TohalStokHareketis { get; set; }
    }
}