using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maximum : MonoBehaviour
{
  // Start is called before the first frame update

  /* ��1�DnumberList1�̍ő�l��Ԃ��֐������i����j
     ��2�DnumberList2�̍ő�l��Ԃ��֐������i���K�j
     ��3�Dint�^�̔z��̍ő�l��Ԃ��֐������i���K�j*/

  int[] numberList1 = new int[3] { 2, -4, 10 };
  int[] numberList2 = new int[4] { 2, -4, 10, 100 };
  void Start()
  {
    /*Debug.Log(GetMaxValue1());
    Debug.Log(GetMaxValue2());*/
    Debug.Log(GetMaxValue(numberList1));
    Debug.Log(GetMaxValue(numberList2));
  }

  int GetMaxValue(int[] numberList)
  {
    int maxValue = numberList[0];
    for (int i = 0; i < numberList.Length; i++)
    {
      if (maxValue < numberList[i])
      {
        maxValue = numberList[i];
      }
    }
    return maxValue;
  }
  
  /*int GetMaxValue1()
  {
    int maxValue = numberList1[0];
    for (int i = 0; i < numberList1.Length; i++)
    {
      if (maxValue < numberList1[i])
      {
        maxValue = numberList1[i];
      }
    }
    return maxValue;
  }

  int GetMaxValue2()
  {
    int maxValue = numberList2[0];
    for (int i = 0; i < numberList2.Length; i++)
    {
      if (maxValue < numberList2[i])
      {
        maxValue = numberList2[i];
      }
    }
    return maxValue;
  }*/

  // Update is called once per frame
  void Update()
  {
        
  }
}
