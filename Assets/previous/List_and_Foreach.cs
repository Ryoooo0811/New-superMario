using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_and_Foreach : MonoBehaviour
{
  // Start is called before the first frame update

  // List
  // 宣言、代入、取得、ながさ取得、追加、削除
  // for文との兼ね合い
  // foreach
  void Start()
  {
    List<int> numbers = new List<int>() { -1, 21, 23 };
    //Debug.Log(numbers[0]);
    //Debug.Log(numbers[1]);
    //Debug.Log(numbers[2]);

    // 代入
    numbers[1] = 0;
    //Debug.Log(numbers[1]);

    // 追加
    numbers.Add(100);
    //Debug.Log(numbers[3]);

    // ながさの取得
    //Debug.Log(numbers.Count);

    // 削除
    //numbers.RemoveAt(1);
    //numbers.Remove(-1);
    //Debug.Log(numbers.Count);

    // for文
    //for (int i = 0; i < numbers.Count; i++)
    //{
    //  Debug.Log(numbers[i]);
    //}

    // foreach（配列とListで使える）
    //List<string> namelist = new List<string>() { "むらぴょん", "岡本", "勅使河原" };
    //foreach (var Name in namelist)
    //{
    //  Debug.Log(Name);
    //}

    /*  演習：
        1～100までの3の倍数を要素に持つListを作りなさい  */
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
