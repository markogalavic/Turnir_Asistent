using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class UtakmicaModel
    {
        /// <summary>
        /// Lista svih natjecatelja turnira nebitno o timu
        /// </summary>
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// Pobijednik odrzane utakmice , pobijednik ide dalje
        /// </summary>
        public EkipaModel Pobijednik { get; set; }
        /// <summary>
        /// Broj runde na kojem je kolu trenutna utakmica
        /// </summary>
        public int  BrojRunde{ get; set; }
    }
}
