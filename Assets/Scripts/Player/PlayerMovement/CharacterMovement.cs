using UnityEngine;

namespace Character.Movement
{
    [RequireComponent(typeof(Rigidbody))]
    public class CharacterMovement : MonoBehaviour
    {
        [Header("Character movement stats")]
        private Animator _animator;
        private Rigidbody _rigidbody;
        private CharacterSetting _characterSetting;

        public Animator Animator { get => _animator; set => _animator = value; }

        private void Start()
        {
            _characterSetting = GetComponent<CharacterSetting>();
            _rigidbody = GetComponent<Rigidbody>();
            _animator = GetComponent<Animator>();
        }


        public void MoveCharacter(Vector3 moveDirection)
        {
            Vector3 offset = moveDirection * _characterSetting.MoveSpeed;
            _rigidbody.velocity = new Vector3(offset.x, _rigidbody.velocity.y, offset.z);
        }
        public void RotateCharacter(Vector3 moveDirection)
        {
            if (Vector3.Angle(transform.forward, moveDirection) > 0)
            {
                Vector3 newDirection = Vector3.RotateTowards(transform.forward, moveDirection,_characterSetting.RotateSpeed, 0);
                transform.rotation = Quaternion.LookRotation(newDirection);
            }
        }

    }
}