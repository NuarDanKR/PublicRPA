#  노무비 현황 자료 취합 RPA

* 프로세스 설명: 동원 건설산업 자체 건설전용 ERP에서 노무비 관련 Excel 자료와 PDF 자료를 자동으로 다운받아서 취합후 담당자에게 메일 발송

* AS-IS : 18 Hrs/Yr
* TO-BE : 0 Hrs/Yr

* Dependencies
  * Activities
    * Donwong Common Libraries
    * Excel Activities
    * JAVA Bridge
  * Application Programmes
    * i-COD 2.0 (동원 건설 자체 개발 ERP , JAVA)

- Designed By Nuar

- 동원 건설산업 자체 건설전용 ERP에서 노무비 관련 Excel 자료와 PDF 자료를 자동으로 다운받아서 취합후 담당자에게 메일 발송




---
## FrameWokr Explanation

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
