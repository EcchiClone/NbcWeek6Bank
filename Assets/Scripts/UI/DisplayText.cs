using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    [Header("User Information")]
    public Text Username_Text;
    public Text PocketMoney_Text;
    public Text BankMoney_Text;

    void Start()
    {
        RenewDisplay();
    }

    public void RenewDisplay()
    {
        Username_Text.text = DataManager.Instance.curUser.Username;
        PocketMoney_Text.text = DataManager.Instance.curUser.PocketMoney.ToString("N0");
        BankMoney_Text.text = DataManager.Instance.curUser.BankMoney.ToString("N0");
    }
}
