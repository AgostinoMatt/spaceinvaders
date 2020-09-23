using UnityEngine;
using UnityEngine.Audio;

public class UISounds : MonoBehaviour {

    [Header("UI Sounds")]
    public AudioMixer mixer;
    public AudioSource sourceMusic;
    public AudioSource sourceSound;
    public AudioClip buttonClick;
    public AudioClip[] music;

    private void Start()
    {
        if (music.Length == 0) { return; }
        PlayBackrgoundMusic();
    }

    private void Update()
    {
        mixer.SetFloat("globalVolume", LoadData.LoadGlobalVolume());
        mixer.SetFloat("musicVolume", LoadData.LoadMusicVolume());
        mixer.SetFloat("soundVolume", LoadData.LoadSoundVolume());
    }

    public void PlayButtonClick()
    {
        sourceSound.PlayOneShot(buttonClick);
    }

    public void PlayBackrgoundMusic()
    {
        sourceMusic.clip = music[Random.Range(0, music.Length)];
        sourceMusic.loop = true;
        sourceMusic.Play();
    }

    public void StopBackgroundMusic()
    {
        sourceMusic.Stop();
    }
}
