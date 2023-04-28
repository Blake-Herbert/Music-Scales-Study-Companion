using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Music_Scales_Study_Companion.Menu
{
	public class MainMenu
	{
		public void Start()
		{
			Title = "Scale Practice Companion";
			Clear();


			string mainMenuPrompt = @"Welcome to the Scale Practice Companion
Use Arrow Keys to cycle through menus!";
			string[] mainMenuOptions = { "Show Me the Scales", "Timed Exercise", "Exit" };
			Menu mainMenu = new Menu(mainMenuPrompt, mainMenuOptions);
			mainMenu.DisplayOptions();
			int selectedMainMenuOption = mainMenu.Run();



			switch (selectedMainMenuOption)
			{
				case 0:
					ScalesGeneratorMenu scalesGeneratorMenu = new ScalesGeneratorMenu();
					scalesGeneratorMenu.Start();
					break;
				case 1:
					//TimedExercise();
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

	}
}
