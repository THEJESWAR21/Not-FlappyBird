using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float PipeSpeed = 9;
    public float deadZone = -15;
    public PlayerMovement Bird;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        transform.position = transform.position + (Vector3.left * PipeSpeed * Time.deltaTime);

         if(transform.position.x < deadZone){
            Destroy(gameObject);
        }


    }
}
