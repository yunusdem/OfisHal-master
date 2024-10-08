using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalTeslimatYeri
    {
        public TohalTeslimatYeri()
        {
            TohalFaturas = new HashSet<TohalFatura>();
            TohalMakbuzs = new HashSet<TohalMakbuz>();
        }

        public int TeslimatYeriId { get; set; }
        public byte? Tip { get; set; }
        public string Ad { get; set; }
        public int? HksWebSiraNo { get; set; }
        public int? HksId { get; set; }
        public string Adres { get; set; }

        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzs { get; set; }
    }
}