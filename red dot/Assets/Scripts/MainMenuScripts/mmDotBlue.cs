﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmDotBlue : MonoBehaviour {

    //casues the blue dot to fall towards the lower boundary
    void Update()
    {
        //set destination of the dot motion to the bottom of the screen
        Vector2 bottom = new Vector2(transform.position.x, -68);
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
            bottom, 100 * Time.deltaTime);
    }
}
