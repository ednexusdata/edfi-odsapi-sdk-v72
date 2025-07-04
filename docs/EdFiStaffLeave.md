# EdFi.OdsApi.Sdk.v72.Models.All.EdFiStaffLeave

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateOnly** | The begin date of the staff leave. | 
**StaffLeaveEventCategoryDescriptor** | **string** | The code describing the type of leave taken. | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**EndDate** | **DateOnly?** | The end date of the staff leave. | [optional] 
**Reason** | **string** | Expanded reason for the staff leave. | [optional] 
**SubstituteAssigned** | **bool?** | Indicator of whether a substitute was assigned during the period of staff leave. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StaffLeave entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

