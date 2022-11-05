using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPointCounter : MonoBehaviour
{
    //  変数定義
    int point;  //  取得したポイント
    Text tex;   //  表示用テキスト

    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>(); //  コンポーネントの取得
    }


    /// <summary>
    /// ポイント加算用の処理
    /// </summary>
    /// <param name="param">加算する点数</param>
    public void AddPoint(int param)
    {
        //  ポイントの加算
        point += param;

        //  表示テキストの更新
        tex.text = "Points:" + point;
    }
}
