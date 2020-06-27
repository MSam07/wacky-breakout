using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game over message
/// </summary>
public class GameOverMessage : MonoBehaviour
{
    [SerializeField]
    Text messageText;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // pause the game when added to the scene
        Time.timeScale = 0;
    }

    /// <summary>
    /// Sets the score in the message to the given score
    /// </summary>
    /// <param name="score">core</param>
    public void SetScore(int score)
    {
        messageText.text = "Score: " + score;
    }

    /// <summary>
    /// Moves to main menu when quit button clicked
    /// </summary>
    public void HandleQuitButtonClicked()
    {
        // unpause game, destroy menu, and go to main menu
        Time.timeScale = 1;
        Destroy(gameObject);
        AudioManager.Play(AudioClipName.Button);
        MenuManager.GoToMenu(MenuName.Main);
    }
}
