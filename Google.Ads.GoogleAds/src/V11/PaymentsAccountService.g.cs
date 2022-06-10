// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/services/payments_account_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/services/payments_account_service.proto</summary>
  public static partial class PaymentsAccountServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/services/payments_account_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaymentsAccountServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvc2VydmljZXMvcGF5bWVudHNf",
            "YWNjb3VudF9zZXJ2aWNlLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTEuc2VydmljZXMaOWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMS9yZXNvdXJj",
            "ZXMvcGF5bWVudHNfYWNjb3VudC5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0",
            "aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aH2dvb2dsZS9h",
            "cGkvZmllbGRfYmVoYXZpb3IucHJvdG8iNwobTGlzdFBheW1lbnRzQWNjb3Vu",
            "dHNSZXF1ZXN0EhgKC2N1c3RvbWVyX2lkGAEgASgJQgPgQQIibgocTGlzdFBh",
            "eW1lbnRzQWNjb3VudHNSZXNwb25zZRJOChFwYXltZW50c19hY2NvdW50cxgB",
            "IAMoCzIzLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5yZXNvdXJjZXMuUGF5",
            "bWVudHNBY2NvdW50MsACChZQYXltZW50c0FjY291bnRTZXJ2aWNlEt4BChRM",
            "aXN0UGF5bWVudHNBY2NvdW50cxI+Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "MS5zZXJ2aWNlcy5MaXN0UGF5bWVudHNBY2NvdW50c1JlcXVlc3QaPy5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MTEuc2VydmljZXMuTGlzdFBheW1lbnRzQWNj",
            "b3VudHNSZXNwb25zZSJFgtPkkwIxEi8vdjExL2N1c3RvbWVycy97Y3VzdG9t",
            "ZXJfaWQ9Kn0vcGF5bWVudHNBY2NvdW50c9pBC2N1c3RvbWVyX2lkGkXKQRhn",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb23SQSdodHRwczovL3d3dy5nb29nbGVh",
            "cGlzLmNvbS9hdXRoL2Fkd29yZHNChwIKJWNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTEuc2VydmljZXNCG1BheW1lbnRzQWNjb3VudFNlcnZpY2VQcm90",
            "b1ABWklnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjExL3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIhR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjExLlNlcnZpY2VzygIhR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjExXFNlcnZpY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjExOjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V11.Resources.PaymentsAccountReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Services.ListPaymentsAccountsRequest), global::Google.Ads.GoogleAds.V11.Services.ListPaymentsAccountsRequest.Parser, new[]{ "CustomerId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Services.ListPaymentsAccountsResponse), global::Google.Ads.GoogleAds.V11.Services.ListPaymentsAccountsResponse.Parser, new[]{ "PaymentsAccounts" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for fetching all accessible payments accounts.
  /// </summary>
  public sealed partial class ListPaymentsAccountsRequest : pb::IMessage<ListPaymentsAccountsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListPaymentsAccountsRequest> _parser = new pb::MessageParser<ListPaymentsAccountsRequest>(() => new ListPaymentsAccountsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListPaymentsAccountsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Services.PaymentsAccountServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListPaymentsAccountsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListPaymentsAccountsRequest(ListPaymentsAccountsRequest other) : this() {
      customerId_ = other.customerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListPaymentsAccountsRequest Clone() {
      return new ListPaymentsAccountsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. The ID of the customer to apply the PaymentsAccount list operation to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListPaymentsAccountsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListPaymentsAccountsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ListPaymentsAccountsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for [PaymentsAccountService.ListPaymentsAccounts][google.ads.googleads.v11.services.PaymentsAccountService.ListPaymentsAccounts].
  /// </summary>
  public sealed partial class ListPaymentsAccountsResponse : pb::IMessage<ListPaymentsAccountsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListPaymentsAccountsResponse> _parser = new pb::MessageParser<ListPaymentsAccountsResponse>(() => new ListPaymentsAccountsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListPaymentsAccountsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Services.PaymentsAccountServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListPaymentsAccountsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListPaymentsAccountsResponse(ListPaymentsAccountsResponse other) : this() {
      paymentsAccounts_ = other.paymentsAccounts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListPaymentsAccountsResponse Clone() {
      return new ListPaymentsAccountsResponse(this);
    }

    /// <summary>Field number for the "payments_accounts" field.</summary>
    public const int PaymentsAccountsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V11.Resources.PaymentsAccount> _repeated_paymentsAccounts_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V11.Resources.PaymentsAccount.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Resources.PaymentsAccount> paymentsAccounts_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Resources.PaymentsAccount>();
    /// <summary>
    /// The list of accessible payments accounts.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Resources.PaymentsAccount> PaymentsAccounts {
      get { return paymentsAccounts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListPaymentsAccountsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListPaymentsAccountsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!paymentsAccounts_.Equals(other.paymentsAccounts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= paymentsAccounts_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      paymentsAccounts_.WriteTo(output, _repeated_paymentsAccounts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      paymentsAccounts_.WriteTo(ref output, _repeated_paymentsAccounts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += paymentsAccounts_.CalculateSize(_repeated_paymentsAccounts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ListPaymentsAccountsResponse other) {
      if (other == null) {
        return;
      }
      paymentsAccounts_.Add(other.paymentsAccounts_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            paymentsAccounts_.AddEntriesFrom(input, _repeated_paymentsAccounts_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            paymentsAccounts_.AddEntriesFrom(ref input, _repeated_paymentsAccounts_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
