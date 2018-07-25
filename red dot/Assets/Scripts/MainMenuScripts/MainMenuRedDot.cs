using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuRedDot : MonoBehaviour {

    public AudioSource start;

    private void OnMouseDown()
    {
        start.Play();
        SceneManager.LoadScene(1);
    }
}
