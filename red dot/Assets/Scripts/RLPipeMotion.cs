using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLPipeMotion : MonoBehaviour {

    //set destination of the right pipe
    Vector2 destinationR = new Vector2(7, 0);
    //set destination of the left pipe
    Vector2 destinationL = new Vector2(-7, 0);

    /*
     * once the score reaches 86 the side pipes will be moved into place
     */
    void Update()
    {
        //at 86 the pipes will be moved in, stop motion at 90 so they arent constently "trying" to move
        if (ScoringSystem.score > 85 && ScoringSystem.score <= 90)
        {
            //make sure the correct pipe is moved to the correct position
            if (this.tag == "pipeR")
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
                  destinationR, 1 * Time.deltaTime);
            }
            else if (this.tag == "pipeL")
            {
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
                  destinationL, 1 * Time.deltaTime);
            }
        }
    }
}
