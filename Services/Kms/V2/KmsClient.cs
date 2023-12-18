using System;
using System.Net.Http;
using System.Collections.Generic;
using CmccCloud.SDK.Core;
using CmccCloud.SDK.Kms.V2.Model;

namespace CmccCloud.SDK.Kms.V2
{
    public partial class KmsClient : Client
    {
        public static ClientBuilder<KmsClient> NewBuilder()
        {
            return new ClientBuilder<KmsClient>();
        }

        
        public BatchCreateKmsTagsResponse BatchCreateKmsTags(BatchCreateKmsTagsRequest batchCreateKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , batchCreateKmsTagsRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateKmsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateKmsTagsResponse>(response);
        }
        
        public CancelGrantResponse CancelGrant(CancelGrantRequest cancelGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/revoke-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CancelGrantResponse>(response);
        }
        
        public CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest cancelKeyDeletionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/cancel-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelKeyDeletionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CancelKeyDeletionResponse>(response);
        }
        
        public CancelSelfGrantResponse CancelSelfGrant(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/retire-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CancelSelfGrantResponse>(response);
        }
        
        public CreateDatakeyResponse CreateDatakey(CreateDatakeyRequest createDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyResponse>(response);
        }
        
        public CreateDatakeyWithoutPlaintextResponse CreateDatakeyWithoutPlaintext(CreateDatakeyWithoutPlaintextRequest createDatakeyWithoutPlaintextRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-datakey-without-plaintext",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyWithoutPlaintextRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyWithoutPlaintextResponse>(response);
        }
        
        public CreateGrantResponse CreateGrant(CreateGrantRequest createGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateGrantResponse>(response);
        }
        
        public CreateKeyResponse CreateKey(CreateKeyRequest createKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/create-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKeyResponse>(response);
        }
        
        public CreateKeyStoreResponse CreateKeyStore(CreateKeyStoreRequest createKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKeyStoreResponse>(response);
        }
        
        public CreateKmsTagResponse CreateKmsTag(CreateKmsTagRequest createKmsTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , createKmsTagRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKmsTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateKmsTagResponse>(response);
        }
        
        public CreateParametersForImportResponse CreateParametersForImport(CreateParametersForImportRequest createParametersForImportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-parameters-for-import",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createParametersForImportRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateParametersForImportResponse>(response);
        }
        
        public CreateRandomResponse CreateRandom(CreateRandomRequest createRandomRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/gen-random",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRandomResponse>(response);
        }
        
        public DecryptDataResponse DecryptData(DecryptDataRequest decryptDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DecryptDataResponse>(response);
        }
        
        public DecryptDatakeyResponse DecryptDatakey(DecryptDatakeyRequest decryptDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/decrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DecryptDatakeyResponse>(response);
        }
        
        public DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest deleteImportedKeyMaterialRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/delete-imported-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>(response);
        }
        
        public DeleteKeyResponse DeleteKey(DeleteKeyRequest deleteKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/schedule-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DeleteKeyResponse>(response);
        }
        
        public DeleteKeyStoreResponse DeleteKeyStore(DeleteKeyStoreRequest deleteKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , deleteKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteKeyStoreResponse>(response);
        }
        
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , deleteTagRequest.KeyId.ToString());
            urlParam.Add("key" , deleteTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }
        
        public DisableKeyResponse DisableKey(DisableKeyRequest disableKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisableKeyResponse>(response);
        }
        
        public DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest disableKeyRotationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/disable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DisableKeyRotationResponse>(response);
        }
        
        public DisableKeyStoreResponse DisableKeyStore(DisableKeyStoreRequest disableKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , disableKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisableKeyStoreResponse>(response);
        }
        
        public EnableKeyResponse EnableKey(EnableKeyRequest enableKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EnableKeyResponse>(response);
        }
        
        public EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest enableKeyRotationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/enable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<EnableKeyRotationResponse>(response);
        }
        
        public EnableKeyStoreResponse EnableKeyStore(EnableKeyStoreRequest enableKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , enableKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EnableKeyStoreResponse>(response);
        }
        
        public EncryptDataResponse EncryptData(EncryptDataRequest encryptDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EncryptDataResponse>(response);
        }
        
        public EncryptDatakeyResponse EncryptDatakey(EncryptDatakeyRequest encryptDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/encrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EncryptDatakeyResponse>(response);
        }
        
        public ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest importKeyMaterialRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/import-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>(response);
        }
        
        public ListGrantsResponse ListGrants(ListGrantsRequest listGrantsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
        }
        
        public ListKeyDetailResponse ListKeyDetail(ListKeyDetailRequest listKeyDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/describe-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKeyDetailResponse>(response);
        }
        
        public ListKeyStoresResponse ListKeyStores(ListKeyStoresRequest listKeyStoresRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeyStoresRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKeyStoresResponse>(response);
        }
        
        public ListKeysResponse ListKeys(ListKeysRequest listKeysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-keys",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKeysResponse>(response);
        }
        
        public ListKmsByTagsResponse ListKmsByTags(ListKmsByTagsRequest listKmsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances" , listKmsByTagsRequest.ResourceInstances.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{resource_instances}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListKmsByTagsResponse>(response);
        }
        
        public ListKmsTagsResponse ListKmsTags(ListKmsTagsRequest listKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKmsTagsResponse>(response);
        }
        
        public ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest listRetirableGrantsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/list-retirable-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListRetirableGrantsResponse>(response);
        }
        
        public ShowKeyRotationStatusResponse ShowKeyRotationStatus(ShowKeyRotationStatusRequest showKeyRotationStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-key-rotation-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>(response);
        }
        
        public ShowKeyStoreResponse ShowKeyStore(ShowKeyStoreRequest showKeyStoreRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id" , showKeyStoreRequest.KeystoreId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/keystores/{keystore_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeyStoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowKeyStoreResponse>(response);
        }
        
        public ShowKmsTagsResponse ShowKmsTags(ShowKmsTagsRequest showKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , showKmsTagsRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowKmsTagsResponse>(response);
        }
        
        public ShowPublicKeyResponse ShowPublicKey(ShowPublicKeyRequest showPublicKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/get-publickey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublicKeyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowPublicKeyResponse>(response);
        }
        
        public ShowUserInstancesResponse ShowUserInstances(ShowUserInstancesRequest showUserInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUserInstancesResponse>(response);
        }
        
        public ShowUserQuotasResponse ShowUserQuotas(ShowUserQuotasRequest showUserQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/user-quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUserQuotasResponse>(response);
        }
        
        public SignResponse Sign(SignRequest signRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/sign",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", signRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SignResponse>(response);
        }
        
        public UpdateKeyAliasResponse UpdateKeyAlias(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-alias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyAliasResponse>(response);
        }
        
        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-description",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>(response);
        }
        
        public UpdateKeyRotationIntervalResponse UpdateKeyRotationInterval(UpdateKeyRotationIntervalRequest updateKeyRotationIntervalRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/update-key-rotation-interval",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>(response);
        }
        
        public ValidateSignatureResponse ValidateSignature(ValidateSignatureRequest validateSignatureRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/kms/verify",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", validateSignatureRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ValidateSignatureResponse>(response);
        }
        
        public ShowVersionResponse ShowVersion(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
        public ShowVersionsResponse ShowVersions(ShowVersionsRequest showVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionsResponse>(response);
        }
        
    }
}