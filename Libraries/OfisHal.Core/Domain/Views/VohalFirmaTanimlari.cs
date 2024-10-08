

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalFirmaTanimlari
    {
        public string DigSicilKodu { get; set; }
        public string DigYazihaneNo { get; set; }
        public string DigFirmaAdi { get; set; }
        public int? DigVergiDairesiId { get; set; }
        public string VergiDairesiAdi { get; set; }
        public string DigVergiKimlikNo { get; set; }
        public string DigSahisAdi { get; set; }
        public string DigSahisSoyadi { get; set; }
        public string DigAdres { get; set; }
        public string DigTelefon { get; set; }
        public string DigGsmNo { get; set; }
        public string DigEposta { get; set; }
        public string DigTopHaliAdi { get; set; }
        public string DigTopHaliTelNo { get; set; }
        public int? HalId { get; set; }
        public string HalAdi { get; set; }
        public string FirMahalle { get; set; }
        public string FirCadde { get; set; }
        public string FirSokak { get; set; }
        public string FirKapiNo { get; set; }
        public string FirDaireNo { get; set; }
        public string FirPostaKodu { get; set; }
        public string FirWebAdresi { get; set; }
        public int? GibFirmamizPostaKutusuId { get; set; }
        public string GibFirmamizPostaKutusu { get; set; }
        public string FirMersisNo { get; set; }
        public string FirIbanNo { get; set; }
        public string FirBankaAdi { get; set; }
        public string DigBagkurKullaniciAdi { get; set; }
        public string DigBagkurSifresi { get; set; }
    }
}