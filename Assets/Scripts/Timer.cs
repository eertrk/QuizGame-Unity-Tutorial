using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float asnwerTime = 5f;
    [SerializeField] float showTime = 7f;
    float timerValue;

    public bool loadNextQuestion;
    public bool isAnsweringQuestion = false;
    public float fillFraction;
    
    void Update()
    {
        UpdateTimer();
    }
     
    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / asnwerTime;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = showTime;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / showTime;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = asnwerTime;
                loadNextQuestion = true;
            }
        }
    }
}
