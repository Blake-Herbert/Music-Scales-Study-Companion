using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Music_Scales
{
     class TimedPractice : Scales
    {

        


        
        public void randomScales()
        {
            Clear();
            Random random = new Random();       

            int randomStartingNote = random.Next(0, 12);        // Random starting note value doesn't exceed a single octave's worth of notes
            int randomMode = random.Next(0, 7);                 // Random mode value doesn't exceed range for selecting a mode

            ScaleConstructor(randomStartingNote, randomMode);   // A scale is constructed with the random starting note and mode



        }
    }
}
