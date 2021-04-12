using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float health = 100;
    public Transform healthBar;
    public float healthPerUnit;
    // Start is called before the first frame update
    void Start()
    {
        healthPerUnit = 100f / health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        health--;
        if(health<= 0)
        {
            Debug.Log($"{transform.name} is Dead");
            Destroy(this.gameObject);
        }
    }

}
