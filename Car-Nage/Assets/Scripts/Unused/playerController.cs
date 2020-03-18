using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float turnSpeed = 6f;
    public GameObject Player;
   // float v = Input.GetAxis("Vertical") * MotorForce;
   // float h = Input.GetAxis("Horizontal") * SteerForce;

    //rearWheel.motorTorque = v;
    //FRWheel.motorTorque = v;

    //REWheel.steerAngle = h;
    //FRWheel.steerAngle = h;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -turnSpeed, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, turnSpeed, 0);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back);

        if (Input.GetKey(KeyCode.Space))
        {
           // REWheel.brakeTorque = BrakeForce;
           // FWWheel.brakeTorque = BrakeForce;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
           // REWheel.brakeTorque = 0;
           // FWWheel.brakeTorque = 0;
        }

       
    }
}
