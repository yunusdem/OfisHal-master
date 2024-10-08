using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class ToambNavlunDizayni
    {
        public ToambNavlunDizayni()
        {
            ToambNavlunFaturasis = new HashSet<ToambNavlunFaturasi>();
            ToambSevkIrsaliyesiSatiriDizayns = new HashSet<ToambSevkIrsaliyesiSatiri>();
            ToambSevkIrsaliyesiSatiriMuameleDizayns = new HashSet<ToambSevkIrsaliyesiSatiri>();
        }

        public int DizaynId { get; set; }
        public string Ad { get; set; }
        public string DosyaAdi { get; set; }
        public int Numerator { get; set; }
        public string EFaturaOnEki { get; set; }
        public int? EFaturaSiraNo { get; set; }
        public string EArsivFaturasiOnEki { get; set; }
        public int? EArsivFaturasiSiraNo { get; set; }

        public virtual ICollection<ToambNavlunFaturasi> ToambNavlunFaturasis { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiriDizayns { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiriMuameleDizayns { get; set; }
    }
}