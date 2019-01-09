using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneDealer : Dealer
    {

        public bool Stay { get; set; }
        public bool isBusted { get; set; }
        public List<Card> Hand { get; set; }

    }
}
