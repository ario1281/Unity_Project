using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerCount : MonoBehaviour
{
    private TMP_Text timeText;
    private float time = 0;


    void Start()
    {
        GameObject.Find("Time").TryGetComponent(out timeText);
    }

    void Update()
    {
        time += Time.deltaTime;
        var text = "TIME:" + time.ToString("F1");
        timeText.SetText(text);
    }
}
