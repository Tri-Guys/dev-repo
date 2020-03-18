using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealthUpdater : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public int health;
    private int healthDecimal; 
    private string healthWholeStr;
    private string healthDecimalStr;
    private string healthParse;
    AudioSource playerAudio;
    Animator anim;
    KartController playerMovement;
    bool isDead;                                                // Whether the player is dead.
    bool damaged;
    public AudioClip deathClip;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        playerAudio = GetComponent<AudioSource>();
        health = 100;
        healthDecimal = 0;
        Debug.Log(health);
    }
    void Update()
    {
       /* healthDecimal--;
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
        if (health <= 50)
        {
            textMesh.color = new Color32(225, 154, 0, 255);
        }
        if (health <= 25)
        {
            textMesh.color = new Color32(255, 13, 34, 255);
        }
        if (health <= 0)
        {
            textMesh.color = new Color32(0, 0, 0, 0);
        } */
       healthWholeStr = health.ToString();
        healthDecimalStr = healthDecimal.ToString();
        healthParse = healthWholeStr + "." + healthDecimalStr;
       // textMesh.text = healthParse;
    }
    public void TakeDamage(int amount)
    {
        damaged = true;
        health -= amount;
        playerAudio.Play();
        /* if (health <= 0 && !isDead)
        {
            Death();
        } */
    }
void Death()
    {
        isDead = true;
        playerAudio.Play();
        playerMovement.enabled = false;
    }
}