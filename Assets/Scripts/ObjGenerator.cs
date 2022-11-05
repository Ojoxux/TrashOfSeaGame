using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjGenerator : MonoBehaviour
{
    //  ��������I�u�W�F�N�g
    [SerializeField] GameObject prefab;

    //  ���Ԋu�Ŏ��s���鏈���̃J�E���^
    float intervalCount = 0;
    [SerializeField]float INTERVAL_TIME = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //  �J�E���^�̉��Z
        intervalCount += Time.deltaTime;

        //  ��莞�ԂɂȂ�����I�u�W�F�N�g�𐶐�
        if(intervalCount > INTERVAL_TIME)
        {
            //  �J�E���^�̏�����
            intervalCount = 0;

            //  �I�u�W�F�N�g�̐���
            Instantiate(prefab, new Vector2(Random.Range(-8.5f,8.5f), Random.Range(-1,-4.5f)), Quaternion.identity);
        }
    }
}
