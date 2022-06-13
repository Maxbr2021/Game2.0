using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   [SerializeField] GameObject gameOver;
   void OnCollisionEnter2D(Collision2D other)
   {
       if (other.transform.tag == "Enemy"){
           Debug.Log("Game over");
           gameOver.SetActive(true);
           GetComponent<PlayerController>().scroll_speed = 0.3f;
           StartCoroutine(bye());
           //Application.Quit();

           
       }
   }

   IEnumerator bye(){
       yield return new WaitForSeconds(5);
       Application.Quit();
   }
}
