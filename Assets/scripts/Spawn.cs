using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
 
    [SerializeField] float xmin_offset,xmax_offset,ymin_offset,ymax_offset;
    //[SerializeField] int spawnPerWave;


    // Start is called before the first frame update
    public void spawn(float x)
    {
        float x_spawn = Random.Range(x+xmin_offset,x+xmax_offset);
        float y_spawn = Random.Range(ymin_offset,ymax_offset);
        Vector3 spwan_pos = new Vector3(x_spawn,y_spawn,0f);
        GameObject enemy = Instantiate(enemyPrefab,spwan_pos,Quaternion.identity);
    }
    

   
}
