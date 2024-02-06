using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using Unity.VisualScripting;

public class InputValidator : MonoBehaviour
{
    public InputField inputField;
    public bool numberInputAllowed;
    public bool alphabetInputAllowed;

    void Start()
    {
        // 입력값이 변경될 때마다 ValidateInput 메서드를 호출
        inputField.onValueChanged.AddListener(ValidateInput);
    }

    void ValidateInput(string input)
    {
        string pattern = "";

        // 숫자와 알파벳 입력 가능 여부에 따라 정규식 패턴을 조정
        if (numberInputAllowed && alphabetInputAllowed) pattern = @"[^a-zA-Z0-9]";
        else if (numberInputAllowed)                    pattern = @"[^0-9]";
        else if (alphabetInputAllowed)                  pattern = @"[^a-zA-Z]";
        else                                            { inputField.text = ""; return; }

        string replacement = "";
        string result = Regex.Replace(input, pattern, replacement);

        if (inputField.text != result)
        {
            inputField.text = result;
            // 커서 위치를 입력 문자열의 끝으로 설정
            inputField.caretPosition = inputField.text.Length;
        }
    }
}
