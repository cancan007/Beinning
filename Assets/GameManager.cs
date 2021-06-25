using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;  //[]は配列、Block[]はBlock型のものをblocksに複数格納することができる
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyAllBlocks())
        {
            Debug.Log("ゲームクリア");    //Debug.Log: コンソールに表示される、主にバグ探しに使われる
        }
    }

    private bool DestroyAllBlocks()   //関数を定義   blockがすべて消えたらtrueを返す
    {
        foreach(Block b in blocks)  // foreachでそれぞれに対して処理を行う。
        {
            if (b != null)
            {
                return false;  // 一つでもblockがあればfalseを返す
            }
        }
        return true; // すべてblockが消えていればtrueを返す
    }

    public void GameOver()   //Ball.csでこの関数にアクセスするため、publicにしておく
    {
        Debug.Log("ゲームオーバー");
    }
}
