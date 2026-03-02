using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Leftpaddle : MonoBehaviour
{
    public BallScript Ball;
    public float moveSpeed ;
    public LOGICSCRIPT logicScript;
    

    
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }   

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = Vector2.up * moveSpeed ;   
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = Vector2.down * moveSpeed ;   
        }
        if (Touchscreen.current != null &&
        Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            if (touchPosition.y > Screen.height / 2)
            {
                rb.linearVelocity = Vector2.up * moveSpeed;
            }
            else if (touchPosition.y < Screen.height / 2)
            {
                rb.linearVelocity = Vector2.down * moveSpeed;
            }
        }
            

        
       
       
    }

     public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Ball")
        {
            logicScript.addScore(1);
            rb.linearVelocity = new Vector2(0,0);
            SoundManager.Instance.PlaySound2D("Paddle Collision");
            
            
            
        }
    
    }
     
    

}
