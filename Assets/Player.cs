using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1.0f;  // publicにすることによってUnityに適応後、スクリプト上に変数が表示され調節可能になる
    // private: このクラス上でしか扱えなくなる

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -4)   // 壁より内側なら動くプログラム
                this.transform.position += Vector3.left * speed * Time.deltaTime;   // thisとはこの場合Playerオブジェクトのこと
        }    // 上記に関しては 一行のプログラムを実行するときは{}を省いても大丈夫

        if(Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 4)
                this.transform.position += Vector3.right * speed * Time.deltaTime;   // ものを動かすときは必ず Time.deltaTimeをつける
        }
    }
}
