using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercreate : MonoBehaviour
{
  // public
  [SerializeField] GameObject playerPrefab;
  void Start()
  {
    Instantiate(playerPrefab);
  }
}
