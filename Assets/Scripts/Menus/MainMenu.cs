using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Listens for OnClick events for the main menu buttons
/// </summary>

public class MainMenu : MonoBehaviour 
{
	/// <summary>
	/// Handles the on click events from the main menu buttons
	/// </summary>
	public void HandlePlayButtonOnClickEvent()
	{
		AudioManager.Play(AudioClipName.Button);
		SceneManager.LoadScene("Gameplay");
	}

	/// <summary>
	/// Handles the on click events from the help menu buttons
	/// </summary>
	public void HandleHelpButtonOnclickEvent()
	{	
			AudioManager.Play(AudioClipName.Button);
			MenuManager.GoToMenu(MenuName.Help);
	}

	/// <summary>
	/// Handles the on click events from the quit menu buttons
	/// </summary>
	public void HandleQuitButtonOnClickEvent()
	{
		AudioManager.Play(AudioClipName.Button);
		Application.Quit();
	}
}
