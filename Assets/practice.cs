using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice : MonoBehaviour
{
  // Start is called before the first frame update

  /* ��1. 1�`10�܂ł����O�ɕ\������֐������i����j
     ��2�Dn�`m�܂ł����O�ɕ\������֐������i����j
     ��3�Dn�`m�܂ł̍��v��Ԃ��֐������i���K�j
     ��4�Dn�`m�܂ł̕��ς�\������֐������i���K�j*/
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
