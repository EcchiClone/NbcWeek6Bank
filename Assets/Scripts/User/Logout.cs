using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logout : MonoBehaviour
{
    public void OnClickButton()
    {
        DataManager.Instance.Logout();
        SceneManager.LoadScene("Login");
    }
}
