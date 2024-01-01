using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    private float timer = 0;
    public float spawnrate = 2;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnrate){
            timer = timer + Time.deltaTime;
        } else {
            spawnPipe();
             timer = 0;
        }
    }

    void spawnPipe()  {

         Instantiate(Pipe,transform.position,transform.rotation);
    }
}
