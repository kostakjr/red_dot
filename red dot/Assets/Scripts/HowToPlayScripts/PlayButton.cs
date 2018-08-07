using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour {

    public AudioSource play;

    //when object is clicked the playing area will be loaded and a noise will play
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
        play.Play();
    }
}
