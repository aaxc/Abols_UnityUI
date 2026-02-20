using TMPro;
using UnityEngine;
using System;

public class CalculateName : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField birthYearInput;
    [SerializeField] private TMP_Text resultText;

    private void Awake()
    {
        birthYearInput.contentType = TMP_InputField.ContentType.IntegerNumber;

        nameInput.onEndEdit.AddListener(_ => Calculate());
        birthYearInput.onEndEdit.AddListener(_ => Calculate());
    }

    private void Calculate()
    {
        string playerName = nameInput.text;

        if (!int.TryParse(birthYearInput.text, out int birthYear))
        {
            resultText.text = "";
            return;
        }

        int currentYear = DateTime.Now.Year;

        int age = currentYear - birthYear;

        // Robot could be from future, so negative age is possible. We will just show it as is!
        // Otherwise we could add if (!age) { age = "" } or similair to hide it

        resultText.text = $"{playerName} {age}";
    }
}
