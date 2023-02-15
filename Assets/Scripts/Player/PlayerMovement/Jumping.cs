using UnityEngine;

namespace Character.Movement
{
    public class Jumping : CharacterSetting
    {
        private Rigidbody _rigidbody;
        [SerializeField] LayerMask _mask;
        [SerializeField] Transform _groundChec;
        private Animator _animator;
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _animator = GetComponent<Animator>();
        }

        public void Jump()// прыжок с системой проверки соприкосновения с землей.
        {
            if (Physics.Raycast(_groundChec.position, Vector2.down, 0.2f, _mask))
            {
                _animator.SetTrigger("Jump");
                _rigidbody.AddForce(Vector3.up * JumpSpeed , ForceMode.Impulse);
            }
            else
            {
                Debug.Log("Did not find ground layer");
            }
        }
        private void Update()
        {
            if (Physics.Raycast(_groundChec.position, Vector2.down, 0.3f, _mask))// проверка на соприкосновение с землейю
            {
                _animator.SetBool("isinAir", false);
            }
            else
            {
                _animator.SetBool("isinAir", true);
            }
        }
    }
}