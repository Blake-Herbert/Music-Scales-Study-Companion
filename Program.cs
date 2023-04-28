using System.Net.Sockets;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Timers;
using Music_Scales;
using static System.Console;


MainMenu();



void MainMenu()
{
    Title = "Scale Practice Companion";


    string mainMenuPrompt = @"Welcome to the Scale Practice Companion
Use Arrow Keys to cycle through menus!";
    string[] mainMenuOptions = { "Show Me the Scales", "Timed Exercise", "Exit" };
    Menu mainMenu = new Menu(mainMenuPrompt, mainMenuOptions);
    mainMenu.DisplayOptions();
    int selectedMainMenuOption = mainMenu.Run();
    


    switch (selectedMainMenuOption)
    {
        case 0:
            ShowMeScales();         
            break;
        case 1:
            TimedExercise();           
            break;
        case 2:                     
            Clear(); 
            WriteLine("Press any key to exit");
            ReadKey();  
            Environment.Exit(0);
            break;
        default:
            break;
    }
}




void ShowMeScales()
{

    Clear();
    Scales.ScaleConstructor(StartingNoteMenu(), ModeMenu());
    ReadKey();
    MainMenu();


    int StartingNoteMenu()               
    {
        string startingNotePrompt = @"Select the starting note for your scale";
        string[] startingNoteMenuOptions = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };


        Menu startingNoteMenu = new Menu(startingNotePrompt, startingNoteMenuOptions);
        startingNoteMenu.DisplayOptions();
        int selectedStartingNote = startingNoteMenu.Run();

        return selectedStartingNote;
    }



    int ModeMenu()                       
    {
        string modeSelectionPrompt = @"Which mode would you like?";
        string[] modeSelectionOptions = { "Ionian/Major", "Dorian", "Phrygian", "Lydian", "Mixolydian", "Aeolian/Minor", "Locrian" };


        Menu modesMenu = new Menu(modeSelectionPrompt, modeSelectionOptions);
        modesMenu.DisplayOptions();
        int selectedMode = modesMenu.Run();
        Clear();

        return selectedMode;
    }
}



void TimedExercise()
{
    Clear();

                                    
   DateTime now = new DateTime();
    now = DateTime.Now;
    string timePrompt = "The time is " + now + "\nHow long would you like to practice?";
    string[] timeOptions = { @"One Minute, you will finish at " + now.AddMinutes(1), "Thirty seconds, you will finish at " + now.AddSeconds(30), "Return" };
    Menu timeMenu = new Menu(timePrompt, timeOptions);
    timeMenu.DisplayOptions();
    switch(timeMenu.Run())
    {
        case 0:
            TimedPractice.Timer.RunOneMinute();
            break;

        case 1:
            TimedPractice.Timer.Run30Seconds();
            break;
        case 2:
            MainMenu();
            break;
    }

    ReadKey();                           
    MainMenu();
}






























