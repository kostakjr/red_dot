using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDotTouch : MonoBehaviour {

    public GameObject reddot;
    public AudioSource redTap;

    /*
     * when the mouse button is clicked on a reddot it will move it back to the correct position,
     * play a noise, and add a point to the score.
     */
    private void OnMouseDown()
    {
        //play noise
        redTap.Play();

        //make sure the correct dot is being moved to the appropriate position
        if (this.tag == "reddot")
        {
            //moves dot back to the top: 0, 7
            this.transform.position = new Vector2(0, 7);
        }
        else
        {
            //moves RL dot to -9, 0
            this.transform.position = new Vector2(-9, 0);
        }

        //uses scoring system to increment the score
        ScoringSystem.score++;
    }
}
