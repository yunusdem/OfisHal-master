using System;

namespace OfisHal.Web.Models
{
    public class TohalEFaturaLog
    {
        public int LogId { get; set; }
        public int FaturaId { get; set; }
        public byte Tur { get; set; }
        public byte Tip { get; set; }
        public string Mesaj { get; set; }
        public DateTime Zaman { get; set; }
    }
}