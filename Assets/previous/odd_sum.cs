using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odd_sum : MonoBehaviour
{
  // Start is called before the first frame update
  // ����n����m�܂ł̋����̘a��Ԃ��֐����쐬����I
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
