using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    public AudioClip explosion;
    public AudioSource speaker;

    public GameObject impactEffectPrefab;
    public float speed = .25f;
    private Transform enemyloc;
    // Start is called before the first frame update
    private void Start()
    { 
        enemyloc = GetComponent<Transform>();
    }
    void Movement()
    {
        transform.Translate(new Vector3(speed, 0, 0));

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Ouch!");

        GameObject effectInstance = Instantiate(impactEffectPrefab);

        Destroy(effectInstance,2f);

        Destroy(collision.gameObject);

        health--;
        if(health <= 0)
        {
            Destroy(gameObject);
            speaker.PlayOneShot(explosion);
            ScoreManager.playerScore += 10;
        }

    }
}
