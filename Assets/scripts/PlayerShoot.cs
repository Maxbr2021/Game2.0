using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] float shootSpeed, shootTimeout;
    [SerializeField] Transform shootPos;
    [SerializeField] GameObject bullet;

    private bool shooting;
    // Start is called before the first frame update
    void Start()
    {
        shooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && !shooting)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        shooting = true;
        Debug.Log("shoot");
        yield return new WaitForSeconds(shootTimeout);
        shooting = false;
    }

}
