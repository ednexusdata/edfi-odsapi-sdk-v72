# EdFi.OdsApi.Sdk.v72.Models.All.EdFiStaffProgramAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateOnly** | Start date for the association of staff to this program. | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**EndDate** | **DateOnly?** | End date for the association of staff to this program. | [optional] 
**StudentRecordAccess** | **bool?** | Indicator of whether the staff has access to the student records of the program per district interpretation of FERPA and other privacy laws, regulations, and policies. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StaffProgramAssociation entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

