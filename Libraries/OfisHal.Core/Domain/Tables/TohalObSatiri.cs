namespace OfisHal.Core.Domain
{
    public class TohalObSatiri
    {
        public int OdemeBordrosuId { get; set; }
        public int SatirNo { get; set; }
        public int OdemeAraciId { get; set; }
        public bool? OdemeAraciSahibi { get; set; }
        public int? SonrakiBordroId { get; set; }
        public string Aciklama { get; set; }

        public virtual TohalOdemeAraci OdemeAraci { get; set; }
        public virtual TohalOdemeBordrosu OdemeBordrosu { get; set; }
        public virtual TohalOdemeBordrosu SonrakiBordro { get; set; }
    }
}