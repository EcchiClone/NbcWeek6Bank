// # 솔루션 : 유저 정보를 저장하고 불러오고 관리하기
// 1. 유저 정보의 저장과 불러오기
//   - 회원가입과 송금 기능을 구현하기 위해, 데이터 저장이 필요
//   - 사전형 형태의 저장 패턴이 마련되어 있는 json 방식 채택
// 2. 불러온 유저 정보의 관리
//   - 게임 시작 시, json 파일을 읽는다.
//   - 로그인 시, 읽은 json 파일과 비교( (이름, 패스워드), ID )하여 이후 ID를 참조한 유저 정보(ID, 계좌번호, 이름, 현금, 계좌잔액)의 관리를 한다.
//   - 송금 시, 계좌번호를 통한(계좌번호, ID) 송금을 한다.(이름은 중복 가능하기 때문)
//   - 여기까지, 총 필요한 사전형 변수의 갯수는 3개.
// 3. 이상의 모든 내용은 이곳 DataManager.cs에 구현하며, 싱글톤화하여 관리한다.

//using System.Collections.Generic;
//using System.IO;
//using UnityEngine;

//[System.Serializable]
//public class SaveData
//{
//    public List<string> testDataA = new List<string>();
//    public List<int> testDataB = new List<int>();

//    public int gold;
//    public int power;
//}

//public class DataManager : MonoBehaviour
//{
//    string path;

//    void Start()
//    {
//        path = Path.Combine(Application.dataPath, "database.json");
//        JsonLoad();
//    }

//    public void JsonLoad()
//    {
//        SaveData saveData = new SaveData();

//        if (!File.Exists(path))
//        {
//            GameManager.instance.playerGold = 100;
//            GameManager.instance.playerPower = 4;
//            JsonSave();
//        }
//        else
//        {
//            string loadJson = File.ReadAllText(path);
//            saveData = JsonUtility.FromJson<SaveData>(loadJson);

//            if (saveData != null)
//            {
//                for (int i = 0; i < saveData.testDataA.Count; i++)
//                {
//                    GameManager.instance.testDataA.Add(saveData.testDataA[i]);
//                }
//                for (int i = 0; i < saveData.testDataB.Count; i++)
//                {
//                    GameManager.instance.testDataB.Add(saveData.testDataB[i]);
//                }
//                GameManager.instance.playerGold = saveData.gold;
//                GameManager.instance.playerPower = saveData.power;
//            }
//        }
//    }

//    public void JsonSave()
//    {
//        SaveData saveData = new SaveData();

//        for (int i = 0; i < 10; i++)
//        {
//            saveData.testDataA.Add("테스트 데이터 no " + i);
//        }

//        for (int i = 0; i < 10; i++)
//        {
//            saveData.testDataB.Add(i);
//        }

//        saveData.gold = GameManager.instance.playerGold;
//        saveData.power = GameManager.instance.playerPower;

//        string json = JsonUtility.ToJson(saveData, true);

//        File.WriteAllText(path, json);
//    }
//}