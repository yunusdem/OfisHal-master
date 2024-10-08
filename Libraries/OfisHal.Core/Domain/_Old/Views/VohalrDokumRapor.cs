

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrDokumRapor
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public int MakbuzId { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public byte? OCariyeIslemeSekli { get; set; }
        public byte? SCariyeIslemeSekli { get; set; }
        public double? OBagkur { get; set; }
        public double? SBagkur { get; set; }
        public double? OBorsa { get; set; }
        public double? SBorsa { get; set; }
        public string OCariKodu { get; set; }
        public string SCariKodu { get; set; }
        public string OCariAd { get; set; }
        public string SCariAd { get; set; }
        public string ODokumNo { get; set; }
        public string SDokumNo { get; set; }
        public string OFaturaNo { get; set; }
        public string SFaturaNo { get; set; }
        public DateTime? OFaturaTarihi { get; set; }
        public DateTime? SFaturaTarihi { get; set; }
        public double? OIadeliKapTutari { get; set; }
        public double? SIadeliKapTutari { get; set; }
        public double? OIadesizKapKdv { get; set; }
        public double? SIadesizKapKdv { get; set; }
        public bool? OIadesizKapKomisyonaDahil { get; set; }
        public bool? SIadesizKapKomisyonaDahil { get; set; }
        public double? OIadesizKapTutari { get; set; }
        public double? SIadesizKapTutari { get; set; }
        public string OIrsaliyeNo { get; set; }
        public string SIrsaliyeNo { get; set; }
        public bool? OKesildi { get; set; }
        public bool? SKesildi { get; set; }
        public double? OKomisyon { get; set; }
        public double? SKomisyon { get; set; }
        public double? OKomisyonKdv { get; set; }
        public double? SKomisyonKdv { get; set; }
        public int? OMarkaId { get; set; }
        public int? SMarkaId { get; set; }
        public double? ONavlun { get; set; }
        public double? SNavlun { get; set; }
        public double? ONavlunKdv { get; set; }
        public double? SNavlunKdv { get; set; }
        public string OPlaka { get; set; }
        public string SPlaka { get; set; }
        public double? ORusum { get; set; }
        public double? SRusum { get; set; }
        public DateTime? OStokGirisTarihi { get; set; }
        public DateTime? SStokGirisTarihi { get; set; }
        public double? OStopaj { get; set; }
        public double? SStopaj { get; set; }
        public int SatirDegisiklikStok { get; set; }
        public int SatirDegisiklikMakbuz { get; set; }
        public int SatirMasrafDegisiklik { get; set; }
    }
}