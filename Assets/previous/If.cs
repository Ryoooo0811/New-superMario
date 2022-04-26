using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
  // Start is called before the first frame update

  // if文
  // 演算子 <, <=, >, >=, ==, !=
  void Start()
  {
    int hp = 100;
    if (hp > 150)
    {
      Debug.Log("処理A");
    }
    else if (hp > 80)
    {
      Debug.Log("処理B");
    }
    else
    {
      Debug.Log("その他");
    }

    if (hp % 2 == 0)
    {
      Debug.Log("HPは偶数");
    }
    else
    {
      Debug.Log("HPは奇数");
    }



    /* 演習
       hpを3で割ったときの余りが1のとき  A
       hpを3で割ったときの余りが2のとき  B
       hpを3で割ったときの余りが0のとき  C    と表示するプログラムを書きなさい。 */

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
