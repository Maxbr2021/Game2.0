using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] float shootTimeout;
    //[SerializeField] Transform shootPos;
    Gun gun;
    PlayerController controller;
    Animator animator;
    private bool shooting;
    private float facing = 0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        shooting = false;
        gun = transform.GetComponentInChildren<Gun>();
        controller = transform.GetComponentInChildren<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        facing = controller.rot;
        if (Input.GetKey("space") && !shooting)
        {
            StartCoroutine(Shoot());
        }

    }

    IEnumerator Shoot()
    {

        animator.SetBool("shoot", true);
        shooting = true;
        gun.shoot(facing);

        yield return new WaitForSeconds(shootTimeout);
        shooting = false;
        animator.SetBool("shoot", false);
    }


}
