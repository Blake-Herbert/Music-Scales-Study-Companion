using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Timers;
using Music_Scales;
using Music_Scales_Study_Companion.Menu;
using static System.Console;


MainMenu mainMenu = new MainMenu();
mainMenu.Start();




//void TimedExercise()
//{
//    Clear();

                                    
//   DateTime now = new DateTime();
//    now = DateTime.Now;
//    string timePrompt = "The time is " + now + "\nHow long would you like to practice?";
//    string[] timeOptions = { @"One Minute, you will finish at " + now.AddMinutes(1), "Thirty seconds, you will finish at " + now.AddSeconds(30), "Return" };
//    Menu timeMenu = new Menu(timePrompt, timeOptions);
//    timeMenu.DisplayOptions();
//    switch(timeMenu.Run())
//    {
//        case 0:
//            TimedPractice.Timer.RunOneMinute();
//            break;

//        case 1:
//            TimedPractice.Timer.Run30Seconds();
//            break;
//        case 2:
//            MainMenu mainMenu = new MainMenu();
//            mainMenu.Start();
//            break;
//    }

//    ReadKey();
//    MainMenu mainMenu = new MainMenu;
//    mainMenu.Start();































