using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour
{
  // Start is called before the first frame update

  // ‰‰ŽZ
  // +, -, *, /, %, +=, ++, --, &&, ||, !
  void Start()
  {
    // +, -
    int a = 10;
    int b = 2;
    Debug.Log(a + b);
    Debug.Log(a - b);

    // *, /
    Debug.Log(a * b);
    Debug.Log(a / b);
    Debug.Log(b / a);

    /*float c = 10.0f;
    float d = 2.0f;
    Debug.Log(d / c);
    */

    // %
    int n = 10;
    int m = 3;
    Debug.Log(n / m);
    Debug.Log(n % m);

    // +=, ++, -=, --
    int x = 10;
    
    x = x + 1;
    Debug.Log(x);

    x += 1;
    Debug.Log(x);

    x++;
    Debug.Log(x);

    int y = 20;

    y = y - 1;
    Debug.Log(y);

    y -= 1;
    Debug.Log(y);

    y--;
    Debug.Log(y);

    // &&, ||, !
    bool flagTrue = true;
    bool flagFalse = false;
    Debug.Log(flagTrue && flagFalse);   // AND
    Debug.Log(flagTrue || flagFalse);   // OR
    Debug.Log(!flagTrue);   // NOT
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
