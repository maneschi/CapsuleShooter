using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 2f);               // destroy the bullet after 2 seconds
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward);    // move bullets forward each frame
	}
}
