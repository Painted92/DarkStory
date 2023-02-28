using UnityEngine;
using UnityEngine.UI;
using Test.Game.Note;
    public class EventButton : MonoBehaviour
    {
        [SerializeField] private Button _intBut;
        [SerializeField] private Note _noteMass;
        [SerializeField] private string _textNote;

    public Button IntBut { get => _intBut; set => _intBut = value; }
    public string TextNote { get => _textNote; set => _textNote = value; }

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
              EnterButton();
            }
        }

       private void OnTriggerExit(Collider other)
       {
        ExitButton();
       }
         private void EnterButton()
        {
        IntBut.gameObject.SetActive(true);
        IntBut.onClick.AddListener(delegate { _noteMass.OpenNote(TextNote); });
    }

       private void ExitButton()
       {
        _noteMass.CloseNote();
        IntBut.gameObject.SetActive(false);
        IntBut.onClick.RemoveListener(delegate { _noteMass.OpenNote(TextNote); });
    }

    }