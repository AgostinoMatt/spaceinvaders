using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// © Glitch Squirrel Design 2017
// All right reserved.

public class UIBehaviour : MonoBehaviour {

    [Header("UI setup")]
    public int score;
    public Text scoreText;
    public Text finalScoreText;

    [Header("Game status")]
	public bool gameOver = false;

	[Header("Settings Utility")]
	public Slider globalVolume;
	public Slider musicVolume;
	public Slider soundVolume;

	private ScreenBehaviour screenBehaviour;

    private void Awake()
    {
        screenBehaviour = FindObjectOfType<ScreenBehaviour>();

    }

    private void Update()
    {
        
    }

    public void IncomeScore(int newScore)
    {
        score += newScore;
        scoreText.text = score.ToString();
    }

	public bool GameOver()
	{
		gameOver = true;
        finalScoreText.text = score.ToString();
        screenBehaviour.SetScreen("GameOver");
		return gameOver;
	}

	public void SetupMusicVolume()
	{
		SaveData.SaveMusicVolume(musicVolume.value);
	}

	public void SetupSoundVolume()
	{
		SaveData.SaveSoundVolume(soundVolume.value);
	}

	public void SetupGlobalVolume()
	{
		SaveData.SaveGlobalVolume(globalVolume.value);
	}

	public void SetupSettings()
	{
		globalVolume.value = LoadData.LoadGlobalVolume();
		musicVolume.value = LoadData.LoadMusicVolume();
		soundVolume.value = LoadData.LoadSoundVolume();
	}

}

// © Glitch Squirrel Design 2017
// All right reserved.
