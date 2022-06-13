using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    [SerializeField] GameObject exp;

    
    void Start()
    {
        Destroy(gameObject, 25);
    }

   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Bullet"){
            
            Debug.Log("Hit by bullet");
            GameObject goExp =  Instantiate(exp,transform.position,Quaternion.identity);
            Destroy(gameObject);
            Destroy(other.gameObject);
            Destroy(goExp,1);
         
        }
    }

}
