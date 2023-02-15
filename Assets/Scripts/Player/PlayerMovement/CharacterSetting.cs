using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSetting : MonoBehaviour
{
    [SerializeField]  private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _jumpSpeed;
    [Range(0,100)]
    [SerializeField] private float _healsCharacter;

    public float MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
    public float JumpSpeed { get => _jumpSpeed; set => _jumpSpeed = value; }
    public float RotateSpeed { get => _rotateSpeed; set => _rotateSpeed = value; }
}
