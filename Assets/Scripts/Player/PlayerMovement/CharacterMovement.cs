using UnityEngine;

namespace Character.Movement
{
    [RequireComponent(typeof(Rigidbody))]
    public class CharacterMovement : CharacterSetting
    {
        [Header("Character movement stats")]
        private Animator _animator;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _animator = GetComponent<Animator>();
        }



        public void MoveCharacter(Vector3 moveDirection)
        {
            Vector3 offset = moveDirection * MoveSpeed * Time.deltaTime;
            _rigidbody.MovePosition(_rigidbody.position + offset);
            _animator.SetFloat("Speed", Vector3.ClampMagnitude(moveDirection, 1).magnitude); // система для активации древа анимаций.
        }

        public void RotateCharacter(Vector3 moveDirection)
        {
            if (Vector3.Angle(transform.forward, moveDirection) > 0)
            {
                Vector3 newDirection = Vector3.RotateTowards(transform.forward, moveDirection, RotateSpeed, 0);
                transform.rotation = Quaternion.LookRotation(newDirection);
            }
        }

    }
}