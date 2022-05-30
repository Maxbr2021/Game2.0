using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed = 4;

    bool shooting = false;
    Vector3 player_pos;
    CapsuleCollider2D body_colider;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var move_dir = Input.GetAxis("Vertical");
        player_pos = new Vector3(0,move_dir,0);
        transform.position += player_pos * Time.deltaTime * speed;
    }
}
