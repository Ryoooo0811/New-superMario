using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable_type : MonoBehaviour
{
  // �ϐ��̌^
  // ������F
  string Name = "�ނ�҂��";
  // �����F
  int hp = 100;
  // ���������_���F
  float speed = 158.3f;
  // �_���l�F
  bool flag1 = true;
  bool flag2 = false;

  // Start is called before the first frame update
  void Start()
  {
    Debug.Log(Name);
    Debug.Log(hp);
    Debug.Log(speed);
    Debug.Log(flag1);
    Debug.Log(flag2);
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
