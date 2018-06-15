using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    [Serializable]
    public class RouletteGame
    {
        public long credits;
        public long bets;
        public long win;

        public long[] numbBets;
        public long bigSeries;
        public long smallSeries;
        public long orphans;
        public long zeroSpiel;

        public long redNumbers;
        public long blackNumbers;

        public RouletteGame()
        {

        }


    }
}
