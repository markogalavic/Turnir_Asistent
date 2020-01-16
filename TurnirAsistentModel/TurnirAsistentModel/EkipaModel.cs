using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class EkipaModel
    {
        /// <summary>
        /// Lista koji su igraci u ekipi
        /// </summary>
        public List<OsobaModel> ClanoviEkipe { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// Sva imena osoba u ekipi
        /// </summary>
        public string ImeEkipe { get; set; }
    }
}
