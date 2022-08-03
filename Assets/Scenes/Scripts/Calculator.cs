using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private Text resultText;
    [SerializeField] private InputField firstNumberField;
    [SerializeField] private InputField secondNumberField;
    private float firstNumber = 1;
    private float secondNumber = 1;
    private float result = 0;

    public void Addition()
    {
        if (firstNumberField.text.Length != 0 && secondNumberField.text.Length != 0)
        {
            bool successFirst = float.TryParse(firstNumberField.text, out firstNumber);
            bool successSecond = float.TryParse(secondNumberField.text, out secondNumber);
            if (successFirst && successSecond)
            {
                result = firstNumber + secondNumber;
                resultText.text = result.ToString();
            }
            else
                resultText.text = "��� ����� �����!";
        }
        else
            resultText.text = "������� ������� �����";
    }
    public void Subtraction()
    {
        if (firstNumberField.text.Length != 0 && secondNumberField.text.Length != 0)
        {
            bool successFirst = float.TryParse(firstNumberField.text, out firstNumber);
            bool successSecond = float.TryParse(secondNumberField.text, out secondNumber);
            if (successFirst && successSecond)
            {
                result = firstNumber - secondNumber;
                resultText.text = result.ToString();
            }
            else
                resultText.text = "��� ����� �����!";
        }
        else
            resultText.text = "������� ������� �����";
    }
    public void Multiplication()
    {
        if (firstNumberField.text.Length != 0 && secondNumberField.text.Length != 0)
        {
            bool successFirst = float.TryParse(firstNumberField.text, out firstNumber);
            bool successSecond = float.TryParse(secondNumberField.text, out secondNumber);
            if (successFirst && successSecond)
            {
                result = firstNumber * secondNumber;
                resultText.text = result.ToString();
            }
            else
                resultText.text = "��� ����� �����!";
        }
        else
            resultText.text = "������� ������� �����";
    }
    public void Division()
    {
        if (firstNumberField.text.Length != 0 && secondNumberField.text.Length != 0)
        {
            bool successFirst = float.TryParse(firstNumberField.text, out firstNumber);
            bool successSecond = float.TryParse(secondNumberField.text, out secondNumber);
            if (successFirst && successSecond)
            {
                if (secondNumber == 0)
                    resultText.text = "�� ���� ������ ������!";
                else
                {
                    result = firstNumber / secondNumber;
                    resultText.text = result.ToString();
                }
            }
            else
                resultText.text = "��� ����� �����!";
        }
        else
            resultText.text = "������� ������� �����";
            
    }
}
