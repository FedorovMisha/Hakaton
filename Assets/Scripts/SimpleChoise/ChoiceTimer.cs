using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using SimpleChoise;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceTimer : MonoBehaviour
{
    private static float _globalTime = 5f;
    public static float GlobalTime
    {
        get => _globalTime;
        set
        {
            if (_globalTime < 2f)
            {
                _globalTime = 1f;
            }
            else
            {
                _globalTime = value;
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
