using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
  // 変数と定数
  // 変数：値を変えられるもの
  // 変数の型 変数名;
  void Start()
  {
    string say = "Hello World";   // 宣言と代入
    say = "スタジオむらぴょん";
    Debug.Log(say);

    const string sayConst = "Hello World2";   // 宣言と代入
    Debug.Log(sayConst);
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
