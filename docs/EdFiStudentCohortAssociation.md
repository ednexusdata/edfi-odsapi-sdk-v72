# EdFi.OdsApi.Sdk.v72.Models.All.EdFiStudentCohortAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateOnly** | The month, day, and year on which the student was first identified as part of the cohort. | 
**CohortReference** | [**EdFiCohortReference**](EdFiCohortReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EndDate** | **DateOnly?** | The month, day, and year on which the student was removed as part of the cohort. | [optional] 
**Sections** | [**List&lt;EdFiStudentCohortAssociationSection&gt;**](EdFiStudentCohortAssociationSection.md) | An unordered collection of studentCohortAssociationSections. The cohort representing the subdivision of students within one or more sections. For example, a group of students may be given additional instruction and tracked as a cohort. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentCohortAssociation entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

