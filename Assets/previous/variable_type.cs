using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable_type : MonoBehaviour
{
  // 変数の型
  // 文字列：
  string Name = "むらぴょん";
  // 整数：
  int hp = 100;
  // 浮動小数点数：
  float speed = 158.3f;
  // 論理値：
  bool flag1 = true;
  bool flag2 = false;

  // Start is called before the first frame update
  void Start()
  {
    Debug.Log(Name);
    Debug.Log(hp);
    Debug.Log(speed);
    Debug.Log(flag1);
    Debug.Log(flag2);
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
