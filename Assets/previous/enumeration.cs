using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumeration : MonoBehaviour
{
  // Start is called before the first frame update

  // —ñ‹“Œ^
  public enum TYPE
  {
    STOP,
    RIGHT,
    LEFT
  }
  TYPE type = TYPE.STOP;
  void Start()
  {
    if (type == TYPE.STOP)
    {
      Debug.Log(type);
    }
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
