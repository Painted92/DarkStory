using UnityEngine;

namespace Character.Movement
{
    public class Jumping : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        [SerializeField] LayerMask _mask;
        [SerializeField] Transform _groundChec;
        private Animator _animator;
        private CharacterSetting _characterSetting;
        void Start()
        {
            _characterSetting =GetComponent<CharacterSetting>();
            _rigidbody = GetComponent<Rigidbody>();
            _animator = GetComponent<Animator>();
        }

        public void Jump()// ?????? ? ???????? ???????? ??????????????? ? ??????.
        {
            if (Physics.Raycast(_groundChec.position, Vector2.down, 0.2f, _mask))
            {
              //  _animator.SetTrigger("Jump");
                _rigidbody.AddForce(Vector3.up *_characterSetting.JumpSpeed , ForceMode.Impulse);
            }
            else
            {
                Debug.Log("Did not find ground layer");
            }
        }
        private void Update()
        {
            if (Physics.Raycast(_groundChec.position, Vector2.down, 0.3f, _mask))// ???????? ?? ??????????????? ? ???????
            {
             //   _animator.SetBool("isinAir", false);
            }
            else
            {
              //  _animator.SetBool("isinAir", true);
            }
        }
    }
}