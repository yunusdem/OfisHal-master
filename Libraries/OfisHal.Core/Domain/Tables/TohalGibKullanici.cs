using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalGibKullanici
    {
        public TohalGibKullanici()
        {
            TohalCariKartEIrsaliyePostaKutusus = new HashSet<TohalCariKart>();
            TohalCariKartGibEFaturaPostaKutusus = new HashSet<TohalCariKart>();
            TohalFaturaGibFirmamizPostaKutusus = new HashSet<TohalFatura>();
            TohalFaturaGibFrmIrsaliyeKutusus = new HashSet<TohalFatura>();
            TohalFaturaGibMuhatapIrsaliyeKutusus = new HashSet<TohalFatura>();
            TohalFaturaGibMuhatapPostaKutusus = new HashSet<TohalFatura>();
            TohalKullaniciEFaturaGondericiBirimis = new HashSet<TohalKullanici>();
            TohalKullaniciEIrsaliyeGondericiBirimis = new HashSet<TohalKullanici>();
            TohalMagazas = new HashSet<TohalMagaza>();
            TohalMakbuzGibFirmamizPostaKutusus = new HashSet<TohalMakbuz>();
            TohalMakbuzGibMuhatapPostaKutusus = new HashSet<TohalMakbuz>();
        }

        public int GibKullaniciId { get; set; }
        public string Vkn { get; set; }
        public string PostaKutusu { get; set; }
        public string Unvan { get; set; }
        public byte Tip { get; set; }
        public DateTime KayitZamani { get; set; }
        public byte PkTipi { get; set; }
        public bool? Silindi { get; set; }
        public byte DokumanTipi { get; set; }
        public byte KayitSekli { get; set; }

        public virtual ICollection<TohalCariKart> TohalCariKartEIrsaliyePostaKutusus { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartGibEFaturaPostaKutusus { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaGibFirmamizPostaKutusus { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaGibFrmIrsaliyeKutusus { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaGibMuhatapIrsaliyeKutusus { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaGibMuhatapPostaKutusus { get; set; }
        public virtual ICollection<TohalKullanici> TohalKullaniciEFaturaGondericiBirimis { get; set; }
        public virtual ICollection<TohalKullanici> TohalKullaniciEIrsaliyeGondericiBirimis { get; set; }
        public virtual ICollection<TohalMagaza> TohalMagazas { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzGibFirmamizPostaKutusus { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzGibMuhatapPostaKutusus { get; set; }
    }
}