using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDotTouch : MonoBehaviour {

    public AudioSource blueTap;

    /*
     * when the mouse button is clicked on a bluedot it will move it back to the top,
     * play a noise, and subtract the score by one.
     */
    private void OnMouseDown()
    {
        //play noise 
        blueTap.Play();

        //make sure the correct dot is being moved to the appropriate position
        if (this.tag == "bluedot")
        {
            //moves dot back to the top
            this.transform.position = new Vector2(0, 7);
        }
        else
        {
            //move dot back to the side
            this.transform.position = new Vector2(-7, 0);
        }

        //uses scoring system to idecrement the score by one
        ScoringSystem.score -= 1;
    }
}
