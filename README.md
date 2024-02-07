# NbcWeek6Bank
**내일배움캠프 6주차 개인과제 : 간단한 ATM 기능 구현**

## 요구사항(기능구현 완료) 목록
- ATM 화면 구성
- 입금 기능
- 출금 기능
- 통화 단위 적용 (난이도 - ★☆☆☆☆)
- 금액 입력시 숫자만 입력 (난이도 - ★☆☆☆☆)
- 로그인 기능 (난이도 - ★★☆☆☆)
- 회원가입 (난이도 - ★★★★☆)
- 송금 기능 (난이도 - ★★★★☆)

## 추가기능 목록
- 금액 입력이 음의 값을 갖지 않도록 한다.
- 뒤로가기 : 로그인 화면으로
- (TEST)모든유저 확인 : 준비된 디스플레이에 표시
- (TEST)데이터 초기화 : 모든 유저 정보 삭제
- (TEST)테스트 유저 준비 : test0 ~ test3 유저를 생성(이미 존재 시 초기화)

## 데이터 관리
- DataManager.cs
  - Monobehavior을 상속받지 않는 싱글톤 형태로, 어플리케이션 실행 도중 전반적인 데이터 관리의 역할
- UserData.cs
  - 유저의 데이터는 클래스 UserData의 형태로 아래와 같은 필드를 가진다.
    - ID
    - Username
    - Password
    - PocketMoney
    - BankMoney
  - PlayerPrefs으로 저장하기 위해, UserData를 List화 한다.
 
  ## 애플리케이션 구동 화면

  ![image](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/06e72e9f-021e-4627-a247-229257e6dcc9)

  ![image](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/51e0ace8-a117-413e-aea5-cf6626eb8f83)

