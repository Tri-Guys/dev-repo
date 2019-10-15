using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAIControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public GameObject Enemy;
    public GameObject agroZone;
    bool inZone = false;
    public float MoveSpeed = 7f;
    float MaxDist = 10f;
    float MinDist = 3.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inZone == true)
        {
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    //Here Call any function U want Like Shoot at here or something
                }
            }



        }
        if (inZone == false)
        {

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == agroZone)
        {
            inZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == agroZone)
        {
            inZone = false;
        }
    }
}
