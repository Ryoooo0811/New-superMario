using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
  // Start is called before the first frame update

  // 配列
  // 宣言、代入、取得、ながさ取得
  // for文との兼ね合い
  void Start()
  {
    /*
    int x1 = 0;
    int x2 = 2;
    int x3 = -3;
    */

    /*
    int[] xList = new int[3];  宣言　パターン1
    xList[0] = 0;   // 代入
    xList[1] = 2;
    xList[2] = -3;
    */

    // 宣言　パターン２
    int[] xList = new int[3] { 0, 1, -3 };

    // 取得
    //Debug.Log(xList[0]);
    //Debug.Log(xList[1]);
    //Debug.Log(xList[2]);

    // ながさの取得（要素の数）
    //Debug.Log(xList.Length);

    // for文との連携
    //for (int i = 0; i < xList.Length; i++)
    //{
    //  Debug.Log(xList[i]);
    //}

    /*  演習：
        0～30までの数を要素とする配列を作成しなさい   */

    int[] ylist = new int[31];
    for (int y = 0; y <= 30; y++)
    {
      ylist[y] = y;
      Debug.Log(ylist[y]);
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
