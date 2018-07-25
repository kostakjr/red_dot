using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackDotTouch : MonoBehaviour {

    public GameObject BlackScreen;
    public GameObject BlackTouchText;
    public GameObject BigBlackSquare;
    public GameObject TapToPlay;
    public GameObject highScore;
    public GameObject highScoreText;
    public GameObject reddot;
    public GameObject blackdot;
    public GameObject mmButton;
    public GameObject mmText;

    //game over sound effect
    public AudioSource gameOver;

    /*
     * when the mouse button is clicked on a blackdot it will 
     * play a noise, and end the game.
     */
    private void OnMouseDown()
    {
        //play sound effect
        gameOver.Play();
        //displays the black dot touched death screen and disable reddot, blackdot and main menu button
        BlackScreen.SetActive(true);
        BlackTouchText.SetActive(true);
        BigBlackSquare.SetActive(true);
        TapToPlay.SetActive(true);
        reddot.SetActive(false);
        blackdot.SetActive(false);
        mmButton.SetActive(false);
        mmText.SetActive(false);

        //make previous highscore display disappear
        highScoreText.SetActive(false);

        //turns on HighScoreCheck and saves the current score to be compared to the high score
        highScore.SetActive(true);
    }
}
