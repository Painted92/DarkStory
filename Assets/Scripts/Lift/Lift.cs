using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;



    public class Lift : MonoBehaviour
    {
        [Range(0f, 10f)]
        [SerializeField] private float _activateTimes = 0.5f;
        [SerializeField] private float _buttonPressedYPosition;
        [SerializeField] private float _buttonPressedYPositionLast;
        [SerializeField] private Button IntButt;
        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                IntButt.gameObject.SetActive(true);
                IntButt.onClick.AddListener(DownLift);
            }
           
        }
        public void DownLift()
        {
            _buttonPressedYPositionLast = transform.position.y;
            transform.DOMoveY(_buttonPressedYPosition, _activateTimes);
        }
        public void UpLift()
        {
            transform.DOMoveY(_buttonPressedYPositionLast, _activateTimes);
        }
    }
