using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)    // 衝突時に処理(引数のcollision部分で何に衝突したときか指定できる（今回はすべてなので不要）)
    {
        Destroy(this.gameObject);  //このオブジェクトを消す
    }
}
