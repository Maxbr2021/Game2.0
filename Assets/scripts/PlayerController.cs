using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed = 4;
    public float scroll_speed;
  
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
       
        // keyboard controll -->  (G = aim; E,X,D = direction)
        if (Input.GetKey(KeyCode.G) ){
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
        //voice controll --> just use voice input when no keyboard signal is given at the same time
        if (!(Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.E))){

            if (Input.GetKey(KeyCode.R))
            {
                transform.eulerAngles = new Vector3(0, 0, 33);
                rot = 33;
                Debug.Log("Voice: Aim up");

            }
            else if (Input.GetKey(KeyCode.C))
            {
                transform.eulerAngles = new Vector3(0, 0, -33);
                rot = -33;
                Debug.Log("Voice: Aim down");
            }
            else if (Input.GetKey(KeyCode.F))
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                rot = 0;
                Debug.Log("Voice: Aim straight");
            }
        }
        

        
    }


    void move_player()
    {
        player_pos.x += scroll_speed * Time.deltaTime;
        transform.position = player_pos;
        if (Input.GetKey(KeyCode.W))
        {
            move_up(1.0f);
        }else if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.UpArrow)){
            move_up(2.0f);
            Debug.Log("Voice: move up");
        }

        if (Input.GetKey(KeyCode.S))
        {
            move_down(-1.0f);
        }else if (!Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.DownArrow)){
            move_down(-2.0f);
            Debug.Log("Voice: move down");
        }
    }
    void move_up(float move_dir){
         player_pos = transform.position;
            player_pos.y += move_dir * speed * Time.deltaTime;

            if (player_pos.y >= max_y)
            {
                player_pos.y = max_y;
            }
            transform.position = player_pos;

    }
    void move_down(float move_dir){
        player_pos = transform.position;
            player_pos.y += move_dir * speed * Time.deltaTime;

            if (player_pos.y <= min_y)
            {
                player_pos.y = min_y;
            }
            transform.position = player_pos;

    }
}
