using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
 
    // Reference To Components In The GameObjects
    public Rigidbody2D rb;
    // Declaration Of Variables
    public float JumpForce = 5;
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true){
            rb.velocity = Vector2.up * JumpForce;
        }

    }
}
