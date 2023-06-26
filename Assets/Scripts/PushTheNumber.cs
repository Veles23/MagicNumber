using UnityEngine;

public class PushTheNum : MonoBehaviour
{
    #region Variables

    private int _step;
    private int _sum;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Debug.Log("Нажмите цифру!");
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            CalculateSumNumbers();
            Debug.Log("Сумма: " + _sum);
        }

        else if (_sum == 50)
        {
            Debug.Log($"Сумма {_sum}! Игра окончена. Колличество ходов {_step}");
        }

        else if (_sum > 50)
        {
            FinalSumCalculate();
            Debug.Log($"Сумма {_sum}! Игра окончена. Колличество ходов {_step}");
        }
    }

    #endregion

    #region Private methods

    private void CalculateSumNumbers()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _sum++;
            _step++;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _sum += 2;
            _step++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _sum += 3;
            _step++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _sum += 4;
            _step++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            _sum += 5;
            _step++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            _sum += 6;
            _step++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            _sum += 7;
            _step++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            _sum += 8;
            _step++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            _sum += 9;
            _step++;
        }
    }

    private int FinalSumCalculate()
    {
        int endSum = _sum - 50;
        _sum -= endSum;
        return _sum;
    }

    #endregion
}