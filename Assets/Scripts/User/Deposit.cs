using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deposit : MonoBehaviour
{
    [SerializeField] private int amount;
    [SerializeField] private bool useAmountInput;
    public InputField amountInput;

    public GameObject[] goSuccess;
    public GameObject popupObject;
    public Text AlertText;

    public DisplayText displayTextManager;
    public void OnClickButton()
    {
        if (useAmountInput)
            amount = int.Parse(amountInput.text);

        if (DataManager.Instance.Deposit(amount))
        {
            displayTextManager.RenewDisplay();
            foreach (GameObject go in goSuccess)
                go.SetActive(!go.activeSelf);
            return;
        }

        AlertText.text = "현금이 부족합니다.";
        popupObject.SetActive(!popupObject.activeSelf);
    }
}
