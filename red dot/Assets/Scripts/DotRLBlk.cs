using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotRLBlk : MonoBehaviour {

    //set destination of the dot motion to the right side of the screen
    Vector2 destination = new Vector2(7, 0);

    /*
     * determines what the horizontal blackdot will do based on what the current score is
     */
    void Update()
    {
        //161+ blackdot will move at speed 4
        if (ScoringSystem.score > 160)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
              destination, 2 * Time.deltaTime);
        }

    }
}
