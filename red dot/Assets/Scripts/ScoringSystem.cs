using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour {

    public static int score;
    public GameObject scoreDisplay;

    void Update()
    {
        //displays score
        scoreDisplay.GetComponent<UnityEngine.UI.Text>().text = "" + score;
    }
}
