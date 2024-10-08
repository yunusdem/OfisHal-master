namespace OfisHal.Web.Models
{
    public class VoambAmbarFiyatlari
    {
        public int AmbarFiyatiId { get; set; }
        public int AmbarId { get; set; }
        public int SatirNo { get; set; }
        public string Aciklama { get; set; }
        public double Muamele { get; set; }
        public double Hammaliye { get; set; }
        public double Navlun { get; set; }
        public int? GeldigiYerId { get; set; }
        public int? YazihaneId { get; set; }
        public int? GonderenId { get; set; }
        public int? MalGrupId { get; set; }
        public int? MalId { get; set; }
        public int? KapId { get; set; }
        public double? Prim { get; set; }
        public double? HammaliyePrimi { get; set; }
        public double? AmbarPrimi { get; set; }
        public int? PrimSahibiId { get; set; }
        public string GeldigiYer { get; set; }
        public string Yazihane { get; set; }
        public string Gonderen { get; set; }
        public string MalGrubu { get; set; }
        public string Mal { get; set; }
        public string Kap { get; set; }
        public string PrimSahibiKodu { get; set; }
        public string PrimSahibi { get; set; }
    }
}