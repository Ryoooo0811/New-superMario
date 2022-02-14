using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
  // Start is called before the first frame update

  // switch•¶
  void Start()
  {
    string characterType = "Player";

    switch (characterType)
    {
      case "Player":
        Debug.Log("–¡•û‚¾‚æ");
        break;
      case "Enemy":
        Debug.Log("“G‚¾‚æ");
        break;
      case "Friends":
        Debug.Log("—F’B‚¾‚æ");
        break;
      default:
        Debug.Log("‚»‚Ì‘¼");
        break;
    }


    /* ‰‰KF
       ã‚Ìswitch•¶‚ğif‚É‘‚«Š·‚¦‚æ‚¤  */

    if (characterType == "Player")
    {
      Debug.Log("–¡•û‚¾‚æ");
    }
    else if (characterType == "Enemy")
    {
      Debug.Log("“G‚¾‚æ");
    }
    else if (characterType == "Friends")
    {
      Debug.Log("—F’B‚¾‚æ");
    }
    else
    {
      Debug.Log("‚»‚Ì‘¼");
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
