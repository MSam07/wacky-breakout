using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pauses and unposes the game
/// </summary>
public class PauseMenu : MonoBehaviour 
{
	public static bool isPaused = false;

	// Use this for initialization
	void Start () 
	{
		//pause the game when added to the scene
		Time.timeScale = 0;	
		isPaused = true;
	}

	/// <summary>
	/// Handles the onclick effect on the pause menu
	/// </summary>
	public void HandleResumeButtonOnClickEvent()
	{	
		DeletePauseEffect();
	}
	
	/// <summary>
	/// Handles the onclick effect from the quit button
	/// </summary>
	public void HandleQuitButtonOnClickEvent()
	{
		DeletePauseEffect();
		MenuManager.GoToMenu(MenuName.Main);

	}

	//delete pause effect
	void DeletePauseEffect ()
	{
		//unpause the game and destroy menu
		AudioManager.Play(AudioClipName.Button);
		Time.timeScale = 1;
		Destroy(gameObject);
		isPaused = false;
	}
}
