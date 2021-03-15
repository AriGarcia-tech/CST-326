using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;
    public AudioClip laser;
    public AudioClip explosion;
    public AudioSource speaker;
    public float maxBound, minBound;
    public float speed;
    private Transform player;

  public Transform shottingOffset;
    // Update is called once per frame

    private void Start()
    {
        player = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }
        if (player.position.x < minBound && speed < 0)
            speed = 0;
        else if (player.position.x > maxBound && speed > 0)
            speed = 0;

       if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            speaker.PlayOneShot(laser);
        //Debug.Log("Bang!");

        Destroy(shot, 3f);

      }
    }
}
