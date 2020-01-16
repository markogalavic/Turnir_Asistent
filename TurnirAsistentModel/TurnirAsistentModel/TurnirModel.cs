using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class TurnirModel
    {
        /// <summary>
        /// Naziv turnira
        /// </summary>
        public string NazivTurnira  { get; set; }
        /// <summary>
        /// Kotizacija turnira
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// Lista svih ekipa u turniru
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// Lista svih nagrada u turniru
        /// </summary>
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// Lista svih rundi  u  utakmicama
        /// </summary>
        public List<List<UtakmicaModel>> Runde { get; set; } = new List<List<UtakmicaModel>>(); 
    }
}
