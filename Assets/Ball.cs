using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody myRigid;   // Unity上で設定した物理エンジンであるRigidbodyをmyRigidという変数に入れる予定のため、宣言しておく
    
    // Start is called before the first frame update
    void Start()  //初めの処理
    {
        myRigid = this.GetComponent<Rigidbody>();  //上で宣言しておいた変数に、実際に代入する(Component)はオブジェクトの内容
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        // AddForce: 力を加える, 第一引数でベクトルと力を指定(この場合右斜めに打ち出す), 　ForceMode.Velocityで一回力を加える
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)    // 衝突時に処理(引数のcollision部分で何に衝突したときか指定できる（今回はすべてなので不要）)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
    }
}
