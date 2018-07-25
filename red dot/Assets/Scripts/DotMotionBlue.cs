using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMotionBlue : MonoBehaviour {

    //set destination of the dot motion to the bottom of the screen
    Vector2 destination = new Vector2(0, -10);

    /*
     * determines what the bluedot will do based on the current score
     * 
     * bluedot will always move at speed 4
     */
    void Update()
    {
        //when the score is 21-30, 41-50, 66-85, 101-130, or 171+ move blue dot at speed 4
        if ((ScoringSystem.score > 20 && ScoringSystem.score <= 30) ||
                (ScoringSystem.score > 40 && ScoringSystem.score <= 50) ||
                (ScoringSystem.score > 65 && ScoringSystem.score <= 85) ||
                (ScoringSystem.score > 100 && ScoringSystem.score <= 130) ||
                (ScoringSystem.score > 170))
        {
            //moves object toward the destination
            //speed is determined by the last param. the higher the number the faster the motion
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 4 * Time.deltaTime);
        }
        //if it's out of the designated ranges and on the screen then move blue dot off the screen
        else if ((ScoringSystem.score > 30 && transform.position.y < 6) ||
                    (ScoringSystem.score > 50 && transform.position.y < 6) ||
                    (ScoringSystem.score > 85 && transform.position.y < 6) ||
                    (ScoringSystem.score > 130 && transform.position.y < 6))
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 4 * Time.deltaTime);
        }
    }
}
