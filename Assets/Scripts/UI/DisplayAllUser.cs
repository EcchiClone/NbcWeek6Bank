using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAllUser : MonoBehaviour
{
    public Text displayText;

    public void OnclickButton()
    {
        string datas = "ID, Name, Pass, Pocket$, Bank$\n";
        foreach (KeyValuePair<string, UserData> userEntry in DataManager.Instance.Users)
        {
            UserData user = userEntry.Value;
            datas += $"{user.ID}, {user.Username}, {user.Password}, {user.PocketMoney}, {user.BankMoney}\n";
        }
        displayText.text = datas;
    }
}
