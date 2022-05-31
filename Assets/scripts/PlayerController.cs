using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed = 4;
    Animator animator;
    bool shooting = false;
    Vector3 player_pos;
    Vector3 move;
    float max_y = 4.1371f;
    float min_y = -4.1371f;
    CapsuleCollider2D body_colider;




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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

        if (Input.GetKey("space")){
            animator.SetBool("shoot", true);
        }

        if (!Input.GetKey("space"))
        {
            animator.SetBool("shoot", false);
        }




    }
}
