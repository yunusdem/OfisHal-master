using OfisHal.Core.Domain;
using OfisHal.Data.Context;
using OfisHal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace OfisHal.Web.Controllers
{
    public class Select2OptionModel
    {
        public string Id { get; set; }

        public string Text { get; set; }
    }

    public class Select2PagedResult
    {
        public int Total { get; set; }

        public IList<Select2OptionModel> Results { get; set; }
    }

    public class CommonController : BaseController
    {
        private readonly Db _context;

        public CommonController(Db context) => _context = context;

        public async Task<ActionResult> Brands() =>
            PartialView("_Brands", await _context.VohalMarkas.Where(x => !x.Kapandi).OrderBy(x => x.Marka).ToListAsync());
        public async Task<ActionResult> ProducerNames(int tip) =>
            PartialView("_Producers", await GetItemsAsync(false, tip));
        public async Task<ActionResult> ProducerCodes(int tip) =>
            PartialView("_Producers", await GetItemsAsync(true, tip));
        public async Task<ActionResult> Carikartlar(int tip) =>
            PartialView("_Producers", await CarikartlarGetir(tip));
        public async Task<ActionResult> Iller(int ustId = 0) =>
            PartialView("_Iller", await IllerGetir(ustId));
        public async Task<ActionResult> MalAdlar() =>
            PartialView("_Mallar", await MallarGetir(false, false));
        public async Task<ActionResult> MalKodlar() =>
            PartialView("_Mallar", await MallarGetir(true, false));
        public async Task<ActionResult> Mallar() =>
            PartialView("_Mallar", await MallarGetir(true, true));
        public async Task<ActionResult> Kaplar() =>
            PartialView("_Kaplar", await KaplarGetir(false, false));
        public async Task<ActionResult> KapKodlar() =>
            PartialView("_Kaplar", await KaplarGetir(true, false));
        public async Task<ActionResult> AramaKaplar() =>
            PartialView("_Kaplar", await KaplarGetir(true, true));
        public async Task<ActionResult> Kullanicilar() =>
            PartialView("_Kullanicilar", await KullanicilarGetir());
        public async Task<ActionResult> HesapAdlar() =>
            PartialView("_Hesaplar", await HesaplarGetir(false, false));
        public async Task<ActionResult> HesapKodlar() =>
            PartialView("_Hesaplar", await HesaplarGetir(true, false));
        public async Task<ActionResult> Hesaplar() =>
            PartialView("_Hesaplar", await HesaplarGetir(true, true));
        public async Task<ActionResult> Maddeler(int tur)
        {
            ViewBag.turler = Turler();
            return PartialView("_Maddeler", await MaddelerGetir(tur));
        }
        public async Task<ActionResult> OAraclari(int tur)
        {
            return PartialView("_OdemeAraci", await OAraclariGetir(tur));
        }
        public async Task<ActionResult> OAraclariIade(int tur)
        {
            return PartialView("_OdemeAraci", await OAraclariGetir(tur));
        }
        public async Task<ActionResult> Sahipler(bool isCode) =>
            PartialView("_Producers", await SahiplerGetir(isCode));
        public async Task<ActionResult> RehinCariKartlar(int tip) =>
            PartialView("_RehinCariKartlar", await RehinCariKartlarGetir(tip));
        public async Task<ActionResult> BankaHesapAdlar(int bankId = 0) => await returnBankaHesaplar(false, bankId, false);
        public async Task<ActionResult> BankaHesapNumaralar(int bankId = 0) => await returnBankaHesaplar(true, bankId, false);
        public async Task<ActionResult> BankaHesaplar(int bankId = 0) => await returnBankaHesaplar(true, bankId, true);
        public async Task<ActionResult> CariHareketler(int tip) =>
            PartialView("_CariHareketler", await CariHareketlerGetir(tip));
        public async Task<ActionResult> HksMallar(int tur) =>
            PartialView("_HksMallar", await HksMallarGetir(tur));
        public async Task<ActionResult> HksMalCinsler(int malId) =>
            PartialView("_HksMalCinsler", await HksMalCinslerGetir(malId));
        public async Task<ActionResult> Faturalar(int tip) =>
            PartialView("_Faturalar", await FaturalarGetir(tip, 0, 0));
        public async Task<ActionResult> FiyatRefFaturalar(int tip, int cariKartId, int faturaId) =>
             PartialView("_FiyatRefFaturalar", await FaturalarGetir(tip, cariKartId, faturaId));
        public async Task<ActionResult> KesilmeyenFaturalar(string tarih) =>
            PartialView("_KesilmeyenFaturalar", await KesilmeyenFaturalarGetir(tarih));
        public async Task<ActionResult> KapHareketler(int kartTip) =>
            PartialView("_KapHareketler", await KapHareketlerGetir(kartTip));
        public async Task<ActionResult> HesapHareketler() =>
            PartialView("_HesapHareketler", await HesapHareketlerGetir());
        public async Task<ActionResult> BankaHareketler() =>
            PartialView("_BankaHareketler", await BankaHareketlerGetir());
        public async Task<ActionResult> PosCihazlar() =>
            PartialView("_PosCihazlar", await PosCihazlarGetir());
        public ActionResult StokKunyeler(int marka, int mal) =>
            PartialView("_StokKunyeler", StokKunyelerGetir(marka, mal));
        public async Task<ActionResult> SatisKunyeler(int tur) =>
            PartialView("_SatisKunyeler", await SatisKunyelerGetir(tur));
        public ActionResult Malfiyatlar(int marka, int mal) =>
            PartialView("_MalFiyatlar", MalFiyatlarGetir(marka, mal));
        public async Task<ActionResult> Dokumler() =>
            PartialView("_VohalAramaDokumler", await DokumlerGetir());
        public async Task<ActionResult> Haller() =>
            PartialView("_Haller", await HallerGetir());
        public async Task<ActionResult> Magazalar(int cariId) =>
            PartialView("_Magazalar", await MagazalarGetir(cariId));
        public async Task<ActionResult> RehinFisiBekleyen01(int tip, int cariKartId) =>
            PartialView("_RehinFisiBekleyen01", await RehinFisiBekleyen01Getir(tip, cariKartId));
        public async Task<ActionResult> RehinFisiBekleyenler(int tip) =>
            PartialView("_RehinFisiBekleyenler", await RehinFisiBekleyenlerGetir(tip));
        public async Task<ActionResult> Siparisler() =>
            PartialView("_Siparisler", await SiparislerGetir());
        public async Task<ActionResult> Makbuzlar(bool kesildi) =>
            PartialView("_Makbuzlar", await MakbuzlarGetir(kesildi));

        //public async Task<ActionResult> GibPostaKutular(string vkn, byte dokTip, byte pkTip, bool silindi) =>
        //    PartialView("_GibPostaKutular", await GibPostaKutularGetir(vkn, dokTip, pkTip, silindi));

        public async Task<ActionResult> GibPostaKutular(string vkn, byte dokTip, byte pkTip = 1, byte kayitSekli = 0, byte tip = 1) =>
        PartialView("_GibPostaKutular", await GibPostaKutularGetir(vkn, dokTip, pkTip, kayitSekli, tip));

        public async Task<ActionResult> GibFirmaPostaKutular(byte dokTip, byte pkTip = 1, byte kayitSekli = 0, byte tip = 0) =>
            PartialView("_GibPostaKutular", await GibFirmaPostaKutularGetir(dokTip, pkTip, kayitSekli, tip));

        public async Task<ActionResult> Markalar(bool kapandi) =>
            PartialView("_Markalar", await MarkalarGetir(kapandi));

        [HttpPost]
        public async Task<ActionResult> KapKaydet(string ad, string kod, float dara)
        {
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(kod))
                throw new ArgumentNullException(nameof(ad));

            if (string.IsNullOrWhiteSpace(kod))
                throw new ArgumentNullException(nameof(kod));

            _context.TohalKaps.Add(new TohalKap
            {
                Ad = ad,
                Kod = kod,
                Dara = dara,
            });

            await _context.SaveChangesAsync();

            return PartialView("_Kaplar", await KaplarGetir(false, false));
        }

        [HttpPost]
        public async Task<ActionResult> ProducerSave(bool isCode, string name, string code, string taxNo, int tip)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(code))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentNullException(nameof(code));

            _context.TohalCariKarts.Add(new TohalCariKart
            {
                Ad = name,
                Kod = code,
                VergiKimlikNo = taxNo,
                Tip = (byte)tip,
                UlkeId = 185,
                GidecegiYerTipi = 5
            });

            await _context.SaveChangesAsync();

            return PartialView("_Producers", await GetItemsAsync(isCode, tip));
        }
        [HttpPost]
        public async Task<ActionResult> MaddeKaydet(string ad, string kisaltma, byte tur)
        {
            ViewBag.turler = Turler();
            try
            {
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@TABLO_MADDESI_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    },
                    new SqlParameter("@TUR", SqlDbType.Int){ Value = (object)tur},
                    new SqlParameter("@AD", SqlDbType.NVarChar){ Value = (object)ad },
                    new SqlParameter("@KISALTMA", SqlDbType.NVarChar){ Value = (object)kisaltma},
                    new SqlParameter("@HKS_ID", SqlDbType.Int){ Value = (object)DBNull.Value },
                };
                await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_TABLO_MADDESI_KAYDET @TABLO_MADDESI_ID OUTPUT, @TUR, @AD, @KISALTMA, @HKS_ID", parameters.ToArray());
                var tabloMaddesiId = parameters[0].Value;
                return Json(new { result = true, message = "Kayıt Eklendi", data = new TohalTabloMaddesi { TabloMaddesiId = (int)tabloMaddesiId, Ad = ad, Kisaltma = kisaltma, Tur = tur } }, JsonRequestBehavior.AllowGet);
            }
            catch (SqlException ex)
            {
                return Json(new { result = false, message = "Kayıt Eklenmedi : " + ex.Errors[0].Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public async Task<ActionResult> IlKaydet(string ad, int tur)
        {
            if (string.IsNullOrWhiteSpace(ad))
                throw new ArgumentNullException(nameof(ad));


            //IL KAYDEDİLECEK YER YAZILACAK
            //_context.TohalCariKarts.Add(new TohalCariKart
            //{
            //    Ad = name,
            //    Kod = code,
            //    VergiKimlikNo = taxNo,
            //    Tip = (byte)tip,
            //    UlkeId = 185,
            //    GidecegiYerTipi = 5
            //});

            await _context.SaveChangesAsync();

            return PartialView("_Iller", await IllerGetir(0));
        }

        [HttpPost]
        public async Task<ActionResult> MalKaydet(string ad, string kod, byte tur)
        {
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(kod))
                throw new ArgumentNullException(nameof(ad));

            if (string.IsNullOrWhiteSpace(kod))
                throw new ArgumentNullException(nameof(kod));

            _context.TohalMals.Add(new TohalMal
            {
                Ad = ad,
                Kod = kod,
                Tur = tur
            });

            await _context.SaveChangesAsync();

            return PartialView("_Mallar", await MallarGetir(false, false));
        }
        [HttpPost]
        public async Task<ActionResult> KullaniciKaydet(string ad)
        {
            if (string.IsNullOrWhiteSpace(ad))
                throw new ArgumentNullException(nameof(ad));


            //KULLANICI KAYDEDİLECEK YER YAZILACAK
            //_context.TohalCariKarts.Add(new TohalCariKart
            //{
            //    Ad = name,
            //    Kod = code,
            //    VergiKimlikNo = taxNo,
            //    Tip = (byte)tip,
            //    UlkeId = 185,
            //    GidecegiYerTipi = 5
            //});
            await _context.SaveChangesAsync();

            return PartialView("_Kullanicilar", await KullanicilarGetir());
        }
        [HttpPost]
        public async Task<ActionResult> HesapKaydet(string ad, string kod, bool isCode)
        {
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(kod))
                throw new ArgumentNullException(nameof(ad));

            _context.TohalHesaps.Add(new TohalHesap
            {
                Ad = ad,
                Kod = kod
            });

            await _context.SaveChangesAsync();

            return PartialView("_Hesaplar", await HesaplarGetir(isCode, false));
        }
        [HttpPost]
        public async Task<ActionResult> BankaHesapKaydet(string no, string hesapad, string subead, int banka)
        {
            if (string.IsNullOrWhiteSpace(no))
                throw new ArgumentNullException(nameof(no));
            if (string.IsNullOrWhiteSpace(hesapad))
                throw new ArgumentNullException(nameof(hesapad));
            if (string.IsNullOrWhiteSpace(subead))
                throw new ArgumentNullException(nameof(subead));
            // BANKA HESABI EKLEME İŞLEMİ
            //_context.TohalBankaHesabis.Add(new TohalBankaHesabi
            //{
            //    HesapNo = no,
            //    HesapAdi = hesapad,
            //    SubeAdi = subead,
            //    BankaId = banka,
            //    Devir = 0
            //});

            await _context.SaveChangesAsync();
            return await returnBankaHesaplar(true, 0, false);
        }
        private async Task<List<TohalKullanici>> KullanicilarGetir() =>
             await _context.TohalKullanicis.OrderBy(x => x.KullaniciId).ToListAsync();
        private async Task<List<VohalKap>> KaplarGetir(bool isCode, bool unOrder) =>
            unOrder ? await _context.VohalKaps.ToListAsync() : await _context.VohalKaps.OrderBy(x => isCode ? x.Kod : x.Ad).ThenBy(x => x.KapId).ToListAsync();
        private async Task<List<TohalMal>> MallarGetir(bool isCode, bool unOrder) =>
            unOrder ? await _context.TohalMals.ToListAsync() : await _context.TohalMals.OrderBy(x => isCode ? x.Kod : x.Ad).ThenBy(x => x.MalId).ToListAsync();
        private async Task<List<TohalTabloMaddesi>> MaddelerGetir(int tur) =>
             await _context.TohalTabloMaddesis.Where(x => x.Tur == tur).OrderBy(x => x.Ad).ThenBy(x => x.TabloMaddesiId).ToListAsync();
        private async Task<List<VohalAramaOdemeAraci>> OAraclariGetir(int tur) =>
            await _context.VohalAramaOdemeAracis.Where(x => x.Tur == tur && x.SonrakiBordroId == null).OrderBy(x => x.OdemeAraciNo).ThenBy(x => x.OdemeAraciId).ToListAsync();
        private async Task<List<VohalAramaOdemeAraci>> OAraclariGetirIade(int tur) =>
            await _context.VohalAramaOdemeAracis.Where(x => x.Tur == tur && x.SonrakiBordroId == null && x.CariKartId == 0).OrderBy(x => x.OdemeAraciNo).ThenBy(x => x.OdemeAraciId).ToListAsync();
        private async Task<List<TohalYer>> IllerGetir(int ustid) =>
             await _context.TohalYers.Where(x => ustid == 0 ? !x.UstId.HasValue : x.UstId == ustid).OrderBy(x => x.Ad).ThenBy(x => x.YerId).ToListAsync();
        private async Task<List<TohalCariKart>> GetItemsAsync(bool isCode, int tip) =>
           await _context.TohalCariKarts.Where(x => x.Tip == tip).OrderBy(x => isCode ? x.Kod : x.Ad).ThenBy(x => x.CariKartId).ToListAsync();
        private async Task<List<TohalCariKart>> CarikartlarGetir(int tip) =>
            await _context.TohalCariKarts.Where(x => x.Tip == tip).ToListAsync();
        private async Task<List<VohalHesap>> HesaplarGetir(bool isCode, bool unOrder) =>
            unOrder ? await _context.VohalHesaps.OrderBy(x => x.HesapId).ToListAsync() : await _context.VohalHesaps.OrderBy(x => isCode ? x.Kod : x.Ad).ThenBy(x => x.HesapId).ToListAsync();
        private async Task<List<TohalCariKart>> SahiplerGetir(bool isCode) =>
             await _context.TohalCariKarts.OrderBy(x => isCode ? x.Kod : x.Ad).ThenBy(x => x.CariKartId).ToListAsync();
        private async Task<List<VohalBankaHesabi>> BankaHesaplarGetir(bool noOrName, int bankId, bool unOrder)
        {
            if (unOrder)
                return await _context.VohalBankaHesabis.ToListAsync();
            else
                return await _context.VohalBankaHesabis.Where(x => bankId == 0 || x.BankaId == bankId).OrderBy(x => noOrName ? x.HesapNo : x.HesapAdi).ThenBy(x => x.BankaHesabiId).ToListAsync();
        }
        private async Task<List<VohalAramaRehinHesabiOlmayanMusteriler>> RehinCariKartlarGetir(int tip) =>
             await _context.VohalAramaRehinHesabiOlmayanMusterilers.Where(x => x.Tip == tip).OrderBy(x => x.Ad).ThenBy(x => x.CariKartId).ToListAsync();
        private async Task<List<VohalCariHareket>> CariHareketlerGetir(int tip) =>
             await _context.VohalCariHarekets.Where(x => x.KartTipi == tip).ToListAsync();
        private async Task<List<VohalCariHareket>> MallarGetir(int tip) =>
             await _context.VohalCariHarekets.Where(x => x.KartTipi == tip).ToListAsync();
        private async Task<List<TohalHksMal>> HksMallarGetir(int tur) =>
             await _context.TohalHksMals.Where(x => x.Tur == tur).OrderBy(x => x.Ad).ThenBy(x => x.HksMalId).ToListAsync();
        private async Task<List<VohalHksMal>> HksMalCinslerGetir(int malId) =>
            await _context.VohalHksMals.Where(x => malId == 0 || x.MalAdiId == malId).OrderBy(x => x.MalCinsi).ThenBy(x => x.MalCinsiId).ToListAsync();
        private async Task<List<VohalAramaFatura>> FaturalarGetir(int tip, int cariKartId, int faturaId)
        {
            var query = _context.VohalAramaFaturas.Where(x => x.Tip == tip && (cariKartId == 0 || (x.CariKartId == cariKartId && x.FaturaId != faturaId)));
            if (cariKartId == 0)
                query = query.OrderBy(x => x.Unvan).ThenBy(x => x.FaturaId);
            else
                query = query.OrderBy(x => x.Tarih).ThenBy(x => x.FaturaId);

            return await query.ToListAsync();
        }
        private async Task<List<VohalAramaKesilmeyenSatisFaturasi>> KesilmeyenFaturalarGetir(string tarih)
        {
            var query = _context.VohalAramaKesilmeyenSatisFaturasis.AsQueryable();
            if (!string.IsNullOrEmpty(tarih))
            {
                DateTime.TryParse(tarih, out DateTime result);
                return await query.Where(x => x.Tarih == result).OrderBy(x => x.Unvan).ThenBy(x => x.FaturaId).ToListAsync();
            }
            return await query.OrderBy(x => x.Unvan).ThenBy(x => x.FaturaId).ToListAsync();

        }
        private async Task<List<VohalKapHareket>> KapHareketlerGetir(int kartTip) =>
            await _context.VohalKapHarekets.OrderBy(x => x.KapHareketId).Where(x => x.KartTipi == kartTip).ToListAsync();
        private async Task<List<VohalHesapHareketi>> HesapHareketlerGetir() =>
            await _context.VohalHesapHareketis.OrderBy(x => x.HesapHareketiId).ToListAsync();
        private async Task<List<TohalBankaHareketi>> BankaHareketlerGetir() =>
            await _context.TohalBankaHareketis.Include(x => x.BankaHesabi).OrderBy(x => x.BankaHareketiId).ToListAsync();
        private async Task<List<TohalPosCihazi>> PosCihazlarGetir() =>
            await _context.TohalPosCihazis.OrderBy(x => x.PosCihaziId).ToListAsync();
        private List<TohalKunyeBakiye> StokKunyelerGetir(int marka, int mal)
        {
            var res = StokKunyeStoreProc(marka, mal);
            res = res.OrderBy(x => x.KUNYE).ThenBy(x => x.KUNYE_ID).ToList();
            return res;
            //return await _context.VohalAramaDokumdenKunyes.Where(x => x.MarkaId == marka && x.MalId == mal).OrderBy(x => x.Kunye).ThenBy(x => x.KunyeId).ToListAsync();

        }

        private List<VohalFaturaSatiriUrt> MalFiyatlarGetir(int marka, int mal)
        {
            var malFiyatlari = _context.VohalFaturaSatiriUrts
                                        .Where(x => x.MarkaId == marka && x.MalId == mal)
                                        .OrderByDescending(x => x.FaturaTarihi) // Tarihe göre azalan sırayla sırala
                                        .Take(10) // İlk 10 kaydı al
                                        .ToList();
            return malFiyatlari;
            //return await _context.VohalAramaDokumdenKunyes.Where(x => x.MarkaId == marka && x.MalId == mal).OrderBy(x => x.Kunye).ThenBy(x => x.KunyeId).ToListAsync();

        }
        private async Task<List<VohalAramaKunye>> SatisKunyelerGetir(int tur) =>
            await _context.VohalAramaKunyes.Where(x => x.Tur == tur).OrderBy(x => x.Kunye).ThenBy(x => x.KunyeId).ToListAsync();
        private async Task<List<VohalAramaDokum>> DokumlerGetir() => await _context.VohalAramaDokums.ToListAsync();
        private async Task<List<TohalHal>> HallerGetir() => await _context.TohalHals.OrderBy(x => x.Ad).ThenBy(x => x.HalId).ToListAsync();
        private async Task<List<VohalMagaza>> MagazalarGetir(int cariId) => await _context.VohalMagazas.Where(x => x.CariKartId == cariId).OrderBy(x => x.MagazaId).ToListAsync();
        private async Task<List<VohalRehinFisiBekleyen01>> RehinFisiBekleyen01Getir(int tip, int cariKartId) =>
            await _context.VohalRehinFisiBekleyen01.Where(x => x.FaturaTipi == tip && x.KalanMiktar > 0.0 && x.CariKartId == cariKartId).OrderBy(x => x.FaturaNo).ThenBy(x => x.FaturaId).ToListAsync();
        private async Task<List<VohalRehinFisiBekleyen>> RehinFisiBekleyenlerGetir(int tip) =>
            await _context.VohalRehinFisiBekleyens.Where(x => x.FaturaTipi == tip && x.KalanMiktar > 0.0).OrderBy(x => x.FaturaNo).ThenBy(x => x.FaturaId).ToListAsync();
        private async Task<List<VohalSipari>> SiparislerGetir() =>
            await _context.VohalSiparis.OrderBy(x => x.SiparisNo).ThenBy(x => x.SiparisId).ToListAsync();

        //private async Task<List<TohalGibKullanici>> GibPostaKutularGetir(string vkn, byte dokTip, byte pkTip, bool silindi) =>
        //    await _context.TohalGibKullanicis.Where(x => x.Vkn == vkn && x.DokumanTipi == dokTip && x.PkTipi == pkTip && x.Silindi == silindi).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId).ToListAsync();

        private async Task<List<TohalGibKullanici>> GibPostaKutularGetir(string vkn, byte dokTip, byte pkTip, byte kayitSekli, byte tip) =>
            await _context.TohalGibKullanicis.Where(x => x.Vkn == vkn && x.DokumanTipi == dokTip && x.KayitSekli == kayitSekli ).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId).ToListAsync();

        private async Task<List<TohalGibKullanici>> GibFirmaPostaKutularGetir(byte dokTip, byte pkTip, byte kayitSekli, byte tip) =>
            await _context.TohalGibKullanicis.Where(x => x.DokumanTipi == dokTip && x.KayitSekli == kayitSekli).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId).ToListAsync();

        private async Task<List<VohalMarka>> MarkalarGetir(bool kapandi) =>
            await _context.VohalMarkas.Where(x => x.Kapandi == kapandi).OrderBy(x => x.Marka).ThenBy(x => x.MarkaId).ToListAsync();
        private async Task<List<VohalAramaMakbuz>> MakbuzlarGetir(bool kesildi) =>
            await _context.VohalAramaMakbuzs.Where(x => x.Kesildi == kesildi).OrderBy(x => x.DokumNo).ThenBy(x => x.MakbuzId).ToListAsync();

        private async Task<ActionResult> returnBankaHesaplar(bool noOrName, int bankId = 0, bool unOrder = false)
        {
            List<SelectListItem> banks = (from x in await MaddelerGetir(3)
                                          select new SelectListItem
                                          {
                                              Value = x.TabloMaddesiId.ToString(),
                                              Text = $"{x.Ad}",
                                          }).ToList();

            var model = new Tuple<IList<VohalBankaHesabi>, List<SelectListItem>>(await BankaHesaplarGetir(noOrName, bankId, unOrder), banks);
            return PartialView("_BankaHesaplar", model);
        }

        public async Task<ActionResult> cariGetir(int tip, string content, bool codeOrName, bool butunCari = false)
        {
            var query = _context.TohalCariKarts.Where(x => butunCari || x.Tip == tip);
            if (!butunCari) query = query.Where(x => x.Tip == tip);
            query = query.Where(x => codeOrName ? x.Kod.Contains(content) : x.Ad.Contains(content));
            var result = await query.OrderBy(x => codeOrName ? x.Kod : x.Ad).ToListAsync();
            if (result.Count > 1) return PartialView("_Producers", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> ilGetir(string content)
        {
            var result = await _context.TohalYers.Where(x => !x.UstId.HasValue && x.Ad.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_Iller", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> ilceGetir(int ustId, string content)
        {
            var result = await _context.TohalYers.Where(x => x.UstId == ustId && x.Ad.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_Iller", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> maddeGetir(int tur, string content)
        {
            ViewBag.turler = Turler();
            var result = await _context.TohalTabloMaddesis.Where(x => x.Tur == tur && x.Ad.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_Maddeler", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> oAraciGetir(int tur, string content)
        {
            var result = await _context.VohalAramaOdemeAracis.Where(x => x.Tur == tur && x.OdemeAraciNo.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_OdemeAraci", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> RehinCariKartGetir(int tip, string content)
        {
            var result = await _context.VohalAramaRehinHesabiOlmayanMusterilers.Where(x => x.Tip == tip && x.Ad.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_RehinCariKartlar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> KapGetir(bool codeOrName, string content)
        {
            var result = await _context.VohalKaps.Where(x => codeOrName ? x.Kod.Contains(content) : x.Ad.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_Kaplar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> MalGetir(bool codeOrName, string content)
        {
            var result = await _context.TohalMals.Where(x => codeOrName ? x.Kod.Contains(content) : x.Ad.Contains(content)).ToListAsync();
            result = result.OrderBy(x => codeOrName ? x.Kod : x.Ad).ToList();
            if (result.Count > 1) return PartialView("_Mallar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> KullaniciGetir(string content)
        {
            var result = await _context.TohalKullanicis.Where(x => x.Ad.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_Kullanicilar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> HesapGetir(bool codeOrName, string content)
        {
            var result = await _context.TohalHesaps.Where(x => codeOrName ? x.Kod.Contains(content) : x.Ad.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_Hesaplar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> BankaHesapGetir(bool nameOrNumber, string content, int bankid = 0)
        {
            var result = await _context.VohalBankaHesabis.Where(x => nameOrNumber ? x.HesapAdi.Contains(content) : x.HesapNo.Contains(content)).ToListAsync();
            result = result.Where(x => bankid == 0 || x.BankaId == bankid).ToList();
            if (result.Count > 1)
            {
                List<SelectListItem> banks = (from x in await MaddelerGetir(3) select new SelectListItem { Value = x.TabloMaddesiId.ToString(), Text = $"{x.Ad}" }).ToList();
                var model = new Tuple<IList<VohalBankaHesabi>, List<SelectListItem>>(result, banks);
                return PartialView("_BankaHesaplar", model);
            }
            else
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
        public async Task<ActionResult> HksMalGetir(int tur, string content)
        {
            var result = await _context.TohalHksMals.Where(x => x.Tur == tur && x.Ad.Contains(content)).ToListAsync();
            result = result.OrderBy(x => x.Ad).ThenBy(x => x.HksMalId).ToList();
            if (result.Count > 1) return PartialView("_HksMallar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> HksMalCinsGetir(int malId, string content)
        {
            var result = await _context.VohalHksMals.Where(x => x.MalCinsiId != null && ((malId == 0 || x.MalAdiId == malId)) && x.MalCinsi.Contains(content)).ToListAsync();
            result = result.OrderBy(x => x.MalCinsi).ThenBy(x => x.MalCinsiId).ToList();
            if (result.Count > 1) return PartialView("_HksMalCinsler", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> PosCihazGetir(string content)
        {
            var result = await _context.TohalPosCihazis.Where(x => x.Ad.Contains(content)).ToListAsync();
            if (result.Count > 1) return PartialView("_PosCihazlar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult StokKunyeGetir(string content, int? marka, int mal)
        {
            try
            {
                var res = StokKunyeStoreProc(marka, mal);
                //var guid = Guid.NewGuid();
                //var parametersVer = new List<SqlParameter>
                //{
                //    new SqlParameter("@TARIH", SqlDbType.DateTime) { Value = DateTime.Now },
                //    new SqlParameter("@MARKA_ID", SqlDbType.Int) { Value = marka },
                //    new SqlParameter("@MAL_ID", SqlDbType.Int) { Value = mal },
                //    new SqlParameter("@KUNYE_ID", DBNull.Value),
                //    new SqlParameter("@SIRALAMA", DBNull.Value),
                //    new SqlParameter("@HKS_KUNYELERI", SqlDbType.Bit) {Value = false},
                //    new SqlParameter("@ARANAN_TEXT", DBNull.Value),
                //    new SqlParameter("@GUID", SqlDbType.UniqueIdentifier) { Value = guid },
                //};

                //var result = _context.Database.SqlQuery<TohalKunyeBakiye>("EXEC SOHAL_KUNYE_BAKIYESI @TARIH, @MARKA_ID, @MAL_ID, @KUNYE_ID ,@SIRALAMA,@HKS_KUNYELERI,@ARANAN_TEXT,@GUID", parametersVer.ToArray()).ToList();
                //result = result.Where(x => x.Kunye != null).ToList();
                if (content != null && content != "")
                {
                    res = res.Where(x => x.KUNYE.Contains(content)).ToList();
                }

                if (res.Count > 1) return PartialView("_StokKunyeler", res);
                else return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json("Başarısız", JsonRequestBehavior.AllowGet);
            }
        }
        public async Task<ActionResult> SatisKunyeGetir(string content, int tur)
        {
            var result = await _context.VohalAramaKunyes.Where(x => x.Tur == tur && x.Kunye.Contains(content)).OrderBy(x => x.Kunye).ThenBy(x => x.KunyeId).ToListAsync();
            if (result.Count > 1) return PartialView("_SatisKunyeler", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> HalGetir(string content)
        {
            var result = await _context.TohalHals.Where(x => x.Ad.Contains(content)).OrderBy(x => x.Ad).ThenBy(x => x.HalId).ToListAsync();
            if (result.Count > 1) return PartialView("_Haller", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> RehinFisiBekleyen01Getir(string content, int tip, int cariKartId)
        {
            var result = await _context.VohalRehinFisiBekleyen01.Where(x => x.FaturaTipi == tip && x.KalanMiktar > 0.0 && x.CariKartId == cariKartId && x.FaturaNo.Contains(content)).OrderBy(x => x.FaturaNo).ThenBy(x => x.FaturaId).ToListAsync();
            if (result.Count > 1) return PartialView("_RehinFisiBekleyen01", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> RehinFisiBekleyenGetir(string content, int tip)
        {
            var result = await _context.VohalRehinFisiBekleyens.Where(x => x.FaturaTipi == tip && x.KalanMiktar > 0.0 && x.FaturaNo.Contains(content)).OrderBy(x => x.FaturaNo).ThenBy(x => x.FaturaId).ToListAsync();
            if (result.Count > 1) return PartialView("_RehinFisiBekleyen", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> SiparisGetir(string content)
        {
            var result = await _context.VohalSiparis.Where(x => x.SiparisNo.Contains(content)).OrderBy(x => x.SiparisNo).ThenBy(x => x.SiparisId).ToListAsync();
            if (result.Count > 1) return PartialView("_Siparisler", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> FiyatRefFatGetir(string content, int tip, int cariKartId, int faturaId)
        {
            var result = await _context.VohalAramaFaturas.Where(x => x.Tip == tip && x.CariKartId == cariKartId && x.FaturaId != faturaId && x.ReferansNo.Contains(content)).OrderBy(x => x.Tarih).ThenBy(x => x.FaturaId).ToListAsync();
            if (result.Count > 1) return PartialView("_FiyatRefFaturalar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> PostaKutusuGetir(string content, string vkn, byte dokTip, byte pkTip = 1, byte kayitSekli = 0, byte tip = 0)
        {
            //var result = await _context.TohalGibKullanicis.Where(x => x.Vkn == vkn && x.DokumanTipi == dokTip && x.PkTipi == pkTip && x.Silindi == silindi && x.PostaKutusu.Contains(content)).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId).ToListAsync();
            //if (result.Count > 1) return PartialView("_GibPostaKutular", result);
            //else return Json(result, JsonRequestBehavior.AllowGet);

            var result = await _context.TohalGibKullanicis.Where(x => x.Vkn == vkn && x.DokumanTipi == dokTip && x.KayitSekli == kayitSekli && x.PostaKutusu.Contains(content)).OrderBy(x => x.PostaKutusu).ThenBy(x => x.GibKullaniciId).ToListAsync();
            if (result.Count > 1) return PartialView("_GibPostaKutular", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<ActionResult> MarkaGetir(string content, bool kapandi)
        {
            var result = await _context.VohalMarkas.Where(x => x.Kapandi == kapandi && x.Marka.Contains(content)).OrderBy(x => x.Marka).ThenBy(x => x.MarkaId).ToListAsync();
            if (result.Count > 1) return PartialView("_Markalar", result);
            else return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> getCariById(int id)
        {
            var val = await _context.VohalCariKarts.FirstOrDefaultAsync(x => x.CariKartId == id);
            return Json(val, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> getCariByIdCustom(int id)
        {

            //var val = await _context.TohalCariKarts.Include(y=> y.TohalMagazas).FirstOrDefaultAsync(x => x.CariKartId == id);
            var val = await _context.VohalCariKarts.FirstOrDefaultAsync(x => x.CariKartId == id);
            var bakiye = Convert.ToDouble(await BakiyeSoyleAsync(id));
            return Json(new { val = val, bakiye = bakiye }, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> getKapById(int id) => Json(await _context.VohalAramaKaps.FirstOrDefaultAsync(x => x.KapId == id), JsonRequestBehavior.AllowGet);
        public async Task<JsonResult> getBankaHesapById(int id) => Json(await _context.VohalBankaHesabis.FirstOrDefaultAsync(x => x.BankaHesabiId == id), JsonRequestBehavior.AllowGet);
        public async Task<JsonResult> getHesapById(int id) => Json(await _context.TohalHesaps.FirstOrDefaultAsync(x => x.HesapId == id), JsonRequestBehavior.AllowGet);
        public async Task<JsonResult> MagazalarGetirJson(int id) => Json(await MagazalarGetir(id), JsonRequestBehavior.AllowGet);
        private Dictionary<int, string> Turler()
        {
            return new Dictionary<int, string>() {
                { 0, "Posta Kodu" },
                { 1, "Şehir" },
                { 2, "Vergi Dairesi" },
                { 3, "Banka" },
                { 11, "Teslimat Şekli" },
                { 12, "Ulaşım Şekli" },
                { 13, "Ödeme Şekli" },
                { 14, "Para Birimi" },
                { 15, "Şoför" },
            };
        }
        public void RemoveIskele()
        {
            _context.TohalIskeleFaturaSatiris.RemoveRange(_context.TohalIskeleFaturaSatiris);
            _context.TohalIskeleRehinFisis.RemoveRange(_context.TohalIskeleRehinFisis);
            _context.SaveChanges();
        }

        public async Task<string> BakiyeSoyleAsync(int id)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@CARI_KART_ID", SqlDbType.Int) { Value = id },
                new SqlParameter("@BAKIYE",SqlDbType.Float) { Direction = ParameterDirection.Output },
                new SqlParameter("@REHINDEKI_KAP_TUTARI", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                new SqlParameter("@KESILMEMIS_FATURA_TUTARI", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                new SqlParameter("@KESILMEYEN_DAHIL_REHINDEKI_KAP_TUTARI", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                new SqlParameter("@BELGE_BASMADAN_CAGRILDI", SqlDbType.Bit) { Value = 0 },
                new SqlParameter("@BORC_TOPLAMI", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                new SqlParameter("@ALACAK_TOPLAMI", SqlDbType.Decimal) { Direction = ParameterDirection.Output }
            };
            await _context.Database.ExecuteSqlCommandAsync("EXEC SOHAL_CARI_BAKIYEYI_SOYLE @CARI_KART_ID, @BAKIYE OUTPUT, @REHINDEKI_KAP_TUTARI OUTPUT, @KESILMEMIS_FATURA_TUTARI OUTPUT, @KESILMEYEN_DAHIL_REHINDEKI_KAP_TUTARI OUTPUT, @BELGE_BASMADAN_CAGRILDI, @BORC_TOPLAMI OUTPUT, @ALACAK_TOPLAMI OUTPUT", parameters.ToArray());
            var bakiye = parameters[1].Value.ToString().Replace('.', ',');
            return bakiye;
        }
        private List<TohalKunyeBakiye> StokKunyeStoreProc(int? marka, int mal)
        {
            var guid = Guid.NewGuid();
            var parametersVer = new List<SqlParameter>
            {
                new SqlParameter("@TARIH", SqlDbType.DateTime) { Value = DateTime.Now },
               //new SqlParameter("@MARKA_ID", SqlDbType.Int) { Value = marka },
                new SqlParameter("@MARKA_ID", DBNull.Value),
                new SqlParameter("@MAL_ID", SqlDbType.Int) { Value = mal },
                new SqlParameter("@KUNYE_ID", DBNull.Value),
                new SqlParameter("@SIRALAMA", DBNull.Value),
                new SqlParameter("@HKS_KUNYELERI", SqlDbType.Bit) {Value = true},
                new SqlParameter("@ARANAN_TEXT", DBNull.Value),
                new SqlParameter("@GUID", SqlDbType.UniqueIdentifier) { Value = guid },
            };
            var result = _context.Database.SqlQuery<TohalKunyeBakiye>("EXEC SOHAL_KUNYE_BAKIYESI @TARIH, @MARKA_ID, @MAL_ID, @KUNYE_ID ,@SIRALAMA,@HKS_KUNYELERI,@ARANAN_TEXT,@GUID", parametersVer.ToArray()).ToList();
            result = result.Where(x => x.KUNYE != null && x.MALIN_MIKTARI >= 0)
              .GroupBy(x => x.KUNYE)
              .Select(group => group.First())
              .ToList();
            return result;
        }
    }
}
