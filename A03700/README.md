# 견적 입찰 이력 정리

## 설명
* 동원 건설의 결재 기안문을 정리하여 DB화 하는 작업
* 결재 기안문 형식은 통일이 되어있지 않고, 2~3가지 형태를 바꿔서 사용함
* 현장에 맞는 양식을 사용하며 입찰 횟수마다 TABLE 형태가 다름 (Column 수 상이)
* 이를 하나로 통일해서 취합하고 누적된 DB를 만드는 RPA

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
