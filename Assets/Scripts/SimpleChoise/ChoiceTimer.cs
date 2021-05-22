using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using SimpleChoise;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceTimer : MonoBehaviour
{
    private static float _globalTime = 15f;
    public static float GlobalTime
    {
        get => _globalTime;
        set
        {
            _globalTime = value;
            
            if (_globalTime < 1f)
            {
                _globalTime = 1f;
            }
        }
    }

    private float currentTime;

    private IGameEnd _gameEnd;

    private Text _text;
    
    private void Start()
    {
        currentTime = GlobalTime;
        _gameEnd = SimpleChoiceGameEnd.GameEnd;
        _text = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        currentTime -= Time.deltaTime;
        _text.text = $"{Math.Round(currentTime, 1)}";
        if (currentTime <= 0f)
        {
            _gameEnd.GameOver();
        }
    }
}
