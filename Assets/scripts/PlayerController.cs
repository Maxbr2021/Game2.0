using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed = 4;
    [SerializeField] float scroll_speed;
    [SerializeField] GameObject cam;
    Vector3 player_pos;
    Vector3 move;
    float max_y = 4.1371f;
    float min_y = -4.1371f;
    CapsuleCollider2D body_colider;
    public float rot;

    Gun gun;


    // Start is called before the first frame update
    void Start()
    {
        gun = transform.GetComponentInChildren<Gun>();
        player_pos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move_player();
        aim();

    }

    void aim()
    {
       

        if (Input.GetKey(KeyCode.E))
        {
            transform.eulerAngles = new Vector3(0, 0, 33);
            rot = 33;

        }
        else if (Input.GetKey(KeyCode.X))
        {
            transform.eulerAngles = new Vector3(0, 0, -33);
            rot = -33;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            rot = 0;
        }
        

        
    }


    void move_player()
    {
        player_pos.x += scroll_speed * Time.deltaTime;
        transform.position = player_pos;
        var move_dir = Input.GetAxis("Vertical");
        if (move_dir > 0f)
        {
            player_pos = transform.position;
            player_pos.y += move_dir * speed * Time.deltaTime;

            if (player_pos.y >= max_y)
            {
                player_pos.y = max_y;
            }
            transform.position = player_pos;
        }

        move_dir = Input.GetAxis("Vertical");
        if (move_dir < 0f)
        {
            player_pos = transform.position;
            player_pos.y += move_dir * speed * Time.deltaTime;

            if (player_pos.y <= min_y)
            {
                player_pos.y = min_y;
            }
            transform.position = player_pos;
        }
    }
}
