using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
 
    // Reference To Components In The GameObjects
    public Rigidbody2D rb;
    public float JumpForce = 5;
    public LogicScripts logic;
    public bool BirdisAlive = true;
   // Start is called before the first frame update
   void Start(){
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
   }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && BirdisAlive){
            rb.velocity = Vector2.up * JumpForce;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        BirdisAlive = false;
    }
}
