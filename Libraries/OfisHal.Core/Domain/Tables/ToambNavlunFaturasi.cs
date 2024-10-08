using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class ToambNavlunFaturasi
    {
        public ToambNavlunFaturasi()
        {
            ToambNavlunFaturaSatiris = new HashSet<ToambNavlunFaturaSatiri>();
        }

        public int NavlunFaturasiId { get; set; }
        public int YazihaneId { get; set; }
        public int? DizaynId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public double NavlunToplam { get; set; }
        public double MuameleToplam { get; set; }
        public double Toplam { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public double GenelToplam { get; set; }
        public bool? Odendi { get; set; }
        public bool? Kesildi { get; set; }
        public int? EkleyenId { get; set; }
        public int? GuncelleyenId { get; set; }
        public DateTime? EklemeZamani { get; set; }
        public DateTime? GuncellemeZamani { get; set; }
        public int? GibFirmamizPostaKutusuId { get; set; }
        public int? GibMuhatapPostaKutusuId { get; set; }
        public string EFaturaEttn { get; set; }
        public byte? EFaturaDurumu { get; set; }
        public byte? EFaturaGibDurumu { get; set; }
        public string EFaturaHataAciklamasi { get; set; }
        public DateTime Zaman { get; set; }

        public virtual ToambNavlunDizayni Dizayn { get; set; }
        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual TohalCariKart Yazihane { get; set; }
        public virtual ICollection<ToambNavlunFaturaSatiri> ToambNavlunFaturaSatiris { get; set; }
    }
}