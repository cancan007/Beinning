using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;  //[]は配列、Block[]はBlock型のものをblocksに複数格納することができる
    public GameObject gameOverUI;  // 宣言しておく
    
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
        gameOverUI.SetActive(true);   //UIを表示(activeにする)   Unity上で設定するので、インスタンス化しなくてよい
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("BlockGame");    // シーンを再読み込み(引数にはシーン名を指定)
            //また、上記の関数でシーンを指定するにはUnity上でBuild Settingsにシーンを設定しなければならない
            // GameRetry()をUnity上でButtonに設定して、押したときに呼ばれるようにする
    }
}
