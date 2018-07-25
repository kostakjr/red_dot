using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SavingScore : MonoBehaviour
{

    public string filename = "highscore.txt";
    public int scoreAmount;

    public int highScore;

    //at the beginning of the game this function will compare 
    //scores to see if a new highscore must be displayed
    private void Start()
    {
        //get the compareScore from the loadingScore script
        highScore = LoadingScore.compareScore;

        //get the current score and compare
        scoreAmount = ScoringSystem.score;
        if (scoreAmount >= highScore)
        {
            //PlayerPrefs.SetInt("HighScore", scoreAmount);
            
            //create a file with the designated file name
            var ourFile = File.CreateText(filename);
            //write high score to file and close
            ourFile.WriteLine("" + scoreAmount);
            ourFile.Close();
            
            
        }

        //after losing the game there will be a file named "highscore.data" with the highscore in it.
        //this is because the two objects responsible for game over (black dot and bottom of the pipe)
        //were given a highscore game object field
    }

}
