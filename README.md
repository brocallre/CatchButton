<img width="1926" height="1289" alt="스크린샷 2026-03-12 120449" src="https://github.com/user-attachments/assets/cc1af0e3-ff71-4411-a6fe-ac0ec2c54851" /># Catch_Button

## 개요
- C# Windows Forms 프로그래밍 학습 프로젝트
- 핵심기능: 마우스를 피해 도망가는 버튼을 클릭하여 점수를 획득하는 게임
- 화면구성: 도망가는 "나를 잡아봐" 버튼, "다시 시작" 버튼, 폼 제목에 점수/좌표 표시

## 게임 규칙
- 버튼 위에 마우스를 올리면 버튼이 랜덤 위치로 도망갑니다 (-10점)
- 버튼을 클릭하면 점수를 획득합니다 (+100점)
- 성공할수록 버튼이 작아져 난이도가 올라갑니다
- 20번 놓치면 Game Over!

## 실행 화면

### 1단계 - 기본 도망 기능
<img width="2041" height="1111" alt="스크린샷 2026-03-12 115336" src="https://github.com/user-attachments/assets/1274eb46-d7a4-46b8-8984-40a9b53249d3" />

### 2단계 - 시각적/청각적 피드백
도망갈 때마다 시스템 경고음 재생

### 3단계 - 점수 표시와 난이도 조정
<img width="1926" height="1289" alt="점수 이미지" src="https://github.com/user-attachments/assets/26290dd4-9f27-4f2a-86df-187111807e1d" />


### 4단계 - 게임 오버 및 리셋
<img width="1926" height="1289" alt="스크린샷 2026-03-12 120449" src="https://github.com/user-attachments/assets/60b2c5ab-33f7-4573-9c7a-f010c89c797a" />

## 구현 시 어려웠던 점
- 컨트롤의 좌표를 계산하는 것이 어려웠지만,
  폼의 ClientSize에서 버튼의 Width/Height를 빼서
  이동 범위를 제한하는 방식으로 해결했습니다.

- 버튼 크기 축소 시 너무 작아지면
  클릭이 불가능해지는 문제가 있었지만,
  최소 크기를 제한하여 해결했습니다.
