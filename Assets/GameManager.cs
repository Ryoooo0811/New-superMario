using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  [SerializeField] GameObject sampleObj;
  void Start()
  {
    // sampleObj.SetActive(false);
    Destroy(sampleObj);
  }
}
