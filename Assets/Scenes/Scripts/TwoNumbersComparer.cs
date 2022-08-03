using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private Text resultText;
    [SerializeField] private InputField firstNumberField;
    [SerializeField] private InputField secondNumberField;
    private float firstNumber;
    private float secondNumber;

    public void CompareNumbers()
    {
        if (firstNumberField.text.Length != 0 && secondNumberField.text.Length != 0)
        {
            bool successFirst = float.TryParse(firstNumberField.text, out firstNumber);
            bool successSecond = float.TryParse(secondNumberField.text, out secondNumber);
            if (successFirst && successSecond)
            {
                if (firstNumber < secondNumber)
                    resultText.text = secondNumber.ToString();
                else if (firstNumber > secondNumber)
                    resultText.text = firstNumber.ToString();
                else
                    resultText.text = "Равны";
            }
            else
                resultText.text = "Нам нужны цифры!";
        }
        else
            resultText.text = "Сначала введите числа";
    }
}

