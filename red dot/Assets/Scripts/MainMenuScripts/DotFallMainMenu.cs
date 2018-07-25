using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotFallMainMenu : MonoBehaviour {

    /*
     * When a dot hits the bottom of the main menue it will be randomly placed above and off the screen
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //designate the range
        int xLow = 0;
        int xyHigh = 710;
        int yLow = 600;

        //makes sure the object being moved isnt the bottom rectangle
        if (collision.gameObject.tag == "bluedot" || collision.gameObject.tag == "yellowdot" ||
                collision.gameObject.tag == "blackdot")
        {
            //puts the colliding dot into a random position at the top
            //x range is 0-710, y range is 600-710
            collision.gameObject.transform.position = new Vector2(Random.Range(xLow, xyHigh), Random.Range(yLow, xyHigh));
        }
    }


}
