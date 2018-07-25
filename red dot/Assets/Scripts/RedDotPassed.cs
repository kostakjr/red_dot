using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDotPassed : MonoBehaviour {

    public GameObject RedScreen;
    public GameObject ReddotPassText;
    public GameObject BigRedSquare;
    public GameObject TapToPlay;
    public GameObject highScore;
    public GameObject reddot;
    public GameObject blackdot;
    public GameObject mmButton;
    public GameObject mmText;
    public AudioSource gameOver;


    /*
     * This method will trigger the end of the game if a red dot passes through the bottom pipe.
     * Collision is the obj colliding with the bottom of the pipe or side of the pipe.
     * If the colliding obj has a tag of "reddot" or "redRL" it will activate the losing screen/text.
     * If another color dot passes through then it will put in back in its proper position.
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "reddot" || collision.gameObject.tag == "redRL")
        {
            //play noise 
            gameOver.Play();
            //display the reddot passed death screen and disable the reddot, blackdot, and main menu button
            RedScreen.SetActive(true);
            ReddotPassText.SetActive(true);
            BigRedSquare.SetActive(true);
            TapToPlay.SetActive(true);
            reddot.SetActive(false);
            blackdot.SetActive(false);
            mmButton.SetActive(false);
            mmText.SetActive(false);

            //turns on CompareHighScore obj and saves the current score to be compared to the high score
            highScore.SetActive(true);
        }
        //put the dot that passed back into its correct position
        else if (collision.gameObject.tag == "bluedot")
        {
            collision.gameObject.transform.position = new Vector2(0, 6);
        }
        else if (collision.gameObject.tag == "blueRL")
        {
            collision.gameObject.transform.position = new Vector2(-5, 0);
        }
        else if (collision.gameObject.tag == "yellowdot")
        {
            collision.gameObject.transform.position = new Vector2(0, 8);
        }
        else if (collision.gameObject.tag == "yellowRL")
        {
            collision.gameObject.transform.position = new Vector2(-7, 0);
        }
        else if (collision.gameObject.tag == "blackdot")
        {
            collision.gameObject.transform.position = new Vector2(0, 9);
        }
        else if (collision.gameObject.tag == "blackRL")
        {
            collision.gameObject.transform.position = new Vector2(-8, 0);
        }

    }


}
