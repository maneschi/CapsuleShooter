using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(TimerCo());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator TimerCo()
    {
        while (true)
        {
            print(Time.time);
            yield return new WaitForSeconds(1);
        }
    }
}
