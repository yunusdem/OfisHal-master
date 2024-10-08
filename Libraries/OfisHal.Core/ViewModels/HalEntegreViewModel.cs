using OfisHal.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfisHal.Core.ViewModels
{
    public class HalEntegreViewModel
    {
        public VohalDokumTanimlari dokum { get; set; }
        public VohalSatisTanimlari satis { get; set; }
        public VohalAlisTanimlari alis { get; set; }
        public VohalHesapTanimlari hesap { get; set; }
        public VohalHksTanimlar hks { get; set; }
        public VohalFirmaTanimlari firma { get; set; }
        public VohalEBelgeTanimi ebelge { get; set; }
        public VohalDigerTanimlar diger { get; set; }
    }
}
