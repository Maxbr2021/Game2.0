using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScrolling : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + offset, transform.position.y, transform.position.z);
    }
}
