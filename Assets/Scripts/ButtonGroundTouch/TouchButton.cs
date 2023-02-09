using UnityEngine;
using DG.Tweening;

namespace Test.Game.Button
{
    public class TouchButton : DefaultButton
    {
       // [Range(0f, 1f)]
        [SerializeField] private float _activateTime = 0.5f;
        [SerializeField] private float _buttonPressedYPosition = -3.47f;

        private MeshRenderer _buttonMeshRenderer;
        private void Start() => _buttonMeshRenderer = gameObject.GetComponent<MeshRenderer>();

        public override void ButtonUse()
        {
            if (IsActive)
            {
                transform.DOMoveY(_buttonPressedYPosition, _activateTime);
                _buttonMeshRenderer.material.DOColor(Color.green, _activateTime);
            }
        }
    }
}
