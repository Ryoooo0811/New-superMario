using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
  // Start is called before the first frame update

  // switch��
  void Start()
  {
    string characterType = "Player";

    switch (characterType)
    {
      case "Player":
        Debug.Log("��������");
        break;
      case "Enemy":
        Debug.Log("�G����");
        break;
      case "Friends":
        Debug.Log("�F�B����");
        break;
      default:
        Debug.Log("���̑�");
        break;
    }


    /* ���K�F
       ���switch����if�ɏ��������悤  */

    if (characterType == "Player")
    {
      Debug.Log("��������");
    }
    else if (characterType == "Enemy")
    {
      Debug.Log("�G����");
    }
    else if (characterType == "Friends")
    {
      Debug.Log("�F�B����");
    }
    else
    {
      Debug.Log("���̑�");
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
