using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelTank : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player")) {
                var health = GameObject.FindObjectOfType<PlayerHealth>();
                //health.addHealth(20); // Or however much health should be added
                Destroy(this.gameObject);
            }
        }
    }
}

