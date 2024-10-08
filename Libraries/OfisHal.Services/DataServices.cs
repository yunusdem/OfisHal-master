using OfisHal.Data.Context;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace OfisHal.Services
{
    public interface IDataServices
    {
        string UnitCodeBul(string birim);

        YerBilgi YerBilgiAl(int yerId);

        int MalBirimIdBul(string birimAd);

        int BildirimTipiIdBul(byte deger);

        int UretimSekliIdBul(byte deger);

        YerBilgi YerGetir(int yerId);
	}

    public class DataServices : IDataServices
    {
        private readonly Db _context;

        public DataServices(Db context)
        {
            _context = context;
        }

        /// <summary>
        /// https://www.prodasoft.com/tr/e-fatura-uluslararasi-birim-kodlari-unitcode
        /// </summary>
        /// <param name="birim"></param>
        /// <returns></returns>
        public string UnitCodeBul(string birim)
        {
            switch (birim.ToLowerInvariant())
            {
                case "kg":
                    return "KGM";
                case "adet":
                    return "NIU";
                case "bag":
                    return "BE";
                default:
                    return string.Empty;
            }
        }


        public YerBilgi YerGetir(int yerId)
        {
            var items = _context.Database.SqlQuery<YerHiyerarsi>("EXEC [dbo].[p_GetYer] @YerId", new SqlParameter("@YerId", yerId)).ToList();

			var model = new YerBilgi
			{
				IlId = items.FirstOrDefault(x => x.Type == YerType.Il)?.Id ?? 0,
				IlAdi = items.FirstOrDefault(x => x.Type == YerType.Il)?.Name,
				IlceId = items.FirstOrDefault(x => x.Type == YerType.Ilce)?.Id ?? 0,
				IlceAdi = items.FirstOrDefault(x => x.Type == YerType.Ilce)?.Name,
				BeldeId = items.FirstOrDefault(x => x.Type == YerType.Belde)?.Id ?? 0,
				BeldeAdi = items.FirstOrDefault(x => x.Type == YerType.Belde)?.Name,
			};

			return model;
        }

		public YerBilgi YerBilgiAl(int yerId)
        {
            var model = new YerBilgi();

            var items = _context.Database.SqlQuery<YerHiyerarsi>(
          "EXEC [dbo].[p_GetYer] @YerId",
          new SqlParameter("@YerId", yerId)
      ).ToList();

            //var items = conn.Query<YerHiyerarsi>("p_GetYer", new { yerId }, commandType: System.Data.CommandType.StoredProcedure);

            if (items != null)
            {
                model.IlId = items.FirstOrDefault(x => x.Type == YerType.Il)?.HksId ?? 0;
                model.IlceId = items.FirstOrDefault(x => x.Type == YerType.Ilce)?.HksId ?? 0;
                model.BeldeId = items.FirstOrDefault(x => x.Type == YerType.Belde)?.HksId ?? 0;
            }

            return model;
        }

        public int MalBirimIdBul(string birimAd)
        {
            if (!string.IsNullOrWhiteSpace(birimAd))
            {
                birimAd = birimAd.ToLower();
                switch (birimAd)
                {
                    default:
                    case "kg":
                        return 74;
                    case "adet":
                        return 73;
                    case "bağ":
                        return 76;
                }
            }
            return 74;
        }

        public int BildirimTipiIdBul(byte deger)
        {
            switch (deger)
            {
                default:
                case 0:
                    return 195; // Satın Alım
                case 1:
                    return 206; // Üreticiden Sevk Alım
                case 2:
                    return 197; // Satış
                case 3:
                    return 196; // Sevk Etme
            }
        }

        public int UretimSekliIdBul(byte deger)
        {
            switch (deger)
            {
                case 0:
                    return 28;
                case 1:
                    return 29;
                case 2:
                default:
                    return 28;
            }
        }
    }

    public class YerBilgi
    {
        public int UlkeId => 201; // türkiye sabit değer

        public string UlkeAdi => "Türkiye";

        public int IlId { get; set; }

        public string IlAdi {  get; set; }

        public int IlceId { get; set; }

		public string IlceAdi { get; set; }

		public int BeldeId { get; set; }

		public string BeldeAdi { get; set; }
	}

    public class YerHiyerarsi
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public YerType Type { get; set; }

        public int? HksId { get; set; }

        public string Name { get; set; }
    }

    public enum YerType : byte
    {
        Il = 0,
        Ilce = 1,
        Belde = 2
    }

    public enum MalNitelik : byte
    {
        Yerli = 1,
        Ithalat = 2,
        ToplamaMal = 3
    }

    public enum BildirimBelgeTipi : byte
    {
        Irsaliye = 207,
        Fatura = 208,
        GumrukBeyannamesi = 209
    }
}
