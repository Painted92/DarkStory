using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
