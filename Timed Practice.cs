using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Music_Scales
{
    public class TimedPractice : Scales
    {
        public void randomScales()
        {
            Clear();
            Random random = new Random();
            int randomStartingNote = random.Next(0, 12);
            int randomMode = random.Next(0, 7);
            ScaleConstructor(randomStartingNote, randomMode);



        }
    }
}
