using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  Rigidbody rigidbody;
  void Start()
  {
    rigidbody = GetComponent<Rigidbody>();
  }

  void Update()
  {
    // transform.position += new Vector3(0.1f, 0, 0);   ���������P
    // rigidbody.velocity = new Vector3(0.1f, 0, 0);   ���������Q
    // rigidbody.AddForce(new Vector3(0, 10, 0));   ���������R
  }
}
