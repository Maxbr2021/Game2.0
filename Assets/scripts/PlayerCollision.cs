using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   
   void OnCollisionEnter2D(Collision2D other)
   {
       if (other.transform.tag == "Enemy"){
           Debug.Log("Game over");
           
       }
   }
}
