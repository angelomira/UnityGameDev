using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public Slider MusicVolumeSlider;
    public Slider SoundVolumeSlider;

    void Start()
    {
        // Initialize sliders with saved values or defaults
        MusicVolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
        SoundVolumeSlider.value = PlayerPrefs.GetFloat("SoundVolume", 1f);

        MusicVolumeSlider.onValueChanged.AddListener(SetMusicVolume);
        SoundVolumeSlider.onValueChanged.AddListener(SetSoundVolume);
    }

    public void SetMusicVolume(float value)
    {
        // Set music volume in your audio manager or directly to AudioSource
        PlayerPrefs.SetFloat("MusicVolume", value);
    }

    public void SetSoundVolume(float value)
    {
        // Set sound effects volume in your audio manager or directly to AudioSource
        PlayerPrefs.SetFloat("SoundVolume", value);
    }

    public void BackToMainMenu()
    {
        FindObjectOfType<MainMenuController>().ShowMainMenu();
    }
}
