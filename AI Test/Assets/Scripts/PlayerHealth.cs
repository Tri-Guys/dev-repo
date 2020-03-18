using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System;

public class PlayerHealth : MonoBehaviour
{
    // public GameObject Player;
    private TextMeshProUGUI healthDispText;
    private TextMeshProUGUI healthDispShad;
    public float startingHealth = 100f;                            // The amount of health the player starts the game with.
    public float currentHealth;
    public string healthDisplay;// The current health the player has.

    public int health; //
    private int healthDecimal; //
    private string healthWholeStr; //
    private string healthDecimalStr; //
    private string healthParse; //
    public AudioClip deathClip;                                 // The audio clip to play when the player dies.
    public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    private const float healthBleed = 0.25f;
    private const float healthBleeding = 0.5f;

    AudioSource playerAudio;                                    // Reference to the AudioSource component.
    KartController playerMovement;                              // Reference to the player's movement.
    bool isDead;                                                // Whether the player is dead.
    bool damaged;                                               // True when the player gets damaged.


    void Awake()
    {
        playerAudio = GetComponent<AudioSource>();
        health = 100;
        healthDecimal = 0;
        healthDispText = GetComponent<TextMeshProUGUI>();
        playerMovement = GetComponent<KartController>();
        // Set the initial health of the player.
        currentHealth = startingHealth;
    }
    void Update()
    {
        Debug.Log(currentHealth);
        if (currentHealth > 0)
        {
            healthDisplay = currentHealth.ToString();
        }
        //HUDhealth.text = "" + health;
        // If the player has just been damaged...
        if (damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            // damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            // damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        void addHealth(int amount)
        {
            health = health + 25;
        }
        healthDecimal--;
        if (healthDecimal <= 0)
        {
            health--;
            healthDecimal = 9;
            // Reset the damaged flag.
            damaged = false;
        }

        void TakeDamage(int amount)
        {
            // Set the damaged flag so the screen will flash.
            damaged = true;

            // Reduce the current health by the damage amount.
            currentHealth -= amount;

            // Set the health bar's value to the current health.
            //healthSlider.value = currentHealth;

            // Play the hurt sound effect.
            playerAudio.Play();

            // If the player has lost all it's health and the death flag hasn't been set yet...
            if (currentHealth <= 0 && !isDead)
            {
                // ... it should die.
                Death();
            }
        }

        void Death()
        {
            // Set the death flag so this function won't be called again.
            isDead = true;

            // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
            //  playerAudio.clip = deathClip;
            playerAudio.Play();

            // Turn off the movement and shooting scripts.
            playerMovement.enabled = false;
            //playerShooting.enabled = false;

            // Destroy(Player); //Remove Player from map
        }
    }
}
