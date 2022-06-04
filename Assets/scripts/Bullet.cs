using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    public Vector2 direction;
    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
        //direction = new Vector2(1, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        velocity = direction * speed;
    }



    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos += velocity * Time.fixedDeltaTime;
        transform.position = pos;
    }
}
