using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiple_of_3 : MonoBehaviour
{
  // Start is called before the first frame update

  // 1から100までのさ３の倍数と３のつく数字を要素とするリストを返す関数を作成せよ
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
      // 下記のbool値がtrueの場合、リストにnumberを追加。
      if (IsThreeAhoNumber(i))
      {
        threeAhoNumberList.Add(i);
      }
    }
    return threeAhoNumberList;
  }

  bool IsThreeAhoNumber(int number)
  {
    // numberが3の倍数ならばtrueを返す。
    if (number % 3 == 0)
    {
      return true;
    }

    // numberの各桁に3が一つでもあればtrue
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
