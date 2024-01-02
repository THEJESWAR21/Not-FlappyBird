using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMIddleScript : MonoBehaviour
{
    public LogicScripts logic;

    void Start(){
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
}   
    
   private void OnTriggerEnter2D(Collider2D collision){
        logic.addScore(1);
   }
}
