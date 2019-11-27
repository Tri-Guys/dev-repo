using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private ScriptableObject health;//activate tmpro
    private int score = 0; //initialise player score
    private string scoreString; //for storing actual score in string
    private int scoreStringLength; //for reading length of actual score
    private string scoreArcadeDisplay; // specifically for displaying arcadey 0s
    private int pointForLiving = 1; //the point given for each tick the player is alive
    private int pointForKilling = 500; //the points given for killing an enemy
    private string currentScore; //final string output for gui
    private int finalScore; //final score player has when dead
    public string finalScoreStr; //string conversion for score readout
    

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
     //   health = GetComponent<HealthUpdater>();//grab tmpro component
                                                   //score = 0; //initialise score as 0
    }

    void Update()
    {
        // deltaTime
        score = score + pointForLiving; //for every delta tick, increase the point counter
       // scoreStringLength = scoreString.Length; //retrieve length of actual score

      //  currentScore = score.ToString();

        /* for (int i = 0; i < scoreStringLength; i++)  //as long as i is below the scorestringlength
        {
                 scoreArcadeDisplay += "0"; //scoreStringLength
        } */

        textMesh.text = score.ToString(); //basic score display

       // textMesh.text = currentScore; //finally, set the score
    }

    void Final()
    {
        finalScoreStr = finalScore.ToString();
    }
}