using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfisHal.Core.ViewModels
{
    public class IsYerleriViewModel
    {
        public int? MagazaId { get; set; }
        public int cariKartId { get; set; }
        public string isyeriKod { get; set; }
        public int? isyeriIlId { get; set; }
        public int? isyeriIlceId { get; set; }
        public int? isyeriBeldeId { get; set; }
        public string isyeriAd { get; set; }
        public string isyeriAdres { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string faks { get; set; }
        public byte? gidecegiYer { get; set; }
        public int? webSiraNo { get; set; }
        public string plakaNo { get; set; }
        public byte? cariSifati { get; set; }
        public int? eIrsaliyePosta { get; set; }
        public int? PostaKoduId { get; set; }
        public string bolgeKodu { get; set; }
        public bool? enCokKullanilan { get; set; }
    }
}
