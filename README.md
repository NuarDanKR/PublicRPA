# PublicRPA
Public RPA(UiPath) source of Dongwon Construction Industry 
<br><br>


## 유류비 청구 서류 자동화(A04100)
2021.12~2021.12(1개월)
- 설명 링크 참조

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A04100
<br><br>


## 발주 임박일 알림(A04000)
2021.12~2021.12(1개월)
- MSSQL DB 연결 

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A04000
<br><br>


## 일용 근로자 노무 명세서 교부(A03800)
2021.11~2021.11(1개월)
- 설명 링크 참조

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03800
<br><br>




## 견적 입찰 내역 정리 및 DB화(A03700)
2021.11~2021.11(1개월)
- 설명 링크 참조

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03700
<br><br>


## 원인자 부담금 폐기물 처리비용 세금계산서 발행 자동화 (A03600)
2021.11~2021.11(1개월)
- 설명 링크 참조

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03600
<br><br>


## 현장 접수 문서 변환 (A03500)
2021.10~2021.11(1개월)
- 설명 추가 예정

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03500_v2
<br><br>


## 집합건물 채권 처리 (A03400)
2021.09~2021.09(1개월)
- 전자세금 계산서 발행한 미수금과 외상매출금을 선수금과 비교함
- 외상매출금과 미수금은 PM사업부의 리스트를 받아와 시행
- 선수금의 경우 건물 세입자가 입력한 통장 내역을 외상매출금, 미수금의 적요랑 비교
->Transaction의 슈퍼키 값이 없으므로 이름, 상호명, 건물명, 동, 호를 복합키로 만들어 비교
- 미수금(또는 외상매출금) 선수금의 키값과 가격이 같으면 SAP에서 상계처리
- 상계처리 되지 못한 목록은 담당자에게 메일 발송

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A3400
<br><br>


## 근재 증권 임박 알림 마감 SMS 안내 (A03300)
2021.10~2021.10(1개월)
- 현장별 협력업체의 근재 증권 DB를 가져옴
- 해당 업체가 첨부한 근재 증권 증빙 서류를 OCR로 내역 확인
- 해당 업체의 근재 만료일이 1달 이내로 도래 예정이면 SMS 발송

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03300
<br><br>


## 외주비 기성 현황 자료 정리 (A03201)
2021.08~2021.08(1개월)
- 동원 건설산업 자체 건설전용 ERP에서 외주비 기성 현황 자료를 Scarping
- 해당 DB를 양식에 맞게 엑셀 자동화 하여 정리

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03201
<br><br>

## 노무비 자료 취합 (A03200)
2021.08~2021.08(1개월)
- 동원 건설산업 자체 건설전용 ERP에서 노무비 관련 Excel 자료와 PDF 자료를 자동으로 다운받아서 취합후 담당자에게 메일 발송

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03200<br><br>
