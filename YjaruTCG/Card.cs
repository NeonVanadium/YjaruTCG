using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YjaruTCG
{
    class Card
    {
        public int width = 200;
        public int height = 280;

        public string name { get; set; }
        public string color { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public Boolean legendary { get; set; }
    }
}
