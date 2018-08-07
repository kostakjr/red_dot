using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuButton : MonoBehaviour {

    public AudioSource mainMenu;

    //when obj is clicked a noise will play, the main menu scene will load and the score resets
    private void OnMouseDown()
    {
        mainMenu.Play();
        //load main menu which is scene 0
        SceneManager.LoadScene(0);
        //resets the score
        ScoringSystem.score = 0;
    }
}
