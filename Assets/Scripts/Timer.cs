using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    
    float startTime;

    float currentTime;

    public float levelTime;

    public TMP_Text timeText;
    
    // Start is called before the first frame update
    void Awake()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = startTime - Time.time + levelTime;
        // timeText.text = currentTime.ToString();
        updateTimer();
    }

    void FixedUpdate()
    {
        
    }

    void updateTimer()
    {
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}
