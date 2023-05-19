using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Racing
{
    internal class Save_Score
    {
        public bool save_Score(List<Score_Board> list_score, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (Score_Board score in list_score)
                {
                    string line = score.N + "; " + score.takedata + "; " + score.score + "; " + score.time;
                    sw.WriteLine(line);
                }

                sw.Close();
                return true;
            }
            catch ( Exception ex)
            {
                throw ex;
            }
        }

        internal static bool save_score(List<Score_Board> score_Boards, string path)
        {
            throw new NotImplementedException();
        }
    }
}
