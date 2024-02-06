// Toggle.cs 는 goArray에 부착된 모든 오브젝트들을 토글한다.
// 참고사항 : Toggle.cs를 컴포넌트로 갖고있는 오브젝트를 foreach의 첫 반복으로 비활성화 한 후
//            이후 반복에서 다른 오브젝트들을 토글한다 하여도
//            메서드가 종료될 때 까지 해당 메서드가 중단되는 일은 없으니 안심.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject[] goArray;

    public void OnClickButton()
    {
        foreach (GameObject go in goArray)
            go.SetActive(!go.activeSelf);
    }
}
