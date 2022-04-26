using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While_and_For : MonoBehaviour
{
  // Start is called before the first frame update

  // 繰り返し
  // while, for
  void Start()
  {
    // while
    int x = 0;
    while (x < 10)
    {
      Debug.Log(x);
      x++;
    }

    // for
    // continue：continue以下の処理を飛ばして次の処理を行う
    // break：ループ処理を抜ける
    for (int i = 10; i < 20; i++)
    {
      if (i == 17)
      {
        break;
      }
      Debug.Log(i);
    }


    /*  演習：
        0～20までの偶数をコンソールに表示しなさい   */

    // while
    int a = 0;
    while (a <= 20)
    {
      Debug.Log(a);
      a += 2;
    }

    // for
    for (int b = 0; b <= 20; b += 2)
    {
      Debug.Log(b);
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
