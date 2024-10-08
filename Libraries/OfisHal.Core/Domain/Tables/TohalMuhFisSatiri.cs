namespace OfisHal.Core.Domain
{
    public class TohalMuhFisSatiri
    {
        public int MuhFisId { get; set; }
        public int SatirNo { get; set; }
        public int MuhHesapId { get; set; }
        public string Aciklama { get; set; }
        public byte Tip { get; set; }
        public double Meblag { get; set; }
        public int? YevmiyeSatirNo { get; set; }

        public virtual TohalMuhFi MuhFis { get; set; }
        public virtual TohalMuhHesap MuhHesap { get; set; }
    }
}