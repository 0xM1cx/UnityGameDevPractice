using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    float horizontalMovement = 0f;
    public float runSpeed;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jump);
    }
}
