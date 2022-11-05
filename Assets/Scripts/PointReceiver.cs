using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointReceiver : MonoBehaviour
{
    //  �|�C���g�̏W�v�ƕ\���p�N���X
    GetPointCounter pCounter;

    // Start is called before the first frame update
    void Start()
    {
        //  �I�u�W�F�N�g�̎擾
        GameObject obj = GameObject.FindWithTag("PointCounter");

        //  ���_�N���X�R���|�[�l���g�̎擾
        pCounter = obj.GetComponent<GetPointCounter>();
    }

    /// <summary>
    /// �|�C���g���W�v�p�N���X�ɑ��M����
    /// </summary>
    /// <param name="param"></param>
    public void PointReceive(int param)
    {
        //  �擾�����|�C���g�̑��t
        pCounter.AddPoint(param);
    }

}
