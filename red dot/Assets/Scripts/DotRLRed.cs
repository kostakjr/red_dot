using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotRLRed : MonoBehaviour {

    //set destination of the dot motion to the right side of the screen
    Vector2 destination = new Vector2(7, 0);

    /*
     * determines what the horizontal reddot will do based on what the current score is
     */
    void Update()
    {
        //91-130, red dot will move at speed 4
        if (ScoringSystem.score > 90 && ScoringSystem.score <= 130)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 4 * Time.deltaTime);
        }
        //131+ red dot will move at speed 5
        else if (ScoringSystem.score > 130 && ScoringSystem.score <= 15)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 5 * Time.deltaTime);
        }
    }
}
