using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace Test.Game.Note
{

    public class Note : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textNotes;


        public void OpenNote(string textNote)
        {
            gameObject.SetActive(true);
            _textNotes.text = textNote;
        }
        public void CloseNote()
        {
            gameObject.SetActive(false);
            _textNotes.text = "";
        }
    }
}