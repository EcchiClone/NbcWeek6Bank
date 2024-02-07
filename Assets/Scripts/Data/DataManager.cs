// # 솔루션 : 유저 정보를 저장하고 불러오고 관리하기
// 1. 유저 정보의 저장과 불러오기
//   - 회원가입과 송금 기능을 구현하기 위해, 데이터 저장이 필요
//   - 사전형 형태의 저장 패턴이 마련되어 있는 json 방식 채택 -> 과제의 주어진 사양에 따라 PlayerPrefs 로 수정
// 2. 불러온 유저 정보의 관리
//   - 게임 시작 시, 저장된 유저 데이터 파일(ID, 이름, 암호, 현금, 계좌잔액)을 읽는다. 
//   - 로그인 성공 시, ID로부터 현재 유저 정보를 불러와 관리한다.(사전형 활용)
//   - 타인의 ID를 입력하여 송금을 한다.
//   - 데이터 관리의 로직들은 O(1)의 시간복잡도.
// 3. 이상의 모든 내용은 이곳 DataManager.cs에 구현하며, 싱글톤화하여 관리한다.

using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager
{
    private static DataManager instance;
    public static DataManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new DataManager();
            }
            return instance;
        }
    }

    public Dictionary<string, UserData> Users { get; private set; }
    public UserData curUser;

    private string filePath;

    private DataManager()
    {
        Users = new Dictionary<string, UserData>();
        filePath = Path.Combine(Application.dataPath, "userData.json");
    }

    public void SaveUserData() // 데이터 저장
    {
        UserDataList userDataList = new UserDataList { users = new List<UserData>(Users.Values) };
        string json = JsonUtility.ToJson(userDataList, true);
        PlayerPrefs.SetString("UsersData", json);
        PlayerPrefs.Save();
        Debug.Log("데이터 저장: " + json);
    }

    public void LoadUserData() // 데이터 로드
    {
        Users.Clear();
        if (PlayerPrefs.HasKey("UsersData"))
        {
            string json = PlayerPrefs.GetString("UsersData");
            UserDataList userDataList = JsonUtility.FromJson<UserDataList>(json);
            
            foreach (var userData in userDataList.users)
            {
                Users[userData.ID] = userData;
            }
            Debug.Log("데이터 로드: " + json);
        }
        else
        {
            Debug.Log("데이터 파일 존재하지 않음");
        }
    }

    public bool Login(string id, string password) // 로그인
    {
        Debug.Log($"{Users.Values.Count}");
        foreach (var user in Users.Values)
        {
            Debug.Log($"{user.ID}, {id}, {user.Password}, {password}");
            if (user.ID == id && user.Password == password)
            {
                curUser = Users[id];
                Debug.Log($"{id}로 로그인 성공");
                return true;
            }
        }
        Debug.Log("로그인 실패");
        return false;
    }

    public bool Deposit(int amount)  // 입금
    {
        if (curUser.PocketMoney >= amount)
        {
            curUser.PocketMoney -= amount;
            curUser.BankMoney += amount;
            SaveUserData();
            return true;
        }
        else
            return false;
    }

    public bool Withdraw(int amount) // 출금
    {
        if (curUser.BankMoney >= amount)
        {
            curUser.BankMoney -= amount;
            curUser.PocketMoney += amount;
            SaveUserData();
            return true;
        }
        else
            return false;
    }
    public bool Transfer(string toUserID, int amount) // 송금
    {
        if (Users.ContainsKey(toUserID) && curUser.BankMoney >= amount && (curUser.ID!=toUserID))
        {
            curUser.BankMoney -= amount;
            Users[toUserID].BankMoney += amount;
            SaveUserData();
            return true;
        }
        else
            return false;
    }

    public void Logout() // 추가기능 : 로그아웃
    {
        SaveUserData();
        curUser = null;
    }

    public void PrepareTestUsers() // 테스트기능 : 테스트 유저 준비
    {
        for (int i = 0; i < 4; i++)
        {
            string userId = $"test{i}";
            UserData newUser = new UserData(
                userId, // ID
                $"테스트{i}", // Username
                "000000", // Password
                100000, // PocketMoney
                50000 // BankMoney
            );

            // 이미 존재하는 ID라면 덮어쓰기
            Users[userId] = newUser;
        }

        SaveUserData();
    }
}
