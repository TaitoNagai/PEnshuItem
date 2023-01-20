using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Text _timeText;
    private Spawner _spawnerTime;
    private void Start()
    {
        _spawnerTime = GetComponent<Spawner>();
    }
    private void Update()
    {
        var time = TimeSpan.FromSeconds(Time.time);
        var offset = TimeSpan.FromMinutes(1);
        var limit = offset - time;
        _timeText.text = $"{limit.Minutes:00}:{limit.Seconds:00}.{limit.Milliseconds:000}";

        if(limit.Seconds == 0)
        {
            _timeText.text = $"{0}";
        }
    }
}
