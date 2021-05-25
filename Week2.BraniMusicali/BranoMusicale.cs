using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BraniMusicali
{
    enum GenereMusicale
    {
        Rock,
        Pop,
        Tecno
    }
    class BranoMusicale
    {
        public String Titolo { get; set; } = "";
        public String Artista { get; set; } = "";
        public double Durata { get; set; } 
        public GenereMusicale Genere { get; set; }

        public bool VersioneLive { get { return IsVersioneLive(); } }

        public bool IsVersioneLive()
        {
            if(Durata > 5)
            {
                return true;
            }
            return false;
        }

        public String ToString()
        {
            string versione = "";
            if (VersioneLive)
            {
                versione = "Concerto";
            } else
            {
                versione = "CD";
            }
            return $"Titolo {Titolo} - Artista {Artista} - Durata {Durata}min - Versione {versione}";
        }
    }
}
