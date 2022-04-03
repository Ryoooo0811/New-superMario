using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice : MonoBehaviour
{
  // Start is called before the first frame update

  /* 問1. 1～10までをログに表示する関数を作れ（見る）
     問2．n～mまでをログに表示する関数を作れ（見る）
     問3．n～mまでの合計を返す関数を作れ（演習）
     問4．n～mまでの平均を表示する関数を作れ（演習）*/
  void Start()
  {
    Getlog1to10();
    GetNumber(3, 24);
    Debug.Log(GetSum(4, 6));
    Debug.Log(GetMean(5, 8));
  }

  void Getlog1to10()
  {
    for (int i = 1; i <= 10; i++)
    {
      Debug.Log(i);
    }
  }

  void GetNumber(int n, int m)
  {
    for (int i = n; i <= m; i++)
    {
      Debug.Log(i);
    }
  }

  int GetSum(int n, int m)
  {
    int sum = 0;
    for (int i = n; i <= m; i++)
    {
      sum += i;
    }
    return sum;
  }

  /*float GetMean(int n, int m)
  {
    float mean = 0f;
    for (int i = n; i <= m; i++)
    {
      mean += i;
    }
    return mean / (m - n + 1);
  }*/

  float GetMean(int n, int m)
  {
    float mean = 0f;
    float sum = 0;
    int count = 0;
    for (int i = n; i <= m; i++)
    {
      sum += i;
      count++;
    }
    mean = sum/ count;
    return mean;
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
