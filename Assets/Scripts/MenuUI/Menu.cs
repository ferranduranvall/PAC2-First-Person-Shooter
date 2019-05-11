using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject controlsScreen;

    public GameObject menuButtons;
    public GameObject backButton;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        
    }

    public void Controls()
    {
        controlsScreen.SetActive(true);
        menuButtons.SetActive(false);
        backButton.SetActive(true);
    }

    public void MainMenu()
    {
        controlsScreen.SetActive(false);
        menuButtons.SetActive(true);
        backButton.SetActive(false);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
