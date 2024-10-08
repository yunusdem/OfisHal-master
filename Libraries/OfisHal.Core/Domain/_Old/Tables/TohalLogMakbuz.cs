using System;

namespace OfisHal.Web.Models
{
    public class TohalLogMakbuz
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int MakbuzId { get; set; }
        public string ODokumNo { get; set; }
        public string SDokumNo { get; set; }
        public int? OCariKartId { get; set; }
        public int? SCariKartId { get; set; }
        public int? OMarkaId { get; set; }
        public int? SMarkaId { get; set; }
        public DateTime? OStokGirisTarihi { get; set; }
        public DateTime? SStokGirisTarihi { get; set; }
        public string OIrsaliyeNo { get; set; }
        public string SIrsaliyeNo { get; set; }
        public string OGeldigiYer { get; set; }
        public string SGeldigiYer { get; set; }
        public string OPlaka { get; set; }
        public string SPlaka { get; set; }
        public DateTime? OFaturaTarihi { get; set; }
        public DateTime? SFaturaTarihi { get; set; }
        public string OFaturaNo { get; set; }
        public string SFaturaNo { get; set; }
        public double? ORusumOrani { get; set; }
        public double? SRusumOrani { get; set; }
        public double? ORusum { get; set; }
        public double? SRusum { get; set; }
        public double? OStopajOrani { get; set; }
        public double? SStopajOrani { get; set; }
        public double? OStopaj { get; set; }
        public double? SStopaj { get; set; }
        public double? OBagkurOrani { get; set; }
        public double? SBagkurOrani { get; set; }
        public double? OBagkur { get; set; }
        public double? SBagkur { get; set; }
        public double? OBorsaOrani { get; set; }
        public double? SBorsaOrani { get; set; }
        public double? OBorsa { get; set; }
        public double? SBorsa { get; set; }
        public double? ONavlun { get; set; }
        public double? SNavlun { get; set; }
        public double? ONavlunKdvOrani { get; set; }
        public double? SNavlunKdvOrani { get; set; }
        public double? ONavlunKdv { get; set; }
        public double? SNavlunKdv { get; set; }
        public double? OKomisyonOrani { get; set; }
        public double? SKomisyonOrani { get; set; }
        public double? OKomisyon { get; set; }
        public double? SKomisyon { get; set; }
        public double? OKomisyonKdvOrani { get; set; }
        public double? SKomisyonKdvOrani { get; set; }
        public double? OKomisyonKdv { get; set; }
        public double? SKomisyonKdv { get; set; }
        public double? OIadesizKapTutari { get; set; }
        public double? SIadesizKapTutari { get; set; }
        public double? OIadesizKapKdvOrani { get; set; }
        public double? SIadesizKapKdvOrani { get; set; }
        public double? OIadesizKapKdv { get; set; }
        public double? SIadesizKapKdv { get; set; }
        public bool? OIadesizKapKomisyonaDahil { get; set; }
        public bool? SIadesizKapKomisyonaDahil { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public bool? OKesildi { get; set; }
        public bool? SKesildi { get; set; }
        public int? OOrtakId { get; set; }
        public int? SOrtakId { get; set; }
        public double? OOrtaklikOrani { get; set; }
        public double? SOrtaklikOrani { get; set; }
        public int? OVade { get; set; }
        public int? SVade { get; set; }
        public double? OIadeliKapTutari { get; set; }
        public double? SIadeliKapTutari { get; set; }
        public byte? OSifati { get; set; }
        public byte? SSifati { get; set; }
        public byte? OBildirimTuru { get; set; }
        public byte? SBildirimTuru { get; set; }
        public byte? OCariyeIslemeSekli { get; set; }
        public byte? SCariyeIslemeSekli { get; set; }
    }
}