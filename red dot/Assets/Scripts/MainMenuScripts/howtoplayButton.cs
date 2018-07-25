using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class howtoplayButton : MonoBehaviour {

    public AudioSource menuSwitch;

    private void OnMouseDown()
    {
        menuSwitch.Play();
        SceneManager.LoadScene(2);
    }
}
