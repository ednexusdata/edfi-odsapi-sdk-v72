# EdFi.OdsApi.Sdk.v72.Apis.All.PostSecondaryInstitutionLevelDescriptorsApi

All URIs are relative to *https://api.ed-fi.org:443/v7.2/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePostSecondaryInstitutionLevelDescriptorById**](PostSecondaryInstitutionLevelDescriptorsApi.md#deletepostsecondaryinstitutionleveldescriptorbyid) | **DELETE** /ed-fi/postSecondaryInstitutionLevelDescriptors/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesPostSecondaryInstitutionLevelDescriptors**](PostSecondaryInstitutionLevelDescriptorsApi.md#deletespostsecondaryinstitutionleveldescriptors) | **GET** /ed-fi/postSecondaryInstitutionLevelDescriptors/deletes | Retrieves deleted resources based on change version. |
| [**GetPostSecondaryInstitutionLevelDescriptors**](PostSecondaryInstitutionLevelDescriptorsApi.md#getpostsecondaryinstitutionleveldescriptors) | **GET** /ed-fi/postSecondaryInstitutionLevelDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetPostSecondaryInstitutionLevelDescriptorsById**](PostSecondaryInstitutionLevelDescriptorsApi.md#getpostsecondaryinstitutionleveldescriptorsbyid) | **GET** /ed-fi/postSecondaryInstitutionLevelDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**KeyChangesPostSecondaryInstitutionLevelDescriptors**](PostSecondaryInstitutionLevelDescriptorsApi.md#keychangespostsecondaryinstitutionleveldescriptors) | **GET** /ed-fi/postSecondaryInstitutionLevelDescriptors/keyChanges | Retrieves resources key changes based on change version. |
| [**PostPostSecondaryInstitutionLevelDescriptor**](PostSecondaryInstitutionLevelDescriptorsApi.md#postpostsecondaryinstitutionleveldescriptor) | **POST** /ed-fi/postSecondaryInstitutionLevelDescriptors | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutPostSecondaryInstitutionLevelDescriptor**](PostSecondaryInstitutionLevelDescriptorsApi.md#putpostsecondaryinstitutionleveldescriptor) | **PUT** /ed-fi/postSecondaryInstitutionLevelDescriptors/{id} | Updates a resource based on the resource identifier. |

<a id="deletepostsecondaryinstitutionleveldescriptorbyid"></a>
# **DeletePostSecondaryInstitutionLevelDescriptorById**
> void DeletePostSecondaryInstitutionLevelDescriptorById (string id, string? ifMatch = null)

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
    public class DeletePostSecondaryInstitutionLevelDescriptorByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionLevelDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletePostSecondaryInstitutionLevelDescriptorById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.DeletePostSecondaryInstitutionLevelDescriptorById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePostSecondaryInstitutionLevelDescriptorByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeletePostSecondaryInstitutionLevelDescriptorByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.DeletePostSecondaryInstitutionLevelDescriptorByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletespostsecondaryinstitutionleveldescriptors"></a>
# **DeletesPostSecondaryInstitutionLevelDescriptors**
> List&lt;TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorDelete&gt; DeletesPostSecondaryInstitutionLevelDescriptors (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, bool? useSnapshot = null)

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
    public class DeletesPostSecondaryInstitutionLevelDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionLevelDescriptorsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var useSnapshot = false;  // bool? | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorDelete> result = apiInstance.DeletesPostSecondaryInstitutionLevelDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.DeletesPostSecondaryInstitutionLevelDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesPostSecondaryInstitutionLevelDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorDelete>> response = apiInstance.DeletesPostSecondaryInstitutionLevelDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.DeletesPostSecondaryInstitutionLevelDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **useSnapshot** | **bool?** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorDelete&gt;**](TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorDelete.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpostsecondaryinstitutionleveldescriptors"></a>
# **GetPostSecondaryInstitutionLevelDescriptors**
> List&lt;EdFiPostSecondaryInstitutionLevelDescriptor&gt; GetPostSecondaryInstitutionLevelDescriptors (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? codeValue = null, string? id = null, string? varNamespace = null, bool? useSnapshot = null)

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
    public class GetPostSecondaryInstitutionLevelDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionLevelDescriptorsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var codeValue = "codeValue_example";  // string? | A code or abbreviation that is used to refer to the descriptor. (optional) 
            var id = "id_example";  // string? |  (optional) 
            var varNamespace = "varNamespace_example";  // string? | A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. (optional) 
            var useSnapshot = false;  // bool? | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiPostSecondaryInstitutionLevelDescriptor> result = apiInstance.GetPostSecondaryInstitutionLevelDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, codeValue, id, varNamespace, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.GetPostSecondaryInstitutionLevelDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPostSecondaryInstitutionLevelDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiPostSecondaryInstitutionLevelDescriptor>> response = apiInstance.GetPostSecondaryInstitutionLevelDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, codeValue, id, varNamespace, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.GetPostSecondaryInstitutionLevelDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **codeValue** | **string?** | A code or abbreviation that is used to refer to the descriptor. | [optional]  |
| **id** | **string?** |  | [optional]  |
| **varNamespace** | **string?** | A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. | [optional]  |
| **useSnapshot** | **bool?** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;EdFiPostSecondaryInstitutionLevelDescriptor&gt;**](EdFiPostSecondaryInstitutionLevelDescriptor.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpostsecondaryinstitutionleveldescriptorsbyid"></a>
# **GetPostSecondaryInstitutionLevelDescriptorsById**
> EdFiPostSecondaryInstitutionLevelDescriptor GetPostSecondaryInstitutionLevelDescriptorsById (string id, string? ifNoneMatch = null, bool? useSnapshot = null)

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
    public class GetPostSecondaryInstitutionLevelDescriptorsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionLevelDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var useSnapshot = false;  // bool? | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiPostSecondaryInstitutionLevelDescriptor result = apiInstance.GetPostSecondaryInstitutionLevelDescriptorsById(id, ifNoneMatch, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.GetPostSecondaryInstitutionLevelDescriptorsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPostSecondaryInstitutionLevelDescriptorsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiPostSecondaryInstitutionLevelDescriptor> response = apiInstance.GetPostSecondaryInstitutionLevelDescriptorsByIdWithHttpInfo(id, ifNoneMatch, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.GetPostSecondaryInstitutionLevelDescriptorsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifNoneMatch** | **string?** | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. | [optional]  |
| **useSnapshot** | **bool?** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**EdFiPostSecondaryInstitutionLevelDescriptor**](EdFiPostSecondaryInstitutionLevelDescriptor.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="keychangespostsecondaryinstitutionleveldescriptors"></a>
# **KeyChangesPostSecondaryInstitutionLevelDescriptors**
> List&lt;TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorKeyChange&gt; KeyChangesPostSecondaryInstitutionLevelDescriptors (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, bool? useSnapshot = null)

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
    public class KeyChangesPostSecondaryInstitutionLevelDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionLevelDescriptorsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var useSnapshot = false;  // bool? | Indicates if the configured Snapshot should be used. (optional)  (default to false)

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorKeyChange> result = apiInstance.KeyChangesPostSecondaryInstitutionLevelDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.KeyChangesPostSecondaryInstitutionLevelDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesPostSecondaryInstitutionLevelDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorKeyChange>> response = apiInstance.KeyChangesPostSecondaryInstitutionLevelDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, useSnapshot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.KeyChangesPostSecondaryInstitutionLevelDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **useSnapshot** | **bool?** | Indicates if the configured Snapshot should be used. | [optional] [default to false] |

### Return type

[**List&lt;TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorKeyChange&gt;**](TrackedChangesEdFiPostSecondaryInstitutionLevelDescriptorKeyChange.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postpostsecondaryinstitutionleveldescriptor"></a>
# **PostPostSecondaryInstitutionLevelDescriptor**
> void PostPostSecondaryInstitutionLevelDescriptor (EdFiPostSecondaryInstitutionLevelDescriptor edFiPostSecondaryInstitutionLevelDescriptor)

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
    public class PostPostSecondaryInstitutionLevelDescriptorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionLevelDescriptorsApi(config);
            var edFiPostSecondaryInstitutionLevelDescriptor = new EdFiPostSecondaryInstitutionLevelDescriptor(); // EdFiPostSecondaryInstitutionLevelDescriptor | The JSON representation of the \"postSecondaryInstitutionLevelDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostPostSecondaryInstitutionLevelDescriptor(edFiPostSecondaryInstitutionLevelDescriptor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.PostPostSecondaryInstitutionLevelDescriptor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostPostSecondaryInstitutionLevelDescriptorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostPostSecondaryInstitutionLevelDescriptorWithHttpInfo(edFiPostSecondaryInstitutionLevelDescriptor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.PostPostSecondaryInstitutionLevelDescriptorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiPostSecondaryInstitutionLevelDescriptor** | [**EdFiPostSecondaryInstitutionLevelDescriptor**](EdFiPostSecondaryInstitutionLevelDescriptor.md) | The JSON representation of the \&quot;postSecondaryInstitutionLevelDescriptor\&quot; resource to be created or updated. |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putpostsecondaryinstitutionleveldescriptor"></a>
# **PutPostSecondaryInstitutionLevelDescriptor**
> void PutPostSecondaryInstitutionLevelDescriptor (string id, EdFiPostSecondaryInstitutionLevelDescriptor edFiPostSecondaryInstitutionLevelDescriptor, string? ifMatch = null)

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
    public class PutPostSecondaryInstitutionLevelDescriptorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v7.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionLevelDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var edFiPostSecondaryInstitutionLevelDescriptor = new EdFiPostSecondaryInstitutionLevelDescriptor(); // EdFiPostSecondaryInstitutionLevelDescriptor | The JSON representation of the \"postSecondaryInstitutionLevelDescriptor\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutPostSecondaryInstitutionLevelDescriptor(id, edFiPostSecondaryInstitutionLevelDescriptor, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.PutPostSecondaryInstitutionLevelDescriptor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutPostSecondaryInstitutionLevelDescriptorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutPostSecondaryInstitutionLevelDescriptorWithHttpInfo(id, edFiPostSecondaryInstitutionLevelDescriptor, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostSecondaryInstitutionLevelDescriptorsApi.PutPostSecondaryInstitutionLevelDescriptorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **edFiPostSecondaryInstitutionLevelDescriptor** | [**EdFiPostSecondaryInstitutionLevelDescriptor**](EdFiPostSecondaryInstitutionLevelDescriptor.md) | The JSON representation of the \&quot;postSecondaryInstitutionLevelDescriptor\&quot; resource to be created or updated. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

