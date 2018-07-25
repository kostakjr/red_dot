using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartGame : MonoBehaviour {

    public AudioSource restart;

    private void OnMouseDown()
    {
        restart.Play();
        //when the player clicks the scene it will reload the playing area and reset the score
        SceneManager.LoadScene(1);
        ScoringSystem.score = 0;
    }
}
