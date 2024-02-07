using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Withdraw : MonoBehaviour
{
    [SerializeField] private int amount;

    public InputField amountInput;

    public GameObject[] goSuccess;
    public GameObject popupObject;
    public Text AlertText;

    public DisplayText displayTextManager;
    public void OnClickButton()
    {
        if (amount < 1)
            amount = int.Parse(amountInput.text);

        if (DataManager.Instance.Withdraw(amount))
        {
            displayTextManager.RenewDisplay();
            foreach (GameObject go in goSuccess)
                go.SetActive(!go.activeSelf);
            return;
        }

        AlertText.text = "계좌 잔금이 부족합니다.";
        popupObject.SetActive(!popupObject.activeSelf);
    }
}
