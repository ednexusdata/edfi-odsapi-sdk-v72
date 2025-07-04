# EdFi.OdsApi.Sdk.v72.Models.All.EdFiCrisisEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**CrisisEventName** | **string** | The name of the crisis event that occurred. If there is no generally accepted name for this crisis event, the suggested format: Location + Crisis type + Year. | 
**CrisisDescription** | **string** | Provides a textual description of the crisis event affecting the student. It may include details such as the nature of the crisis (e.g., natural disaster, conflict, medical emergency), its severity, location, and any other relevant information describing the crisis situation. | [optional] 
**CrisisEndDate** | **DateOnly?** | The date on which the crisis ceased to affect the student. | [optional] 
**CrisisStartDate** | **DateOnly?** | The year, month and day on which the crisis affected the student. This date may not be the same as the date the crisis occurred if evacuation orders are implemented in anticipation of a crisis. | [optional] 
**CrisisTypeDescriptor** | **string** | The type or category of crisis. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the CrisisEvent entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

