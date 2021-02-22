using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Timer time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Clock(Timer time)
    {
        time.Countdown();
    }
}
