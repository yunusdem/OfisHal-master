

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMakbuzXslt
    {
        public string FirmaVergiDairesiAdi { get; set; }
        public string DigVergiKimlikNo { get; set; }
        public string FirMersisNo { get; set; }
        public string DigSicilKodu { get; set; }
        public string FirmaSehir { get; set; }
        public string FirmaAdresi { get; set; }
        public string FirmaTelefonNo { get; set; }
        public string DigEposta { get; set; }
        public string FirWebAdresi { get; set; }
        public string FirIbanNo { get; set; }
        public int MakbuzId { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public string FaturaNo { get; set; }
        public string EFaturaEttn { get; set; }
        public string DuzenlemeZamani { get; set; }
        public string CariAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiKimlikNo { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string EPosta { get; set; }
        public string Plaka { get; set; }
        public double Rusum { get; set; }
        public double Stopaj { get; set; }
        public double StopajOrani { get; set; }
        public double Bagkur { get; set; }
        public double BagkurOrani { get; set; }
        public double Borsa { get; set; }
        public double BorsaOrani { get; set; }
        public double IadeliKapTutari { get; set; }
        public double? Masraflar { get; set; }
        public string DigAdres { get; set; }
        public byte[] Logo { get; set; }
        public byte[] Imza { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string DokumNo { get; set; }
        public string IrsaliyeNo { get; set; }
    }
}