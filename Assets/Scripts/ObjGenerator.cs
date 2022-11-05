using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjGenerator : MonoBehaviour
{
    //  生成するオブジェクト
    [SerializeField] GameObject prefab;

    //  一定間隔で実行する処理のカウンタ
    float intervalCount = 0;
    [SerializeField]float INTERVAL_TIME = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //  カウンタの加算
        intervalCount += Time.deltaTime;

        //  一定時間になったらオブジェクトを生成
        if(intervalCount > INTERVAL_TIME)
        {
            //  カウンタの初期化
            intervalCount = 0;

            //  オブジェクトの生成
            Instantiate(prefab, new Vector2(Random.Range(-8.5f,8.5f), Random.Range(-1,-4.5f)), Quaternion.identity);
        }
    }
}
