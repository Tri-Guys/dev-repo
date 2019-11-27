using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealthUpdaterShadow : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private int health;
    private int healthDecimal;
    private string healthWholeStr;
    private string healthDecimalStr;
    private string healthParse;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        health = 100;
        healthDecimal = 0;
    }
    void Update()
    {
        healthDecimal--;
        if (healthDecimal <= 0)
        {
            health--;
            healthDecimal = 9;
        }
        if (health > 100)
        {
            health = 100;
            healthDecimal = 0;
        }
        if (health <= 0)
        {
            textMesh.color = new Color32(0, 0, 0, 0);
        }
        healthWholeStr = health.ToString();
        healthDecimalStr = healthDecimal.ToString();
        healthParse = healthWholeStr + "." + healthDecimalStr;
        textMesh.text = healthParse;
    }
    /* public void TakeDamage(int amount)
    {
        damaged = true;
        health -= amount;
        playerAudio.Play();
        if (health <= 0 && !isDead)
        {
            Death();
        }
    } */
}