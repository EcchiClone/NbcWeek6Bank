using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareTestUsers : MonoBehaviour
{
    public void OnClickButton()
    {
        DataManager.Instance.PrepareTestUsers();
        Debug.Log("테스트 유저 준비 완료");
    }
}
