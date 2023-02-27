using UnityEngine;
using Test.Game.Button;
namespace Test.Game.Trigger.Zone
{
    public class Newlevel : MonoBehaviour
    {
        [SerializeField] private DorOpen _dor;
        [SerializeField] private TimerLevel _timer;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _dor.CloseDor();
                _timer.LvlTime = 60;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
                gameObject.SetActive(false);
        }
    }
}