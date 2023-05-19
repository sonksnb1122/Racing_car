using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    internal class Score_Board
    {
        public int N { get; set; }
        public String takedata { get; set; }
        public String score { get; set; }
        public String time { get; set; }

        public override string ToString()
        {
            return N + " --- " + takedata + " --- " + score + " --- " + time.ToString();
        }
    }
}
