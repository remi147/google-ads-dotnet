// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/customer_manager_link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/customer_manager_link.proto</summary>
  public static partial class CustomerManagerLinkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/customer_manager_link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerManagerLinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "bWFuYWdlcl9saW5rLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52MS5y",
            "ZXNvdXJjZXMaN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxL2VudW1zL21hbmFn",
            "ZXJfbGlua19zdGF0dXMucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZp",
            "b3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHmdvb2dsZS9w",
            "cm90b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90byKoAwoTQ3VzdG9tZXJNYW5hZ2VyTGluaxJLCg1yZXNvdXJjZV9u",
            "YW1lGAEgASgJQjTgQQX6QS4KLGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9D",
            "dXN0b21lck1hbmFnZXJMaW5rEjsKEG1hbmFnZXJfY3VzdG9tZXIYAyABKAsy",
            "HC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAxI5Cg9tYW5hZ2Vy",
            "X2xpbmtfaWQYBCABKAsyGy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZUID",
            "4EEDElYKBnN0YXR1cxgFIAEoDjJGLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "LmVudW1zLk1hbmFnZXJMaW5rU3RhdHVzRW51bS5NYW5hZ2VyTGlua1N0YXR1",
            "czp06kFxCixnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJNYW5h",
            "Z2VyTGluaxJBY3VzdG9tZXJzL3tjdXN0b21lcn0vY3VzdG9tZXJNYW5hZ2Vy",
            "TGlua3Mve2N1c3RvbWVyX21hbmFnZXJfbGlua31ChQIKJWNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MS5yZXNvdXJjZXNCGEN1c3RvbWVyTWFuYWdlckxp",
            "bmtQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjEvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dB",
            "QaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLlJlc291cmNlc8oCIUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYxXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYxOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.CustomerManagerLink), global::Google.Ads.GoogleAds.V1.Resources.CustomerManagerLink.Parser, new[]{ "ResourceName", "ManagerCustomer", "ManagerLinkId", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents customer-manager link relationship.
  /// </summary>
  public sealed partial class CustomerManagerLink : pb::IMessage<CustomerManagerLink> {
    private static readonly pb::MessageParser<CustomerManagerLink> _parser = new pb::MessageParser<CustomerManagerLink>(() => new CustomerManagerLink());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerManagerLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.CustomerManagerLinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerManagerLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerManagerLink(CustomerManagerLink other) : this() {
      resourceName_ = other.resourceName_;
      ManagerCustomer = other.ManagerCustomer;
      ManagerLinkId = other.ManagerLinkId;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerManagerLink Clone() {
      return new CustomerManagerLink(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// CustomerManagerLink resource names have the form:
    /// `customers/{customer_id}/customerManagerLinks/{manager_customer_id}~{manager_link_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manager_customer" field.</summary>
    public const int ManagerCustomerFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_managerCustomer_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string managerCustomer_;
    /// <summary>
    /// Output only. The manager customer linked to the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ManagerCustomer {
      get { return managerCustomer_; }
      set {
        managerCustomer_ = value;
      }
    }


    /// <summary>Field number for the "manager_link_id" field.</summary>
    public const int ManagerLinkIdFieldNumber = 4;
    private static readonly pb::FieldCodec<long?> _single_managerLinkId_codec = pb::FieldCodec.ForStructWrapper<long>(34);
    private long? managerLinkId_;
    /// <summary>
    /// Output only. ID of the customer-manager link. This field is read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? ManagerLinkId {
      get { return managerLinkId_; }
      set {
        managerLinkId_ = value;
      }
    }


    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus status_ = global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified;
    /// <summary>
    /// Status of the link between the customer and the manager.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerManagerLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerManagerLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ManagerCustomer != other.ManagerCustomer) return false;
      if (ManagerLinkId != other.ManagerLinkId) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (managerCustomer_ != null) hash ^= ManagerCustomer.GetHashCode();
      if (managerLinkId_ != null) hash ^= ManagerLinkId.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (managerCustomer_ != null) {
        _single_managerCustomer_codec.WriteTagAndValue(output, ManagerCustomer);
      }
      if (managerLinkId_ != null) {
        _single_managerLinkId_codec.WriteTagAndValue(output, ManagerLinkId);
      }
      if (Status != global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (managerCustomer_ != null) {
        size += _single_managerCustomer_codec.CalculateSizeWithTag(ManagerCustomer);
      }
      if (managerLinkId_ != null) {
        size += _single_managerLinkId_codec.CalculateSizeWithTag(ManagerLinkId);
      }
      if (Status != global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerManagerLink other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.managerCustomer_ != null) {
        if (managerCustomer_ == null || other.ManagerCustomer != "") {
          ManagerCustomer = other.ManagerCustomer;
        }
      }
      if (other.managerLinkId_ != null) {
        if (managerLinkId_ == null || other.ManagerLinkId != 0L) {
          ManagerLinkId = other.ManagerLinkId;
        }
      }
      if (other.Status != global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        Status = other.Status;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26: {
            string value = _single_managerCustomer_codec.Read(input);
            if (managerCustomer_ == null || value != "") {
              ManagerCustomer = value;
            }
            break;
          }
          case 34: {
            long? value = _single_managerLinkId_codec.Read(input);
            if (managerLinkId_ == null || value != 0L) {
              ManagerLinkId = value;
            }
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V1.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
