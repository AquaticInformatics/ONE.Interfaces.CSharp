# Changelog
All notable changes to this project will be documented in this file.

## Version 4.35.0 - 2023-10-04
### Added
- Historian Data Ingest data source entry to EnumDataSource
- DelaySeconds added to DataSourceBinding

## Version 4.34.0 - 2023-10-03
### Added
- WIMS Computation entry to EnumDataSource

## Version 4.33.0 - 2023-08-24
### Added
- ReportDefinitionCategoryTenant entry to EnumReportDefinitionCategory

## Version 4.32.0 - 2023-08-23
### Added
- WIMS entry to EnumDataSource and EnumDomainSource

## Version 4.31.0 - 2023-08-07
### Changed
- Removed QueryParameters from ReportDefinitionJsonV2 protobuf

## Version 4.30.0 - 2023-07-31
### Added
- Added ReportDefinitionJsonV2 protobuf

## Version 4.29.0 - 2023-07-19
### Changed
- Removed Users, Report Runs, Tenant, and Dashboards from Operation Export Protobuf
- Changed WorksheetDefinition to WorksheetDefinitions (plural) in Operation Export Protobuf

## Version 4.28.0 - 2023-06-28
### Added
- Operation Export Protobuf
- LastLoginDateUTC On User Protobuf

## Version 4.27.0 - 2023-06-16
### Added
- EnumTimeContext
- TimeContext
### Changed
- Added contextType and twinRefId to JsonTicksDateTime

## Version 4.26.0 - 2023-05-15
### Changed
- Added requestId, numberOfExecutions and cellKey to OutputCellBackup
- Added stringValue, timestamp and cellKey to CellValueBackup
- Added CellValueBackups and OutputCellBackups to Content

## Version 4.25.0 - 2023-05-09
### Added
- Added constant ClientIngestCloudServiceSubType

## Version 4.24.0 - 2023-05-02
### Added
- Added SignalR OneHub models

## Version 4.23.0 - 2023-04-28
### Added
- Added protobuf types for Historian Ingest
- Deprecate ONE.Models.CSharp.Enums.EnumLogLevel

## Version 4.22.1 - 2023-04-21
### Fixed
- Resolved missing models issue in previous two releases

## Version 4.22.0 - 2023-04-17
### Added
- Added TakeCurrentAndNext to EnumCellRangeAction

## Version 4.21.0 - 2023-04-14
### Added
- Created ReportRun and ReportRuns protobuf 
- Integrated ReportRuns into content.proto

## Version 4.20.0 - 2023-04-13
### Added
- Added ReportableQualifierDefinitions

## Version 4.19.0 - 2023-04-04
### Added
- DoubleEntered to EnumReportableQualifierDefinition
- EnteredOrConstant to EnumReportableQualifierDefinition

## Version 4.18.0
### Added
- Add ReportRendered to protobuf type ReportDefinitionRun 

## Version 4.17.0
### Added
- Added Version, TenantId to protobuf type ReportDefinition

## Version 4.16.0 
### Added
- Update QueryParameters Protobuf to include plurals

## Version 4.15.0
### Added
- Added EnterpriseDataSetDefinition.queryParameters

## Version 4.14.0 - 2023-02-17
### Added 
- EnumDataSource.DATASOURCE_SAMPLE_MANAGER
- EnumSamplingStatistic.SAMPLING_STATISTIC_FIRST
- EnumSamplingStatistic.SAMPLING_STATISTIC_LAST
### Deprecated
- EnumSamplingStatistic.SAMPLING_STATISTIC_24_HOUR_COMPOSITE
- EnumSamplingStatistic.SAMPLING_STATISTIC_CALCULATION
- EnumSamplingStatistic.SAMPLING_STATISTIC_LAB_DATA_TRANSFER
- EnumSamplingStatistic.SAMPLING_STATISTIC_LABORATORY_REPORT
- EnumSamplingStatistic.SAMPLING_STATISTIC_FIELD_TEST
		
## Version 4.13.0 - 2023-02-02
### Added
- Take_Special to EnumCellRangeAction

## Version 4.12.0 - 2023-01-30
### Added
- Column.DisplayOptions

## Version 4.11.0 - 2023-01-12
### Added
- Grouping field to ComputationVariableBinding

## Version 4.10.0-alpha - 2022-12-06
### Added
- EnterpriseDataSourceDefinition
- EnterpriseDataTableQueryParameter
- EnterpriseDataTableQuery
- EnterpriseDataTableField
- EnterpriseDataTableDefinition
- EnterpriseDataSetDefinition

## Version 4.9.0 - 2022-11-21
### Added
- Models and Constants from ClientSDK

## Version 4.8.0 - 2022-11-17
### Added
- ConfigurationNote - added Geography field

## Version 4.7.1 - 2022-08-08
Remove
- ScheduleId from ScheduleOccurrence

## Version 4.7.0 - 2022-08-02
### Added
- Analyte collection to TestAnalyteGroup
### Remove
- TestAnalyteGroupItem

## Version 4.6.0 - 2022-07-20
### Added
- Analyte
- TestAnalyteGroup
- TestAnalyteGroupItem

## Version 4.5.0 - 2022-07-11
### Added
- ScheduleRecurrencePattern

## Version 4.4.0 - 2022-06-24
### Added
- ConfigurationNotes
- ConfigurationTags

## Version 4.3.0 - 2022-06-06
### Changed
- Schedule - updated fields
- ScheduleType - updated fields
- Content - allow ScheduleOccurrences to be returned through API

### Added
- ScheduleOccurrence

## Version 4.2.0 - 2022-05-11
### Added
- Nullable entry to EnumVariableType
- TakeAny entry to EnumCellRangeAction
- ErrorMessage field to Variable model

## Version 4.1.0 - 2022-04-25
### Changed
- Activity.Prioritycode to int from EnumActivityPriority
- Activity.StatusCode to int from EnumActivityStatus
### Removed
- EnumActivityPriority
- EnumActivityStatus

## Version 4.0.0 - 2022-04-20
### Added
- New Activity models
### Removed
- Old models related to Activities

## Version 3.0.0
### Added
- Regulatory, Warning, Goal to EnumLimit
### Removed
- Id field from HistorianData model

## Version 2.5.1
### Added
- HistorianDatas to content

## Version 2.5.0
### Added
- New HistorianData model

## Version 2.4.0
### Added
- New fields to Configuration model

## Version 2.3.0
### Added
- I18N properties to notification template

## Version 2.2.0
### Added
- notificationFlag to limit model

## Version 2.1.1
### Added
- Terms and Conditions fields back to user model

## Version 2.1.0
### Added
- Schedule and ScheduleType models

## Version 2.0.0
### Added
- MIT license
### Changed
- All models moved to ONE.Models.CSharp namespace
