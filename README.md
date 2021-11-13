# PublicRPA
Public RPA(UiPath) source of Dongwon Construction Industry 
<br>
<br>
## 근재 증권 임박 알림 마감 SMS 안내
2021.10~2021.10(1개월)
- 현장별 협력업체의 근재 증권 DB를 가져옴
- 해당 업체가 첨부한 근재 증권 증빙 서류를 OCR로 내역 확인
- 해당 업체의 근재 만료일이 1달 이내로 도래 예정이면 SMS 발송

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03300%20%EA%B7%BC%EC%9E%AC%20%EB%AF%B8%EB%B9%84%20%EC%95%8C%EB%9E%8C
<br><br>

## 집합건물 채권 처리
2021.09~2021.09(1개월)
- 전자세금 계산서 발행한 미수금과 외상매출금을 선수금과 비교함
- 외상매출금과 미수금은 PM사업부의 리스트를 받아와 시행
- 선수금의 경우 건물 세입자가 입력한 통장 내역을 외상매출금, 미수금의 적요랑 비교
->Transaction의 슈퍼키 값이 없으므로 이름, 상호명, 건물명, 동, 호를 복합키로 만들어 비교
- 미수금(또는 외상매출금) 선수금의 키값과 가격이 같으면 SAP에서 상계처리
- 상계처리 되지 못한 목록은 담당자에게 메일 발송

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A3400%20%EC%A7%91%ED%95%A9%EA%B1%B4%EB%AC%BC%20%EC%B1%84%EA%B6%8C%20%EC%B2%98%EB%A6%AC
<br><br>

## 외주비 기성 현황 자료 정리
2021.08~2021.08(1개월)
- 동원 건설산업 자체 건설전용 ERP에서 외주비 기성 현황 자료를 Scarping
- 해당 DB를 양식에 맞게 엑셀 자동화 하여 정리

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03201%20%EC%99%B8%EC%A3%BC%EB%B9%84%20%EC%A0%95%EB%A6%AC
<br><br>

## 노무비 자료 취합
2021.08~2021.08(1개월)
- 동원 건설산업 자체 건설전용 ERP에서 노무비 관련 Excel 자료와 PDF 자료를 자동으로 다운받아서 취합후 담당자에게 메일 발송

GitHub 링크:
https://github.com/NuarDanKR/PublicRPA/tree/main/A03200_노무비_현황<br><br>
