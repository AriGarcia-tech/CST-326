using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class EthanCharacter : MonoBehaviour
{
  private Animator animator;
  public Rigidbody rb;
  public float modifier = 1;
  public float jumpForce = 1;
  [Range(-2, 2)] public float speed = 0;
  private bool jump = false;

  void Awake()
  {
    animator = GetComponent<Animator>();
  }

  void Update()
  {
    float horizontal = Input.GetAxis("Horizontal");
        jump = (Input.GetKeyDown(KeyCode.Space)) ? true : false;

        //horizontal = speed;

    float y = (horizontal < 0) ? -90 : 90;
      
    Quaternion newRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, y, transform.rotation.eulerAngles.z);

    transform.rotation = newRotation;


    animator.SetFloat("Speed", Mathf.Abs(horizontal));

        //Debug.Log(transform.forward * horizontal);
    transform.Translate(new Vector3(0, 0, 1) * Mathf.Abs(horizontal) * modifier * Time.deltaTime);
    }


    void FixedUpdate()
    {
        if (jump) rb.AddForce(transform.up * jumpForce, ForceMode.VelocityChange);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Flag" || collision.gameObject.name == "Lava")
        {
            Debug.Log($"Game Over");
            rb.MovePosition(Vector3.zero);
        }
    }

}
