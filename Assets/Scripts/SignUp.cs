using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class SignUp : MonoBehaviour
{
    public InputField idInput;
    public InputField nameInput;
    public InputField passwordInput;
    public InputField confirmPasswordInput;

    public GameObject popupObject;
    public GameObject signUpObject;
    public Text AlertText;

    public void OnClickButton()
    {
        string id = idInput.text;
        string name = nameInput.text;
        string password = passwordInput.text;
        string confirmPassword = confirmPasswordInput.text;

        if (!ValidateInputs(id, name, password, confirmPassword))
        {
            Debug.Log("회원가입 조건 부적합");
            popupObject.SetActive(!popupObject.activeSelf);

            return;
        }

        SignUpUser(id, name, password);
        signUpObject.SetActive(!signUpObject.activeSelf);
        popupObject.SetActive(!popupObject.activeSelf);
    }

    private bool ValidateInputs(string id, string name, string password, string confirmPassword)
    {
        // ID 검증
        if (!Regex.IsMatch(id, @"^[a-zA-Z0-9]{3,10}$")) { setAlertText("ID는 영어 숫자의 3~10글자가 가능합니다"); return false; }
        // 이름 검증
        if (name.Length < 2 || name.Length > 5) { setAlertText("이름은 2~5글자가 가능합니다"); return false; }
        // 암호 검증
        if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]{5,15}$")) { setAlertText("암호는 영어 숫자의 5~15글자가 가능합니다"); return false; }
        // 암호 재확인 검증
        if (password != confirmPassword) { setAlertText("암호 확인이 일치하지 않습니다"); return false; }
        // ID 중복 검증
        if (DataManager.Instance.Users.ContainsKey(id)) { setAlertText("이미 존재하는 ID입니다"); return false; }

        return true;
    }

    private void SignUpUser(string id, string name, string password)
    {
        // 사용자 데이터 생성 및 저장
        UserData newUser = new UserData(id, name, password, 100000, 50000);
        DataManager.Instance.Users.Add(id, newUser);
        DataManager.Instance.SaveUserData();

        setAlertText("회원가입이 완료되었습니다");
        Debug.Log($"{id} 회원가입 성공");
    }

    private void setAlertText(string alertMsg)
    {
        AlertText.text = alertMsg;
    }

}
