using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadingScore : MonoBehaviour
{

    public string filename = "highscore.txt";
    public string scoreLoad;
    string line;

    public GameObject highScoreDisplay;
    public static int compareScore;

    //loads the highscore from the filename and displays it
    private void Start()
    {
        
        //reads the high score form the highscore.data file
        StreamReader reader = new StreamReader(filename);
        line = reader.ReadLine();

        while (line != null)
        {
            scoreLoad = line;
            line = reader.ReadLine();
        }
        reader.Close();
        

        //scoreLoad = PlayerPrefs.GetString("HighScore");
        highScoreDisplay.GetComponent<UnityEngine.UI.Text>().text = "" + scoreLoad;

        compareScore = int.Parse(scoreLoad);
    }
}
