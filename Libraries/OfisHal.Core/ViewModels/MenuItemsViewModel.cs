using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OfisHal.Core.ViewModels
{
    public class MenuItemsViewModel
    {
        public class MenuItems
        {
            public int Id { get; set; }
            public int UstId { get; set; }
            public string Title { get; set; }
            public string IconClass { get; set; }
            public string Url { get; set; }
            public List<MenuItems> SubMenu { get; set; }
        }

        public List<MenuItems> GetMenuItems()
        {
            return new List<MenuItems>() {
                //Müstahsil İşlemleri
                new MenuItems
                {
                    Title = "Cari Kart İşlemleri", IconClass = "mdi-account-arrow-down", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Tedarikçi Kayıt", IconClass = null, Url = "/TohalCariKarts/Create"},
                        new MenuItems {Title = "Müşteri Kayıt", IconClass = null, Url = "/TohalCariKarts/MCreate"},
                        new MenuItems {Title = "Araç Kayıt", IconClass = null, Url = "/TohalCariKarts/MCreate"},
                        new MenuItems {Title = "Personel Kayıt", IconClass = null, Url = "/TohalCariKarts/MCreate"},
                        new MenuItems {Title = "Cari Kayıt", IconClass = null, Url = "/TohalCariHarekets/Create"},
                        new MenuItems {Title = "Tedarikçi Liste", IconClass = null, Url = "/reports/details/mustahsilliste"},
                        new MenuItems {Title = "Tedarilçi Son Ürün Hareket Raporu", IconClass = null, Url = "/reports/details/mustahsilsonurun"},
                        new MenuItems {Title = "Tedarikçi Ciro Raporu", IconClass = null, Url = "/reports/details/mustahsilciro"},
                        new MenuItems {Title = "Tedarikçi Satış Raporu", IconClass = null, Url = "/reports/details/mustahsilsatis"},
                        new MenuItems {Title = "Tedarikçi Ürün Hareket Listesi (Detay)", IconClass = null, Url = "/reports/details/mustahsilurunhareketdetay"},
                        new MenuItems {Title = "Tedarikçi Cari Hareket Raporu", IconClass = null, Url = "/reports/details/mustahsilcarihareket"},
                    }
                },
                //Müşteri Cari
                new MenuItems
                {
                    Title = "Müşteri İşlemleri", IconClass = "mdi-account-arrow-up", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        
                        new MenuItems {Title = "Tahsilat Kayıt", IconClass = null, Url = "/TohalCariHarekets/MCreate"},
                        new MenuItems {Title = "Müşteri Veresiye Defteri", IconClass = null, Url = "/reports/details/musteriveresiyedefteri"},
                        new MenuItems {Title = "Müşteri Veresiye Mizan", IconClass = null, Url = "/reports/details/musteriveresiyemizan"},
                        new MenuItems {Title = "Müşteri Veresiye Takip", IconClass = null, Url = "/reports/details/musteriveresiyetakip"},
                        new MenuItems {Title = "Müşteri Listesi", IconClass = null, Url = "/reports/details/musterilistesi"},
                       new MenuItems {Title = "Müşteri Cari Hareket Raporu", IconClass = null, Url = "/reports/details/mustericarihareket"},
                        new MenuItems {Title = "Müşteri Risk Analizi Raporu", IconClass = null, Url = "/reports/details/musteririskanalizi"},
                    }
                },
                //Alış İşlemleri
                new MenuItems
                {
                    Title = "Alış - Satınalma İşlemleri", IconClass = "mdi-alpha-a-box", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Araç Plaka Ruhsat ", IconClass = null, Url = "/AlisIslemleri/Index"},
                        new MenuItems {Title = "Gider Faturası", IconClass = null, Url = "/AlisIslemleri/Index"},
                        new MenuItems {Title = "Alış Faturası", IconClass = null, Url = "/AlisIslemleri/Index"},
                        new MenuItems {Title = "Sipariş", IconClass = null, Url = "/AlisIslemleri/Siparis"},
                        new MenuItems {Title = "Alış Faturası Dökümü", IconClass = null, Url = "/reports/details/alisfaturasidokumu"},
                        new MenuItems {Title = "Kdv Bazlı Alış Fatura Listesi", IconClass = null, Url = "/reports/details/aliskdvbazlifaturalistesi"},
                        new MenuItems {Title = "Alış İstatistiği", IconClass = null, Url = "/reports/details/alisistat"},
                         new MenuItems {Title = "Alış Takibi", IconClass = null, Url = "/reports/details/alistakibi"},
                    }

                },
                //Satış İşlemleri
                new MenuItems
                {
                    Title = "Satış İşlemleri", IconClass = "mdi-alpha-s-box", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Satış Faturası", IconClass = null, Url = "/TohalFaturas/Index"},
                        new MenuItems {Title = "Satış Takibi", IconClass = null, Url = "/reports/details/satistakibi"},
                        new MenuItems
                        {
                            Title = "Satış Raporları", IconClass = null, Url = null,
                            SubMenu = new List<MenuItems>()
                            {
                                new MenuItems {Title = "Satış İcmali", IconClass = null, Url = "/reports/details/satisicmali"},
                                new MenuItems {Title = "Satış İstatistiği", IconClass = null, Url = "/reports/details/satisistat"},
                                new MenuItems {Title = "Müşteri Satış İstatistiği", IconClass = null, Url = "/reports/details/satismusteriistat"},
                                new MenuItems {Title = "Satış Faturası Dökümü", IconClass = null, Url = "/reports/details/satisfaturasidokumu"},
                                new MenuItems {Title = "Kdv Bazlı Fatura Listesi", IconClass = null, Url = "/reports/details/satiskdvbazlifaturalistesi"},
                                new MenuItems {Title = "Müşteri Ciro Raporu", IconClass = null, Url = "/reports/details/satismustericiro"},
                                new MenuItems {Title = "Müşteri Satış Listesi", IconClass = null, Url = "/reports/details/satismusterilistesi"},
                                new MenuItems {Title = "Satış İzlenebilirliği Raporu", IconClass = null, Url = "/reports/details/satisizlenebilirligi"},
                               }
                        },
                        new MenuItems {Title = "Kullanıcı Satış Durumu", IconClass = null, Url = "/reports/details/satiskullanicidurumu"},
                        new MenuItems {Title = "Fatura Aktarma", IconClass = null, Url = "/SatisIslemleri/FaturaAktarma"},
                        //new MenuItems {Title = "Künye Bildirim Listesi", IconClass = null, Url = "/SatisIslemleri/KunyeBildirimListesi"},
                        new MenuItems {Title = "E-Belge Bildirimi", IconClass = null, Url = "/Invoice/Index"},
                       /* new MenuItems {Title = "Mağaza Bazında Satış Takibi", IconClass = null, Url = "/reports/details/satismagazabazindatakibi"},*/ //RAPOR DA HATA VAR RAPOR AKTARILAMADI
                    }
                },
                //Döküm İşlemleri
                new MenuItems
                {
                    Title = "Operasyon İşlemleri", IconClass = "mdi-alpha-d-box", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "İş emri", IconClass = null, Url = "/DokumIslemleri/Stok"},
                        new MenuItems {Title = "Aktarma", IconClass = null, Url = "/reports/details/dokumstokliste"},
                        new MenuItems {Title = "Abron Aktarma", IconClass = null, Url = "/DokumIslemleri/IslemdekiFaturalar"},
                        new MenuItems {Title = "Thy Yuk senedi-Manifesto", IconClass = null, Url = "/DokumIslemleri/HazirFaturalar"},
                        new MenuItems {Title = "Çağrı Talep oluşturma", IconClass = null, Url = "/DokumIslemleri/KesilmisFaturalar"},
                         new MenuItems
                        {
                            Title = "Operasyon Raporları", IconClass = null, Url = null,
                            SubMenu = new List<MenuItems>()
                            {
                                new MenuItems {Title = "Genel Rapor", IconClass = null, Url = "/reports/details/dokumgenelrapor"},
                                new MenuItems {Title = "Detaylı Diğer Masraflar", IconClass = null, Url = "/reports/details/dokumdetaylimasraflar"},
                               }
                        },
                    }
                },
                ////Güvenlik İşlemleri
                new MenuItems
                {
                    Title = "Fuar  İşlemleri", IconClass = "mdi-alpha-k-box", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Fuar Tanımları", IconClass = null, Url = "/KasaIslemleri/KasaHareketKayit"},
                        new MenuItems {Title = "Personle Zimmet", IconClass = null, Url = "/reports/details/kasadefteri"},
                    }
                },
                ////Güvenlik İşlemleri
                new MenuItems
                {
                    Title = "Güvenlik  İşlemleri", IconClass = "mdi-alpha-k-box", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Silah ve Ruhsat Tanımları", IconClass = null, Url = "/KasaIslemleri/KasaHareketKayit"},
                        new MenuItems {Title = "Personle Zimmet", IconClass = null, Url = "/reports/details/kasadefteri"},
                    }
                },
                ////onay İşlemleri
                new MenuItems
                {
                    Title = "Onay  İşlemleri", IconClass = "mdi-alpha-k-box", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Kasa şifre onay", IconClass = null, Url = "/KasaIslemleri/KasaHareketKayit"},
                        new MenuItems {Title = "Kullanıcı Giriş onay", IconClass = null, Url = "/reports/details/kasadefteri"},
                        }
                },
                ////Kasa İşlemleri
                new MenuItems
                {
                    Title = "Kasa İşlemleri", IconClass = "mdi-alpha-k-box", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Kasa Hareketi", IconClass = null, Url = "/KasaIslemleri/KasaHareketKayit"},
                        new MenuItems {Title = "Kasa Defteri", IconClass = null, Url = "/reports/details/kasadefteri"},
                        new MenuItems {Title = "Kasa Bilanço", IconClass = null, Url = "/reports/details/kasabilanco"},
                        new MenuItems {Title = "Bordro Hesabı", IconClass = null, Url = "/reports/details/kasabordrohesabi"},
                        new MenuItems {Title = "Hesap Kayıt", IconClass = null, Url = "/TohalHesaps/Create"},
                        new MenuItems {Title = "Hesap Ad Liste", IconClass = null, Url = "/reports/details/kasahesapadliste"},
                        new MenuItems {Title = "Hesaplar Cari Defteri", IconClass = null, Url = "/reports/details/kasahesaplarcaridefteri"},
                        new MenuItems {Title = "Hesaplar Cari Mizanı", IconClass = null, Url = "/reports/details/kasahesaplarcarimizani"},
                        new MenuItems {Title = "Nakit Kredi Kartı İşlemleri Raporu", IconClass = null, Url = "/reports/details/kasanakitkkartislemleri"},
                    }
                },
                //Banka Çek senet İşlemleri
                new MenuItems
                {
                    Title = "Banka/Çek-Senet İşlemleri", IconClass = "mdi-bank", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Tahsilat", IconClass = null, Url = "/CekSenetIslemleri/Tahsilat"},
                        new MenuItems {Title = "Ödeme", IconClass = null, Url = "/CekSenetIslemleri/Odeme"},
                        new MenuItems {Title = "Karşılıksız Portföye İade", IconClass = null, Url = "/CekSenetIslemleri/KarsiliksizPortfoyeIade"},
                        new MenuItems {Title = "Portföye İade", IconClass = null, Url = "/CekSenetIslemleri/PortfoyeIade"},
                        new MenuItems {Title = "Elden Tahsil", IconClass = null, Url = "/CekSenetIslemleri/EldenTahsil"},
                        new MenuItems {Title = "İade", IconClass = null, Url = "/CekSenetIslemleri/Iade"},
                        new MenuItems {Title = "Firma Çek-Senet Elden Ödeme", IconClass = null, Url = "/CekSenetIslemleri/FirmaCekEldenOdeme"},
                        new MenuItems {Title = "Çek Listesi", IconClass = null, Url = "/reports/details/ceklistesi"},
                        new MenuItems {Title = "Senet Listesi", IconClass = null, Url = "/reports/details/senetlistesi"},
                        new MenuItems {Title = "Firma Çeki Listesi", IconClass = null, Url = "/reports/details/firmacekilistesi"},
                        new MenuItems {Title = "Firma Senedi Listesi", IconClass = null, Url = "/reports/details/firmasenedilistesi"},
                        new MenuItems {Title = "Vadesi Gelen Çek-Senet Listesi", IconClass = null, Url = "/reports/details/vadesigelenceksenet"},
                        new MenuItems {Title = "Banka Hesabı Kayıt", IconClass = null, Url = "/TohalBankaHesabis/Create"},
                        new MenuItems {Title = "Banka Hareket Kayıt", IconClass = null, Url = "/TohalBankaHareketis/Create"},
                        new MenuItems {Title = "Tahsile Verme", IconClass = null, Url = "/BankaIslemleri/TahsileVerme"},
                        new MenuItems {Title = "Tahsil", IconClass = null, Url = "/BankaIslemleri/Tahsil"},
                        new MenuItems {Title = "Karşılıksız Portföye İade", IconClass = null, Url = "/BankaIslemleri/KarsiliksizPortfoyeIade"},
                        new MenuItems {Title = "Portföye İade", IconClass = null, Url = "/BankaIslemleri/PortfoyeIade"},
                        new MenuItems {Title = "Firma Çek Ödeme", IconClass = null, Url = "/BankaIslemleri/FirmaCekOdeme"},
                        new MenuItems {Title = "POS Ekstre Raporu", IconClass = null, Url = "/reports/details/bankaposekstre"},
                        new MenuItems {Title = "Hesap Ekstre Raporu", IconClass = null, Url = "/reports/details/bankahesapekstre"},
                        new MenuItems {Title = "Hesab Bakiye Raporu", IconClass = null, Url = "/reports/details/bankahesapbakiye"},
                        new MenuItems {Title = "Günlük Durum Özet Raporu", IconClass = null, Url = "/reports/details/bankagunlukdurumozet"},
                    }
                },
                //Teknik İşlemleri
                new MenuItems
                {
                    Title = "Teknik İşlemler", IconClass = "mdi-tools", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Ürün - Hizmet Kayıt", IconClass = null, Url = "/TohalMals/Create"},
                        new MenuItems {Title = "Ürün - Hizmet Liste", IconClass = null, Url = "/reports/details/teknikmalliste"},
                        new MenuItems {Title = "Kullanıcı Tanımları", IconClass = null, Url = "/TeknikIslemler/KullaniciTanimlari"},
                        //new MenuItems {Title = "Yazıcı Tanımları", IconClass = null, Url = "/TeknikIslemler/YaziciTanimlari"},
                        new MenuItems {Title = "Sistem Tanımları", IconClass = null, Url = "/TeknikIslemler/HalEntegreTanimlari"},
                      
                        //new MenuItems {Title = "Cari Fiyat Listeleri", IconClass = null, Url = "/TeknikIslemler/CariFiyatListeleri"},
                        new MenuItems {Title = "Fiyat Listleri", IconClass = null, Url = "/TeknikIslemler/PiyasaFiyatListeleri"},
                        //new MenuItems {Title = "KDV Tevkifat Tanımları", IconClass = null, Url = "/TeknikIslemler/KdvTevkifatTanimlari"},
                        //new MenuItems
                        //{
                        //    Title = "Servis İşlemleri", IconClass = null, Url = null,
                        //    SubMenu = new List<MenuItems>()
                        //    {
                        //        new MenuItems {Title = "Devir Ayarları", IconClass = null, Url = "/TeknikIslemler/DevirAyarlari"},
                        //        new MenuItems {Title = "Devir İşlemleri", IconClass = null, Url = "/TeknikIslemler/DevirIslemleri"},
                        //        new MenuItems {Title = "Dönemi Onayla", IconClass = null, Url = "/TeknikIslemler/DonemiOnayla"},
                        //        new MenuItems {Title = "Müstahsil İl/İlçe/Beldeyi Döküme Aktar", IconClass = null, Url = "/TeknikIslemler/MustahsilIlIlceBeldeAktar"},
                        //        new MenuItems {Title = "Müstahsil hal Bilgisini Döküme Aktar", IconClass = null, Url = "/TeknikIslemler/MustahsilHalBilgisiAktar"},
                        //        new MenuItems {Title = "Müşteri İl/İlçe/Beldeyi Satışa Aktar", IconClass = null, Url = "/TeknikIslemler/MusteriIlIlceBeldeAktar"},
                        //        new MenuItems {Title = "Müşteri hal Bilgisini Satışa Aktar", IconClass = null, Url = "/TeknikIslemler/MusterilHalBilgisiAktar"},
                        //        new MenuItems {Title = "Kayıtsız Müşteri/İLçe/Beldeyi Satışa Aktar", IconClass = null, Url = "/TeknikIslemler/KayitsizMusteriIlIlceBeldeAktar"},
                        //        new MenuItems {Title = "Kayıtsız Müşteri Hal Bilgisini Satışa Aktar", IconClass = null, Url = "/TeknikIslemler/KayitsizMusteriHalBilgisiAktar"},
                        //        new MenuItems {Title = "Künye Alınmayanların Listesi", IconClass = null, Url = "/TeknikIslemler/KunyeAlinmayanlarinListesi"},
                        //        new MenuItems {Title = "Müşteri İşyerlerini Doldur", IconClass = null, Url = "/TeknikIslemler/MusteriIsYerleriniDoldur"},
                        //        new MenuItems {Title = "Yeni Tablo Açma", IconClass = null, Url = "/TeknikIslemler/YeniTabloAcma"},
                        //        new MenuItems {Title = "İndeksi Yenile", IconClass = null, Url = "/Authentication/SignInBasic"},
                        //        new MenuItems {Title = "İstek-Cevap Tablosunu Sil", IconClass = null, Url = "/Authentication/SignInBasic"},
                        //        new MenuItems {Title = "Müşterilerin E-Fatura Bakiye Var Seçilmesi", IconClass = null, Url = "/Authentication/SignInBasic"},
                        //    }
                        //},
                    }
                },
            };
        }

        public List<MenuItems> GetMenuItemsHome()
        {
            return new List<MenuItems>() {
                //Müstahsil İşlemleri
                new MenuItems
                {
                    Title = "Cari Kart İşlemleri", IconClass = "user", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Tedarikçi Kayıt", IconClass = null, Url = "/TohalCariKarts/Create"},
                        new MenuItems {Title = "Cari Kayıt", IconClass = null, Url = "/TohalCariHarekets/Create"},
                        new MenuItems {Title = "Cari Defteri", IconClass = null, Url = "/reports/details/mustahsilcaridefteri"},
                        new MenuItems {Title = "Cari Mizan", IconClass = null, Url = "/reports/details/mustahsilcarimizan"},
                        new MenuItems {Title = "Kap Cari Kayıt", IconClass = null, Url = "/TohalKapHarekets/Edit"},
                        new MenuItems {Title = "Kap Cari Defteri", IconClass = null, Url = "/reports/details/mustahsilkapcaridefteri"},
                        new MenuItems {Title = "Kap Cari Mizanı", IconClass = null, Url = "/reports/details/mustahsilkapcarimizani"},
                        new MenuItems {Title = "Müstahsil Liste", IconClass = null, Url = "/reports/details/mustahsilliste"},
                        //new MenuItems {Title = "Müstahsil Son Ürün Hareket Raporu", IconClass = null, Url = "/reports/details/mustahsilsonurun"},
                        //new MenuItems {Title = "Müstahsil Ciro Raporu", IconClass = null, Url = "/reports/details/mustahsilciro"},
                        //new MenuItems {Title = "Müstahsil Ticari Ciro Raporu", IconClass = null, Url = "/reports/details/mustahsilticariciro"},
                        //new MenuItems {Title = "Müstahsil Satış İstatistiği", IconClass = null, Url = "/reports/details/mustahsilsatisistat"},
                        //new MenuItems {Title = "Müstahsil Satış Raporu", IconClass = null, Url = "/reports/details/mustahsilsatis"},
                        //new MenuItems {Title = "Bağkur Muafiyet Raporu", IconClass = null, Url = "/reports/details/mustahsilbagkurmuafiyet"},
                        //new MenuItems {Title = "Müstahsil Ürün Hareket Listesi (Detay)", IconClass = null, Url = "/reports/details/mustahsilurunhareketdetay"},
                        //new MenuItems {Title = "Müstahsil Cari Hareket Raporu", IconClass = null, Url = "/reports/details/mustahsilcarihareket"},
                    }
                },
                //Müşteri Cari
                new MenuItems
                {
                    Title = "Müşteri İşlemleri", IconClass = "user", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Müşteri Kayıt", IconClass = null, Url = "/TohalCariKarts/MCreate"},
                        new MenuItems {Title = "Veresiye Kayıt", IconClass = null, Url = "/TohalCariHarekets/MCreate"},
                        new MenuItems {Title = "Veresiye Defteri", IconClass = null, Url = "/reports/details/musteriveresiyedefteri"},
                        new MenuItems {Title = "Veresiye Mizan", IconClass = null, Url = "/reports/details/musteriveresiyemizan"},
                        new MenuItems {Title = "Veresiye Takip", IconClass = null, Url = "/reports/details/musteriveresiyetakip"},
                        new MenuItems {Title = "Müşteri Listesi", IconClass = null, Url = "/reports/details/musterilistesi"},
                        new MenuItems {Title = "Rehin İade Düzeltme", IconClass = null, Url = "/MusteriCari/RehinIadeDuzeltme"},
                        new MenuItems {Title = "Kap Cari Defteri", IconClass = null, Url = "/reports/details/musterikapcaridefteri"},
                        new MenuItems {Title = "Kap Cari Mizanı", IconClass = null, Url = "/reports/details/musterikapcarimizan"},
                        new MenuItems {Title = "Müşteri Cari Hareket Raporu", IconClass = null, Url = "/reports/details/mustericarihareket"},
                        new MenuItems {Title = "Müşteri Risk Analizi Raporu", IconClass = null, Url = "/reports/details/musteririskanalizi"},
                    }
                },
                //Alış İşlemleri
                new MenuItems
                {
                    Title = "Alış - Satınalma İşlemleri", IconClass = "shopping-bag", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Araç Plaka Ruhsat ", IconClass = null, Url = "/AlisIslemleri/Index"},
                        new MenuItems {Title = "Gider Faturası", IconClass = null, Url = "/AlisIslemleri/Index"},
                        new MenuItems {Title = "Alış Faturası", IconClass = null, Url = "/AlisIslemleri/Index"},
                        new MenuItems {Title = "Sipariş", IconClass = null, Url = "/AlisIslemleri/Siparis"},
                        new MenuItems {Title = "Alış Faturası Dökümü", IconClass = null, Url = "/reports/details/alisfaturasidokumu"},
                        new MenuItems {Title = "Kdv Bazlı Alış Fatura Listesi", IconClass = null, Url = "/reports/details/aliskdvbazlifaturalistesi"},
                        new MenuItems {Title = "Alış İstatistiği", IconClass = null, Url = "/reports/details/alisistat"},
                        new MenuItems {Title = "Alış Takibi", IconClass = null, Url = "/reports/details/alistakibi"},
                    }


                },
                //Satış İşlemleri
                new MenuItems
                {
                    Title = "Satış İşlemleri", IconClass = "dollar-sign", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Satış Faturası", IconClass = null, Url = "/TohalFaturas/Index"},
                        new MenuItems {Title = "Satış Takibi", IconClass = null, Url = "/reports/details/satistakibi"},
                        new MenuItems
                        {
                            Title = "Satış Raporları", IconClass = null, Url = null,
                            SubMenu = new List<MenuItems>()
                            {
                                new MenuItems {Title = "Satış İcmali", IconClass = null, Url = "/reports/details/satisicmali"},
                                new MenuItems {Title = "Satış İstatistiği", IconClass = null, Url = "/reports/details/satisistat"},
                                new MenuItems {Title = "Müşteri Satış İstatistiği", IconClass = null, Url = "/reports/details/satismusteriistat"},
                                new MenuItems {Title = "Satış Faturası Dökümü", IconClass = null, Url = "/reports/details/satisfaturasidokumu"},
                                new MenuItems {Title = "Kdv Bazlı Fatura Listesi", IconClass = null, Url = "/reports/details/satiskdvbazlifaturalistesi"},
                                new MenuItems {Title = "Müşteri Ciro Raporu", IconClass = null, Url = "/reports/details/satismustericiro"},
                                new MenuItems {Title = "Müşteri Satış Listesi", IconClass = null, Url = "/reports/details/satismusterilistesi"},
                                new MenuItems {Title = "Satış İzlenebilirliği Raporu", IconClass = null, Url = "/reports/details/satisizlenebilirligi"},
                               }
                        },
                        new MenuItems {Title = "Kullanıcı Satış Durumu", IconClass = null, Url = "/reports/details/satiskullanicidurumu"},
                        new MenuItems {Title = "Fatura Aktarma", IconClass = null, Url = "/SatisIslemleri/FaturaAktarma"},
                        //new MenuItems {Title = "Künye Bildirim Listesi", IconClass = null, Url = "/SatisIslemleri/KunyeBildirimListesi"},
                        new MenuItems {Title = "E-Belge Bildirimi", IconClass = null, Url = "/Invoice/Index"},
                       /* new MenuItems {Title = "Mağaza Bazında Satış Takibi", IconClass = null, Url = "/reports/details/satismagazabazindatakibi"},*/ //RAPOR DA HATA VAR RAPOR AKTARILAMADI
                    }
                },
                //Döküm İşlemleri
                new MenuItems
                {
                    Title = "Operasyon İşlemleri", IconClass = "file-minus", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "İş emri", IconClass = null, Url = "/DokumIslemleri/Stok"},
                        new MenuItems {Title = "Aktarma", IconClass = null, Url = "/reports/details/dokumstokliste"},
                        new MenuItems {Title = "Abron Aktarma", IconClass = null, Url = "/DokumIslemleri/IslemdekiFaturalar"},
                        new MenuItems {Title = "Thy Yuk senedi-Manifesto", IconClass = null, Url = "/DokumIslemleri/HazirFaturalar"},
                        new MenuItems {Title = "Çağrı Talep oluşturma", IconClass = null, Url = "/DokumIslemleri/KesilmisFaturalar"},
                        new MenuItems
                        {
                            Title = "Operasyon Raporları", IconClass = null, Url = null,
                            SubMenu = new List<MenuItems>()
                            {
                                new MenuItems {Title = "Genel Rapor", IconClass = null, Url = "/reports/details/dokumgenelrapor"},
                                new MenuItems {Title = "Detaylı Diğer Masraflar", IconClass = null, Url = "/reports/details/dokumdetaylimasraflar"},
                            }
                        },
                    }
                },
                ////Fuar İşlemleri
                new MenuItems
                {
                    Title = "Fuar İşlemleri", IconClass = "hard-drive", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Fuar Tanımları", IconClass = null, Url = "/KasaIslemleri/KasaHareketKayit"},
                        new MenuItems {Title = "Personle Zimmet", IconClass = null, Url = "/reports/details/kasadefteri"},
                    }
                },
                ////Güvenlik İşlemleri
                new MenuItems
                {
                    Title = "Güvenlik İşlemleri", IconClass = "hard-drive", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Silah ve Ruhsat Tanımları", IconClass = null, Url = "/KasaIslemleri/KasaHareketKayit"},
                        new MenuItems {Title = "Personle Zimmet", IconClass = null, Url = "/reports/details/kasadefteri"},
                    }
                },
                ////Fuar İşlemleri
                new MenuItems
                {
                    Title = "Onay İşlemleri", IconClass = "hard-drive", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Kasa şifre onay", IconClass = null, Url = "/KasaIslemleri/KasaHareketKayit"},
                        new MenuItems {Title = "Kullanıcı Giriş onay", IconClass = null, Url = "/reports/details/kasadefteri"},
                    }
                },
                ////Kasa İşlemleri
                new MenuItems
                {
                    Title = "Kasa İşlemleri", IconClass = "hard-drive", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Kasa Hareketi", IconClass = null, Url = "/KasaIslemleri/KasaHareketKayit"},
                        new MenuItems {Title = "Kasa Defteri", IconClass = null, Url = "/reports/details/kasadefteri"},
                        new MenuItems {Title = "Kasa Bilanço", IconClass = null, Url = "/reports/details/kasabilanco"},
                        new MenuItems {Title = "Bordro Hesabı", IconClass = null, Url = "/reports/details/kasabordrohesabi"},
                        new MenuItems {Title = "Hesap Kayıt", IconClass = null, Url = "/TohalHesaps/Create"},
                        new MenuItems {Title = "Hesap Ad Liste", IconClass = null, Url = "/reports/details/kasahesapadliste"},
                        new MenuItems {Title = "Hesaplar Cari Defteri", IconClass = null, Url = "/reports/details/kasahesaplarcaridefteri"},
                        new MenuItems {Title = "Hesaplar Cari Mizanı", IconClass = null, Url = "/reports/details/kasahesaplarcarimizani"},
                        new MenuItems {Title = "Nakit Kredi Kartı İşlemleri Raporu", IconClass = null, Url = "/reports/details/kasanakitkkartislemleri"},
                    }
                },
                //Banka Çek senet İşlemleri
                new MenuItems
                {
                    Title = "Banka/Çek-Senet İşlemleri", IconClass = "file-minus", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Tahsilat", IconClass = null, Url = "/CekSenetIslemleri/Tahsilat"},
                        new MenuItems {Title = "Ödeme", IconClass = null, Url = "/CekSenetIslemleri/Odeme"},
                        new MenuItems {Title = "Karşılıksız Portföye İade", IconClass = null, Url = "/CekSenetIslemleri/KarsiliksizPortfoyeIade"},
                        new MenuItems {Title = "Portföye İade", IconClass = null, Url = "/CekSenetIslemleri/PortfoyeIade"},
                        new MenuItems {Title = "Elden Tahsil", IconClass = null, Url = "/CekSenetIslemleri/EldenTahsil"},
                        new MenuItems {Title = "İade", IconClass = null, Url = "/CekSenetIslemleri/Iade"},
                        new MenuItems {Title = "Firma Çek-Senet Elden Ödeme", IconClass = null, Url = "/CekSenetIslemleri/FirmaCekEldenOdeme"},
                        new MenuItems {Title = "Çek Listesi", IconClass = null, Url = "/reports/details/ceklistesi"},
                        new MenuItems {Title = "Senet Listesi", IconClass = null, Url = "/reports/details/senetlistesi"},
                        new MenuItems {Title = "Firma Çeki Listesi", IconClass = null, Url = "/reports/details/firmacekilistesi"},
                        new MenuItems {Title = "Firma Senedi Listesi", IconClass = null, Url = "/reports/details/firmasenedilistesi"},
                        new MenuItems {Title = "Vadesi Gelen Çek-Senet Listesi", IconClass = null, Url = "/reports/details/vadesigelenceksenet"},
                        new MenuItems {Title = "Banka Hesabı Kayıt", IconClass = null, Url = "/TohalBankaHesabis/Create"},
                        new MenuItems {Title = "Banka Hareket Kayıt", IconClass = null, Url = "/TohalBankaHareketis/Create"},
                        new MenuItems {Title = "Tahsile Verme", IconClass = null, Url = "/BankaIslemleri/TahsileVerme"},
                        new MenuItems {Title = "Tahsil", IconClass = null, Url = "/BankaIslemleri/Tahsil"},
                        new MenuItems {Title = "Karşılıksız Portföye İade", IconClass = null, Url = "/BankaIslemleri/KarsiliksizPortfoyeIade"},
                        new MenuItems {Title = "Portföye İade", IconClass = null, Url = "/BankaIslemleri/PortfoyeIade"},
                        new MenuItems {Title = "Firma Çek Ödeme", IconClass = null, Url = "/BankaIslemleri/FirmaCekOdeme"},
                        new MenuItems {Title = "POS Ekstre Raporu", IconClass = null, Url = "/reports/details/bankaposekstre"},
                        new MenuItems {Title = "Hesap Ekstre Raporu", IconClass = null, Url = "/reports/details/bankahesapekstre"},
                        new MenuItems {Title = "Hesab Bakiye Raporu", IconClass = null, Url = "/reports/details/bankahesapbakiye"},
                        new MenuItems {Title = "Günlük Durum Özet Raporu", IconClass = null, Url = "/reports/details/bankagunlukdurumozet"},
                    }
                },
                //Teknik İşlemleri
                new MenuItems
                {
                    Title = "Teknik İşlemler", IconClass = "tool", Url = null,
                    SubMenu = new List<MenuItems>()
                    {
                        new MenuItems {Title = "Ürün - Hizmet Kayıt", IconClass = null, Url = "/TohalMals/Create"},
                        new MenuItems {Title = "Ürün - Hizmet Liste", IconClass = null, Url = "/reports/details/teknikmalliste"},
                        new MenuItems {Title = "Kullanıcı Tanımları", IconClass = null, Url = "/TeknikIslemler/KullaniciTanimlari"},
                        //new MenuItems {Title = "Yazıcı Tanımları", IconClass = null, Url = "/TeknikIslemler/YaziciTanimlari"},
                        new MenuItems {Title = "Sistem Tanımları", IconClass = null, Url = "/TeknikIslemler/HalEntegreTanimlari"},
                      
                        //new MenuItems {Title = "Cari Fiyat Listeleri", IconClass = null, Url = "/TeknikIslemler/CariFiyatListeleri"},
                        new MenuItems {Title = "Fiyat Listleri", IconClass = null, Url = "/TeknikIslemler/PiyasaFiyatListeleri"},
                        //new MenuItems {Title = "KDV Tevkifat Tanımları", IconClass = null, Url = "/TeknikIslemler/KdvTevkifatTanimlari"}
                        //new MenuItems
                        //{
                        //    Title = "Servis İşlemleri", IconClass = null, Url = null,
                        //    SubMenu = new List<MenuItems>()
                        //    {
                        //        new MenuItems {Title = "Devir Ayarları", IconClass = null, Url = "/TeknikIslemler/DevirAyarlari"},
                        //        new MenuItems {Title = "Devir İşlemleri", IconClass = null, Url = "/TeknikIslemler/DevirIslemleri"},
                        //        new MenuItems {Title = "Dönemi Onayla", IconClass = null, Url = "/TeknikIslemler/DonemiOnayla"},
                        //        new MenuItems {Title = "Müstahsil İl/İlçe/Beldeyi Döküme Aktar", IconClass = null, Url = "/TeknikIslemler/MustahsilIlIlceBeldeAktar"},
                        //        new MenuItems {Title = "Müstahsil hal Bilgisini Döküme Aktar", IconClass = null, Url = "/TeknikIslemler/MustahsilHalBilgisiAktar"},
                        //        new MenuItems {Title = "Müşteri İl/İlçe/Beldeyi Satışa Aktar", IconClass = null, Url = "/TeknikIslemler/MusteriIlIlceBeldeAktar"},
                        //        new MenuItems {Title = "Müşteri hal Bilgisini Satışa Aktar", IconClass = null, Url = "/TeknikIslemler/MusterilHalBilgisiAktar"},
                        //        new MenuItems {Title = "Kayıtsız Müşteri/İLçe/Beldeyi Satışa Aktar", IconClass = null, Url = "/TeknikIslemler/KayitsizMusteriIlIlceBeldeAktar"},
                        //        new MenuItems {Title = "Kayıtsız Müşteri Hal Bilgisini Satışa Aktar", IconClass = null, Url = "/TeknikIslemler/KayitsizMusteriHalBilgisiAktar"},
                        //        new MenuItems {Title = "Künye Alınmayanların Listesi", IconClass = null, Url = "/TeknikIslemler/KunyeAlinmayanlarinListesi"},
                        //        new MenuItems {Title = "Müşteri İşyerlerini Doldur", IconClass = null, Url = "/TeknikIslemler/MusteriIsYerleriniDoldur"},
                        //        new MenuItems {Title = "Yeni Tablo Açma", IconClass = null, Url = "/TeknikIslemler/YeniTabloAcma"},
                        //        new MenuItems {Title = "İndeksi Yenile", IconClass = null, Url = "/Authentication/SignInBasic"},
                        //        new MenuItems {Title = "İstek-Cevap Tablosunu Sil", IconClass = null, Url = "/Authentication/SignInBasic"},
                        //        new MenuItems {Title = "Müşterilerin E-Fatura Bakiye Var Seçilmesi", IconClass = null, Url = "/Authentication/SignInBasic"},
                        //    }
                        //},
                    }
                },
            };
        }
    }
}
