using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
  // Start is called before the first frame update

  // �z��
  // �錾�A����A�擾�A�Ȃ����擾
  // for���Ƃ̌��ˍ���
  void Start()
  {
    /*
    int x1 = 0;
    int x2 = 2;
    int x3 = -3;
    */

    /*
    int[] xList = new int[3];  �錾�@�p�^�[��1
    xList[0] = 0;   // ���
    xList[1] = 2;
    xList[2] = -3;
    */

    // �錾�@�p�^�[���Q
    int[] xList = new int[3] { 0, 1, -3 };

    // �擾
    //Debug.Log(xList[0]);
    //Debug.Log(xList[1]);
    //Debug.Log(xList[2]);

    // �Ȃ����̎擾�i�v�f�̐��j
    //Debug.Log(xList.Length);

    // for���Ƃ̘A�g
    //for (int i = 0; i < xList.Length; i++)
    //{
    //  Debug.Log(xList[i]);
    //}

    /*  ���K�F
        0�`30�܂ł̐���v�f�Ƃ���z����쐬���Ȃ���   */

    int[] ylist = new int[31];
    for (int y = 0; y <= 30; y++)
    {
      ylist[y] = y;
      Debug.Log(ylist[y]);
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
