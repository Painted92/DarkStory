using UnityEngine;
using TMPro;


public class TimerLevel : MonoBehaviour
{
    private float _lvlTime = 30;
    [SerializeField] private TMP_Text _timer;

    public float LvlTime { get => _lvlTime; set => _lvlTime = value; }

    private void   FixedUpdate()
    {
        TimerUpdate();
    }

    private void TimerUpdate()
    {
        LvlTime -= Time.deltaTime;
        _timer.text = "Time :" + LvlTime.ToString("0");
        if (LvlTime <= 0)
        {
            Debug.Log("You Die");
        }
        if (LvlTime <= 20)
        {
            _timer.color =   Color.yellow;
        }
        if (LvlTime <= 10)
        {
            _timer.color = Color.red;
        }
    }
}
