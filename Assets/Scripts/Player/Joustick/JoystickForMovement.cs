using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character.Movement;
namespace Joystick.DarkGames
{
    public class JoystickForMovement : JoystickHandlerr
    {
        [SerializeField] private CharacterMovement _characterMovement;

        private void FixedUpdate()
        {
            if (_inputVector.x != 0 || _inputVector.y != 0)
            {
                _characterMovement.MoveCharacter(new Vector3(_inputVector.x, 0, _inputVector.y));
                _characterMovement.RotateCharacter(new Vector3(_inputVector.x, 0, _inputVector.y));
            }
            else
            {
                _characterMovement.MoveCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
                _characterMovement.RotateCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
            }
        }

    }
}