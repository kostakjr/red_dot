using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class howtoplayButton : MonoBehaviour {

    public AudioSource menuSwitch;

    //when object is clicked the how to play menu will be loaded and a noise will play
    private void OnMouseDown()
    {
        menuSwitch.Play();
        SceneManager.LoadScene(2);
    }
}
