using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdaterShadow : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private int score = 0000000;
    private int pointForLiving = 0000001;
    private int pointForKilling = 0000500;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        score = 0000000;

    }

    void Update()
    {
        // deltaTime

        score = score + pointForLiving;
        textMesh.text = score.ToString();
    }
}