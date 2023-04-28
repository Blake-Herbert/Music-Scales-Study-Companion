using System.Timers;
using static System.Console;

namespace Music_Scales
{
	public partial class TimedPractice
	{
		public class Timer
        {
            bool activated = false;

            public static void RunOneMinute()
            {
                Clear();
                randomScales();
                SetTimer();
            }

            public static void Run30Seconds()
            {
                Clear();
                randomScales();
                SetTimer3();
            }

            private static System.Timers.Timer newRandomScaleTimer;

            private static void SetTimer()
            {
                newRandomScaleTimer = new System.Timers.Timer(15000);
                newRandomScaleTimer.Elapsed += randomScale1;
                newRandomScaleTimer.AutoReset = false;
                newRandomScaleTimer.Enabled = true;
            }



            static void randomScale1(Object source, ElapsedEventArgs e)
            {
                newRandomScaleTimer.Stop();
                newRandomScaleTimer.Dispose();
                WriteLine("\n \n");
                randomScales();
                SetTimer2();
            }

            static void SetTimer2()
            {

                newRandomScaleTimer = new System.Timers.Timer(15000);
                newRandomScaleTimer.Elapsed += randomScale2;
                newRandomScaleTimer.AutoReset = false;
                newRandomScaleTimer.Enabled = true;
            }

            static void randomScale2(Object source, ElapsedEventArgs e)
            {
                newRandomScaleTimer.Stop();
                newRandomScaleTimer.Dispose();
                WriteLine("\n \n");
                randomScales();
                SetTimer3();
            }
            static void SetTimer3()
            {

                newRandomScaleTimer = new System.Timers.Timer(15000);
                newRandomScaleTimer.Elapsed += randomScale3;
                newRandomScaleTimer.AutoReset = false;
                newRandomScaleTimer.Enabled = true;
            }

            static void randomScale3(Object source, ElapsedEventArgs e)
            {
                newRandomScaleTimer.Stop();
                newRandomScaleTimer.Dispose();
                WriteLine("\n \n");
                randomScales();
                SetTimer4();
            }
            static void SetTimer4()
            {

                newRandomScaleTimer = new System.Timers.Timer(15000);
                newRandomScaleTimer.Elapsed += endOfExercise;
                newRandomScaleTimer.AutoReset = false;
                newRandomScaleTimer.Enabled = true;


                static void endOfExercise(Object source, ElapsedEventArgs e)
                {
                    newRandomScaleTimer.Stop();
                    newRandomScaleTimer.Dispose();
                    Clear();


                    WriteLine("End of exercise. Press any key to return to main menu.");


                }
            }

        }

    }
}
