using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_and_Foreach : MonoBehaviour
{
  // Start is called before the first frame update

  // List
  // �錾�A����A�擾�A�Ȃ����擾�A�ǉ��A�폜
  // for���Ƃ̌��ˍ���
  // foreach
  void Start()
  {
    List<int> numbers = new List<int>() { -1, 21, 23 };
    //Debug.Log(numbers[0]);
    //Debug.Log(numbers[1]);
    //Debug.Log(numbers[2]);

    // ���
    numbers[1] = 0;
    //Debug.Log(numbers[1]);

    // �ǉ�
    numbers.Add(100);
    //Debug.Log(numbers[3]);

    // �Ȃ����̎擾
    //Debug.Log(numbers.Count);

    // �폜
    //numbers.RemoveAt(1);
    //numbers.Remove(-1);
    //Debug.Log(numbers.Count);

    // for��
    //for (int i = 0; i < numbers.Count; i++)
    //{
    //  Debug.Log(numbers[i]);
    //}

    // foreach�i�z���List�Ŏg����j
    //List<string> namelist = new List<string>() { "�ނ�҂��", "���{", "���g�͌�" };
    //foreach (var Name in namelist)
    //{
    //  Debug.Log(Name);
    //}

    /*  ���K�F
        1�`100�܂ł�3�̔{����v�f�Ɏ���List�����Ȃ���  */
    List<int> num = new List<int> ();
    for (int i = 3; i < 100; i += 3)
    {
      num.Add(i);
    }

    foreach (var multiple in num)
    {
      Debug.Log(multiple);
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
