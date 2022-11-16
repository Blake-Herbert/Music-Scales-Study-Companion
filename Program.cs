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


                                   // New menus display prompts and allow selection of options using arrow keys + enter

    string mainMenuPrompt = @"Welcome to the Scale Practice Companion
Use Arrow Keys to cycle through menus!";
    string[] mainMenuOptions = { "Show Me the Scales", "Timed Exercise", "Exit" };
    Menu mainMenu = new Menu(mainMenuPrompt, mainMenuOptions);
    mainMenu.DisplayOptions();
    int selectedMainMenuOption = mainMenu.Run();
    


                                    // This switch statement determines what the selected Main Menu option does
    switch (selectedMainMenuOption)
    {
        case 0:
            ShowMeScales();         // Show Me Scales displays requested scales by choosing a starting note and mode
            break;
        case 1:
            TimedExercise();        // Timed exercise displays random scales periodically            
            break;
        case 2:                     // This option terminates the program
            Clear(); 
            WriteLine("Press any key to exit");
            ReadKey();  
            Environment.Exit(0);
            break;
        default:
            break;
    }
}




void ShowMeScales()                      // Show Me Scales method handles selection of starting note and mode
{                                        // Show Me Scales then refers to the Scales class to produce the scale with chosen options
    Clear();
    Scales.ScaleConstructor(StartingNoteMenu(), ModeMenu());
    ReadKey();
    MainMenu();


    int StartingNoteMenu()               // Starting Note Menu displays all possible starting notes and returns the user's selection
    {
        string startingNotePrompt = @"Select the starting note for your scale";
        string[] startingNoteMenuOptions = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };


        Menu startingNoteMenu = new Menu(startingNotePrompt, startingNoteMenuOptions);
        startingNoteMenu.DisplayOptions();
        int selectedStartingNote = startingNoteMenu.Run();

        return selectedStartingNote;
    }



    int ModeMenu()                       // Mode menu displays all available modes and returns the user's selection
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

                                    // Time Menu gives the user the current time and how long their practice will last
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

    ReadKey();                           // Return to main menu when the practice is finished
    MainMenu();
}






























