using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 300;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Countdown()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
    }
}
