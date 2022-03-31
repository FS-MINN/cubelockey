using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject BlockPrefab;
    float span = 0;
    float delta = 0;
    
    void Start()
    {
        for ( int i = 0 ; i < 21 ; i++ ){
        this.delta += Time.deltaTime;
            if (this.delta > this.span){
                this.delta = 0;
                GameObject go = Instantiate(BlockPrefab);
                int px = Random.Range(-6.5, 6.5);
                int pz = Random.Range(18, -18);
                go.transform.position = new Vector3(px, 2.5, pz);
           }
        }
    }
}