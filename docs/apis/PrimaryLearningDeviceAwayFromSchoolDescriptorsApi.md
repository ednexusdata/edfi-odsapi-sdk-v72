# EdFi.OdsApi.Sdk.v72.Apis.All.PrimaryLearningDeviceAwayFromSchoolDescriptorsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.2/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePrimaryLearningDeviceAwayFromSchoolDescriptorById**](PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.md#deleteprimarylearningdeviceawayfromschooldescriptorbyid) | **DELETE** /ed-fi/primaryLearningDeviceAwayFromSchoolDescriptors/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesPrimaryLearningDeviceAwayFromSchoolDescriptors**](PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.md#deletesprimarylearningdeviceawayfromschooldescriptors) | **GET** /ed-fi/primaryLearningDeviceAwayFromSchoolDescriptors/deletes | Retrieves deleted resources based on change version. |
| [**GetPrimaryLearningDeviceAwayFromSchoolDescriptors**](PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.md#getprimarylearningdeviceawayfromschooldescriptors) | **GET** /ed-fi/primaryLearningDeviceAwayFromSchoolDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetPrimaryLearningDeviceAwayFromSchoolDescriptorsById**](PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.md#getprimarylearningdeviceawayfromschooldescriptorsbyid) | **GET** /ed-fi/primaryLearningDeviceAwayFromSchoolDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptors**](PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.md#keychangesprimarylearningdeviceawayfromschooldescriptors) | **GET** /ed-fi/primaryLearningDeviceAwayFromSchoolDescriptors/keyChanges | Retrieves resources key changes based on change version. |
| [**PostPrimaryLearningDeviceAwayFromSchoolDescriptor**](PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.md#postprimarylearningdeviceawayfromschooldescriptor) | **POST** /ed-fi/primaryLearningDeviceAwayFromSchoolDescriptors | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutPrimaryLearningDeviceAwayFromSchoolDescriptor**](PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.md#putprimarylearningdeviceawayfromschooldescriptor) | **PUT** /ed-fi/primaryLearningDeviceAwayFromSchoolDescriptors/{id} | Updates a resource based on the resource identifier. |

<a id="deleteprimarylearningdeviceawayfromschooldescriptorbyid"></a>
# **DeletePrimaryLearningDeviceAwayFromSchoolDescriptorById**
> void DeletePrimaryLearningDeviceAwayFromSchoolDescriptorById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v72.Apis.All;
using EdFi.OdsApi.Sdk.v72.Client;
using EdFi.OdsApi.Sdk.v72.Models.All;

namespace Example
{
    public class DeletePrimaryLearningDeviceAwayFromSchoolDescriptorByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrimaryLearningDeviceAwayFromSchoolDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletePrimaryLearningDeviceAwayFromSchoolDescriptorById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.DeletePrimaryLearningDeviceAwayFromSchoolDescriptorById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePrimaryLearningDeviceAwayFromSchoolDescriptorByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeletePrimaryLearningDeviceAwayFromSchoolDescriptorByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.DeletePrimaryLearningDeviceAwayFromSchoolDescriptorByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifMatch** | **string** | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was successfully deleted. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Use-Snapshot header is set to true, the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletesprimarylearningdeviceawayfromschooldescriptors"></a>
# **DeletesPrimaryLearningDeviceAwayFromSchoolDescriptors**
> List&lt;TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorDelete&gt; DeletesPrimaryLearningDeviceAwayFromSchoolDescriptors (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

Retrieves deleted resources based on change version.

This operation is used to retrieve identifying information about resources that have been deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v72.Apis.All;
using EdFi.OdsApi.Sdk.v72.Client;
using EdFi.OdsApi.Sdk.v72.Models.All;

namespace Example
{
    public class DeletesPrimaryLearningDeviceAwayFromSchoolDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrimaryLearningDeviceAwayFromSchoolDescriptorsApi(config);
            var offset = 0;  // int | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorDelete> result = apiInstance.DeletesPrimaryLearningDeviceAwayFromSchoolDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.DeletesPrimaryLearningDeviceAwayFromSchoolDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorDelete>> response = apiInstance.DeletesPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.DeletesPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorDelete&gt;**](TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorDelete.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. If Use-Snapshot header is set to true, this response can indicate the snapshot may have been removed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getprimarylearningdeviceawayfromschooldescriptors"></a>
# **GetPrimaryLearningDeviceAwayFromSchoolDescriptors**
> List&lt;EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor&gt; GetPrimaryLearningDeviceAwayFromSchoolDescriptors (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string codeValue = null, string id = null, string varNamespace = null, bool useSnapshot = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v72.Apis.All;
using EdFi.OdsApi.Sdk.v72.Client;
using EdFi.OdsApi.Sdk.v72.Models.All;

namespace Example
{
    public class GetPrimaryLearningDeviceAwayFromSchoolDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrimaryLearningDeviceAwayFromSchoolDescriptorsApi(config);
            var offset = 0;  // int | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var codeValue = "codeValue_example";  // string | A code or abbreviation that is used to refer to the descriptor. (optional) 
            var id = "id_example";  // string |  (optional) 
            var varNamespace = "varNamespace_example";  // string | A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor> result = apiInstance.GetPrimaryLearningDeviceAwayFromSchoolDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, codeValue, id, varNamespace, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.GetPrimaryLearningDeviceAwayFromSchoolDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor>> response = apiInstance.GetPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, codeValue, id, varNamespace, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.GetPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **codeValue** | **string** | A code or abbreviation that is used to refer to the descriptor. | [optional]  |
| **id** | **string** |  | [optional]  |
| **varNamespace** | **string** | A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor&gt;**](EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. If Use-Snapshot header is set to true, this response can indicate the snapshot may have been removed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getprimarylearningdeviceawayfromschooldescriptorsbyid"></a>
# **GetPrimaryLearningDeviceAwayFromSchoolDescriptorsById**
> EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor GetPrimaryLearningDeviceAwayFromSchoolDescriptorsById (string id, string ifNoneMatch = null, bool useSnapshot = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v72.Apis.All;
using EdFi.OdsApi.Sdk.v72.Client;
using EdFi.OdsApi.Sdk.v72.Models.All;

namespace Example
{
    public class GetPrimaryLearningDeviceAwayFromSchoolDescriptorsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrimaryLearningDeviceAwayFromSchoolDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor result = apiInstance.GetPrimaryLearningDeviceAwayFromSchoolDescriptorsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.GetPrimaryLearningDeviceAwayFromSchoolDescriptorsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrimaryLearningDeviceAwayFromSchoolDescriptorsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor> response = apiInstance.GetPrimaryLearningDeviceAwayFromSchoolDescriptorsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.GetPrimaryLearningDeviceAwayFromSchoolDescriptorsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifNoneMatch** | **string** | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. | [optional]  |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor**](EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. If Use-Snapshot header is set to true, this response can indicate the snapshot may have been removed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="keychangesprimarylearningdeviceawayfromschooldescriptors"></a>
# **KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptors**
> List&lt;TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorKeyChange&gt; KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptors (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, bool useSnapshot = null)

Retrieves resources key changes based on change version.

This operation is used to retrieve identifying information about resources whose key values have been changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v72.Apis.All;
using EdFi.OdsApi.Sdk.v72.Client;
using EdFi.OdsApi.Sdk.v72.Models.All;

namespace Example
{
    public class KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrimaryLearningDeviceAwayFromSchoolDescriptorsApi(config);
            var offset = 0;  // int | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var useSnapshot = false;  // bool | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorKeyChange> result = apiInstance.KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorKeyChange>> response = apiInstance.KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.KeyChangesPrimaryLearningDeviceAwayFromSchoolDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **useSnapshot** | **bool** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorKeyChange&gt;**](TrackedChangesEdFiPrimaryLearningDeviceAwayFromSchoolDescriptorKeyChange.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. If Use-Snapshot header is set to true, this response can indicate the snapshot may have been removed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postprimarylearningdeviceawayfromschooldescriptor"></a>
# **PostPrimaryLearningDeviceAwayFromSchoolDescriptor**
> void PostPrimaryLearningDeviceAwayFromSchoolDescriptor (EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor edFiPrimaryLearningDeviceAwayFromSchoolDescriptor)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v72.Apis.All;
using EdFi.OdsApi.Sdk.v72.Client;
using EdFi.OdsApi.Sdk.v72.Models.All;

namespace Example
{
    public class PostPrimaryLearningDeviceAwayFromSchoolDescriptorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrimaryLearningDeviceAwayFromSchoolDescriptorsApi(config);
            var edFiPrimaryLearningDeviceAwayFromSchoolDescriptor = new EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor(); // EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor | The JSON representation of the \"primaryLearningDeviceAwayFromSchoolDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostPrimaryLearningDeviceAwayFromSchoolDescriptor(edFiPrimaryLearningDeviceAwayFromSchoolDescriptor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.PostPrimaryLearningDeviceAwayFromSchoolDescriptor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostPrimaryLearningDeviceAwayFromSchoolDescriptorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostPrimaryLearningDeviceAwayFromSchoolDescriptorWithHttpInfo(edFiPrimaryLearningDeviceAwayFromSchoolDescriptor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.PostPrimaryLearningDeviceAwayFromSchoolDescriptorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiPrimaryLearningDeviceAwayFromSchoolDescriptor** | [**EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor**](EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor.md) | The JSON representation of the \&quot;primaryLearningDeviceAwayFromSchoolDescriptor\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **201** | The resource was created.  An ETag value is available in the ETag header, and the location of the resource is available in the Location header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **405** | Method Is Not Allowed. When the Use-Snapshot header is set to true, the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putprimarylearningdeviceawayfromschooldescriptor"></a>
# **PutPrimaryLearningDeviceAwayFromSchoolDescriptor**
> void PutPrimaryLearningDeviceAwayFromSchoolDescriptor (string id, EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor edFiPrimaryLearningDeviceAwayFromSchoolDescriptor, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation, so the recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v72.Apis.All;
using EdFi.OdsApi.Sdk.v72.Client;
using EdFi.OdsApi.Sdk.v72.Models.All;

namespace Example
{
    public class PutPrimaryLearningDeviceAwayFromSchoolDescriptorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrimaryLearningDeviceAwayFromSchoolDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiPrimaryLearningDeviceAwayFromSchoolDescriptor = new EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor(); // EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor | The JSON representation of the \"primaryLearningDeviceAwayFromSchoolDescriptor\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutPrimaryLearningDeviceAwayFromSchoolDescriptor(id, edFiPrimaryLearningDeviceAwayFromSchoolDescriptor, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.PutPrimaryLearningDeviceAwayFromSchoolDescriptor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutPrimaryLearningDeviceAwayFromSchoolDescriptorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutPrimaryLearningDeviceAwayFromSchoolDescriptorWithHttpInfo(id, edFiPrimaryLearningDeviceAwayFromSchoolDescriptor, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrimaryLearningDeviceAwayFromSchoolDescriptorsApi.PutPrimaryLearningDeviceAwayFromSchoolDescriptorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiPrimaryLearningDeviceAwayFromSchoolDescriptor** | [**EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor**](EdFiPrimaryLearningDeviceAwayFromSchoolDescriptor.md) | The JSON representation of the \&quot;primaryLearningDeviceAwayFromSchoolDescriptor\&quot; resource to be created or updated. |  |
| **ifMatch** | **string** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Use-Snapshot header is set to true, the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

