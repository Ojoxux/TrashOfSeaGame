using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPointCounter : MonoBehaviour
{
    //  �ϐ���`
    int point;  //  �擾�����|�C���g
    Text tex;   //  �\���p�e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>(); //  �R���|�[�l���g�̎擾
    }


    /// <summary>
    /// �|�C���g���Z�p�̏���
    /// </summary>
    /// <param name="param">���Z����_��</param>
    public void AddPoint(int param)
    {
        //  �|�C���g�̉��Z
        point += param;

        //  �\���e�L�X�g�̍X�V
        tex.text = "Points:" + point;
    }
}
