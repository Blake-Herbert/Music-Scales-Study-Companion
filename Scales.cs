using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Music_Scales
{
    public class Scales
    {

                                // Array of all possible starting notes
        private static string[] allDiatonicNotes = { "C", "C#/Db", "D", "Eb/D#", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "Bb/A#", "B",
                                                     "C", "C#/Db", "D", "Eb/D#", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "Bb/A#", "B" };
        
        enum Mode               // Mode enum to display selected mode as a string
        {
            Ionian,
            Dorian,
            Phrygian,
            Lydian,
            Mixolydian,
            Aeolian,
            Locrian
        }

       

        public static void ScaleConstructor(int selectedStartingNote, int selectedMode) 
        {
            
                                // Displaying full name of the scale using selected starting note and the Mode enum to display the selected mode
            Mode mode = (Mode)selectedMode;     

            WriteLine(allDiatonicNotes[selectedStartingNote] + " " + mode + " Scale:" + "\n----------------------------");

                                // Intervals are the "shape" of modes, these arrays store those shapes
            int[] ionianScaleIntervals = { 0, 2, 4, 5, 7, 9, 11, 12 };
            int[] dorianScaleIntervals = { 0, 2, 3, 5, 7, 9, 10, 12 };
            int[] phrygianScaleIntervals = { 0, 1, 3, 5, 7, 8, 10, 12 };
            int[] lydianScaleIntervals = { 0, 2, 4, 6, 7, 9, 11, 12 };
            int[] mixolydianScaleIntervals = { 0, 2, 4, 5, 7, 9, 10, 12 };
            int[] aeolianScaleIntervals = { 0, 2, 3, 5, 7, 8, 10, 12 };
            int[] locrianScaleIntervals = { 0, 1, 3, 5, 6, 8, 10, 12 };

                                // Mode Array converts selected mode to the corresponding shape
            int[][] modeArray = new int[7][];
            modeArray[0] = ionianScaleIntervals;
            modeArray[1] = dorianScaleIntervals;
            modeArray[2] = phrygianScaleIntervals;
            modeArray[3] = lydianScaleIntervals;
            modeArray[4] = mixolydianScaleIntervals;
            modeArray[5] = aeolianScaleIntervals;
            modeArray[6] = locrianScaleIntervals;

                                // This loop produces the requested scale by using the selected mode shape starting at the selected starting note
            foreach (int interval in modeArray[selectedMode])
            {
                
                Write("(" + allDiatonicNotes[selectedStartingNote + interval] + ") ");
            }
            

        }
    }
}

