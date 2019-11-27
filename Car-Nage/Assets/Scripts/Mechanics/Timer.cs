using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI textMesh; //activate tmpro
    private float StartTime;
   // public Text timerText;

   // public TextMeshProGUI TimerText { get => timerText; set => timerText = value; }

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>(); //grab tmpro component
    }

    private void Update()
    {
        float t = Time.time - StartTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2"); //seconds spent alive
        string finalTime; //final time for player

        textMesh.text = minutes + ":" + seconds;

        // timerText.text(minutes + ":" + seconds);
        // timeOnScreen.SetText(minutes + ":" + seconds);

       /* if(minutes == "5")
        {
            textMesh.color = new Color32(121, 255, 70, 255);
        }

        if (minutes == "10")
        {
            textMesh.color = new Color32(184, 255, 0, 255);
        }

        if (minutes == "15")
        {
            textMesh.color = new Color32(255, 252, 0, 255);

        }

        if (minutes == "20")
        {
            textMesh.color = new Color32(225, 216, 0, 255);
        }

        if (minutes == "25")
        {
            textMesh.color = new Color32(255, 160, 0, 255);
        }

        if (minutes == "30")
        {
            textMesh.color = new Color32(225, 80, 0, 255);
        } */

        void Dead()
        {
            finalTime = minutes + ":" + seconds;
        }
    }
}