using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WorldTime : MonoBehaviour
{
    private int _day;
    private float _timeInHours;
    [Range(0, 23)] [SerializeField] private int firstGameDayHour = 6;

    [Header("Day/Night Cycle Settings")] 
    [Range(0, 23)] [SerializeField] private int dayStartHour = 6;
    [Range(1, 24)] [SerializeField] private int endOfDayHour = 24;
    
    [Space]
    [Range(1, 120)] [SerializeField] private int dayInMinutes = 1;
    private int _timeMultiplier;
    [SerializeField] private bool useRealTime;

    [Header("UI Settings")]
    [SerializeField] private bool useUI;
    [SerializeField] private Text worldClock;
    [SerializeField] private bool showSeconds;

    [Header("Unity Events")] 
    public UnityEvent onNewDay;

    private void Start()
    {
        InitClock();
    }

    private void InitClock()
    {
        _timeInHours = firstGameDayHour;
        if (!useUI) return;
        worldClock = GameObject.Find("WorldClock").GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        if (IsEndOfDay) AddDay();
        
        if (useRealTime) ScaleTime();
        else ScaleTime(dayInMinutes);
        
        FillUI();
        AddTime();
    }

    private void AddTime()
    {
        _timeInHours += Time.fixedDeltaTime / 3600 * _timeMultiplier;
    }

    private void ScaleTime(int timeInMinutes = 720)
    {
        _timeMultiplier = 720 / timeInMinutes;
    }

    private string FormatTime()
    {
        var hours = _timeInHours;
        var contextHours = Mathf.FloorToInt(hours);
        
        var minutes = (hours - contextHours) * 60;
        var contextMinutes = Mathf.FloorToInt(minutes);

        if (!showSeconds) return $"{contextHours:00}:{contextMinutes:00}";
        
        var seconds = (minutes - contextMinutes) * 60;
        var contextSeconds = Mathf.FloorToInt(seconds);
        
        return $"{contextHours:00}:{contextMinutes:00}:{contextSeconds:00}";
    }

    private void FillUI()
    {
        if (!useUI) return;
        worldClock.text = "Day: " + _day + "\n" + FormatTime();
    }

    public void AddDay()
    {
        ResetTime();
        ++_day;
        onNewDay?.Invoke();
    }

    private void ResetTime()
    {
        _timeInHours = 0;
    }
    
    public int CurrentDay => _day;
    public float CurrentTimeInHours => _timeInHours;
    public int DayInMinutes => dayInMinutes;
    public bool IsEndOfDay => (int)_timeInHours == endOfDayHour;
}