using DG.Tweening;
using UnityEngine;

namespace Test.Game.Button {
    public class DorOpen : MonoBehaviour
    {
        [Range(0f, 1f)]
        [SerializeField] private float _activateTime = 0.5f;
        [SerializeField] private float _buttonPressedZPosition;

        public void OpenDor()
        {
           transform.DOMoveZ(_buttonPressedZPosition, _activateTime);
        }
    }
}