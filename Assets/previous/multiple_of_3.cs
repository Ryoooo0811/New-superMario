using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiple_of_3 : MonoBehaviour
{
  // Start is called before the first frame update

  // 1����100�܂ł̂��R�̔{���ƂR�̂�������v�f�Ƃ��郊�X�g��Ԃ��֐����쐬����
  void Start()
  {
    List<int> threeAhoNumberList = GetThreeAhoNumberList();
    foreach (int number in threeAhoNumberList)
    {
      Debug.Log(number);
    }
  }

  /*
  int MultipleOf_3(int a, int b)
  {
    for (int i = a; i <= b; i++)
    {
      if (i % 3 == 0 || i )
      {

      }  
    }
  }   */

  List<int> GetThreeAhoNumberList()
  {
    List<int> threeAhoNumberList = new List<int>();
    for (int i = 1; i <= 100; i++)
    {
      // ���L��bool�l��true�̏ꍇ�A���X�g��number��ǉ��B
      if (IsThreeAhoNumber(i))
      {
        threeAhoNumberList.Add(i);
      }
    }
    return threeAhoNumberList;
  }

  bool IsThreeAhoNumber(int number)
  {
    // number��3�̔{���Ȃ��true��Ԃ��B
    if (number % 3 == 0)
    {
      return true;
    }

    // number�̊e����3����ł������true
    while (number != 0)
    {
      if (number % 10 == 3)
      {
        return true;
      }
      number = number / 10;
    }
    return false;
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
