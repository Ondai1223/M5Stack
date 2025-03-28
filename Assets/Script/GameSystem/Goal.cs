using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private string playerTag = "player";
    private bool isGoal = false;
   private void OnTriggerEnter2D(Collider2D collision){
    if(collision.tag == playerTag){
        isGoal = true;
        Debug.Log("ゴール");
    }
   }
    public bool checkGoal{get => isGoal;}
}
