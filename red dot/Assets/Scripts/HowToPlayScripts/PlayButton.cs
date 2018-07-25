using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour {

    public AudioSource play;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
        play.Play();
    }
}
