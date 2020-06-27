using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages navigation through the menu system
/// </summary>

public static class MenuManager 
{
	/// <summary>
	/// Goes to the menu with the given name
	/// </summary>
	public static void GoToMenu(MenuName name)
	{
		switch(name)
		{
			case MenuName.Main:

				//go to MainMenu scene
				SceneManager.LoadScene("MainMenu");
				break;

			case MenuName.Help:
				//deactivate main menu canvas and instantiate prefab
				GameObject mainMenuCanvas = GameObject.Find("MainMenuCanvas");
				mainMenuCanvas.SetActive(false);
				Object.Instantiate(Resources.Load("HelpMenu"));
				break;
		
			case MenuName.Pause:

				//instantiate prefab
				Object.Instantiate(Resources.Load("PauseMenu"));
				break;



		}
	}
}
