using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) && transform.position.x > -40){
	        transform.position = new Vector3(
            transform.position.x - 0.1f,
            transform.position.y,
            transform.position.z
            );
        }
        if(Input.GetKey(KeyCode.D) && transform.position.x < -20){
        	transform.position = new Vector3(
            transform.position.x + 0.1f,
            transform.position.y,
            transform.position.z
            );
        }
        if(Input.GetKey(KeyCode.W) && transform.position.z < 20){
        	transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z + 0.1f
            );
        }
        if(Input.GetKey(KeyCode.S) && transform.position.z > -20){
        	transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - 0.1f
            );
        }
    }
}
