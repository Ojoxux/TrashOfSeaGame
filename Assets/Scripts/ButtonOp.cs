using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOp : MonoBehaviour
{
    public void OnClicked(int number)
    {
        switch(number){
            case 0: //�����ԃ{�^���������ꂽ�Ƃ��̏���
                FadeManager.Instance.LoadScene("Game", 1.0f);
                break;
            case 1: //�R���N�V�����{�^���������ꂽ�Ƃ��̏���
                FadeManager.Instance.LoadScene("Collect", 1.0f);
                break;
            case 2: //�K�`���{�^���������ꂽ�Ƃ��̏���
                FadeManager.Instance.LoadScene("Gatya", 1.0f);
                break;

             /*
            case 3: //�ݒ�{�^���������ꂽ�Ƃ��̏���
                FadeManager.Instance.LoadScene("Setting", 1.0f);
                break;
             */

            default:
                break;
        }
    }
}