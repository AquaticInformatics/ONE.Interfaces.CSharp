# Changelog
All notable changes to this project will be documented in this file.

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
