// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/ad_group_extension_setting_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V2.Services {
  /// <summary>
  /// Service to manage ad group extension settings.
  /// </summary>
  public static partial class AdGroupExtensionSettingService
  {
    static readonly string __ServiceName = "google.ads.googleads.v2.services.AdGroupExtensionSettingService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest> __Marshaller_google_ads_googleads_v2_services_GetAdGroupExtensionSettingRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting> __Marshaller_google_ads_googleads_v2_resources_AdGroupExtensionSetting = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest> __Marshaller_google_ads_googleads_v2_services_MutateAdGroupExtensionSettingsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse> __Marshaller_google_ads_googleads_v2_services_MutateAdGroupExtensionSettingsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest, global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting> __Method_GetAdGroupExtensionSetting = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest, global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdGroupExtensionSetting",
        __Marshaller_google_ads_googleads_v2_services_GetAdGroupExtensionSettingRequest,
        __Marshaller_google_ads_googleads_v2_resources_AdGroupExtensionSetting);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest, global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse> __Method_MutateAdGroupExtensionSettings = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest, global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdGroupExtensionSettings",
        __Marshaller_google_ads_googleads_v2_services_MutateAdGroupExtensionSettingsRequest,
        __Marshaller_google_ads_googleads_v2_services_MutateAdGroupExtensionSettingsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V2.Services.AdGroupExtensionSettingServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdGroupExtensionSettingService</summary>
    [grpc::BindServiceMethod(typeof(AdGroupExtensionSettingService), "BindService")]
    public abstract partial class AdGroupExtensionSettingServiceBase
    {
      /// <summary>
      /// Returns the requested ad group extension setting in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting> GetAdGroupExtensionSetting(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes ad group extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse> MutateAdGroupExtensionSettings(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdGroupExtensionSettingService</summary>
    public partial class AdGroupExtensionSettingServiceClient : grpc::ClientBase<AdGroupExtensionSettingServiceClient>
    {
      /// <summary>Creates a new client for AdGroupExtensionSettingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdGroupExtensionSettingServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdGroupExtensionSettingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdGroupExtensionSettingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdGroupExtensionSettingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdGroupExtensionSettingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad group extension setting in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting GetAdGroupExtensionSetting(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupExtensionSetting(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group extension setting in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting GetAdGroupExtensionSetting(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdGroupExtensionSetting, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad group extension setting in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupExtensionSettingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group extension setting in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdGroupExtensionSetting, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad group extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse MutateAdGroupExtensionSettings(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupExtensionSettings(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad group extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse MutateAdGroupExtensionSettings(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdGroupExtensionSettings, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad group extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse> MutateAdGroupExtensionSettingsAsync(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupExtensionSettingsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad group extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse> MutateAdGroupExtensionSettingsAsync(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdGroupExtensionSettings, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdGroupExtensionSettingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdGroupExtensionSettingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdGroupExtensionSettingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdGroupExtensionSetting, serviceImpl.GetAdGroupExtensionSetting)
          .AddMethod(__Method_MutateAdGroupExtensionSettings, serviceImpl.MutateAdGroupExtensionSettings).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdGroupExtensionSettingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdGroupExtensionSetting, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V2.Services.GetAdGroupExtensionSettingRequest, global::Google.Ads.GoogleAds.V2.Resources.AdGroupExtensionSetting>(serviceImpl.GetAdGroupExtensionSetting));
      serviceBinder.AddMethod(__Method_MutateAdGroupExtensionSettings, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsRequest, global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupExtensionSettingsResponse>(serviceImpl.MutateAdGroupExtensionSettings));
    }

  }
}
#endregion
