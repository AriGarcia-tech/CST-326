using UnityEngine;
using UnityEngine.Serialization;

public class Ball : MonoBehaviour {

    [SerializeField] private Paddle paddle;
    [SerializeField] private ScoreKeeper scorekeep;

    public float startSpeed;
    public float step;
    public bool useDebugVisualization;

    private float speed;
    private Rigidbody rb;

    //-----------------------------------------------------------------------------
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        speed = startSpeed;
    }

    //-----------------------------------------------------------------------------
    // Update is called once per frame
    public void Restart()
    {
        speed = startSpeed;
        rb.MovePosition(Vector3.zero);
        /*if (collider == )
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * -speed; // change to send to losing side
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * speed; // change to send to losing side
        }*/
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * speed; // change to send to losing side

    }

    //-----------------------------------------------------------------------------
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PaddleLeft" || collision.gameObject.name == "PaddleRight")
        {
            //play sound
            paddle.MadeContact();
            

            speed += step;
            float heightAboveOrBelow = transform.position.z - collision.transform.position.z;
            float maxHeight = collision.collider.bounds.extents.z;
            float percentOfMax = heightAboveOrBelow / maxHeight;

            if (useDebugVisualization) {
                DebugDraw.DrawSphere(transform.position, 0.5f, Color.green);
                DebugDraw.DrawSphere(collision.transform.position, 0.5f, Color.red);
                Debug.Break();
                Debug.Log($"percent height = {percentOfMax}");
            }

            bool hitLeftPaddle = collision.gameObject.name == "PaddleLeft";
            float newHorizontalSpeed = (hitLeftPaddle) ? speed: -speed;

            Vector3 newVelocity = new Vector3(newHorizontalSpeed, 0f, percentOfMax * 4f).normalized * speed;
            rb.velocity = newVelocity;
        }
        if(collision.gameObject.name == "LeftGoal" || collision.gameObject.name == "RightGoal")
        {
            //play sound for winning round
            paddle.WinHit();
        }
    }
    //-----------------------------------------------------------------------------

    public void Pow()
    {
        speed = -speed;
    }
}
