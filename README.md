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
 
## 애플리케이션 구동 화면(시간 순서)

![bandicam 2024-02-07 10-53-27-497](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/86e7619e-2679-43c6-8d38-c25d4c5190bb)

![bandicam 2024-02-07 10-53-39-924](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/33d266dd-c83a-4588-9cd4-92d88a53d2e1)

![bandicam 2024-02-07 10-54-03-026](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/4f257725-577c-4b5f-9303-cc9054192b57)

![bandicam 2024-02-07 10-54-14-457](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/2570fe81-bf76-4f07-9db6-98bb42fcd3ee)

![bandicam 2024-02-07 10-54-50-180](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/84e0fb17-ee5a-412d-93aa-30df0cb2d4f1)

![bandicam 2024-02-07 10-54-57-789](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/b6bc859f-f33f-4cd9-a552-82edc5225cea)

![bandicam 2024-02-07 10-55-34-468](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/a728a783-a207-424a-91c5-5a2c42a7baeb)

![bandicam 2024-02-07 10-55-40-038](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/d711df20-6191-4eea-a302-e1e02f7ff2b5)

![bandicam 2024-02-07 10-55-49-123](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/42f1d250-0909-4a3a-a796-3af71221ce7c)

![bandicam 2024-02-07 10-55-54-225](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/bedd6945-a061-43fb-a530-e85b36d9394a)

![bandicam 2024-02-07 10-56-21-435](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/94ee621d-6e03-455e-b809-aa3acd2ed391)

![bandicam 2024-02-07 10-56-26-227](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/f39dda61-3f9f-4fd6-9088-cd6d320491e5)

![bandicam 2024-02-07 10-56-44-475](https://github.com/EcchiClone/NbcWeek6Bank/assets/21221633/b60c9951-b8da-4fb1-9894-0f810d19d574)

