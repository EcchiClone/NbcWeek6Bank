using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transfer : MonoBehaviour
{
    private string transferTo;
    private int amount;

    public InputField transferToInput;
    public InputField amountInput;

    public GameObject[] goSuccess;
    public GameObject popupObject;
    public Text AlertText;

    public DisplayText displayTextManager;
    public void OnClickButton()
    {
        transferTo = transferToInput.text;
        amount = int.Parse(amountInput.text);

        if (DataManager.Instance.Transfer(transferTo, amount))
        {
            displayTextManager.RenewDisplay();
            AlertText.text = $"{DataManager.Instance.Users[transferTo].Username}에게 {amount.ToString("N0")}원을 송금했습니다.";
            foreach (GameObject go in goSuccess)
                go.SetActive(!go.activeSelf);
            return;
        }

        AlertText.text = "계좌 잔금 혹은 송금 대상의 아이디를 확인하세요.";
        popupObject.SetActive(!popupObject.activeSelf);
    }
}
