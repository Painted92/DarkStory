using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Test.Game.Button;

public class Newlevel : MonoBehaviour
{
    [SerializeField] private DorOpen dor;
    [SerializeField] private TimerLevel timer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            dor.CloseDor();
            timer.LvlTime = 60;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            gameObject.SetActive(false);
    }
}
