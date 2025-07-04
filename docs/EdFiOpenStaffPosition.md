# EdFi.OdsApi.Sdk.v72.Models.All.EdFiOpenStaffPosition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**RequisitionNumber** | **string** | The number or identifier assigned to an open staff position, typically a requisition number assigned by Human Resources. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**AcademicSubjects** | [**List&lt;EdFiOpenStaffPositionAcademicSubject&gt;**](EdFiOpenStaffPositionAcademicSubject.md) | An unordered collection of openStaffPositionAcademicSubjects. The teaching field required for the open staff position. | [optional] 
**DatePosted** | **DateOnly** | Date the open staff position was posted. | 
**DatePostingRemoved** | **DateOnly?** | The date the posting was removed or filled. | [optional] 
**EmploymentStatusDescriptor** | **string** | Reflects the type of employment or contract desired for the position. | 
**InstructionalGradeLevels** | [**List&lt;EdFiOpenStaffPositionInstructionalGradeLevel&gt;**](EdFiOpenStaffPositionInstructionalGradeLevel.md) | An unordered collection of openStaffPositionInstructionalGradeLevels. The set of grade levels for which the position&#39;s assignment is responsible. | [optional] 
**PositionTitle** | **string** | The descriptive name of an individual&#39;s position. | [optional] 
**PostingResultDescriptor** | **string** | Indication of whether the OpenStaffPosition was filled or retired without filling. | [optional] 
**ProgramAssignmentDescriptor** | **string** | The name of the program for which the open staff position will be assigned. | [optional] 
**StaffClassificationDescriptor** | **string** | The titles of employment, official status, or rank of education staff. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the OpenStaffPosition entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

