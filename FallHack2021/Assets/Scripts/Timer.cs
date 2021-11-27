using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float LevelTimer = 30f;
    public float fillFraction;
    float timerValue;

    bool isAlive = true;
    // Update is called once per frame
    void Update()
    {   
        UpdateTimer();
    }

    public void CancelTimer(){
        timerValue = 0;
    }

    void UpdateTimer(){
        timerValue -= Time.deltaTime;

        if(isAlive){
            if(timerValue > 0){
                fillFraction = timerValue/timeToComplete;
            }else{
                isAlive = false;
                timerValue = LevelTimer;
            }
        }else{
            //some death animation
        }
    }
}
