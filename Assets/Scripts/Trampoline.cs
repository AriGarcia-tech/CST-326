using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
  
  public float impulseStrength = 1f;

  void OnCollisionEnter(Collision collision)
  {
    Debug.Log($"{this.name} collided with the {collision.gameObject.name}");
    //float mag = collision.relativeVelocity.magnitude;
    Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
    rb.AddForce((transform.up * impulseStrength), ForceMode.Impulse);
  }


    void FixedUpdate()
    {
        impulseStrength = Input.GetAxisRaw(axisName);
        GetComponent<Rigidbody>().velocity
    }
}
