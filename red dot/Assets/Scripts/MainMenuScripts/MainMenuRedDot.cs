using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuRedDot : MonoBehaviour {

    public AudioSource start;

    //when the object is clicked the playing area will be loaded and a noise will play
    private void OnMouseDown()
    {
        start.Play();
        SceneManager.LoadScene(1);
    }
}
