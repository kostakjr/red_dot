using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour {

    //when obj is clicked the application will close
    private void OnMouseDown()
    {
        Application.Quit();
    }
}
