using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOp : MonoBehaviour
{
    public void OnClicked(int number)
    {
        switch(number){
            case 0: //あそぶボタンが押されたときの処理
                FadeManager.Instance.LoadScene("Game", 1.0f);
                break;
            case 1: //コレクションボタンが押されたときの処理
                FadeManager.Instance.LoadScene("Collect", 1.0f);
                break;
            case 2: //ガチャボタンが押されたときの処理
                FadeManager.Instance.LoadScene("Gatya", 1.0f);
                break;

             /*
            case 3: //設定ボタンが押されたときの処理
                FadeManager.Instance.LoadScene("Setting", 1.0f);
                break;
             */

            default:
                break;
        }
    }
}