using DG.Tweening;
using UnityEngine;

namespace Test.Game.Button {
    public class DorOpen : MonoBehaviour
    {
        [Range(0f, 1f)]
        [SerializeField] private float _activateTime = 0.5f;
        [SerializeField] private float _buttonPressedZPosition;
        [SerializeField] private float _buttonPressedXPosition;
        [SerializeField] private float _buttonPressedYPosition;
        [SerializeField] private float _buttonPressedZPositionLast;
        public void OpenDor()
        {
            _buttonPressedZPositionLast = transform.position.z;
           transform.DOMoveZ(_buttonPressedZPosition, _activateTime);
        }
        public void CloseDor()
        {
            transform.DOMoveZ(_buttonPressedZPositionLast, _activateTime);
        }
    }
}