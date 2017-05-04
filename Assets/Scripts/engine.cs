using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engine : MonoBehaviour
{
    public float speed = 10;                  // Variable for the speed of movement and turing
    Rigidbody myRigi;
    public PhysicMaterial carMat;
    // Use this for initialization
    void Start()
    {
        myRigi = GetComponent<Rigidbody>();
    }


    // Update runs every frame
    void Update()
    {
        if (Input.GetKey("escape"))    Application.Quit();                        // end game if escape key pressed

        carMat.dynamicFriction = 1 - (Mathf.Abs(Input.GetAxis("Vertical")));
     //   if (Physics.Raycast(transform.position, -transform.up, 1))                 // if the car is upright
        {
            //  print(Input.GetAxis("Horizontal"));
            myRigi.AddRelativeTorque(Input.GetAxis("Horizontal")*Vector3.up * 50 * speed * Time.deltaTime);
            myRigi.AddRelativeForce(Input.GetAxis("Vertical") * Vector3.forward * 3 * speed * Time.deltaTime);

            //     if (Input.GetKey(KeyCode.W))                                                // if W is pressed, move forward
            //  {
            //       myRigi.AddRelativeForce(Vector3.forward * 3 * speed * Time.deltaTime);
            //    }

            //    if (Input.GetKey(KeyCode.S))                                                   // if S is pressed, move back
            //    {
            //        myRigi.AddRelativeForce(Vector3.back * 3 * speed * Time.deltaTime);
            //    }

            //   if (Input.GetKey(KeyCode.D))                                                   // if D is pressed, turn right
            //   {
            //       myRigi.AddRelativeTorque(Vector3.up * 50 * speed * Time.deltaTime);
            //  }

            //  if (Input.GetKey(KeyCode.A))                                                   // if A is pressed, turn left
            //  {
            //       myRigi.AddRelativeTorque(Vector3.down * 50 * speed * Time.deltaTime);
            //  }
        }
    }
}
