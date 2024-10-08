using OfisHal.Services.HksBildirimSvc;
using OfisHal.Services.HksGenelSvc;
using OfisHal.Services.HksUrunSvc;
using System;
using System.Collections.Generic;

namespace OfisHal.Services
{
    public interface IHksService
    {
        /// <summary>
        /// Belde listesi
        /// </summary>
        /// <param name="ilceId">Beldeleri istenen ilçe Id’si</param>
        /// <returns></returns>
        IEnumerable<BeldeDTO> Beldeler(int ilceId);

        /// <summary>
        /// Servis kullanıcısı GTB hal kayıt sisteminden daha önceden girmiş olduğu bildirimlerini sorgulayabilir
        /// </summary>
        /// <param name="kunyeTuru">Alabileceği değerler : 1 referans, 2 nihai tüketim</param>
        /// <param name="kunyeNo">İstenen bildirimin künye numarası. Eğer “0” gönderilirse tüm bildirimler listelenir</param>
        /// <param name="startDate">Bildirim başlangıç tarihi</param>
        /// <param name="endDate">Bildirim bitiş tarihi</param>
        /// <param name="uniqueId">Yerel ID</param>
        /// <param name="greaterThanZero">“True” gönderilirse ilgili kişi veya kuruluşun kalan miktarı 0’dan büyük olan bildirimleri, “False” gönderilirse tüm bildirimleri getirilir.</param>
        /// <param name="sifatId">Bildirimcinin sıfat Id’si.Zorunlu alan değildir. Boş gönderilirse tüm sıfatlar için bildirimler listelenir. <seealso cref="SifatListesi"/></param>
        /// <returns></returns>
        IEnumerable<BildirimSorguDTO> BildirimcininYaptigiBildirimler(int kunyeTuru, long kunyeNo, DateTime startDate, DateTime endDate, string uniqueId, bool greaterThanZero = true, int? sifatId = null);

        /// <summary>
        /// Servis kullanıcısı GTB hal kayıt sisteminden daha önceden kendisine yapılmış olan bildirimleri sorgulayabilir
        /// </summary>
        /// <param name="kunyeTuru">Alabileceği değerler : 1 referans, 2 nihai tüketim</param>
        /// <param name="kunyeNo">İstenen bildirimin künye numarası. Eğer “0” gönderilirse tüm bildirimler listelenir</param>
        /// <param name="startDate">Bildirim başlangıç tarihi</param>
        /// <param name="endDate">Bildirim bitiş tarihi</param>
        /// <param name="uniqueId">Yerel ID</param>
        /// <param name="greaterThanZero">“True” gönderilirse ilgili kişi veya kuruluşun kalan miktarı 0’dan büyük olan bildirimleri, “False” gönderilirse tüm bildirimleri getirilir.</param>
        /// <param name="sifatId">Bildirimcinin sıfat Id’si.Zorunlu alan değildir.Boş gönderilirse tüm sıfatlar için bildirimler listelenir. <seealso cref="SifatListesi"/></param>
        /// <returns></returns>
        IEnumerable<BildirimSorguDTO> BildirimciyeYapilaniBildirimler(int kunyeTuru, long kunyeNo, DateTime startDate, DateTime endDate, string uniqueId, bool greaterThanZero = true, int? sifatId = null);

        /// <summary>
        /// GTB hal kayıt sistemine bildirim kaydı
        /// </summary>
        /// <param name="faturaId">Kayıt işlemlerinin yapılacağı Fatura ID'si</param>
        /// <returns></returns>
        List<BildirimKayitCevap> BildirimKaydet(int faturaId, bool faturaTip);

        /// <summary>
        /// GTB hal kayıt sistemine stok bildirim kaydı
        /// </summary>
        /// <param name="faturaId">Kayıt işlemlerinin yapılacağı Fatura ID'si</param>
        /// <returns></returns>
        List<BildirimKayitCevap> StokBildirimKaydet(int faturaId);

        /// <summary>
        /// GTB hal kayıt sistemine stok bildirim kaydı
        /// </summary>
        /// <param name="faturaId">Kayıt işlemlerinin yapılacağı Fatura ID'si</param>
        /// <returns></returns>
        List<BildirimKayitCevap> SatisStokBildirimKaydet(int faturaId);

        /// <summary>
        /// Bildirim türleri listesi
        /// </summary>
        /// <returns></returns>
        IEnumerable<BildirimTuruDTO> BildirimTurleri();

        /// <summary>
        /// Depo listesi
        /// </summary>
        /// <param name="tcVkn">Depoları istenen kişi veya kurumun Tc kimlik veya vergi nosu.</param>
        /// <returns></returns>
        IEnumerable<DepoDTO> Depolar(string tcVkn);

        /// <summary>
        /// GTB hal kayıt sistemine daha önceden girilmiş 2’li künyeler etiket formunda toplu halde basılacak şekilde sorgulanabilmektedir
        /// </summary>
        /// <remarks>
        /// İstek mesajında <paramref name="tcVkn"/> ve <paramref name="bildirimTarihi"/> alanları boş olamaz.
        /// <paramref name="aracPlakaNo"/> ve <paramref name="belgeNo"/> alanlarından en az birisi dolu olmalıdır
        /// </remarks>
        /// <param name="aracPlakaNo">Basılacak kunyelerin ait oldukları Araç plaka numarası</param>
        /// <param name="belgeNo">Basılacak künyelere ait olan malların Belge numarası(İrsaliye, Gümrük beyannamesi vs)</param>
        /// <param name="bildirimTarihi">Basılacak kunyelerin bildirim tarihi</param>
        /// <param name="beldeId">Basılacak Bildirimin üzerindeki gidecek Yer Belde id</param>
        /// <param name="ilceId">Basılacak Bildirimin üzerindeki gidecek Yer İlçe id</param>
        /// <param name="yerId">Basılacak Bildirimin üzerindeki gidecek Yer İl id</param>
        /// <param name="tcVkn">Bildirime mevzu olan malın üzerinde olduğu kişinin Tc Kimlik yada Vergi numarası</param>
        /// <returns></returns>
        IEnumerable<BildirimEtiketDTO> Etiketler(string aracPlakaNo, string belgeNo, DateTime bildirimTarihi, int beldeId, int ilceId, int yerId, string tcVkn);

        /// <summary>
        /// Haliçi işyerleri listesi
        /// </summary>
        /// <param name="tcVkn">Haliçi istenen kişi veya kurumun Tc kimlik veya vergi nosu.</param>
        /// <returns></returns>
        IEnumerable<HalIciIsyeriDTO> HalIciIsyerleri(string tcVkn);

        /// <summary>
        /// İlçe listesi
        /// </summary>
        /// <param name="ilId">Ilçeleri istenen il Id’si.</param>
        /// <returns></returns>
        IEnumerable<IlceDTO> Ilceler(int ilId);

        /// <summary>
        /// İl listesi
        /// </summary>
        /// <returns></returns>
        IEnumerable<IlDTO> Iller();

        /// <summary>
        /// İşletme türleri listesi
        /// </summary>
        /// <returns></returns>
        IEnumerable<IsletmeTuruDTO> IsletmeTurleri();

        /// <summary>
        /// Kayıtlı kişileri sorgulama
        /// </summary>
        /// <param name="tcVkns">Kayıtlı kişi olup olmadığı öğrenilmek istenen kişilerin Tc Kimlik veya vergi numaralarının liste olarak girildiği alan.</param>
        /// <returns></returns>
        IEnumerable<KayitliKisiSorguDTO> KayitliKisiler(List<string> tcVkns);

        /// <summary>
        /// GTB hal kayıt sistemine daha önceden girilmiş künyeler toplu halde basılacak şekilde sorgulanabilmektedir
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="belgeNo">Basılacak künyelere ait olan malların Belge numarası(Fatura, İrsaliye, Gümrük beyannamesi vs)</param>
        /// <returns></returns>
        IEnumerable<TopluKunyeDTO> Kunyeler(string belgeNo);

        /// <summary>
        /// GTB hal kayıt sisteminde kayıtlı malın nitelikleri sorgulanabilmektedir
        /// </summary>
        /// <returns></returns>
        IEnumerable<MalinNiteligiDTO> MalNitelikleri();

        /// <summary>
        /// Referans Künye Listesi
        /// </summary>
        /// <param name="startDate">Başlangıç tarihi</param>
        /// <param name="endDate">Bitiş tarihi</param>
        /// <param name="tcVkn">Referans künyesi istenen kişi veya kurumun TC kimlik numarası veya vergi numarası</param>
        /// <param name="urunId">Aranan Referans bildirimlere konu olan ürünün Id si.Ürün Listesi servisinden dönen Id lerden biri olmak zorundadır</param>
        /// <param name="kisiSifat">Referans künyesi istenen kişinin,hangi sıfatı üzerinde bulunan künyelerin aranacağını belirtir.Kişi kendisine hangi sıfatı ile bildirim yapılmışsa, bu bildirimleri o sıfat ile referans olarak kullanabilir.Örnek olarak kişi Haliçi Tüccar sıfatı mal almışşsa Sanayici sıfatı ile bu bildirimi referans gösteremez</param>
        /// <param name="greaterThanZero">“True” gönderilirse ilgili kişi veya kuruluşun kalan miktarı 0’dan büyük olan künyeleri, “False” gönderilirse tüm künyeleri getirilir.</param>
        /// <param name="kunyeNo">İstenen künye numarası. Eğer “0” gönderilirse “greaterThanZero” alanına girilen kişinin son 50 künyesi getirilir.</param>
        /// <returns></returns>
        IEnumerable<ReferansKunyeDTO> ReferansKunyeler(DateTime startDate, DateTime endDate, string tcVkn, int urunId, int kisiSifat, bool greaterThanZero = true, int kunyeNo = 0);

        /// <summary>
        /// Sıfat listesi
        /// </summary>
        /// <returns></returns>
        IEnumerable<SifatDTO> SifatListesi();

        /// <summary>
        /// Şube listesi
        /// </summary>
        /// <param name="tcVkn">Şubeleri istenen kişi veya kurumun Tc kimlik veya vergi nosu.</param>
        /// <returns></returns>
        IEnumerable<SubeDTO> Subeler(string tcVkn);

        /// <summary>
        /// Ülke listesi
        /// </summary>
        /// <returns></returns>
        IEnumerable<UlkeDTO> Ulkeler();

        /// <summary>
        /// Üretim şekilleri listesi
        /// </summary>
        /// <returns></returns>
        IEnumerable<UretimSekliDTO> UretimSekilleri();

        /// <summary>
        /// Ürün birimleri listesi
        /// </summary>
        /// <returns></returns>
        IEnumerable<UrunBirimiDTO> UrunBirimleri();

        /// <summary>
        /// Ürün cinsleri listesi
        /// </summary>
        /// <param name="urunId"></param>
        /// <returns></returns>
        IEnumerable<UrunCinsiDTO> UrunCinsleri(int urunId);

        /// <summary>
        /// Ürün listesi
        /// </summary>
        /// <returns></returns>
        IEnumerable<UrunDTO> Urunler();
    }
}
