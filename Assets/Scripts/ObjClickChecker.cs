using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //  クリック系のクラスを継承する為に参照設定

//  IPointerUpHandlerクラスとIDragHandlerクラスを継承
//  https://docs.unity3d.com/ja/2018.4/Manual/SupportedEvents.html
//  上記サイトに記載されているクラスは継承する事で機能が使えるよ
public class ObjClickChecker : MonoBehaviour,IPointerUpHandler,IDragHandler,IPointerDownHandler
{
    //  この2Dオブジェクトに重なっているオブジェクトの当たり判定を取得する
    Collider2D[] overlapCols = new Collider2D[10];

    //  このオブジェクトにアタッチされている当たり判定を保存
    Collider2D col;

    void Start()
    {
        col = GetComponent<Collider2D>();   //  当たり判定コンポーネントの取得
    }

    /// <summary>
    /// クリック時処理。要IPointerDownHandlerの継承
    /// </summary>
    /// <param name="eventData"></param>
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {

    }

    /// <summary>
    /// クリック終了時処理。要IPointerUpHandlerの継承
    /// </summary>
    /// <param name="eventdata"></param>
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {

        //  クリック終了時にこのオブジェクトに重なっているオブジェクトの一覧を取得
        //  overlapColsに配列として格納する
        int hitCount = col.OverlapCollider(new ContactFilter2D(), overlapCols);

        //  GetAreaのタグを持つオブジェクトを探す
        //  見つけたらポイントにプラス１？
        for (int i = 0; i < hitCount; i++)
        { 
            if (overlapCols[i].gameObject.tag == "GetArea")
            {
                //  ポイントを加算する(暫定)
                //  PointReceiverクラスのPointReceiveメソッドを呼び出し
                overlapCols[i].gameObject.SendMessage("PointReceive", 1);

                //  このオブジェクトの削除
                Destroy(gameObject);
            }
        }
    }
    
   

    /// <summary>
    /// ドラッグ時処理。要IDragHandlerの継承
    /// </summary>
    /// <param name="eventdata"></param>
    void IDragHandler.OnDrag(PointerEventData eventdata)
    {
        Vector3 mousePos = Input.mousePosition; 
        mousePos.z = 10;    //  3D空間上だとZ値が必要。2D平面(Z値：０とカメラのZ値との距離を指定)
        Vector3 pos = Camera.main.ScreenToWorldPoint(mousePos);  //  座標系の変換
        pos.z = 0;  //  2Dなので奥行きを要素を削除
        transform.position = pos;
    }

}
