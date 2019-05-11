using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuInGame : MonoBehaviour
{
    //public GameObject menuInGame;
    //public GameObject controlsScreen;
    //public GameObject backButton;
    public GameObject introImage;


    // Start is called before the first frame update
    void Start()
    {
        //menuInGame.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("Menu");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            introImage.SetActive(false);
        }

    }

    //public void DisableMenuInGame()
    //{
    //    menuInGame.SetActive(false);
    //}

    //public void MenuGame()
    //{
    //    SceneManager.LoadScene("Menu");
    //}

    //public void Controls()
    //{
    //    controlsScreen.SetActive(true);
    //    menuInGame.SetActive(false);
    //    backButton.SetActive(true);
    //}

    //public void DisableControls()
    //{
    //    backButton.SetActive(false);
    //    controlsScreen.SetActive(false);
    //    menuInGame.SetActive(true);
    //}

}
