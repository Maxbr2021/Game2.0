using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Bullet bullet;
    Vector2 shoot_dir;

    // Start is called before the first frame update
    void Start()
    {
        shoot_dir = (transform.localRotation * Vector2.right).normalized;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void shoot(float rot)
    {
        transform.localRotation = Quaternion.Euler(0, 0, rot);
        GameObject bull = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
        Bullet goBull = bull.GetComponent<Bullet>();
        shoot_dir = (transform.localRotation * Vector2.right).normalized;
        goBull.direction = shoot_dir;
     
    }



   
}
