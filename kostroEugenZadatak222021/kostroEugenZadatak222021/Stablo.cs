using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenZadatak222021
{
    class Stablo : Biljka
    {
        bool opadajuListovi;
        private bool OpadajuListovi()
        {
            return opadajuListovi;
        }
        public void stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
    }
}
