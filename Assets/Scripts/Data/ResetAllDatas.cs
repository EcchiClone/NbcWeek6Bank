using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAllDatas : MonoBehaviour
{
    public void OnClickButton()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        DataManager.Instance.LoadUserData();

        Debug.Log("모든 데이터 초기화 완료");
    }
}
