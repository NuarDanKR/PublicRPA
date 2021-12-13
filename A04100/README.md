# A04100
## 기술적 설명
### Init
1. Google Froms 연결 Spread Sheet 주소 접속
2. 로그인 여부 파악 (Get Attribute)
3. I/O Folder에 목록 저장

### Set Transaction Data
1. Init에서 가져온 파일 -> DT_RawData
2. DT_RawData에서 사번 Column만 추출
3. 추출된 사번 중복 제거
 + 사번 <=> Transaction

### Process Transaction
1. 사번(한 사람)이 하나의 Transaction이므로
2. DT_RawData에서 row를 해당되는 사번만 Filter -> DT_ToDo
3. DT_ToDo를 For each row로 반복
4. row의 링크 접속(네이버 지도)
5. 지도의 출발지, 경유지, 도착지 row 수 파악 -> location_num
6. loaction_num 수 -> 작성할 row 생성
---
   
### Documentation is included in the Documentation folder ###

[ReFrameWork Documentation](https://github.com/UiPath/ReFrameWork/blob/master/Documentation/REFramework%20documentation.pdf)

### ReFrameWork Template ###
**Robotic Enterprise Framework**

* built on top of *Transactional Business Process* template
* using *State Machine* layout for the phases of automation project
* offering high level exception handling and application recovery
* keeps external settings in *Config.xlsx* file and Orchestrator assets
* pulls credentials from *Credential Manager* and Orchestrator assets
* gets transaction data from Orchestrator queue and updates back status
* takes screenshots in case of application exceptions
* provides extra utility workflows like sending a templated email
* runs sample Notepad application with dummy Excel input data
* 


### How It Works ###

1. **INITIALIZE PROCESS**
 + *InitiAllSettings* - Load config data from file and from assets
 + *InitiAllApplications* - Login to applications as per Config("OpenApps") field
   + *GetAppCredentials* - From Orchestrator assets or local Credential Manager
 + If failing, retry a few times as per Config("ProcessRetries")

2. **GET TRANSACTION DATA**
   + ./Framework/*GetTransactionData* - Fetches from Orchestrator queue as per Config("TransactionQueue")
   + ./*GetTransactionData* - Sample for working with Excel input files

3. **PROCESS TRANSACTION**
 + Try *ProcessTransaction*
 + If application exceptions happen
   + *SaveErrorScreen* - In Config("ErrorsFolder") with the exception message
   + Going to re/INITIALIZE
 + *SetTransactionStatus* - As Success, Failed or Rejected with reason
   + ./Framework/*SetTransactionStatus* - Updates the Orchestrator queue item
   + ./*SetTransactionStatus* - Sample for updating Excel input file

4. **END PROCESS**
 + *CloseAllApplications* - As listed in Config("CloseApps")


### For New Project ###

1. Check out the Config.xlsx file and add/customize any required fields and values
2. Implement OpenApp and CloseApp workflows, linking them in the Config.xlsx fields
3. Implement GetTransactionData and SetTransactionStatus or use ./Framework versions for Orchestrator queues
4. Implement ProcessTransaction workflow and any invoked others
