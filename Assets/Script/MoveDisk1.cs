using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDisk1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(30, Random.Range(120, 210), 0);//回転角の情報　Rangeで120-210としている⇒左下～右下
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward *500);//具体的な動作。Rigitbodyに具体的な関数（AddForce）がある。
    }

    // Update is called once per frame
    void Update()
    {
        //ここに当たり判定（ゴール判定とその後）を書くかも？
    }
}
