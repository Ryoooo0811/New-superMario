using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odd_sum : MonoBehaviour
{
  // Start is called before the first frame update
  // 整数nからmまでの偶数の和を返す関数を作成せよ！
  void Start()
  {
    Debug.Log(OddSum(2, 7));
  }

  int OddSum(int n, int m)
  {
    int sum = 0;
    for (int i = n; i <= m; i++)
    {
      if (i % 2 == 0)
      {
        sum += i;
      }
    }
    return sum;
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
