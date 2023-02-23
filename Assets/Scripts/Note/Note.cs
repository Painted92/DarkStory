using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    [TextArea(5,10)]
    [SerializeField]  private string _text;
    [SerializeField] private TMP_Text _textNotes;

    
    public void OpenNote()
    {
        gameObject.SetActive(true);
        _textNotes.text = _text;
    }
    public void CloseNote()
    {
        gameObject.SetActive(false);
        _textNotes.text = "";
    }
}
