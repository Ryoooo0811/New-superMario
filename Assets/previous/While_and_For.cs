using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While_and_For : MonoBehaviour
{
  // Start is called before the first frame update

  // �J��Ԃ�
  // while, for
  void Start()
  {
    // while
    int x = 0;
    while (x < 10)
    {
      Debug.Log(x);
      x++;
    }

    // for
    // continue�Fcontinue�ȉ��̏������΂��Ď��̏������s��
    // break�F���[�v�����𔲂���
    for (int i = 10; i < 20; i++)
    {
      if (i == 17)
      {
        break;
      }
      Debug.Log(i);
    }


    /*  ���K�F
        0�`20�܂ł̋������R���\�[���ɕ\�����Ȃ���   */

    // while
    int a = 0;
    while (a <= 20)
    {
      Debug.Log(a);
      a += 2;
    }

    // for
    for (int b = 0; b <= 20; b += 2)
    {
      Debug.Log(b);
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
