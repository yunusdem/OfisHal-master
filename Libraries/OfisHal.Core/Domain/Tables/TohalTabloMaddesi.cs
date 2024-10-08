using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalTabloMaddesi
    {
        public TohalTabloMaddesi()
        {
            ToambAmbarFiyatiGeldigiYers = new HashSet<ToambAmbarFiyati>();
            ToambAmbarFiyatiMalGrups = new HashSet<ToambAmbarFiyati>();
            ToambNavlunFaturaSatiris = new HashSet<ToambNavlunFaturaSatiri>();
            ToambSevkIrsaliyesiGeldigiYers = new HashSet<ToambSevkIrsaliyesi>();
            ToambSevkIrsaliyesiPlakas = new HashSet<ToambSevkIrsaliyesi>();
            TohalBankaHesabis = new HashSet<TohalBankaHesabi>();
            TohalCariKartBolgeKodus = new HashSet<TohalCariKart>();
            TohalCariKartGeldigiYers = new HashSet<TohalCariKart>();
            TohalCariKartPostaKodus = new HashSet<TohalCariKart>();
            TohalCariKartSofors = new HashSet<TohalCariKart>();
            TohalCariKartUlkes = new HashSet<TohalCariKart>();
            TohalCariKartVergiDairesis = new HashSet<TohalCariKart>();
            TohalFaturaIhracatParaBirimis = new HashSet<TohalFatura>();
            TohalFaturaOdemeSeklis = new HashSet<TohalFatura>();
            TohalFaturaSehirs = new HashSet<TohalFatura>();
            TohalFaturaSofors = new HashSet<TohalFatura>();
            TohalFaturaTeslimatSeklis = new HashSet<TohalFatura>();
            TohalFaturaUlasimSeklis = new HashSet<TohalFatura>();
            TohalFaturaVergiDairesis = new HashSet<TohalFatura>();
            TohalKayitsizMusteriSehirs = new HashSet<TohalKayitsizMusteri>();
            TohalKayitsizMusteriVergiDairesis = new HashSet<TohalKayitsizMusteri>();
            TohalMagazaPostaKodus = new HashSet<TohalMagaza>();
            TohalMagazaSehirs = new HashSet<TohalMagaza>();
            TohalMakbuzs = new HashSet<TohalMakbuz>();
            TohalOdemeAracis = new HashSet<TohalOdemeAraci>();
        }

        public int TabloMaddesiId { get; set; }
        public byte Tur { get; set; }
        public string Ad { get; set; }
        public int? HksId { get; set; }
        public string Kisaltma { get; set; }

        public virtual ICollection<ToambAmbarFiyati> ToambAmbarFiyatiGeldigiYers { get; set; }
        public virtual ICollection<ToambAmbarFiyati> ToambAmbarFiyatiMalGrups { get; set; }
        public virtual ICollection<ToambNavlunFaturaSatiri> ToambNavlunFaturaSatiris { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesi> ToambSevkIrsaliyesiGeldigiYers { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesi> ToambSevkIrsaliyesiPlakas { get; set; }
        public virtual ICollection<TohalBankaHesabi> TohalBankaHesabis { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartBolgeKodus { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartGeldigiYers { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartPostaKodus { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartSofors { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartUlkes { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartVergiDairesis { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaIhracatParaBirimis { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaOdemeSeklis { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaSehirs { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaSofors { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaTeslimatSeklis { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaUlasimSeklis { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaVergiDairesis { get; set; }
        public virtual ICollection<TohalKayitsizMusteri> TohalKayitsizMusteriSehirs { get; set; }
        public virtual ICollection<TohalKayitsizMusteri> TohalKayitsizMusteriVergiDairesis { get; set; }
        public virtual ICollection<TohalMagaza> TohalMagazaPostaKodus { get; set; }
        public virtual ICollection<TohalMagaza> TohalMagazaSehirs { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzs { get; set; }
        public virtual ICollection<TohalOdemeAraci> TohalOdemeAracis { get; set; }
    }
}