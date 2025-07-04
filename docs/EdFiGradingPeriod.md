# EdFi.OdsApi.Sdk.v72.Models.All.EdFiGradingPeriod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**GradingPeriodDescriptor** | **string** | The state&#39;s name of the period for which grades are reported. | 
**GradingPeriodName** | **string** | The school&#39;s descriptive name of the grading period. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | 
**BeginDate** | **DateOnly** | Month, day, and year of the first day of the grading period. | 
**EndDate** | **DateOnly** | Month, day, and year of the last day of the grading period. | 
**PeriodSequence** | **int?** | The sequential order of this period relative to other periods. | [optional] 
**TotalInstructionalDays** | **int** | Total days available for educational instruction during the grading period. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the GradingPeriod entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

