using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music_Scales;
using static System.Console;

namespace Music_Scales_Study_Companion.Menu
{
	internal class ScalesGeneratorMenu
	{
		public void Start()
		{
			Clear();
			Scales.ScaleConstructor(StartingNote(), Mode());
			ReadKey();
			MainMenu mainMenu = new MainMenu();
			mainMenu.Start();


			int StartingNote()
			{
				string startingNotePrompt = @"Select the starting note for your scale";
				string[] startingNoteMenuOptions = { "C ", "C#/Db ", "D ", "Eb/D# ", "E ", "F ", "F#/Gb ", "G ", "G#/Ab ", "A ", "Bb/A# ", "B " };


				Menu startingNoteMenu = new Menu(startingNotePrompt, startingNoteMenuOptions);
				startingNoteMenu.DisplayOptions();
				int selectedStartingNote = startingNoteMenu.Run();

				return selectedStartingNote;
			}



			int Mode()
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

	}
}
