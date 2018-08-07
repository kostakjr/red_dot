using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMotionBlk : MonoBehaviour {

    //set destination of the dot motion to the bottom of the screen
    Vector2 bottom = new Vector2(0, -10);

    //casues the black dot to fall at the appropriate times (based on score)
    void Update()
    {
        //56-85, 121-130, 200+ move black dot at speed 2
        if ((ScoringSystem.score > 55 && ScoringSystem.score <= 85) ||
            (ScoringSystem.score > 120 && ScoringSystem.score <= 130) ||
            (ScoringSystem.score > 200))
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              bottom, 2 * Time.deltaTime);
        }
        //if it's out of the designated ranges and on the screen then move black dot off the screen
        else if ((ScoringSystem.score > 85 && transform.position.y < 9) ||
                    (ScoringSystem.score > 130 && transform.position.y < 9))
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              bottom, 2 * Time.deltaTime);
        }
    }
}
