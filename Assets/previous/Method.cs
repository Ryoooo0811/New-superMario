using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
  // Start is called before the first frame update

  /* 関数(メソッド)：処理をまとめた便利道具 */
  void Start()
  {
    string name1 = SampleNameFunction("Murapyon");
    string name2 = SampleNameFunction("Love and peace");
    Debug.Log(name1);
    Debug.Log(name2);
    Debug.Log(SampleAddFunction(10, 2));
  }

  string SampleNameFunction(string sampleName)
  {
    Debug.Log(sampleName);
    return sampleName + "さん";
  }

  // 四則演算
  int SampleAddFunction(int a, int b)
  {
    return a + b;
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
