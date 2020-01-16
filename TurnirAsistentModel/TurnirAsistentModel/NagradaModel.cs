using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class NagradaModel
    {
        /// <summary>
        /// Osvojeno mjesto
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Naziv mjesta pobijednika
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Iznos nagrade
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// Postotak osvojene nagrade
        /// </summary>
        public double PostotakNagrade { get; set; }
    }
}
