using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicsNumb : MonoBehaviour
{
    private int _min;
    private int _max;
    private int _guess;

    void Start()
    {
        _min = 1;
        _max = 1000;
        Debug.Log($"Привет! Загадай число от {_min} до {_max}!");
        CalculateGuess();
        AskGuess();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            CalculateGuess();
            AskGuess();
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            CalculateGuess();
            AskGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.Space))

        {
            Debug.Log($"Поздравляю! Твоё число {_guess}!");
        }
    }

    private void AskGuess()
    {
        Debug.Log($"Твоё число {_guess}?");
    }

    private void CalculateGuess()
    {
        _guess = (_min + _max) / 2;
    }
}