using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthUpdater : MonoBehaviour
{

    private TextMeshProUGUI textMesh;
    public int health;
    public AudioClip deathClip;
    private int healthDecimal;
    private string healthWholeStr;
    private string healthDecimalStr;
    private string healthParse;
    AudioSource playerAudio;
    Animator anim;
    KartController playerMovement;
    bool isDead;                                                // Whether the player is dead.
    bool damaged;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        playerAudio = GetComponent<AudioSource>();
        health = 100;
        healthDecimal = 0;
    }

    void Update()
    {


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
        }
        healthWholeStr = health.ToString();
        healthDecimalStr = healthDecimal.ToString();
        healthParse = healthWholeStr + "." + healthDecimalStr;

        // textMesh.text = healthParse;


        /* void addHealth(int amount)
        {
            health = health + 25;
        }
        healthDecimal--;
        if (healthDecimal <= 0)
        {
            health--;
            healthDecimal = 9;
        } */
    }


    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;

        // Reduce the current health by the damage amount.
        health -= amount;

        // Set the health bar's value to the current health.
        //healthSlider.value = currentHealth;

        // Play the hurt sound effect.
        playerAudio.Play();

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (health <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }




    void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;

        // Turn off any remaining shooting effects.
        //playerShooting.DisableEffects();

        // Tell the animator that the player is dead.
        //anim.SetTrigger("Die");

        // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
        //  playerAudio.clip = deathClip;
        playerAudio.Play();

        // Turn off the movement and shooting scripts.
        playerMovement.enabled = false;

    }
}
