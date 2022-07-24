using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  // Player Speed
  [SerializeField] float moveSpeed = 10f;
  // Start is called before the first frame update
  void Start()
  {
    HowToPlay();
  }

  // Update is called once per frame
  void Update()
  {
    PlayerMovement();
  }

  void HowToPlay()
  {
    print("Use W,A,S,D to move around");
    print("Avoid the obstacles!");
    print("Remember, One Day At A Time");
  }

  void PlayerMovement()
  {
    // Player Input movement variables
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    transform.Translate(xValue, 0, zValue);
  }

}
