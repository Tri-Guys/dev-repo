﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestart : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneToChangeTo = "AI Test";
    private Animation anim;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {




            SceneManager.LoadScene(sceneToChangeTo);
        }
    }
}
