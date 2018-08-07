using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotMotionYllw : MonoBehaviour {

    //set destination of the dot motion to the bottom of the screen
    Vector2 bottom = new Vector2(0, -10);

    //casues the yellow dot to fall at the appropriate times (based on score)
    void Update()
    {
        //when the score is 31-50, 76-85, 111-130 or 181+ move the yellow dot at speed 3
        if ((ScoringSystem.score > 30 && ScoringSystem.score <= 50) ||
            (ScoringSystem.score > 70 && ScoringSystem.score <= 85) ||
            (ScoringSystem.score > 110 && ScoringSystem.score <= 130) ||
                (ScoringSystem.score > 181))
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              bottom, 3 * Time.deltaTime);
        }
        //if its still on the screen but out of the score range, move it off the screen
        else if ((ScoringSystem.score > 50 && transform.position.y < 8) ||
                 (ScoringSystem.score > 85 && transform.position.y < 8) ||
                 (ScoringSystem.score > 130 && transform.position.y < 8))
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
             bottom, 3 * Time.deltaTime);
        }
    }
}
