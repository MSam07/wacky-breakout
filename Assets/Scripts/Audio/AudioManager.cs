using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// The audio manager
/// </summary>
public class AudioManager : MonoBehaviour 
{
	static bool initialized = false;
    static AudioSource audioSource;
    static Dictionary<AudioClipName, AudioClip> audioClips =
        new Dictionary<AudioClipName, AudioClip>();


	/// <summary>
    /// Gets whether or not the audio manager has been initialized
    /// </summary>
    public static bool Initialized
    {
        get { return initialized; }
    }

	/// <summary>
    /// Initializes the audio manager
    /// </summary>
    /// <param name="source">audio source</param>
    public static void Initialize(AudioSource source)
    {
        initialized = true;
        audioSource = source;
        audioClips.Add(AudioClipName.Spawn,
            Resources.Load<AudioClip>("Spawn"));
        audioClips.Add(AudioClipName.Button, 
            Resources.Load<AudioClip>("Button"));
        audioClips.Add(AudioClipName.Collision,
            Resources.Load<AudioClip>("COllision"));
        audioClips.Add(AudioClipName.Effect,
             Resources.Load<AudioClip>("Effect"));
        audioClips.Add(AudioClipName.GameLost,
            Resources.Load<AudioClip>("GameLost"));
        audioClips.Add(AudioClipName.LoseLife,
            Resources.Load<AudioClip>("LoseLife"));
        
    }

	/// <summary>
    /// Plays the audio clip with the given name
    /// </summary>
    /// <param name="name">name of the audio clip to play</param>
    public static void Play(AudioClipName name)
    {
        audioSource.PlayOneShot(audioClips[name]);
	}
}
