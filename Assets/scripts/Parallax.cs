using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float len, start;
    [SerializeField] GameObject cam;
    [SerializeField] float parallax;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position.x;
        len = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallax));
        float dist = (cam.transform.position.x * parallax);
        transform.position = new Vector3(start + dist, transform.position.y, transform.position.z);

        if (temp > start + len)
        {
            start += len*2;
        }
    }
}
