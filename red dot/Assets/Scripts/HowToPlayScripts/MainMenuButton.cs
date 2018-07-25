using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuButton : MonoBehaviour {

    public AudioSource mainMenu;

    private void OnMouseDown()
    {
        mainMenu.Play();
        SceneManager.LoadScene(0);
    }
}
