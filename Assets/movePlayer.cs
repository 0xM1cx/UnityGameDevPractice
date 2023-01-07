using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private float moveSpeed;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;
    private float jumpForce;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        // Initializing the variables to be used..
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 3f;
        jumpForce = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal"); // if user clicks d or a it will return 1 or -1  respectively
        moveVertical = Input.GetAxisRaw("Vertical"); // if user clicks w or s it will return 1 or -1 respectively
    }

    private void FixedUpdate() // This is used to update at a fixed time, recommended if using physics to manipulate objects
    {
        if(moveHorizontal != 0) // kun an user nag click ha a or d keys then it will satisfy this condition
        {
            // This moves the object left or right depending on the key that user clicked.
            rigidBody.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }

        if(!isJumping && moveVertical > 0)
        {
            // Adds a vertical, y axis, force to the player
            rigidBody.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse); 
        }
    }

    // The two functions below are used to prevent the player from jumping even when in the air.
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Ground")
        {
            isJumping = false; // set the isJumping to false because the has or currently collided with the ground
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isJumping = true; // set to true because the player is currently not collided to the ground and therefore is in the air.
        }    
    }
}
