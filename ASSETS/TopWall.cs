using UnityEngine;

public class TopWall : MonoBehaviour
{
    public BallScript Ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Ball.direction.y = -Ball.direction.y;
            Ball.myRigidbody2D.linearVelocity = Ball.direction * Ball.ballspeed;
        }
    }
      
}
