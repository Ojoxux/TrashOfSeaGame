using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //  �N���b�N�n�̃N���X���p������ׂɎQ�Ɛݒ�

//  IPointerUpHandler�N���X��IDragHandler�N���X���p��
//  https://docs.unity3d.com/ja/2018.4/Manual/SupportedEvents.html
//  ��L�T�C�g�ɋL�ڂ���Ă���N���X�͌p�����鎖�ŋ@�\���g�����
public class ObjClickChecker : MonoBehaviour,IPointerUpHandler,IDragHandler,IPointerDownHandler
{
    //  ����2D�I�u�W�F�N�g�ɏd�Ȃ��Ă���I�u�W�F�N�g�̓����蔻����擾����
    Collider2D[] overlapCols = new Collider2D[10];

    //  ���̃I�u�W�F�N�g�ɃA�^�b�`����Ă��铖���蔻���ۑ�
    Collider2D col;

    void Start()
    {
        col = GetComponent<Collider2D>();   //  �����蔻��R���|�[�l���g�̎擾
    }

    /// <summary>
    /// �N���b�N�������B�vIPointerDownHandler�̌p��
    /// </summary>
    /// <param name="eventData"></param>
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {

    }

    /// <summary>
    /// �N���b�N�I���������B�vIPointerUpHandler�̌p��
    /// </summary>
    /// <param name="eventdata"></param>
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {

        //  �N���b�N�I�����ɂ��̃I�u�W�F�N�g�ɏd�Ȃ��Ă���I�u�W�F�N�g�̈ꗗ���擾
        //  overlapCols�ɔz��Ƃ��Ċi�[����
        int hitCount = col.OverlapCollider(new ContactFilter2D(), overlapCols);

        //  GetArea�̃^�O�����I�u�W�F�N�g��T��
        //  ��������|�C���g�Ƀv���X�P�H
        for (int i = 0; i < hitCount; i++)
        { 
            if (overlapCols[i].gameObject.tag == "GetArea")
            {
                //  �|�C���g�����Z����(�b��)
                //  PointReceiver�N���X��PointReceive���\�b�h���Ăяo��
                overlapCols[i].gameObject.SendMessage("PointReceive", 1);

                //  ���̃I�u�W�F�N�g�̍폜
                Destroy(gameObject);
            }
        }
    }
    
   

    /// <summary>
    /// �h���b�O�������B�vIDragHandler�̌p��
    /// </summary>
    /// <param name="eventdata"></param>
    void IDragHandler.OnDrag(PointerEventData eventdata)
    {
        Vector3 mousePos = Input.mousePosition; 
        mousePos.z = 10;    //  3D��ԏゾ��Z�l���K�v�B2D����(Z�l�F�O�ƃJ������Z�l�Ƃ̋������w��)
        Vector3 pos = Camera.main.ScreenToWorldPoint(mousePos);  //  ���W�n�̕ϊ�
        pos.z = 0;  //  2D�Ȃ̂ŉ��s����v�f���폜
        transform.position = pos;
    }

}
