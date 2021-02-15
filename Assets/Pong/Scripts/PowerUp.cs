using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] Ball ball;
    public void RandSpawn()
    {
        gameObject.transform.position = new Vector3(0, 0.5f, Random.Range(-7.0f, 7.0f));
    }
    
    //-----------------------------------------------------------------------------
    private void OnTriggerEnter(Collider other)
    {
        //do something interesting to the ball, paddle, or some other game element
        ball.Pow();
    }
    
}
