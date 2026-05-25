using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rightpaddle: MonoBehaviour
{
    public BallScript Ball;
    public float moveSpeed2 ;

 
    public Rigidbody2D rb;
    public LOGICSCRIPT logicScript;
   
   
    void Start()
    {
       
    }   

    // Update is called once per frame
    void Update()
    {
            
            if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = Vector2.up * moveSpeed2;   
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = Vector2.down * moveSpeed2;   
        }
        if (Touchscreen.current != null &&
        Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            if (touchPosition.y > Screen.height / 2)
            {
                rb.linearVelocity = Vector2.up * moveSpeed2;
            }
            else if (touchPosition.y < Screen.height / 2)
            {
                rb.linearVelocity = Vector2.down * moveSpeed2;
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
