using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool paused = false;

    //#region Monobehaviour API
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            paused = !paused;
            if (paused)
            {
                Time.timeScale = 1;
            }

            else
                Time.timeScale = 0;
        }
    }
}

