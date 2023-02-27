using UnityEngine;
using UnityEngine.UI;
using Test.Game.Note;
    public class EventButton : MonoBehaviour
    {
        [SerializeField] private Button _intBut;
        [SerializeField] private Note noteMass;
        [SerializeField] private string textNote;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _intBut.gameObject.SetActive(true);
                _intBut.onClick.AddListener(delegate { noteMass.OpenNote(textNote); });
            }
        }
        private void OnTriggerExit(Collider other)
        {
            noteMass.CloseNote();
            _intBut.gameObject.SetActive(false);
            _intBut.onClick.RemoveListener(delegate { noteMass.OpenNote(textNote); });
        }
    }