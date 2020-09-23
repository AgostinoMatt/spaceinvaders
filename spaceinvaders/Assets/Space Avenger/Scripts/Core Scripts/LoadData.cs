using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// © Glitch Squirrel Design 2017
// All right reserved.

public class LoadData {
    
	public static int LoadScore()
	{
        int newScore = PlayerPrefs.GetInt("Score", 0);
        return (newScore);
	}

	/// <summary>
    /// Loads the music volume.
    /// </summary>
    /// <returns>The music volume.</returns>
	public static float LoadMusicVolume()
    {
        float musicVolume = PlayerPrefs.GetFloat("MusicVolume", -5);
        return (musicVolume);
    }

    /// <summary>
    /// Loads the sound volume.
    /// </summary>
    /// <returns>The sound volume.</returns>
	public static float LoadSoundVolume()
	{
        float soundVolume = PlayerPrefs.GetFloat("SoundVolume", -5);
		return (soundVolume);
	}

    /// <summary>
    /// Loads the global volume.
    /// </summary>
    /// <returns>The global volume.</returns>
	public static float LoadGlobalVolume()
	{
        float globalVolume = PlayerPrefs.GetFloat("GlobalVolume", -5);
		return (globalVolume);
	}
}

// © Glitch Squirrel Design 2017
// All right reserved.
