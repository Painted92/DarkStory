using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventButton : MonoBehaviour
    {
    [SerializeField] private Button _intBut;
    [SerializeField] private Note noteMass;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _intBut.gameObject.SetActive(true);
            _intBut.onClick.AddListener(noteMass.OpenNote); 
        }
    }
    private void OnTriggerExit(Collider other)
    {
         noteMass.CloseNote();
        _intBut.gameObject.SetActive(false);
        _intBut.onClick.RemoveListener(noteMass.OpenNote);
    }

}
