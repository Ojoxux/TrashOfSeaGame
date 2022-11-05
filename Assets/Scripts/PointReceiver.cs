using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointReceiver : MonoBehaviour
{
    //  ポイントの集計と表示用クラス
    GetPointCounter pCounter;

    // Start is called before the first frame update
    void Start()
    {
        //  オブジェクトの取得
        GameObject obj = GameObject.FindWithTag("PointCounter");

        //  得点クラスコンポーネントの取得
        pCounter = obj.GetComponent<GetPointCounter>();
    }

    /// <summary>
    /// ポイントを集計用クラスに送信する
    /// </summary>
    /// <param name="param"></param>
    public void PointReceive(int param)
    {
        //  取得したポイントの送付
        pCounter.AddPoint(param);
    }

}
