using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement movement;
    private Animator animator;
  [SerializeField]  private Joystick joystick;
    void Start()
    {
        movement = GetComponent<Movement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.MoveHorizontal(joystick);// вызов метода движения.
    }
}
