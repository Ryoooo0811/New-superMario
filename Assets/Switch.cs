using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
  // Start is called before the first frame update

  // switch文
  void Start()
  {
    string characterType = "Player";

    switch (characterType)
    {
      case "Player":
        Debug.Log("味方だよ");
        break;
      case "Enemy":
        Debug.Log("敵だよ");
        break;
      case "Friends":
        Debug.Log("友達だよ");
        break;
      default:
        Debug.Log("その他");
        break;
    }


    /* 演習：
       上のswitch文をifに書き換えよう  */

    if (characterType == "Player")
    {
      Debug.Log("味方だよ");
    }
    else if (characterType == "Enemy")
    {
      Debug.Log("敵だよ");
    }
    else if (characterType == "Friends")
    {
      Debug.Log("友達だよ");
    }
    else
    {
      Debug.Log("その他");
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
