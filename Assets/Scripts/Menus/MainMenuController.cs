using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SettingsPanel;

    void Start()
    {
        ShowMainMenu();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Levels/Level1");
    }

    public void LoadMenu() {
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void ShowSettings()
    {
        MainMenuPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ShowMainMenu()
    {
        MainMenuPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
}
