using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
  // Start is called before the first frame update

  // if��
  // ���Z�q <, <=, >, >=, ==, !=
  void Start()
  {
    int hp = 100;
    if (hp > 150)
    {
      Debug.Log("����A");
    }
    else if (hp > 80)
    {
      Debug.Log("����B");
    }
    else
    {
      Debug.Log("���̑�");
    }

    if (hp % 2 == 0)
    {
      Debug.Log("HP�͋���");
    }
    else
    {
      Debug.Log("HP�͊");
    }



    /* ���K
       hp��3�Ŋ������Ƃ��̗]�肪1�̂Ƃ�  A
       hp��3�Ŋ������Ƃ��̗]�肪2�̂Ƃ�  B
       hp��3�Ŋ������Ƃ��̗]�肪0�̂Ƃ�  C    �ƕ\������v���O�����������Ȃ����B */

    if (hp % 3 == 1)
    {
      Debug.Log("A");
    }
    else if (hp % 3 == 2)
    {
      Debug.Log("B");
    }
    else
    {
      Debug.Log("C");
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
