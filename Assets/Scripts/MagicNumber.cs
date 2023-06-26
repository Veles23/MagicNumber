using TMPro;
using UnityEngine;

public class MagicsNumb : MonoBehaviour
{
    #region Variables

    public TMP_Text firsText;
    public int max;
    public int min;
    public TMP_Text otherText;
    private int _guess;
    private int _numberOfSteps;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        min = 1;
        max = 1000;
        firsText.text = $"Загадай число от {min} до {max}!\n\n" +
                        "Твое число больше? Жми стрелку вверх." +
                        "\nТвоё число меньше? Жми стрелку вниз." +
                        "\nЯ угадал твое число? Жми пробел." +
                        "\n\nДля старта нажми стрелку вверх или вниз.";

        CalculateGuess();
        AskGuess();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _numberOfSteps++;
            max = _guess;
            CalculateGuess();
            AskGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _numberOfSteps++;
            min = _guess;
            CalculateGuess();
            AskGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            otherText.text = $"Хе-хе! Твоё число {_guess}! Колличество ходов: {_numberOfSteps}.";
        }
    }

    #endregion

    #region Private methods

    private void AskGuess()
    {
        otherText.text = $"Твоё число {_guess}?";
    }

    private void CalculateGuess()
    {
        _guess = (min + max) / 2;
    }

    #endregion
}