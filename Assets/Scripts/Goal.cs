using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
  {
    Debug.Log($"{this.name} scored one point!");
  }

}
