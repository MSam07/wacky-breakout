using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Opens the Help Menu
/// </summary>
public class HelpMenu : MonoBehaviour 
{
	//Handles the OnClickEvent on the quit button
	public void HandleQuitButtonOnClickEvent()
	{
		AudioManager.Play(AudioClipName.Button);
		//destroy menu and go to the main menu
		Destroy(gameObject);
		MenuManager.GoToMenu(MenuName.Main);
	}
}
