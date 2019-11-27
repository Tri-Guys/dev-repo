using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIFlash : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        //StartBlinking();
    }

    IEnumerator Blink()
    {
        while (true)
        {
            switch (text.color.a.ToString())
            {
               /*  case "0":
                    text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
                    //play sound
                    yield return new WaitForSecond(0.5f);
                    break;

                case "1":
                    text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
                    //play sound
                    yield return new WaitForSecond(0.5f);
                    break; */
            }
        }
    }

   /*  void StartBlinking()
    {
        StopCoroutline("Blink");
        StartCoroutline("Blink");
    }

    void StopBlinking()
    {
        StopCoroutline("Blink");
    } */
}

