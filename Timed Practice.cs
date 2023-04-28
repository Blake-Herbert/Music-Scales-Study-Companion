using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Scales
{
	public partial class TimedPractice : Scales
    {

        public static void randomScales()
        {
            
            Random random = new Random();       

            int randomStartingNote = random.Next(0, 12);        
            int randomMode = random.Next(0, 7);                 

            ScaleConstructor(randomStartingNote, randomMode);  

        }

    }
}
