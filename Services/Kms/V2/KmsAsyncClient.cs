using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using CmccCloud.SDK.Core;
using CmccCloud.SDK.Kms.V2.Model;

namespace CmccCloud.SDK.Kms.V2
{
    public partial class KmsAsyncClient : Client
    {
        public static ClientBuilder<KmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<KmsAsyncClient>();
        }

        
        public async Task<BatchCreateKmsTagsResponse> BatchCreateKmsTagsAsync(BatchCreateKmsTagsRequest batchCreateKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , batchCreateKmsTagsRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateKmsTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateKmsTagsResponse>(response);
        }
        
        public async Task<CancelGrantResponse> CancelGrantAsync(CancelGrantRequest cancelGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/revoke-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CancelGrantResponse>(response);
        }
        
        public async Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest cancelKeyDeletionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/cancel-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelKeyDeletionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CancelKeyDeletionResponse>(response);
        }
        
        public async Task<CancelSelfGrantResponse> CancelSelfGrantAsync(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/retire-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CancelSelfGrantResponse>(response);
        }
        
        public async Task<CreateDatakeyResponse> CreateDatakeyAsync(CreateDatakeyRequest createDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyResponse>(response);
        }
        
        public async Task<CreateDatakeyWithoutPlaintextResponse> CreateDatakeyWithoutPlaintextAsync(CreateDatakeyWithoutPlaintextRequest createDatakeyWithoutPlaintextRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey-without-plaintext",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyWithoutPlaintextRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyWithoutPlaintextResponse>(response);
        }
        
        public async Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest createGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateGrantResponse>(response);
        }
        
        public async Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest createKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateKeyResponse>(response);
        }
        
        public async Task<CreateKeyStoreResponse> CreateKeyStoreAsync(CreateKeyStoreRequest createKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyStoreRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateKeyStoreResponse>(response);
        }
        
        public async Task<CreateKmsTagResponse> CreateKmsTagAsync(CreateKmsTagRequest createKmsTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , createKmsTagRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKmsTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateKmsTagResponse>(response);
        }
        
        public async Task<CreateParametersForImportResponse> CreateParametersForImportAsync(CreateParametersForImportRequest createParametersForImportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-parameters-for-import",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createParametersForImportRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateParametersForImportResponse>(response);
        }
        
        public async Task<CreateRandomResponse> CreateRandomAsync(CreateRandomRequest createRandomRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/gen-random",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRandomResponse>(response);
        }
        
        public async Task<DecryptDataResponse> DecryptDataAsync(DecryptDataRequest decryptDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DecryptDataResponse>(response);
        }
        
        public async Task<DecryptDatakeyResponse> DecryptDatakeyAsync(DecryptDatakeyRequest decryptDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DecryptDatakeyResponse>(response);
        }
        
        public async Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest deleteImportedKeyMaterialRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/delete-imported-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>(response);
        }
        
        public async Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest deleteKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/schedule-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeleteKeyResponse>(response);
        }
        
        public async Task<DeleteKeyStoreResponse> DeleteKeyStoreAsync(DeleteKeyStoreRequest deleteKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , deleteKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeyStoreRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteKeyStoreResponse>(response);
        }
        
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , deleteTagRequest.KeyId.ToString());
            urlParam.Add("key" , deleteTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }
        
        public async Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest disableKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisableKeyResponse>(response);
        }
        
        public async Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest disableKeyRotationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DisableKeyRotationResponse>(response);
        }
        
        public async Task<DisableKeyStoreResponse> DisableKeyStoreAsync(DisableKeyStoreRequest disableKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , disableKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableKeyStoreRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisableKeyStoreResponse>(response);
        }
        
        public async Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest enableKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<EnableKeyResponse>(response);
        }
        
        public async Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest enableKeyRotationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<EnableKeyRotationResponse>(response);
        }
        
        public async Task<EnableKeyStoreResponse> EnableKeyStoreAsync(EnableKeyStoreRequest enableKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , enableKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableKeyStoreRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<EnableKeyStoreResponse>(response);
        }
        
        public async Task<EncryptDataResponse> EncryptDataAsync(EncryptDataRequest encryptDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<EncryptDataResponse>(response);
        }
        
        public async Task<EncryptDatakeyResponse> EncryptDatakeyAsync(EncryptDatakeyRequest encryptDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<EncryptDatakeyResponse>(response);
        }
        
        public async Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest importKeyMaterialRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/import-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>(response);
        }
        
        public async Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest listGrantsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
        }
        
        public async Task<ListKeyDetailResponse> ListKeyDetailAsync(ListKeyDetailRequest listKeyDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/describe-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListKeyDetailResponse>(response);
        }
        
        public async Task<ListKeyStoresResponse> ListKeyStoresAsync(ListKeyStoresRequest listKeyStoresRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyStoresRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKeyStoresResponse>(response);
        }
        
        public async Task<ListKeysResponse> ListKeysAsync(ListKeysRequest listKeysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-keys",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListKeysResponse>(response);
        }
        
        public async Task<ListKmsByTagsResponse> ListKmsByTagsAsync(ListKmsByTagsRequest listKmsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances" , listKmsByTagsRequest.ResourceInstances.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{resource_instances}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListKmsByTagsResponse>(response);
        }
        
        public async Task<ListKmsTagsResponse> ListKmsTagsAsync(ListKmsTagsRequest listKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKmsTagsResponse>(response);
        }
        
        public async Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest listRetirableGrantsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-retirable-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListRetirableGrantsResponse>(response);
        }
        
        public async Task<ShowKeyRotationStatusResponse> ShowKeyRotationStatusAsync(ShowKeyRotationStatusRequest showKeyRotationStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-key-rotation-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>(response);
        }
        
        public async Task<ShowKeyStoreResponse> ShowKeyStoreAsync(ShowKeyStoreRequest showKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , showKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeyStoreRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowKeyStoreResponse>(response);
        }
        
        public async Task<ShowKmsTagsResponse> ShowKmsTagsAsync(ShowKmsTagsRequest showKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , showKmsTagsRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowKmsTagsResponse>(response);
        }
        
        public async Task<ShowPublicKeyResponse> ShowPublicKeyAsync(ShowPublicKeyRequest showPublicKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-publickey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublicKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowPublicKeyResponse>(response);
        }
        
        public async Task<ShowUserInstancesResponse> ShowUserInstancesAsync(ShowUserInstancesRequest showUserInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserInstancesResponse>(response);
        }
        
        public async Task<ShowUserQuotasResponse> ShowUserQuotasAsync(ShowUserQuotasRequest showUserQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserQuotasResponse>(response);
        }
        
        public async Task<SignResponse> SignAsync(SignRequest signRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/sign",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", signRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SignResponse>(response);
        }
        
        public async Task<UpdateKeyAliasResponse> UpdateKeyAliasAsync(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-alias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyAliasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyAliasResponse>(response);
        }
        
        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-description",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>(response);
        }
        
        public async Task<UpdateKeyRotationIntervalResponse> UpdateKeyRotationIntervalAsync(UpdateKeyRotationIntervalRequest updateKeyRotationIntervalRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-rotation-interval",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>(response);
        }
        
        public async Task<ValidateSignatureResponse> ValidateSignatureAsync(ValidateSignatureRequest validateSignatureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateSignatureRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ValidateSignatureResponse>(response);
        }
        
        public async Task<ShowVersionResponse> ShowVersionAsync(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
        public async Task<ShowVersionsResponse> ShowVersionsAsync(ShowVersionsRequest showVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionsResponse>(response);
        }
        
    }
}