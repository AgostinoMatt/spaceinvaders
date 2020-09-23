using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// © Glitch Squirrel Design 2017
// All right reserved.

public class SaveData {

    /// <summary>
    /// Saves the score.
    /// </summary>
    /// <param name="score">Score.</param>
    public static void SaveScore(int score)
	{
        PlayerPrefs.SetInt("Score", score);
	}

	/// <summary>
    /// Saves the sound volume.
    /// </summary>
    /// <param name="soundVolume">Sound volume.</param>
	public static void SaveSoundVolume(float soundVolume)
    {
        PlayerPrefs.SetFloat("SoundVolume", soundVolume);
    }

    /// <summary>
    /// Saves the music volume.
    /// </summary>
    /// <param name="musicVolume">Music volume.</param>
	public static void SaveMusicVolume(float musicVolume)
	{
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
	}

    /// <summary>
    /// Saves the global volume.
    /// </summary>
    /// <param name="globalVolume">Global volume.</param>
	public static void SaveGlobalVolume(float globalVolume)
	{
        PlayerPrefs.SetFloat("GlobalVolume", globalVolume);
	}
}

// © Glitch Squirrel Design 2017
// All right reserved.
