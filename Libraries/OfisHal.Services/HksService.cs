using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Services.HksBildirimSvc;
using OfisHal.Services.HksGenelSvc;
using OfisHal.Services.HksUrunSvc;
using OfisHal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.UI;

namespace OfisHal.Services
{
    public class HksService : IHksService
    {
        private readonly Db _context;
        private readonly IDataServices _dataServices;
        private readonly BildirimServiceClient _bildirimServiceClient;
        private readonly GenelServiceClient _genelServiceClient;
        private readonly UrunServiceClient _urunServiceClient;
        private readonly string _servicePassword;
        private readonly string _userName;
        private readonly string _password;
        private readonly bool _testEnv;

        public HksService(Db context, IDataServices dataServices)
        {
            _context = context;

            _servicePassword = _context.TohalTanims.FirstOrDefault().DigHksSifresi;
            _userName = _context.TohalTanims.FirstOrDefault().DigWebKullanicisi;
            _password = _context.TohalTanims.FirstOrDefault().DigWebSifresi;

            _bildirimServiceClient = new BildirimServiceClient();
            _genelServiceClient = new GenelServiceClient();
            _urunServiceClient = new UrunServiceClient();

            _testEnv = false;
            _dataServices = dataServices;
        }

        #region Bildirim Servisleri
        public IEnumerable<BildirimTuruDTO> BildirimTurleri()
        {
            var response = _bildirimServiceClient.BildirimServisBildirimTurleri(new BildirimTurleriIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.BildirimTurleri.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<BildirimTuruDTO>();
        }

        public IEnumerable<SifatDTO> SifatListesi()
        {
            var response = _bildirimServiceClient.BildirimServisSifatListesi(new SifatIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Sifatlar.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<SifatDTO>();
        }

        public IEnumerable<ReferansKunyeDTO> ReferansKunyeler(DateTime startDate, DateTime endDate, string tcVkn, int urunId, int kisiSifat, bool greaterThanZero = true, int kunyeNo = 0)
        {
            var response = _bildirimServiceClient.BildirimServisReferansKunyeler(new ReferansKunyeIstek()
            {
                BaslangicTarihi = startDate,
                BitisTarihi = endDate,
                KalanMiktariSifirdanBuyukOlanlar = greaterThanZero,
                KunyeNo = kunyeNo,
                MalinSahibiTcKimlikVergiNo = tcVkn,
                KisiSifat = kisiSifat,
                UrunId = urunId
            }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.ReferansKunyeler.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<ReferansKunyeDTO>();
        }

        public List<BildirimKayitCevap> BildirimKaydet(int faturaId, bool faturaTip)
        {
            var fatura = _context.TohalFaturas.Include(x => x.CariKart).FirstOrDefault(x => x.FaturaId == faturaId);
            
         
          
            if (fatura != null)
            {
                var tanim = _context.TohalTanims.FirstOrDefault();
                var faturaSatirlari = _context.VohalFaturaSatiriUrts.AsNoTracking().Where(x => x.FaturaId == faturaId).ToList();
                var bildirimciYer = _dataServices.YerBilgiAl(tanim.DigYerId?? 0);
                YerBilgi malBilgiYer = new YerBilgi();
                var requests = new List<BildirimKayitIstek>();
                var teslimat = _context.TohalTeslimatYeris.Where(x => x.TeslimatYeriId == fatura.TeslimatYeriId).FirstOrDefault();
                int GidecekYerIsletmeTuruId = 0;
                int GidecekIsyeriId = 0;
                if (tanim != null && faturaSatirlari?.Count() > 0)
                {
                    foreach (var faturaSatir in faturaSatirlari)
                    {
                        if((faturaSatir.StokKunyesi != null 
                            && faturaSatir.StokKunyesi != ""
                            && faturaTip)) continue;

                        if(( faturaSatir.SatisKunyesi != null 
                            && faturaSatir.SatisKunyesi != "") 
                            && !faturaTip ) continue;

                      
                        var malBilgi = _context.VohalMalHksBagis.FirstOrDefault(x => x.MalId == faturaSatir.MalId) ?? new VohalMalHksBagi();
                        var malHksBilgi = _context.VohalHksMals.FirstOrDefault(x => x.MalAdiId == malBilgi.HksMalId);

                        var magaza = _context.VohalMagazas.FirstOrDefault(x => x.MagazaId == fatura.MagazaId);
                        if(magaza != null) magaza.HksId = magaza.HksId == null ? 0 : magaza.HksId;
                        var belgeNo = "";
                        long ReferansBildirimKunyeNo;
                        byte BildirimTuru = 0;
                        byte? KisiSifat;
                        if(magaza != null && magaza.CariSifati != null & magaza.CariSifati != 0) { 
                            KisiSifat = magaza.CariSifati;
                        }
                        else
                        {
                            KisiSifat = fatura.CariSifati;
                        }
                        var AdSoyad = "";
                        var CepTel = "";
                        var Eposta = "";
                        var TcKimlikVergiNo = fatura.VergiKimlikNo.Trim();
                        if (!faturaTip)
                        {
                            GidecekYerIsletmeTuruId = magaza == null ? Convert.ToInt32(fatura.GidecegiYerTipi) : Convert.ToInt32(magaza.GidecegiYer); 
                            GidecekIsyeriId = magaza == null ? 0 : (int)magaza.HksId;                        
                            ReferansBildirimKunyeNo = faturaSatir.StokKunyesi != null ? long.Parse(faturaSatir.StokKunyesi) : 0;
                            malBilgiYer = _dataServices.YerBilgiAl(_context.TohalCariKarts
                                                                        .Where(x => x.CariKartId == fatura.CariKartId)
                                                                        .FirstOrDefault().YerId ?? 0);
                            AdSoyad = fatura.Unvan;
                            CepTel = fatura.GsmNo;
                            Eposta = fatura.EPosta;
                            BildirimTuru = (byte)fatura.BildirimTuru;
                        }
                        else
                        {
                            var faturaSatirCari = _context.VohalCariKarts.Where(x => x.CariKartId == faturaSatir.CariKartId).FirstOrDefault();

                            GidecekYerIsletmeTuruId = (int)teslimat.Tip;
                            GidecekIsyeriId = teslimat.HksId != null ? (int)teslimat.HksId : 0;
                            ReferansBildirimKunyeNo = 0;
                            
                            KisiSifat = 4;

                            TcKimlikVergiNo = faturaSatirCari.VergiKimlikNo.Trim();
                            if(fatura.Tip == 1)
                            {
                                malBilgiYer = _dataServices.YerBilgiAl(faturaSatirCari.BeldeId ?? 0);
                                AdSoyad = faturaSatirCari.Ad;
                                CepTel = faturaSatirCari.GsmNo;
                                Eposta = faturaSatirCari.EPosta;
                            }
                            else
                            {
                                malBilgiYer = _dataServices.YerBilgiAl(fatura.YerId ?? 0);
                                AdSoyad = fatura.Unvan;
                                CepTel = fatura.GsmNo;
                                Eposta = fatura.EPosta;
                            }
                        }

                        requests.Add(new BildirimKayitIstek()
                        {
                            BildirimciBilgileri = new BildirimciBilgileriDTO { KisiSifat = fatura.Sifati ?? 0 },
                            BildirimTuru = _dataServices.BildirimTipiIdBul(BildirimTuru),
                            ReferansBildirimKunyeNo = ReferansBildirimKunyeNo,// Referans yok ise 0 gönderilmeli -- satışta dolu gidecek
                            UniqueId = faturaSatir.Guid,
                            BildirimMalBilgileri = new BildirimMalBilgileriDTO
                            {
                                GelenUlkeId = malBilgiYer.UlkeId,
                                UretimIlId = malBilgiYer.IlId,
                                UretimIlceId = malBilgiYer.IlceId,
                                UretimBeldeId = malBilgiYer.BeldeId,

                                MalinNiteligi = 1, // MalNitelikleri ID - boş gidecekse 0 // bakılacak
                                MalinKodNo = malHksBilgi?.MalAdiHksId ?? 0,
                                UretimSekli = malHksBilgi?.UretimSekli ?? 0,
                                MalinCinsiId = malHksBilgi?.MalCinsiHksId ?? 0,

                                MiktarBirimId = _dataServices.MalBirimIdBul(faturaSatir.MalBirimi),
                                MalinMiktari = faturaSatir.MalMiktari,
                                MalinSatisFiyat = faturaSatir.MalFiyati,
                                AnalizeGonderilecekMi = false
                            },

                            MalinGidecekYerBilgileri = new MalinGidecekYerBilgileriDTO
                           
                            {
                                GidecekYerIsletmeTuruId = GidecekYerIsletmeTuruId,
                                GidecekIsyeriId = GidecekIsyeriId,
                                GidecekUlkeId = bildirimciYer.UlkeId,
                                GidecekYerIlId = bildirimciYer.IlId,
                                GidecekYerIlceId = bildirimciYer.IlceId,
                                GidecekYerBeldeId = bildirimciYer.BeldeId,
                                AracPlakaNo = fatura.PlakaNo.Trim(),
                                BelgeNo = belgeNo,//fatura.FaturaNo,  // stok kayıtta döküm no, irsaliyede irasaliye no
                                BelgeTipi = 0 // dinamik değişecek
                            },
                            IkinciKisiBilgileri = new IkinciKisiBilgileriDTO
                            {
                                KisiSifat = Convert.ToInt32(KisiSifat),
                                AdSoyad = AdSoyad,
                                CepTel = CepTel,
                                Eposta = Eposta,
                                TcKimlikVergiNo = TcKimlikVergiNo,
                                YurtDisiMi = false
                            }
                        });
                    
                    }
                    
                    if(requests.Count != 0)
                    {                 
                        var svcRes = _bildirimServiceClient.BildirimServisBildirimKaydet(requests, _password, _servicePassword, _userName, out var code, out var responses);

                 
                    foreach (var response in responses)
                    {

                            /*
                            response.HataKodu;
                            response.Mesaj;
                            */
                            var ctHata = new CevapTablosu();
                            var uretimYeriId = _context.VohalHksTanimlars.SingleOrDefault().BeldeHksId;
                        try
                        {
                            if (response.HataKodu == 0)
                            {

                                var uretimYeri = _context.TohalYers.Where(x => x.HksId == response.UretimBeldeId).FirstOrDefault();
                                if (uretimYeri != null)
                                {
                                    uretimYeriId = uretimYeri.YerId;
                                }

                                var kunye = new TohalKunye
                                {
                                    BelgeNo = response.BelgeNo,
                                    BildirimciAdi = null,
                                    Kod = Convert.ToString(response.YeniKunyeNo),
                                    KunyeZamani = FillDate(response.KayitTarihi, DateTime.Now),
                                    MalSahibiAdi = response.MalinSahibAdi,
                                    PlakaNo = response.AracPlakaNo,
                                    Rusum = response.RusumMiktari,
                                    Tur = (byte)response.BelgeTipi,
                                    UreticiAdi = response.UreticisininAdUnvani,
                                    UretimYeriId = uretimYeriId
                                };

                                var satir = _context.TohalFaturaSatiris.FirstOrDefault(x => x.Guid == response.UniqueId);

                                if (satir != null)
                                {
                                    _context.TohalKunyes.Add(kunye);



                                    var existingKunye = _context.TohalKullanilanKunyes
                                        .SingleOrDefault(k => k.FaturaSatiriId == satir.FaturaSatiriId);

                                    if (existingKunye != null)
                                    {

                                        if (faturaTip)
                                        {
                                            existingKunye.StokKunyeId = kunye.KunyeId;
                                            satir.Guid = Guid.NewGuid().ToString();
                                            _context.Entry(satir).State = EntityState.Modified;
                                            _context.Entry(existingKunye).State = EntityState.Modified;
                                        }
                                        else
                                        {
                                            existingKunye.SatisKunyeId = kunye.KunyeId;
                                            _context.Entry(existingKunye).State = EntityState.Modified;
                                        }
                                        _context.SaveChanges();
                                    }
                                    else
                                    {
                                        var kullanilanKunye = faturaTip
                                        ? new TohalKullanilanKunye
                                        {
                                            FaturaSatiriId = satir.FaturaSatiriId,
                                            StokKunyeId = kunye.KunyeId,
                                            SatirNo = 0
                                        }
                                        : new TohalKullanilanKunye
                                        {
                                            FaturaSatiriId = satir.FaturaSatiriId,
                                            SatisKunyeId = kunye.KunyeId,
                                            SatirNo = 0
                                        };
                                        if (faturaTip)
                                        {
                                            satir.Guid = Guid.NewGuid().ToString();
                                            _context.Entry(satir).State = EntityState.Modified;
                                        }
                                        _context.TohalKullanilanKunyes.Add(kullanilanKunye);

                                        _context.SaveChanges();
                                    }



                                }
                            }
                            else
                            {
                                ctHata.Guid = Guid.NewGuid();
                                ctHata.HataKodu = response.HataKodu;
                                ctHata.HataMesaji = response.Mesaj;
                                ctHata.DonenAlanAdi = "BildirimKayitCevap";
                                ctHata.DonenAlanDegeri = response.ToString();
                                _context.CevapTablosus.Add(ctHata);

                            }
                        }
                        catch
                        {

                        }
                              
                    }
                    _context.SaveChanges();
               
                    return responses;
         
                   
                    }
                }
            }
            return new List<BildirimKayitCevap>();
        }

        public List<BildirimKayitCevap> StokBildirimKaydet(int faturaId)
        {
            var fatura = _context.TohalMakbuzs.Include(x => x.CariKart).FirstOrDefault(x => x.MakbuzId == faturaId);
            //var bildirimciYer = _dataServices.YerBilgiAl(fatura.YerId ?? 0);
            //var gidecekYer = _dataServices.YerBilgiAl(fatura.YerId ?? 0);

            if (fatura != null)
            {
                var tanim = _context.TohalTanims.FirstOrDefault();
                var faturaSatirlari = _context.VohalStokHareketis.Where(x => x.MakbuzId == faturaId).ToList();
                var bildirimciYer = _dataServices.YerBilgiAl(tanim.DigYerId ?? 0);
                YerBilgi malBilgiYer = new YerBilgi();
                var requests = new List<BildirimKayitIstek>();
                var teslimat = _context.TohalTeslimatYeris.Where(x => x.TeslimatYeriId == fatura.TeslimatYeriId).FirstOrDefault();
                var bildirimTuru = fatura.BildirimTuru == 17 ? 1 : 0;
                var GidecekIsyeriId = teslimat.HksId != null ? (int)teslimat.HksId : 0;
                if (tanim != null && faturaSatirlari?.Count() > 0)
                {
                    foreach (var faturaSatir in faturaSatirlari)
                    {
                        if ((faturaSatir.StokKunyesi != null
                                && faturaSatir.StokKunyesi != "")) continue;

                        var malBilgi = _context.VohalMalHksBagis.FirstOrDefault(x => x.MalId == faturaSatir.MalId) ?? new VohalMalHksBagi();
                        var malHksBilgi = _context.VohalHksMals.FirstOrDefault(x => x.MalCinsiId == malBilgi.HksMalCinsiId);
                        var uretimSekli = _dataServices.UretimSekliIdBul(malHksBilgi.UretimSekli.Value);
                        var belgeNo = "";

                        
                        var uniqueId = Guid.NewGuid().ToString();
                        var stokHareketi = _context.TohalStokHareketis
                                                    .Where(x => x.StokHareketiId == faturaSatir.StokHareketiId)
                                                    .FirstOrDefault();
                     
                        if (stokHareketi != null && (stokHareketi.Guid == null || stokHareketi.Guid == Guid.Empty.ToString() || stokHareketi.Guid == ""))
                        {
                            stokHareketi.Guid = uniqueId;
                            _context.Entry(stokHareketi).State = EntityState.Modified;
                        }
                        _context.SaveChanges();

                        requests.Add(new BildirimKayitIstek()
                        {
                            BildirimciBilgileri = new BildirimciBilgileriDTO { KisiSifat = 5 },
                            BildirimTuru = _dataServices.BildirimTipiIdBul((byte)bildirimTuru),
                            ReferansBildirimKunyeNo = 0,// Referans yok ise 0 gönderilmeli -- satışta dolu gidecek
                            UniqueId = stokHareketi.Guid,
                            
                            BildirimMalBilgileri = new BildirimMalBilgileriDTO
                            {
                                GelenUlkeId = bildirimciYer.UlkeId,
                                UretimIlId = bildirimciYer.IlId,
                                UretimIlceId = bildirimciYer.IlceId,
                                UretimBeldeId = bildirimciYer.BeldeId,

                                MalinNiteligi = 1, // MalNitelikleri ID - boş gidecekse 0 // bakılacak
                                MalinKodNo = (int)malHksBilgi.MalAdiHksId,
                                UretimSekli = (int)uretimSekli,
                                MalinCinsiId = (int)malHksBilgi.MalCinsiHksId,

                                MiktarBirimId = 74,
                                MalinMiktari = faturaSatir.Miktar,
                                MalinSatisFiyat = 0,
                                AnalizeGonderilecekMi = false
                            },


                            MalinGidecekYerBilgileri = new MalinGidecekYerBilgileriDTO
                            {
                                GidecekYerIsletmeTuruId = (int)teslimat.Tip,
                                GidecekIsyeriId = (int)teslimat.HksId,
                                GidecekUlkeId = malBilgiYer.UlkeId,
                                GidecekYerIlId = 0,//gidecekYer.IlId,
                                GidecekYerIlceId = 0,// gidecekYer.IlceId,
                                GidecekYerBeldeId = 0,//gidecekYer.BeldeId,
                                AracPlakaNo = fatura.Plaka.Trim(),
                                BelgeNo = belgeNo,//fatura.FaturaNo,  // stok kayıtta döküm no, irsaliyede irasaliye no
                                BelgeTipi = 0 // dinamik değişecek
                            },
                            IkinciKisiBilgileri = new IkinciKisiBilgileriDTO
                            {
                                KisiSifat = 4,
                                AdSoyad = fatura.CariKart.Ad ?? string.Empty,
                                CepTel = fatura.CariKart.GsmNo ?? string.Empty,
                                Eposta = fatura.CariKart.EPosta ?? string.Empty,
                                TcKimlikVergiNo = fatura.CariKart.VergiKimlikNo.Trim() ?? string.Empty,
                                YurtDisiMi = false
                            }
                        });
                    }

                    var svcRes = _bildirimServiceClient.BildirimServisBildirimKaydet(requests, _password, _servicePassword, _userName, out var code, out var responses);

              
                        foreach (var response in responses)
                        {
                            var ctHata = new CevapTablosu();
                            try
                                {
                                if (response.HataKodu == 0)
                                {

                                    var kunye = new TohalKunye
                                    {
                                        BelgeNo = response.BelgeNo,
                                        BildirimciAdi = null,
                                        Kod = Convert.ToString(response.YeniKunyeNo),
                                        KunyeZamani = FillDate(response.KayitTarihi, DateTime.Now),
                                        MalSahibiAdi = response.MalinSahibAdi,
                                        PlakaNo = response.AracPlakaNo,
                                        Rusum = response.RusumMiktari,
                                        Tur = (byte)response.BelgeTipi,
                                        UreticiAdi = response.UreticisininAdUnvani,
                                        UretimYeriId = _context.TohalYers.Where(x => x.HksId == response.UretimBeldeId).FirstOrDefault().YerId
                                    };

                                    var satir = _context.TohalStokHareketis.FirstOrDefault(x => x.Guid == response.UniqueId);

                                    if (satir != null)
                                    {
                                        _context.TohalKunyes.Add(kunye);
                                        _context.SaveChanges();
                                        satir.StokKunyeId = kunye.KunyeId;
                                        _context.Entry(satir).State = EntityState.Modified;
                                        _context.SaveChanges();
                                    }
                                }
                                else
                                {
                                    ctHata.Guid = Guid.NewGuid();
                                    ctHata.HataKodu = response.HataKodu;
                                    ctHata.HataMesaji = response.Mesaj;
                                    ctHata.DonenAlanAdi = "StokBildirimKayitCevap";
                                    ctHata.DonenAlanDegeri = response.ToString();
                                    _context.CevapTablosus.Add(ctHata);
                            }
                            }
                            catch
                            {

                            }
                        }

                        return responses;
              
                }
            }
            return new List<BildirimKayitCevap>();
        }

        public List<BildirimKayitCevap> SatisStokBildirimKaydet(int faturaId)
        {
            var fatura = _context.TohalFaturas.Include(x => x.CariKart).FirstOrDefault(x => x.FaturaId == faturaId);
            //var bildirimciYer = _dataServices.YerBilgiAl(fatura.YerId ?? 0);
            //var gidecekYer = _dataServices.YerBilgiAl(fatura.YerId ?? 0);

            if (fatura != null)
            {
                var tanim = _context.TohalTanims.FirstOrDefault();
                var faturaSatirlari = _context.VohalFaturaSatiriUrts.Where(x => x.FaturaId == faturaId).ToList();
                var bildirimciYer = _dataServices.YerBilgiAl(tanim.DigYerId ?? 0);
                YerBilgi malBilgiYer = new YerBilgi();
                var requests = new List<BildirimKayitIstek>();
                var teslimat = _context.TohalTeslimatYeris.Where(x => x.TeslimatYeriId == fatura.TeslimatYeriId).FirstOrDefault();
                var bildirimTuru = fatura.BildirimTuru == 17 ? 1 : 0;
                var GidecekIsyeriId = teslimat.HksId != null ? (int)teslimat.HksId : 0;

                if (tanim != null && faturaSatirlari?.Count() > 0)
                {
                    foreach (var faturaSatir in faturaSatirlari)
                    {
                        if ((faturaSatir.StokKunyesi != null
                               && faturaSatir.StokKunyesi != "")) continue;

                        var malBilgi = _context.VohalMalHksBagis.FirstOrDefault(x => x.MalId == faturaSatir.MalId);
                        var malHksBilgi = _context.VohalHksMals.FirstOrDefault(x => x.MalCinsiId == malBilgi.HksMalCinsiId);
                        var belgeNo = "";
                        var uniqueId = Guid.NewGuid().ToString();
                        var faturaSatirCari = _context.VohalCariKarts.Where(x => x.CariKartId == faturaSatir.CariKartId).FirstOrDefault();
                        var faturaSatirUp = _context.TohalFaturaSatiris
                                                    .Where(x => x.FaturaSatiriId == faturaSatir.FaturaSatiriId)
                                                    .FirstOrDefault();
                        if (faturaSatirUp != null && (faturaSatirUp.Guid == null || faturaSatirUp.Guid == Guid.Empty.ToString() || faturaSatirUp.Guid == ""))
                        {
                            faturaSatirUp.Guid = uniqueId;
                        }

                        _context.SaveChanges();
                        requests.Add(new BildirimKayitIstek()
                        {
                            BildirimciBilgileri = new BildirimciBilgileriDTO { KisiSifat = Convert.ToInt32(fatura.Sifati) },
                            BildirimTuru = 206,
                            ReferansBildirimKunyeNo = 0,// Referans yok ise 0 gönderilmeli -- satışta dolu gidecek
                            UniqueId = faturaSatir.Guid,

                            BildirimMalBilgileri = new BildirimMalBilgileriDTO
                            {
                                GelenUlkeId = bildirimciYer.UlkeId,
                                UretimIlId = bildirimciYer.IlId,
                                UretimIlceId = bildirimciYer.IlceId,
                                UretimBeldeId = bildirimciYer.BeldeId,

                                MalinNiteligi = 1, // MalNitelikleri ID - boş gidecekse 0 // bakılacak
                                MalinKodNo = (int)malHksBilgi.MalAdiHksId,
                                UretimSekli = (int)malHksBilgi.UretimSekli,
                                MalinCinsiId = (int)malHksBilgi.MalCinsiHksId,

                                MiktarBirimId = 74,
                                MalinMiktari = faturaSatir.MalMiktari,
                                MalinSatisFiyat = 0,
                                AnalizeGonderilecekMi = false
                            },


                            MalinGidecekYerBilgileri = new MalinGidecekYerBilgileriDTO
                            {
                                GidecekYerIsletmeTuruId = (int)teslimat.Tip,
                                GidecekIsyeriId = GidecekIsyeriId,
                                GidecekUlkeId = malBilgiYer.UlkeId,
                                GidecekYerIlId = 0,//gidecekYer.IlId,
                                GidecekYerIlceId = 0,// gidecekYer.IlceId,
                                GidecekYerBeldeId = 0,//gidecekYer.BeldeId,
                                AracPlakaNo = fatura.PlakaNo.Trim(),
                                BelgeNo = belgeNo,//fatura.FaturaNo,  // stok kayıtta döküm no, irsaliyede irasaliye no
                                BelgeTipi = 0 // dinamik değişecek
                            },
                            IkinciKisiBilgileri = new IkinciKisiBilgileriDTO
                            {
                                KisiSifat = 4,
                                AdSoyad = faturaSatirCari.Ad,
                                CepTel = faturaSatirCari.GsmNo,
                                Eposta = faturaSatirCari.EPosta,
                                TcKimlikVergiNo = faturaSatirCari.VergiKimlikNo?.Trim() ?? "",
                                YurtDisiMi = false
                            }
                        });
                    }

                    try
                    {
                        var svcRes = _bildirimServiceClient.BildirimServisBildirimKaydet(requests, _password, _servicePassword, _userName, out var code, out var responses);


                        foreach (var response in responses)
                        {
                            var ctHata = new CevapTablosu();
                            try
                            {
                                if (response.HataKodu == 0)
                                {
                                    var kunye = new TohalKunye
                                    {
                                        BelgeNo = response.BelgeNo,
                                        BildirimciAdi = null,
                                        Kod = Convert.ToString(response.YeniKunyeNo),
                                        KunyeZamani = FillDate(response.KayitTarihi, DateTime.Now),
                                        MalSahibiAdi = response.MalinSahibAdi,
                                        PlakaNo = response.AracPlakaNo,
                                        Rusum = response.RusumMiktari,
                                        Tur = (byte)response.BelgeTipi,
                                        UreticiAdi = response.UreticisininAdUnvani,
                                        UretimYeriId = _context.TohalYers.Where(x => x.HksId == response.UretimBeldeId).FirstOrDefault().YerId
                                    };

                                    var satir = _context.TohalFaturaSatiris.FirstOrDefault(x => x.Guid == response.UniqueId);

                                    if (satir != null)
                                    {
                                        _context.TohalKunyes.Add(kunye);
                                        _context.SaveChanges();
                                        TohalKullanilanKunye tkk = new TohalKullanilanKunye();
                                        tkk.FaturaSatiriId = satir.FaturaSatiriId;
                                        tkk.StokKunyeId = kunye.KunyeId;
                                        tkk.SatirNo = satir.SatirNo;
                                        _context.TohalKullanilanKunyes.Add(tkk);
                                        satir.Guid = Guid.NewGuid().ToString();
                                        _context.SaveChanges();
                                    }
                                    satir.Guid = Guid.NewGuid().ToString();
                                    _context.Entry(satir).State = EntityState.Modified;
                                    _context.SaveChanges();
                                }
                                else
                                {
                                    ctHata.Guid = Guid.NewGuid();
                                    ctHata.HataKodu = response.HataKodu;
                                    ctHata.HataMesaji = response.Mesaj;
                                    ctHata.DonenAlanAdi = "StokBildirimKayitCevap";
                                    ctHata.DonenAlanDegeri = response.ToString();
                                    _context.CevapTablosus.Add(ctHata);
                                }
                            }
                            catch
                            {

                            }
                        }

                        return responses;
                    }
                    catch
                    {
                    }
                }
            }
            return new List<BildirimKayitCevap>();
        }


        public IEnumerable<BildirimSorguDTO> BildirimcininYaptigiBildirimler(int kunyeTuru, long kunyeNo, DateTime startDate, DateTime endDate, string uniqueId, bool greaterThanZero = true, int? sifatId = null) =>
            Bildirimler(false, kunyeTuru, kunyeNo, startDate, endDate, uniqueId, greaterThanZero, sifatId);

        public IEnumerable<BildirimSorguDTO> BildirimciyeYapilaniBildirimler(int kunyeTuru, long kunyeNo, DateTime startDate, DateTime endDate, string uniqueId, bool greaterThanZero = true, int? sifatId = null) =>
            Bildirimler(true, kunyeTuru, kunyeNo, startDate, endDate, uniqueId, greaterThanZero, sifatId);

        private IEnumerable<BildirimSorguDTO> Bildirimler(bool bildirimciye, int kunyeTuru, long kunyeNo, DateTime startDate, DateTime endDate, string uniqueId, bool greaterThanZero = true, int? sifatId = null)
        {
            var request = new BildirimSorguIstek
            {
                KunyeTuru = kunyeTuru,
                KunyeNo = kunyeNo,
                BaslangicTarihi = startDate,
                BitisTarihi = endDate,
                KalanMiktariSifirdanBuyukOlanlar = greaterThanZero,
                Sifat = sifatId ?? 0,
                UniqueId = uniqueId,
            };

            
            BildirimSorguCevap result;
            List<HksBildirimSvc.ErrorModel> response;

            string kod;
            if (bildirimciye)
                response = _bildirimServiceClient.BildirimServisBildirimciyeYapilanBildirimListesi(request, _password, _servicePassword, _userName, out kod, out result);
            else
                response = _bildirimServiceClient.BildirimServisBildirimcininYaptigiBildirimListesi(request, _password, _servicePassword, _userName, out kod, out result);

            if (Result(kod, out var msg))
                return result.Bildirimler.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<BildirimSorguDTO>();
        }

        public IEnumerable<KayitliKisiSorguDTO> KayitliKisiler(List<string> tcVkns)
        {
            var response = _bildirimServiceClient.BildirimServisKayitliKisiSorgu(new KayitliKisiSorguIstek() { TcKimlikVergiNolar = tcVkns }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.TcKimlikVergiNolar.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<KayitliKisiSorguDTO>();
        }

        public IEnumerable<TopluKunyeDTO> Kunyeler(string belgeNo)
        {
            if (!string.IsNullOrWhiteSpace(belgeNo))
            {
                var current = DateTime.Now;
                belgeNo = belgeNo.Trim();

                var response = _bildirimServiceClient.BildirimServisTopluKunye(new TopluKunyeIstek()
                {
                    BelgeNo = belgeNo,
                    BildirimTarihi = current,
                    AracPlakaNo = string.Empty
                }, _password, _servicePassword, _userName, out var kod, out var result);

                if (Result(kod, out var msg))
                {
                    foreach (var kunye in result.Kunyeler)
                    {
                        _context.TohalKunyes.Add(new TohalKunye
                        {
                            BelgeNo = kunye.BelgeNo,
                            BildirimciAdi = kunye.Bildirimci,
                            KunyeZamani = FillDate(kunye.KayitTarihi,current),
                            MalSahibiAdi = kunye.MalinSahibAdi,
                            PlakaNo = kunye.AracPlakaNo,
                            Kod = Convert.ToString(kunye.MalinKunyeNo),
                            //Tur = (byte)belgeTipi,
                        });
                    }

                    _context.SaveChanges();

                    return result.Kunyeler.AsEnumerable();
                }

                if (_testEnv)
                    ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            }

            return Enumerable.Empty<TopluKunyeDTO>();
        }

        public IEnumerable<BildirimEtiketDTO> Etiketler(string aracPlakaNo, string belgeNo, DateTime bildirimTarihi, int beldeId, int ilceId, int yerId, string tcVkn)
        {
            var response = _bildirimServiceClient.BildirimServisBildirimEtiket(new BildirimEtiketIstek()
            {
                AracPlakaNo = aracPlakaNo,
                BelgeNo = belgeNo,
                BildirimTarihi = bildirimTarihi,
                GidecekYerBeldeId = beldeId,
                GidecekYerIlceId = ilceId,
                GidecekYerIlId = yerId,
                MalinSahibiTcKimlikNo = tcVkn
            }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Kunyeler.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<BildirimEtiketDTO>();
        }
        #endregion

        #region Genel Servisler
        public IEnumerable<UlkeDTO> Ulkeler()
        {
            var response = _genelServiceClient.GenelServisUlkeler(new UlkelerIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Ulkeler.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<UlkeDTO>();
        }

        public IEnumerable<IlDTO> Iller()
        {
            var response = _genelServiceClient.GenelServisIller(new IllerIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Iller.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<IlDTO>();
        }

        public IEnumerable<IlceDTO> Ilceler(int ilId)
        {
            var response = _genelServiceClient.GenelServisIlceler(new IlcelerIstek() { IlId = ilId }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Ilceler.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<IlceDTO>();
        }

        public IEnumerable<BeldeDTO> Beldeler(int ilceId)
        {
            var response = _genelServiceClient.GenelServisBeldeler(new BeldelerIstek() { IlceId = ilceId }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Beldeler.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<BeldeDTO>();
        }

        public IEnumerable<HalIciIsyeriDTO> HalIciIsyerleri(string tcVkn)
        {
            var response = _genelServiceClient.GenelServisHalIciIsyeri(new HalIciIsyeriIstek() { TcKimlikVergiNo = tcVkn }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Isyerleri.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<HalIciIsyeriDTO>();
        }

        public IEnumerable<IsletmeTuruDTO> IsletmeTurleri()
        {
            var response = _genelServiceClient.GenelServisIsletmeTurleri(new IsletmeTurleriIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.IsletmeTurleri.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<IsletmeTuruDTO>();
        }

        public IEnumerable<DepoDTO> Depolar(string tcVkn)
        {
            var response = _genelServiceClient.GenelServisDepolar(new DepolarIstek() { TcKimlikVergiNo = tcVkn }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Depolar.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<DepoDTO>();
        }

        public IEnumerable<SubeDTO> Subeler(string tcVkn)
        {
            var response = _genelServiceClient.GenelServisSubeler(new SubelerIstek() { TcKimlikVergiNo = tcVkn }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Subeler.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<SubeDTO>();
        }
        #endregion

        #region Ürün Servisleri
        public IEnumerable<MalinNiteligiDTO> MalNitelikleri()
        {
            var response = _urunServiceClient.UrunServiceMalinNiteligi(new MalinNiteligiIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.MalinNitelikleri.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<MalinNiteligiDTO>();
        }

        public IEnumerable<UrunDTO> Urunler()
        {
            var response = _urunServiceClient.UrunServiceUrunler(new UrunlerIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.Urunler.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<UrunDTO>();
        }

        public IEnumerable<UrunBirimiDTO> UrunBirimleri()
        {
            var response = _urunServiceClient.UrunServiceUrunBirimleri(new UrunBirimleriIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.UrunBirimleri.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<UrunBirimiDTO>();
        }

        public IEnumerable<UretimSekliDTO> UretimSekilleri()
        {
            var response = _urunServiceClient.UrunServiceUretimSekilleri(new UretimSekilleriIstek(), _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.UretimSekilleri.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<UretimSekliDTO>();
        }

        public IEnumerable<UrunCinsiDTO> UrunCinsleri(int urunId)
        {
            var response = _urunServiceClient.UrunServiceUrunCinsleri(new UrunCinsleriIstek() { UrunId = urunId }, _password, _servicePassword, _userName, out var kod, out var result);

            if (Result(kod, out var msg))
                return result.UrunCinsleri.AsEnumerable();

            if (_testEnv)
                ThrowErr(response[0].HataKodu, response[0].Mesaj, msg);
            return Enumerable.Empty<UrunCinsiDTO>();
        }
        #endregion

        private bool Result(string code, out string msg)
        {
            code = code?.Trim();

            switch (code)
            {
                case "GTBWSRV0000001":
                    msg = "İşlem başarılı";
                    return true;
                default:
                case "GTBWSRV0000002":
                    msg = "İşlem başarısız";
                    return false;
                case "GTBGLB00000001":
                    msg = "Beklenmeyen hata oluştu";
                    return false;
                case "GTBGLB00000011":
                    msg = "Kullanıcı bilgileri yanlış";
                    return false;
                case "GTBGLB00000012":
                    msg = "Kullanıcı belli bir süre bloklandı";
                    return false;
                case "GTBGLB00000013":
                    msg = "Kullanıcı bilgilerinden en az biri boş";
                    return false;
                case "GTBGLB00000014":
                    msg = "Kullanıcı servis şifresi geçici olarak iptal edilmiştir";
                    return false;
                case "GTBGLB00000015":
                    msg = "Kullanıcı birimi istek gönderilen servis için yetkili değil";
                    return false;
            }
        }

        private void ThrowErr(int code, string msg, string msg2)
        {
            var ex = new ApplicationException(string.Concat(code, " - ", msg, " - ", msg2));
            if (_testEnv)
                throw ex;
            else
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
        }

        private DateTime FillDate(DateTime value, DateTime alt) => value <= DateTime.MinValue ? alt : value;
    }
}
