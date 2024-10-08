using OfisHal.Core.Domain;
using OfisHal.Web.Models;
using System.Data.Entity;

namespace OfisHal.Data.Context
{
    public partial class Db
    {
        public virtual DbSet<VohalAramaDokum> VohalAramaDokums { get; set; }

        public virtual DbSet<VohalAramaKap> VohalAramaKaps { get; set; }

        public virtual DbSet<VohalAramaRehinHesabiOlmayanMusteriler> VohalAramaRehinHesabiOlmayanMusterilers { get; set; }

        public virtual DbSet<VohalAramaTeslimatYeri> VohalAramaTeslimatYeris { get; set; }

        public virtual DbSet<VohalBankaHesabi> VohalBankaHesabis { get; set; }

        public virtual DbSet<VohalbFatura> VohalbFaturas { get; set; }

        public virtual DbSet<VohalCariHareket> VohalCariHarekets { get; set; }

        public virtual DbSet<VohalCariKart> VohalCariKarts { get; set; }

        public virtual DbSet<VohalEIrsaliye> VohalEIrsaliyes { get; set; }

        public virtual DbSet<VohalEIrsaliyeSatiri> VohalEIrsaliyeSatiris { get; set; }

        public virtual DbSet<VohalFatura> VohalFaturas { get; set; }

        public virtual DbSet<VohalFaturaSatiriTuk> VohalFaturaSatiriTuks { get; set; }

        public virtual DbSet<VohalFaturaSatiriUrt> VohalFaturaSatiriUrts { get; set; }

        public virtual DbSet<VohalFaturaSonToplam> VohalFaturaSonToplams { get; set; }

        public virtual DbSet<VohalGonderimeHazirEFatura> VohalGonderimeHazirEFaturas { get; set; }

        public virtual DbSet<VohalGonderimeHazirEIrsaliye> VohalGonderimeHazirEIrsaliyes { get; set; }

        public virtual DbSet<VohalHksMal> VohalHksMals { get; set; }

        public virtual DbSet<VohalKap> VohalKaps { get; set; }

        public virtual DbSet<VohalKullanici> VohalKullanicis { get; set; }

        public virtual DbSet<VohalMagaza> VohalMagazas { get; set; }

        public virtual DbSet<VohalMal> VohalMals { get; set; }

        public virtual DbSet<VohalMalHksBagi> VohalMalHksBagis { get; set; }

        public virtual DbSet<VohalMarka> VohalMarkas { get; set; }

        public virtual DbSet<VohalRehinFisi> VohalRehinFisis { get; set; }

        public virtual DbSet<VohalMakbuz> VohalMakbuzs { get; set; }

        public virtual DbSet<VohalStokHareketi> VohalStokHareketis { get; set; }
        public virtual DbSet<VohalAlisTanimlari> VohalAlisTanimlaris { get; set; }
        public virtual DbSet<VohalDigerTanimlar> VohalDigerTanimlars { get; set; }
        public virtual DbSet<VohalDokumTanimlari> VohalDokumTanimlaris { get; set; }
        public virtual DbSet<VohalFirmaTanimlari> VohalFirmaTanimlaris { get; set; }
        public virtual DbSet<VohalHesapTanimlari> VohalHesapTanimlaris { get; set; }
        public virtual DbSet<VohalHksTanimlar> VohalHksTanimlars { get; set; }
        public virtual DbSet<VohalSatisTanimlari> VohalSatisTanimlaris { get; set; }
        public virtual DbSet<VohalEBelgeTanimi> VohalEBelgeTanimis { get; set; }

        public virtual DbSet<VohalAramaDokumdenKunye> VohalAramaDokumdenKunyes { get; set; }

        public virtual DbSet<VohalAramaKunye> VohalAramaKunyes { get; set; }

        public virtual DbSet<VohalGonderimeHazirEMustahsilMakbuzu> VohalGonderimeHazirEMustahsilMakbuzus { get; set; }
        public virtual DbSet<VohalAramaFatura> VohalAramaFaturas { get; set; }
        public virtual DbSet<VohalAramaKesilmeyenSatisFaturasi> VohalAramaKesilmeyenSatisFaturasis { get; set; }
        public virtual DbSet<VohalRehinFisiBekleyen> VohalRehinFisiBekleyens { get; set; }
        public virtual DbSet<VohalRehinFisiBekleyen01> VohalRehinFisiBekleyen01 { get; set; }
        public virtual DbSet<VohalKapHareket> VohalKapHarekets { get; set; }
        public virtual DbSet<VohalSipari> VohalSiparis { get; set; }
        public virtual DbSet<VohalAramaMakbuz> VohalAramaMakbuzs { get; set; }
        public virtual DbSet<VohalEntegreEdilmeyenFaturaSatiri> VohalEntegreEdilmeyenFaturaSatiris { get; set; }
        public virtual DbSet<VohalHesapHareketi> VohalHesapHareketis { get; set; }
        public virtual DbSet<VohalHesapBakiyeListesi> VohalHesapBakiyeListesis { get; set; }
        public virtual DbSet<VohalHesap> VohalHesaps { get; set; }
        public virtual DbSet<VohalMakbuzSatiri> VohalMakbuzSatiris { get; set; }
        public virtual DbSet<VohksHksKayitliKunyeBilgileri> VohksHksKayitliKunyeBilgileris { get; set; }
        public virtual DbSet<VohalEvrakMasrafi> VohalEvrakMasrafis { get; set; }
        public virtual DbSet<VohalObSatiri> VohalObSatiris { get; set; }
        public virtual DbSet<VohalOdemeBordrosu> VohalOdemeBordrosus { get; set; }
        public virtual DbSet<VohalAramaOdemeAraci> VohalAramaOdemeAracis { get; set; }
        /*
        public virtual DbSet<VoambAmbarFiyatlari> VoambAmbarFiyatlaris { get; set; }
        public virtual DbSet<VoambAmbarKomisyonu> VoambAmbarKomisyonus { get; set; }
        public virtual DbSet<VoambAmbarTanimlari> VoambAmbarTanimlaris { get; set; }
        public virtual DbSet<VoambAramaNavlunFaturasi> VoambAramaNavlunFaturasis { get; set; }
        public virtual DbSet<VoambAramaSevkIrsaliyesi> VoambAramaSevkIrsaliyesis { get; set; }
        public virtual DbSet<VoambEFaturaEvrakKdv> VoambEFaturaEvrakKdvs { get; set; }
        public virtual DbSet<VoambEntegreEdilmeyenIrsaliyeSatiri> VoambEntegreEdilmeyenIrsaliyeSatiris { get; set; }
        public virtual DbSet<VoambGonderimeHazirEFatura> VoambGonderimeHazirEFaturas { get; set; }
        public virtual DbSet<VoambNavlunFaturasi> VoambNavlunFaturasis { get; set; }
        public virtual DbSet<VoambNavlunFaturasiSatiri> VoambNavlunFaturasiSatiris { get; set; }
        public virtual DbSet<VoambSevkIrsaliyesi> VoambSevkIrsaliyesis { get; set; }
        public virtual DbSet<VoambSevkIrsaliyesiSatiri> VoambSevkIrsaliyesiSatiris { get; set; }
        public virtual DbSet<VoambrAmbarBakiyeRaporu> VoambrAmbarBakiyeRaporus { get; set; }
        public virtual DbSet<VoambrAmbarEkstre> VoambrAmbarEkstres { get; set; }
        public virtual DbSet<VoambrAmbarFiyatListesiRaporu> VoambrAmbarFiyatListesiRaporus { get; set; }
        public virtual DbSet<VoambrAmbarGunlukDefter> VoambrAmbarGunlukDefters { get; set; }
        public virtual DbSet<VoambrAmbarHareketRaporu> VoambrAmbarHareketRaporus { get; set; }
        public virtual DbSet<VoambrAmbarKesintiRaporu> VoambrAmbarKesintiRaporus { get; set; }
        public virtual DbSet<VoambrAmbarKesintiRaporu1> VoambrAmbarKesintiRaporu1 { get; set; }
        public virtual DbSet<VoambrAmbarKomisyonu> VoambrAmbarKomisyonus { get; set; }
        public virtual DbSet<VoambrAmbarListeDokumu> VoambrAmbarListeDokumus { get; set; }
        public virtual DbSet<VoambrAmbarListesi> VoambrAmbarListesis { get; set; }
        public virtual DbSet<VoambrAmbarPrimi> VoambrAmbarPrimis { get; set; }
        public virtual DbSet<VoambrBolgeBazindaGozlemRaporu> VoambrBolgeBazindaGozlemRaporus { get; set; }
        public virtual DbSet<VoambrIrsaliyeGozlemRaporu> VoambrIrsaliyeGozlemRaporus { get; set; }
        public virtual DbSet<VoambrIrsaliyeGozlemRaporuPrimDetayi> VoambrIrsaliyeGozlemRaporuPrimDetayis { get; set; }
        public virtual DbSet<VoambrNavlunFaturaDokumu> VoambrNavlunFaturaDokumus { get; set; }
        public virtual DbSet<VoambrNavlunFaturaSatiriToplamlar> VoambrNavlunFaturaSatiriToplamlars { get; set; }
        public virtual DbSet<VoambrNavlunFaturasiSatiriXslt> VoambrNavlunFaturasiSatiriXslts { get; set; }
        public virtual DbSet<VoambrTuccarBakiyeRaporu> VoambrTuccarBakiyeRaporus { get; set; }
        public virtual DbSet<VoambrTuccarEkstre> VoambrTuccarEkstres { get; set; }
        public virtual DbSet<VoambrTuccarListesi> VoambrTuccarListesis { get; set; }
        public virtual DbSet<VoambrYazihaneBakiyeRaporu> VoambrYazihaneBakiyeRaporus { get; set; }
        public virtual DbSet<VoambrYazihaneEkstre> VoambrYazihaneEkstres { get; set; }
        public virtual DbSet<VoambrYazihaneGelenMalRaporu> VoambrYazihaneGelenMalRaporus { get; set; }
        public virtual DbSet<VoambrYazihaneHareketRaporu> VoambrYazihaneHareketRaporus { get; set; }
        public virtual DbSet<VoambrYazihaneListesi> VoambrYazihaneListesis { get; set; }
        public virtual DbSet<Vohal00AlisFaturasi> Vohal00AlisFaturasi { get; set; }
        public virtual DbSet<Vohal00CariRehinEkstre> Vohal00CariRehinEkstre { get; set; }
        public virtual DbSet<Vohal00EvrakMasrafi> Vohal00EvrakMasrafi { get; set; }
        public virtual DbSet<Vohal00FirmaLogosu> Vohal00FirmaLogosu { get; set; }
        public virtual DbSet<Vohal00Makbuz> Vohal00Makbuz { get; set; }
        public virtual DbSet<Vohal00MakbuzKesilmemis> Vohal00MakbuzKesilmemis { get; set; }
        public virtual DbSet<Vohal00MuhHesapToplami> Vohal00MuhHesapToplami { get; set; }
        public virtual DbSet<Vohal00MusteriOdemeAraciRiskListesi> Vohal00MusteriOdemeAraciRiskListesi { get; set; }
        public virtual DbSet<Vohal00OdemeAraciVadeListesi> Vohal00OdemeAraciVadeListesi { get; set; }
        public virtual DbSet<Vohal00SatisFaturasi> Vohal00SatisFaturasi { get; set; }
        public virtual DbSet<Vohal01BankaHareketi> Vohal01BankaHareketi { get; set; }
        public virtual DbSet<Vohal01CariHareket> Vohal01CariHareket { get; set; }
        public virtual DbSet<Vohal01CariRehinTutari> Vohal01CariRehinTutari { get; set; }
        public virtual DbSet<Vohal01EntegreEdilmeyenAlisFaturaSatiri> Vohal01EntegreEdilmeyenAlisFaturaSatiri { get; set; }
        public virtual DbSet<Vohal01EntegreEdilmeyenFaturaSatiri> Vohal01EntegreEdilmeyenFaturaSatiri { get; set; }
        public virtual DbSet<Vohal01Fatura> Vohal01Fatura { get; set; }
        public virtual DbSet<Vohal01HesapHareketi> Vohal01HesapHareketi { get; set; }
        public virtual DbSet<Vohal01MustahsilAlinanKap> Vohal01MustahsilAlinanKap { get; set; }
        public virtual DbSet<Vohal01MusteriVerilenKap> Vohal01MusteriVerilenKap { get; set; }
        public virtual DbSet<Vohal01PosHareketi> Vohal01PosHareketi { get; set; }
        public virtual DbSet<Vohal02CariHareket> Vohal02CariHareket { get; set; }
        public virtual DbSet<Vohal02Fatura> Vohal02Fatura { get; set; }
        public virtual DbSet<Vohal02VeresiyeMizan> Vohal02VeresiyeMizan { get; set; }
        public virtual DbSet<VohalAdanaHalSatisBildirimi> VohalAdanaHalSatisBildirimis { get; set; }
        
        public virtual DbSet<VohalAnkaraHalSatisBildirimi> VohalAnkaraHalSatisBildirimis { get; set; }
        public virtual DbSet<VohalAnkaraHalStokBildirimi> VohalAnkaraHalStokBildirimis { get; set; }
        public virtual DbSet<VohalAntalyaHalSatisBildirimi> VohalAntalyaHalSatisBildirimis { get; set; }
        public virtual DbSet<VohalAramaAlisFaturasiDurumu> VohalAramaAlisFaturasiDurumus { get; set; }
        public virtual DbSet<VohalAramaAlisFaturasiKunyeBildirimListesi> VohalAramaAlisFaturasiKunyeBildirimListesis { get; set; }
        public virtual DbSet<VohalAramaDokumKunyeBildirimListesi> VohalAramaDokumKunyeBildirimListesis { get; set; }
        
       
        public virtual DbSet<VohalAramaFaturaKunyeBildirimListesi> VohalAramaFaturaKunyeBildirimListesis { get; set; }
        public virtual DbSet<VohalAramaKayitsizDahilTumMusteriler> VohalAramaKayitsizDahilTumMusterilers { get; set; }
        public virtual DbSet<VohalAramaKayitsizMusteriHalBilgileriOlanlar> VohalAramaKayitsizMusteriHalBilgileriOlanlars { get; set; }
        public virtual DbSet<VohalAramaKayitsizMusteriIlIlceBeldeBilgileriOlanlar> VohalAramaKayitsizMusteriIlIlceBeldeBilgileriOlanlars { get; set; }
       

        public virtual DbSet<VohalAramaKunyesiAlinamayanlar> VohalAramaKunyesiAlinamayanlars { get; set; }
        public virtual DbSet<VohalAramaMagaza> VohalAramaMagazas { get; set; }
        public virtual DbSet<VohalAramaMalKabul> VohalAramaMalKabuls { get; set; }
        public virtual DbSet<VohalAramaMarkaMalBakiye> VohalAramaMarkaMalBakiyes { get; set; }
        public virtual DbSet<VohalAramaMuhFi> VohalAramaMuhFis { get; set; }
        public virtual DbSet<VohalAramaMustahsilHalBilgileriOlanlar> VohalAramaMustahsilHalBilgileriOlanlars { get; set; }
        public virtual DbSet<VohalAramaMustahsilIlIlceBeldeBilgileriOlanlar> VohalAramaMustahsilIlIlceBeldeBilgileriOlanlars { get; set; }
        public virtual DbSet<VohalAramaMusteriBilgisi> VohalAramaMusteriBilgisis { get; set; }
        public virtual DbSet<VohalAramaMusteriHalBilgileriOlanlar> VohalAramaMusteriHalBilgileriOlanlars { get; set; }
        public virtual DbSet<VohalAramaMusteriIlIlceBeldeBilgileriOlanlar> VohalAramaMusteriIlIlceBeldeBilgileriOlanlars { get; set; }
        public virtual DbSet<VohalAramaMusteriler> VohalAramaMusterilers { get; set; }

        public virtual DbSet<VohalAramaOdemeBordrosu> VohalAramaOdemeBordrosus { get; set; }
        public virtual DbSet<VohalAramaOdenmeyenSatisFaturasi> VohalAramaOdenmeyenSatisFaturasis { get; set; }
        public virtual DbSet<VohalAramaSatisFisi> VohalAramaSatisFisis { get; set; }
        public virtual DbSet<VohalAramaUrununSonAlisFiyatilari> VohalAramaUrununSonAlisFiyatilaris { get; set; }
        public virtual DbSet<VohalBagkurDosyasi> VohalBagkurDosyasis { get; set; }
        public virtual DbSet<VohalBankaHareketi> VohalBankaHareketis { get; set; }
        public virtual DbSet<VohalBekleyenStokHareketi> VohalBekleyenStokHareketis { get; set; }
        public virtual DbSet<VohalBeldesiOlmayanKayitsizMusteriler> VohalBeldesiOlmayanKayitsizMusterilers { get; set; }
        public virtual DbSet<VohalBeldesiOlmayanKayitsizMusterilerIslemdeOlanlar> VohalBeldesiOlmayanKayitsizMusterilerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalBeldesiOlmayanMustahsiller> VohalBeldesiOlmayanMustahsillers { get; set; }
        public virtual DbSet<VohalBeldesiOlmayanMustahsillerIslemdeOlanlar> VohalBeldesiOlmayanMustahsillerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalBeldesiOlmayanMusteriler> VohalBeldesiOlmayanMusterilers { get; set; }
        public virtual DbSet<VohalBeldesiOlmayanMusterilerIslemdeOlanlar> VohalBeldesiOlmayanMusterilerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalBuBeldeyeBagliOlmayanKayitsizMusteriler> VohalBuBeldeyeBagliOlmayanKayitsizMusterilers { get; set; }
        public virtual DbSet<VohalBuBeldeyeBagliOlmayanKayitsizMusterilerIslemdeOlanlar> VohalBuBeldeyeBagliOlmayanKayitsizMusterilerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalBuBeldeyeBagliOlmayanMustahsiller> VohalBuBeldeyeBagliOlmayanMustahsillers { get; set; }
        public virtual DbSet<VohalBuBeldeyeBagliOlmayanMustahsillerIslemdeOlanlar> VohalBuBeldeyeBagliOlmayanMustahsillerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalBuBeldeyeBagliOlmayanMusteriler> VohalBuBeldeyeBagliOlmayanMusterilers { get; set; }
        public virtual DbSet<VohalBuBeldeyeBagliOlmayanMusterilerIslemdeOlanlar> VohalBuBeldeyeBagliOlmayanMusterilerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalBuHaleBagliOlmayanKayitsizMusteriler> VohalBuHaleBagliOlmayanKayitsizMusterilers { get; set; }
        public virtual DbSet<VohalBuHaleBagliOlmayanKayitsizMusterilerIslemdeOlanlar> VohalBuHaleBagliOlmayanKayitsizMusterilerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalBuHaleBagliOlmayanMustahsiller> VohalBuHaleBagliOlmayanMustahsillers { get; set; }
        public virtual DbSet<VohalBuHaleBagliOlmayanMustahsillerIslemdeOlanlar> VohalBuHaleBagliOlmayanMustahsillerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalBuHaleBagliOlmayanMusteriler> VohalBuHaleBagliOlmayanMusterilers { get; set; }
        public virtual DbSet<VohalBuHaleBagliOlmayanMusterilerIslemdeOlanlar> VohalBuHaleBagliOlmayanMusterilerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalDevirHesapHareketiBakiye> VohalDevirHesapHareketiBakiyes { get; set; }
        public virtual DbSet<VohalDevirKalanDokumler> VohalDevirKalanDokumlers { get; set; }
        public virtual DbSet<VohalDevirKapHareket> VohalDevirKapHarekets { get; set; }
        public virtual DbSet<VohalDevirOdemeBordrosu> VohalDevirOdemeBordrosus { get; set; }
        
        public virtual DbSet<VohalDokumDefteri> VohalDokumDefteris { get; set; }
        public virtual DbSet<VohalDokumDefteriBaski> VohalDokumDefteriBaskis { get; set; }
        public virtual DbSet<VohalDokumDefteriFiyatBazinda> VohalDokumDefteriFiyatBazindas { get; set; }
        public virtual DbSet<VohalDokumRehinToplami> VohalDokumRehinToplamis { get; set; }
        public virtual DbSet<VohalDokumSatiriHksIstek> VohalDokumSatiriHksIsteks { get; set; }
        
        public virtual DbSet<VohalDonemOnayi> VohalDonemOnayis { get; set; }
        
        public virtual DbSet<VohalEFaturaEvrakKdv> VohalEFaturaEvrakKdvs { get; set; }
        public virtual DbSet<VohalEIrsaliyeKunye> VohalEIrsaliyeKunyes { get; set; }
        public virtual DbSet<VohalEIrsaliyeNote> VohalEIrsaliyeNotes { get; set; }
        public virtual DbSet<VohalEIrsaliyeOrder> VohalEIrsaliyeOrders { get; set; }
        public virtual DbSet<VohalEIrsaliyeSofor> VohalEIrsaliyeSofors { get; set; }
        public virtual DbSet<VohalEntegreEdilmeyenStokHareketi> VohalEntegreEdilmeyenStokHareketis { get; set; }
       
        public virtual DbSet<VohalFaturaKunyeDurumu> VohalFaturaKunyeDurumus { get; set; }
        public virtual DbSet<VohalFaturaSatiriHksIstek> VohalFaturaSatiriHksIsteks { get; set; }
        public virtual DbSet<VohalFaturaSatiriKullanilanKunye> VohalFaturaSatiriKullanilanKunyes { get; set; }
        public virtual DbSet<VohalFaturaSatiriSatisKunyeDetayListesi> VohalFaturaSatiriSatisKunyeDetayListesis { get; set; }
        public virtual DbSet<VohalFaturaSatiriStokKunyeDetayListesi> VohalFaturaSatiriStokKunyeDetayListesis { get; set; }
        public virtual DbSet<VohalFi> VohalFis { get; set; }
        
        public virtual DbSet<VohalFisSatiri> VohalFisSatiris { get; set; }
        public virtual DbSet<VohalFiyatListesiSatiri> VohalFiyatListesiSatiris { get; set; }
        public virtual DbSet<VohalGonderimeHazirEMustahsilFaturasi> VohalGonderimeHazirEMustahsilFaturasis { get; set; }
        public virtual DbSet<VohalGonderimeHazirEMustahsilFaturasiMakbuzu> VohalGonderimeHazirEMustahsilFaturasiMakbuzus { get; set; }

        public virtual DbSet<VohalHaliOlmayanKayitsizMusteriler> VohalHaliOlmayanKayitsizMusterilers { get; set; }
        public virtual DbSet<VohalHaliOlmayanKayitsizMusterilerIslemdeOlanlar> VohalHaliOlmayanKayitsizMusterilerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalHaliOlmayanMustahsiller> VohalHaliOlmayanMustahsillers { get; set; }
        public virtual DbSet<VohalHaliOlmayanMustahsillerIslemdeOlanlar> VohalHaliOlmayanMustahsillerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalHaliOlmayanMusteriler> VohalHaliOlmayanMusterilers { get; set; }
        public virtual DbSet<VohalHaliOlmayanMusterilerIslemdeOlanlar> VohalHaliOlmayanMusterilerIslemdeOlanlars { get; set; }
        public virtual DbSet<VohalHamaliyeFiyat> VohalHamaliyeFiyats { get; set; }
        public virtual DbSet<VohalHazirdaVeIslemdekiMakbuzlar> VohalHazirdaVeIslemdekiMakbuzlars { get; set; }
        public virtual DbSet<VohalHesap> VohalHesaps { get; set; }
       
        

        public virtual DbSet<VohalKayitsizMusteri> VohalKayitsizMusteris { get; set; }
        public virtual DbSet<VohalKonyaHalSatisBildirimi> VohalKonyaHalSatisBildirimis { get; set; }


        public virtual DbSet<VohalMakbuzdanCariKartBilgileriniSoyle> VohalMakbuzdanCariKartBilgileriniSoyles { get; set; }
        public virtual DbSet<VohalMalKabulFaturalanmayan> VohalMalKabulFaturalanmayans { get; set; }
        public virtual DbSet<VohalMuhFi> VohalMuhFis { get; set; }
        public virtual DbSet<VohalMuhasebeTanimi> VohalMuhasebeTanimis { get; set; }
        public virtual DbSet<VohalMusteriRiskBakiyeListesi> VohalMusteriRiskBakiyeListesis { get; set; }
        public virtual DbSet<VohalNavlunFaturasi> VohalNavlunFaturasis { get; set; }


        public virtual DbSet<VohalOdenenSatisFaturasi> VohalOdenenSatisFaturasis { get; set; }
        public virtual DbSet<VohalOfisEdefterBaslikBilgileri> VohalOfisEdefterBaslikBilgileris { get; set; }
        public virtual DbSet<VohalOfisEdefterIcerikBilgileri> VohalOfisEdefterIcerikBilgileris { get; set; }
        public virtual DbSet<VohalOfisEdefterIcerikMaster> VohalOfisEdefterIcerikMasters { get; set; }
        public virtual DbSet<VohalRehinAlinanKaplar> VohalRehinAlinanKaplars { get; set; }

        public virtual DbSet<VohalRehindekiKaplar> VohalRehindekiKaplars { get; set; }
        public virtual DbSet<VohalSatisFaturasiGezgini> VohalSatisFaturasiGezginis { get; set; }
        public virtual DbSet<VohalSatisFisiFaturalanmayan> VohalSatisFisiFaturalanmayans { get; set; }
        public virtual DbSet<VohalSatisKunyeSatiri> VohalSatisKunyeSatiris { get; set; }
        
        public virtual DbSet<VohalSipari> VohalSiparis { get; set; }
        public virtual DbSet<VohalSiparisSatiri> VohalSiparisSatiris { get; set; }

        public virtual DbSet<VohalStokHareketiKunyeDetayListesi> VohalStokHareketiKunyeDetayListesis { get; set; }
        public virtual DbSet<VohalStokIade> VohalStokIades { get; set; }
        public virtual DbSet<VohalYer> VohalYers { get; set; }
        public virtual DbSet<VohalbFaturaDetay> VohalbFaturaDetays { get; set; }
        public virtual DbSet<VohalbFaturaUrunKunyesi> VohalbFaturaUrunKunyesis { get; set; }
        public virtual DbSet<VohalbFirmamiz> VohalbFirmamizs { get; set; }
        public virtual DbSet<VohalbHalTeslimBelgesi> VohalbHalTeslimBelgesis { get; set; }
        public virtual DbSet<VohalbKasaHareket> VohalbKasaHarekets { get; set; }
        public virtual DbSet<VohalbMakbuz> VohalbMakbuzs { get; set; }
        public virtual DbSet<VohalbMakbuzSatiri> VohalbMakbuzSatiris { get; set; }
        public virtual DbSet<VohalbMuhFisi> VohalbMuhFisis { get; set; }
        public virtual DbSet<VohalbOdemeBordrosu> VohalbOdemeBordrosus { get; set; }
        public virtual DbSet<VohalbStokIade> VohalbStokIades { get; set; }
        public virtual DbSet<Vohalr00EntegreEdilmeyenStokHareketi> Vohalr00EntegreEdilmeyenStokHareketi { get; set; }
        public virtual DbSet<VohalrAlisFaturasiDetay> VohalrAlisFaturasiDetays { get; set; }
        public virtual DbSet<VohalrAlisFaturasiDokumu> VohalrAlisFaturasiDokumus { get; set; }
        public virtual DbSet<VohalrAlisFaturasiKapDetay> VohalrAlisFaturasiKapDetays { get; set; }
        public virtual DbSet<VohalrAlisFaturasiRehinDetay> VohalrAlisFaturasiRehinDetays { get; set; }
        public virtual DbSet<VohalrAlisIcmali> VohalrAlisIcmalis { get; set; }
        public virtual DbSet<VohalrAlisKdvRaporu> VohalrAlisKdvRaporus { get; set; }
        public virtual DbSet<VohalrAlisRusumRaporu> VohalrAlisRusumRaporus { get; set; }
        public virtual DbSet<VohalrBagkurMuafiyetRaporu> VohalrBagkurMuafiyetRaporus { get; set; }
        public virtual DbSet<VohalrBalikesirHalMudurlugu> VohalrBalikesirHalMudurlugus { get; set; }
        public virtual DbSet<VohalrBankaEsktre> VohalrBankaEsktres { get; set; }
        public virtual DbSet<VohalrBankaHareketiDegisiklikTakip> VohalrBankaHareketiDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrBekleyenStokHareketi> VohalrBekleyenStokHareketis { get; set; }
        public virtual DbSet<VohalrBordroHesabi> VohalrBordroHesabis { get; set; }
        public virtual DbSet<VohalrBorsaBeyannamesi> VohalrBorsaBeyannamesis { get; set; }
        public virtual DbSet<VohalrCariHareketDegisiklikTakip> VohalrCariHareketDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrCariKartDevirDegisiklikTakip> VohalrCariKartDevirDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrCekListesi> VohalrCekListesis { get; set; }
        public virtual DbSet<VohalrCekSenetDegisiklikTakip> VohalrCekSenetDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrDokumDefteri> VohalrDokumDefteris { get; set; }
        public virtual DbSet<VohalrDokumDefteriMusteriBazli> VohalrDokumDefteriMusteriBazlis { get; set; }
        public virtual DbSet<VohalrDokumDefteriUretici> VohalrDokumDefteriUreticis { get; set; }
        public virtual DbSet<VohalrDokumKontrol> VohalrDokumKontrols { get; set; }
        public virtual DbSet<VohalrDokumRapor> VohalrDokumRapors { get; set; }
        public virtual DbSet<VohalrEntegrasyonaGirmeyenSatisFaturalari> VohalrEntegrasyonaGirmeyenSatisFaturalaris { get; set; }
        public virtual DbSet<VohalrEntegreEdilmeyenFaturaSatiri> VohalrEntegreEdilmeyenFaturaSatiris { get; set; }
        public virtual DbSet<VohalrEntegreEdilmeyenFaturaSatiriIade> VohalrEntegreEdilmeyenFaturaSatiriIades { get; set; }
        public virtual DbSet<VohalrEntegreEdilmeyenFaturaSatiriUretici> VohalrEntegreEdilmeyenFaturaSatiriUreticis { get; set; }
        public virtual DbSet<VohalrEntegreEdilmeyenStokHareketi> VohalrEntegreEdilmeyenStokHareketis { get; set; }
        public virtual DbSet<VohalrEntegreEdilmeyenStokHareketiKilo> VohalrEntegreEdilmeyenStokHareketiKiloes { get; set; }
        public virtual DbSet<VohalrEvrakMasrafi> VohalrEvrakMasrafis { get; set; }
        public virtual DbSet<VohalrEvrakMasrafiDegisiklikTakip> VohalrEvrakMasrafiDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrFaturaDegisiklikTakip> VohalrFaturaDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrFaturaMasrafi> VohalrFaturaMasrafis { get; set; }
        public virtual DbSet<VohalrFaturaSatiriDegisiklikTakip> VohalrFaturaSatiriDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrFaturaSatiriToplamlar> VohalrFaturaSatiriToplamlars { get; set; }
        public virtual DbSet<VohalrFaturaVeresiyeDegisiklikTakip> VohalrFaturaVeresiyeDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrHesapAdListe> VohalrHesapAdListes { get; set; }
        public virtual DbSet<VohalrHesapCariDefteri> VohalrHesapCariDefteris { get; set; }
        public virtual DbSet<VohalrHesapHareketiDegisiklikTakip> VohalrHesapHareketiDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrIadesizKapTakibi> VohalrIadesizKapTakibis { get; set; }
        public virtual DbSet<VohalrKapCariDefteri> VohalrKapCariDefteris { get; set; }
        public virtual DbSet<VohalrKapHareketDegisiklikTakip> VohalrKapHareketDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrKdvBazliAlisFaturasiListesi> VohalrKdvBazliAlisFaturasiListesis { get; set; }
        public virtual DbSet<VohalrKdvBazliSatisFaturasiListesi> VohalrKdvBazliSatisFaturasiListesis { get; set; }
        public virtual DbSet<VohalrKesintiRaporu> VohalrKesintiRaporus { get; set; }
        public virtual DbSet<VohalrKisaltmaKapListeDokumu> VohalrKisaltmaKapListeDokumus { get; set; }
        public virtual DbSet<VohalrKisaltmaMalListeDokumu> VohalrKisaltmaMalListeDokumus { get; set; }
        public virtual DbSet<VohalrKullaniciSatisDurumu> VohalrKullaniciSatisDurumus { get; set; }
        public virtual DbSet<VohalrMakbuz> VohalrMakbuzs { get; set; }
        public virtual DbSet<VohalrMakbuzMasraflari> VohalrMakbuzMasraflaris { get; set; }
        public virtual DbSet<VohalrMakbuzMasraflariSubReport> VohalrMakbuzMasraflariSubReports { get; set; }
        public virtual DbSet<VohalrMakbuzSatiri> VohalrMakbuzSatiris { get; set; }
        public virtual DbSet<VohalrMakbuzSatiriDegisiklik> VohalrMakbuzSatiriDegisikliks { get; set; }
        public virtual DbSet<VohalrMakbuzSatiriKunyesiz> VohalrMakbuzSatiriKunyesizs { get; set; }
        public virtual DbSet<VohalrMakbuzSatiriToplamlar> VohalrMakbuzSatiriToplamlars { get; set; }
        public virtual DbSet<VohalrMakbuzSatiriXslt> VohalrMakbuzSatiriXslts { get; set; }
        public virtual DbSet<VohalrMakbuzXslt> VohalrMakbuzXslts { get; set; }
        public virtual DbSet<VohalrMarkaSatisRaporu> VohalrMarkaSatisRaporus { get; set; }
        public virtual DbSet<VohalrMasraf> VohalrMasrafs { get; set; }
        public virtual DbSet<VohalrMuhHesapEkstre> VohalrMuhHesapEkstres { get; set; }
        public virtual DbSet<VohalrMuhHesapMizani> VohalrMuhHesapMizanis { get; set; }
        public virtual DbSet<VohalrMustahsilAktarimi> VohalrMustahsilAktarimis { get; set; }
        public virtual DbSet<VohalrMustahsilAlisListesi> VohalrMustahsilAlisListesis { get; set; }
        public virtual DbSet<VohalrMustahsilCariDefteri> VohalrMustahsilCariDefteris { get; set; }
        public virtual DbSet<VohalrMustahsilCariHareketiniSoyle> VohalrMustahsilCariHareketiniSoyles { get; set; }
        public virtual DbSet<VohalrMustahsilFaturaDokumu> VohalrMustahsilFaturaDokumus { get; set; }
        public virtual DbSet<VohalrMustahsilFaturaMasraflar> VohalrMustahsilFaturaMasraflars { get; set; }
        public virtual DbSet<VohalrMustahsilMusteriListesi> VohalrMustahsilMusteriListesis { get; set; }
        public virtual DbSet<VohalrMustahsilSatisIstatistigi> VohalrMustahsilSatisIstatistigis { get; set; }
        public virtual DbSet<VohalrMustahsilSatisRaporu> VohalrMustahsilSatisRaporus { get; set; }
        public virtual DbSet<VohalrMustahsilSonUrunHareketi> VohalrMustahsilSonUrunHareketis { get; set; }
        public virtual DbSet<VohalrMusteriSatisIstatistigi> VohalrMusteriSatisIstatistigis { get; set; }
        public virtual DbSet<VohalrMusteriSatisListesi> VohalrMusteriSatisListesis { get; set; }
        public virtual DbSet<VohalrNavlunKarsilastirmaRaporu> VohalrNavlunKarsilastirmaRaporus { get; set; }
        public virtual DbSet<VohalrOdemeAraciGecmisi> VohalrOdemeAraciGecmisis { get; set; }
        public virtual DbSet<VohalrOdemeAraciListesi> VohalrOdemeAraciListesis { get; set; }
        public virtual DbSet<VohalrOdemeBordrosu> VohalrOdemeBordrosus { get; set; }
        public virtual DbSet<VohalrPosEkstresi> VohalrPosEkstresis { get; set; }
        public virtual DbSet<VohalrRehinDegisiklikTakip> VohalrRehinDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrRehinOdendiDetayi> VohalrRehinOdendiDetayis { get; set; }
        public virtual DbSet<VohalrRehinTakibi> VohalrRehinTakibis { get; set; }
        public virtual DbSet<VohalrRehinTakibiUretici> VohalrRehinTakibiUreticis { get; set; }
        public virtual DbSet<VohalrRehinXslt> VohalrRehinXslts { get; set; }
        public virtual DbSet<VohalrRusumKdvRaporu> VohalrRusumKdvRaporus { get; set; }
        public virtual DbSet<VohalrSatisFaturasi> VohalrSatisFaturasis { get; set; }
        public virtual DbSet<VohalrSatisFaturasiAktarimi> VohalrSatisFaturasiAktarimis { get; set; }
        public virtual DbSet<VohalrSatisFaturasiSatiri> VohalrSatisFaturasiSatiris { get; set; }
        public virtual DbSet<VohalrSatisFaturasiSatiriDegisiklikTakip> VohalrSatisFaturasiSatiriDegisiklikTakips { get; set; }
        public virtual DbSet<VohalrSatisFaturasiSatiriRehinli> VohalrSatisFaturasiSatiriRehinlis { get; set; }
        public virtual DbSet<VohalrSatisFaturasiSatiriXslt> VohalrSatisFaturasiSatiriXslts { get; set; }
        public virtual DbSet<VohalrSatisIcmali> VohalrSatisIcmalis { get; set; }
        public virtual DbSet<VohalrSatisIzlenebilirligi> VohalrSatisIzlenebilirligis { get; set; }
        public virtual DbSet<VohalrSatisRusumRaporu> VohalrSatisRusumRaporus { get; set; }
        public virtual DbSet<VohalrSermayeKarlilik> VohalrSermayeKarliliks { get; set; }
        public virtual DbSet<VohalrSermayeKarlilikDetay> VohalrSermayeKarlilikDetays { get; set; }
        public virtual DbSet<VohalrSermayeKarlilikEkstre> VohalrSermayeKarlilikEkstres { get; set; }
        public virtual DbSet<VohalrSiparisFaturaMasraf> VohalrSiparisFaturaMasrafs { get; set; }
        public virtual DbSet<VohalrSiparisKarlilikRaporu> VohalrSiparisKarlilikRaporus { get; set; }
        public virtual DbSet<VohalrSiparisKarsilastirmaAlisDetay> VohalrSiparisKarsilastirmaAlisDetays { get; set; }
        public virtual DbSet<VohalrSiparisKarsilastirmaRaporu> VohalrSiparisKarsilastirmaRaporus { get; set; }
        public virtual DbSet<VohalrSiparisKarsilastirmaSatisDetay> VohalrSiparisKarsilastirmaSatisDetays { get; set; }
        public virtual DbSet<VohalrSiparisKarsilastirmasi> VohalrSiparisKarsilastirmasis { get; set; }
        public virtual DbSet<VohalrStokHareketiDegisiklik> VohalrStokHareketiDegisikliks { get; set; }
        public virtual DbSet<VohalrStokHareketiMusteriBazli> VohalrStokHareketiMusteriBazlis { get; set; }
        public virtual DbSet<VohalrTicariKarlilik> VohalrTicariKarliliks { get; set; }
        public virtual DbSet<VohalrTicariKarlilikDetay> VohalrTicariKarlilikDetays { get; set; }
        public virtual DbSet<VohalrTicariKarlilikEkstre> VohalrTicariKarlilikEkstres { get; set; }
        public virtual DbSet<VohalrTicariKarlilikFaturaDetay> VohalrTicariKarlilikFaturaDetays { get; set; }
        public virtual DbSet<VohalrTuccarBorsaBeyannamesi> VohalrTuccarBorsaBeyannamesis { get; set; }
        public virtual DbSet<VohalrTuccarMustahsilFaturaDokumu> VohalrTuccarMustahsilFaturaDokumus { get; set; }
        public virtual DbSet<VohalrUrunBakiye> VohalrUrunBakiyes { get; set; }
        public virtual DbSet<VohalrYuklemeNakliyeRaporu> VohalrYuklemeNakliyeRaporus { get; set; }
        public virtual DbSet<VohalrYuklemeNakliyeRaporuAli> VohalrYuklemeNakliyeRaporuAlis { get; set; }
        public virtual DbSet<VohksAlisFaturaSatiriIstek> VohksAlisFaturaSatiriIsteks { get; set; }
        public virtual DbSet<VohksCevapTablosu> VohksCevapTablosus { get; set; }
        public virtual DbSet<VohksDokumSatiriIstek> VohksDokumSatiriIsteks { get; set; }
        public virtual DbSet<VohksFaturaSatiriIstek> VohksFaturaSatiriIsteks { get; set; }

        public virtual DbSet<VohksIstekTablosu> VohksIstekTablosus { get; set; }
        */
    }
}