using UnityEngine;

namespace Test.Game.Button
{
    public abstract class DefaultButton : MonoBehaviour
    {
        protected bool _isActive = true;
        private const string PLAYER = "Player";
        [SerializeField] private DorOpen dorOpen;

        public bool IsActive { get => _isActive; }

        public abstract void ButtonUse();
   

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(PLAYER))
            {
                ButtonUse();
                dorOpen.OpenDor();
                _isActive = false;
            }
        }
    }
}
