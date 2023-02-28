using UnityEngine;
using TMPro;


public class TimerLevel : MonoBehaviour
{
    private float _lvlTime = 30;
    [SerializeField] private TMP_Text _timerText;

    public float LvlTime { get => _lvlTime; set => _lvlTime = value; }

    private void   FixedUpdate()
    {
        TimerUpdate();
    }

    private void TimerUpdate()
    {
        LvlTime -= Time.deltaTime;
        _timerText.text = "Time :" + LvlTime.ToString("0");
        if (LvlTime <= 0)
        {
            Debug.Log("You Die");
            LvlTime = 0;
        }
        if (LvlTime <= 20)
        {
            _timerText.color =   Color.yellow;
        }
        if (LvlTime <= 10)
        {
            _timerText.color = Color.red;
        }
        if(LvlTime >= 21)
        {
            _timerText.color = Color.white;
        }
    }
}
