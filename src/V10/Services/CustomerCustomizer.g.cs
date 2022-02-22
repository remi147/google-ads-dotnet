// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/customer_customizer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/customer_customizer.proto</summary>
  public static partial class CustomerCustomizerReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/customer_customizer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerCustomizerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL2N1c3RvbWVy",
            "X2N1c3RvbWl6ZXIucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5y",
            "ZXNvdXJjZXMaNmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMC9jb21tb24vY3Vz",
            "dG9taXplcl92YWx1ZS5wcm90bxo8Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEw",
            "L2VudW1zL2N1c3RvbWl6ZXJfdmFsdWVfc3RhdHVzLnByb3RvGhxnb29nbGUv",
            "YXBpL2Fubm90YXRpb25zLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2",
            "aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvItwDChJDdXN0",
            "b21lckN1c3RvbWl6ZXISSgoNcmVzb3VyY2VfbmFtZRgBIAEoCUIz4EEF+kEt",
            "Citnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJDdXN0b21pemVy",
            "ElUKFGN1c3RvbWl6ZXJfYXR0cmlidXRlGAIgASgJQjfgQQLgQQX6QS4KLGdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21pemVyQXR0cmlidXRlEmQK",
            "BnN0YXR1cxgDIAEoDjJPLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5lbnVt",
            "cy5DdXN0b21pemVyVmFsdWVTdGF0dXNFbnVtLkN1c3RvbWl6ZXJWYWx1ZVN0",
            "YXR1c0ID4EEDEkQKBXZhbHVlGAQgASgLMjAuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjEwLmNvbW1vbi5DdXN0b21pemVyVmFsdWVCA+BBAjp36kF0Citnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJDdXN0b21pemVyEkVjdXN0",
            "b21lcnMve2N1c3RvbWVyX2lkfS9jdXN0b21lckN1c3RvbWl6ZXJzL3tjdXN0",
            "b21pemVyX2F0dHJpYnV0ZV9pZH1CiQIKJmNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTAucmVzb3VyY2VzQhdDdXN0b21lckN1c3RvbWl6ZXJQcm90b1AB",
            "Wktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjEwL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMTAuUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjEwXFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYxMDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Common.CustomizerValueReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.CustomerCustomizer), global::Google.Ads.GoogleAds.V10.Resources.CustomerCustomizer.Parser, new[]{ "ResourceName", "CustomizerAttribute", "Status", "Value" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customizer value for the associated CustomizerAttribute at the Customer
  /// level.
  /// </summary>
  public sealed partial class CustomerCustomizer : pb::IMessage<CustomerCustomizer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerCustomizer> _parser = new pb::MessageParser<CustomerCustomizer>(() => new CustomerCustomizer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerCustomizer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.CustomerCustomizerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerCustomizer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerCustomizer(CustomerCustomizer other) : this() {
      resourceName_ = other.resourceName_;
      customizerAttribute_ = other.customizerAttribute_;
      status_ = other.status_;
      value_ = other.value_ != null ? other.value_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerCustomizer Clone() {
      return new CustomerCustomizer(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer customizer.
    /// Customer customizer resource names have the form:
    ///
    /// `customers/{customer_id}/customerCustomizers/{customizer_attribute_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customizer_attribute" field.</summary>
    public const int CustomizerAttributeFieldNumber = 2;
    private string customizerAttribute_ = "";
    /// <summary>
    /// Required. Immutable. The customizer attribute which is linked to the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomizerAttribute {
      get { return customizerAttribute_; }
      set {
        customizerAttribute_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus status_ = global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the customer customizer attribute.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V10.Common.CustomizerValue value_;
    /// <summary>
    /// Required. The value to associate with the customizer attribute at this level. The
    /// value must be of the type specified for the CustomizerAttribute.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Common.CustomizerValue Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerCustomizer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerCustomizer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CustomizerAttribute != other.CustomizerAttribute) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (CustomizerAttribute.Length != 0) hash ^= CustomizerAttribute.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) hash ^= Status.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (CustomizerAttribute.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (value_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Value);
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (CustomizerAttribute.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (value_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Value);
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
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (CustomizerAttribute.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerCustomizer other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.CustomizerAttribute.Length != 0) {
        CustomizerAttribute = other.CustomizerAttribute;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Google.Ads.GoogleAds.V10.Common.CustomizerValue();
        }
        Value.MergeFrom(other.Value);
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            CustomizerAttribute = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus) input.ReadEnum();
            break;
          }
          case 34: {
            if (value_ == null) {
              Value = new global::Google.Ads.GoogleAds.V10.Common.CustomizerValue();
            }
            input.ReadMessage(Value);
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            CustomizerAttribute = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Google.Ads.GoogleAds.V10.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus) input.ReadEnum();
            break;
          }
          case 34: {
            if (value_ == null) {
              Value = new global::Google.Ads.GoogleAds.V10.Common.CustomizerValue();
            }
            input.ReadMessage(Value);
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
