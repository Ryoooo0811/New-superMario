using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
  // �ϐ��ƒ萔
  // �ϐ��F�l��ς��������
  // �ϐ��̌^ �ϐ���;
  void Start()
  {
    string say = "Hello World";   // �錾�Ƒ��
    say = "�X�^�W�I�ނ�҂��";
    Debug.Log(say);

    const string sayConst = "Hello World2";   // �錾�Ƒ��
    Debug.Log(sayConst);
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
