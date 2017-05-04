using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed = 5;

    public NavMeshAgent agent;
    private Rigidbody r;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
      //  r.AddForce(Vector3.up);
     agent.SetDestination(target.position);
       agent.speed = speed;

    }
}
