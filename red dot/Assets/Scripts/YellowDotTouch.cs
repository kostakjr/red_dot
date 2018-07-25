using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowDotTouch : MonoBehaviour {

    public AudioSource yellowTap;

    /*
     * when the mouse button is clicked on a yellowdot it will move it back to the top,
     * play a noise, and subtract the score by two.
     */
    private void OnMouseDown()
    {
        //play noise
        yellowTap.Play();

        if (this.tag == "yellowdot")
        {
            //moves dot back to the top
            this.transform.position = new Vector2(0, 9);
        }
        else
        {
            //moves dot back to the side
            this.transform.position = new Vector2(-9, 0);
        }
        //uses scoring system to idecrement the score by two
        ScoringSystem.score -= 2;
    }
}
