using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public string ID;
    public string Username;
    public string Password;
    public int PocketMoney;
    public int BankMoney;

    public UserData(string id, string username, string password, int pocketMoney, int bankMoney)
    {
        ID = id;
        Username = username;
        Password = password;
        PocketMoney = pocketMoney;
        BankMoney = bankMoney;
    }
}

[System.Serializable]
public class UserDataList // UserData 객체의 리스트를 관리
{
    public List<UserData> users = new List<UserData>();
}
