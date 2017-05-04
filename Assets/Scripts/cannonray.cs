using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonray : MonoBehaviour
{
    public GameObject projectile;
    public RaycastHit[] hitRef;             // Array of raycast hits
    public LayerMask myLayerMask;
    public Ray myRay;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        //    if (Input.GetKeyDown(KeyCode.Space))   //If space bar is pressed....
        if (Input.GetButtonDown("Fire1"))            //If Left Ctrl is pressed....
        {
            Instantiate(projectile, transform.position, transform.rotation);               //...fire a bullet...
            myRay = new Ray(transform.position, transform.forward);
            RaycastHit[] hits = Physics.RaycastAll(myRay, Mathf.Infinity, myLayerMask);    //...and cast a ray to to get an array of hits.
            foreach (RaycastHit hit in hits)                                               // Loop through the array of hits 
            {
                GameObject g = hit.collider.gameObject;
                HitScript hs = g.GetComponent<HitScript>();
                hs.SetState(true);                                                         // Call function to change the material color of the hit object
                Destroy(g,.5f);                                                            // Destroy the object in half a second 
            }
        }
    }
}
