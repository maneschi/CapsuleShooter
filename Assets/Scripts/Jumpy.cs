using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpy : Enemy {
    private  Rigidbody r;
	// Use this for initialization
	void Start () {
        r = GetComponent<Rigidbody>();
	}
	
 void FixedUpdate () {
        r.position +=Vector3.up;
     //   print(r.position);
        
	}
}
