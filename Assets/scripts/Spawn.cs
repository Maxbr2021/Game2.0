using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
 
    [SerializeField] float xmin_offset,xmax_offset,ymin_offset,ymax_offset;
    [SerializeField] float spawnoffset;
    [SerializeField] int spawnPerWave;
    private float temp_offset,temp;

    void start(){
        temp_offset = spawnoffset;
    }

    void FixedUpdate(){
        temp = transform.position.x;
        if (temp > temp_offset){
            // Debug.Log(temp);
            // Debug.Log(temp_offset);
            temp_offset += spawnoffset;
            spawn(temp);
        // }else{
        //     Debug.Log(temp - temp_offset);
        // }
        }
    }
 
    public void spawn(float x)
    {
        for(int i = 0; i < spawnPerWave; i++ ){
        Debug.Log(xmax_offset);
        Debug.Log(xmax_offset + x);
        Debug.Log(x);
        float x_spawn = Random.Range(x+xmin_offset,x+xmax_offset);
        float y_spawn = Random.Range(ymin_offset,ymax_offset);
        Vector3 spwan_pos = new Vector3(x_spawn,y_spawn,0f);
        GameObject enemy = Instantiate(enemyPrefab,spwan_pos,Quaternion.identity);
        }
    }
    

   
}
