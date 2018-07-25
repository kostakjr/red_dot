using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMotionR : MonoBehaviour {

    //set destination of the dot motion to the bottom of the screen
    Vector2 destination = new Vector2(0, -10);

    /*
     * determines the speed of the reddot based on the current score
     */
    void Update()
    {
        //under 3 the red dot will move at speed 2
        if (ScoringSystem.score <= 3)
        {
            //moves object toward the destination
            //speed is determined by the last param. the higher the number the faster the motion
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 2 * Time.deltaTime);
        }
        //4-8, red dot will move at speed 3
        else if (ScoringSystem.score > 3 && ScoringSystem.score <=8)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 3 * Time.deltaTime);
        }
        //9-15, red dot will move at speed 4
        else if (ScoringSystem.score > 8 && ScoringSystem.score <= 15)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 4 * Time.deltaTime);
        }
        //16-50 or 86+ red dot will move at speed 5
        else if ((ScoringSystem.score > 15 && ScoringSystem.score <= 50) ||
                    ScoringSystem.score > 85)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 5 * Time.deltaTime);
        }
        //51-85 red dot will move at speed 6
        else if (ScoringSystem.score > 50 && ScoringSystem.score <= 85)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 6 * Time.deltaTime);
        }
    }
}
