using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField IdInput;
    public InputField passwordInput;

    public GameObject popupObject;
    public Text AlertText;

    private void Start()
    {
        DataManager.Instance.LoadUserData();    
    }

    public void OnClickButton()
    {
        string id = IdInput.text;
        string password = passwordInput.text;

        if (DataManager.Instance.Login(id, password))
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            AlertText.text = "로그인 실패";
            popupObject.SetActive(!popupObject.activeSelf);
        }
    }
}
