// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/list_operation_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/list_operation_error.proto</summary>
  public static partial class ListOperationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/list_operation_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListOperationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvbGlzdF9vcGVyYXRp",
            "b25fZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVycm9y",
            "cxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJ+ChZMaXN0T3BlcmF0",
            "aW9uRXJyb3JFbnVtImQKEkxpc3RPcGVyYXRpb25FcnJvchIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIaChZSRVFVSVJFRF9GSUVMRF9NSVNTSU5H",
            "EAcSFAoQRFVQTElDQVRFX1ZBTFVFUxAIQvIBCiJjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjEuZXJyb3JzQhdMaXN0T3BlcmF0aW9uRXJyb3JQcm90b1AB",
            "WkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjEvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlYxLkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYx",
            "XEVycm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOjpFcnJvcnNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.ListOperationErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.ListOperationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.ListOperationErrorEnum.Types.ListOperationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible list operation errors.
  /// </summary>
  public sealed partial class ListOperationErrorEnum : pb::IMessage<ListOperationErrorEnum> {
    private static readonly pb::MessageParser<ListOperationErrorEnum> _parser = new pb::MessageParser<ListOperationErrorEnum>(() => new ListOperationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListOperationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.ListOperationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListOperationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListOperationErrorEnum(ListOperationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListOperationErrorEnum Clone() {
      return new ListOperationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListOperationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListOperationErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListOperationErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ListOperationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible list operation errors.
      /// </summary>
      public enum ListOperationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Field required in value is missing.
        /// </summary>
        [pbr::OriginalName("REQUIRED_FIELD_MISSING")] RequiredFieldMissing = 7,
        /// <summary>
        /// Duplicate or identical value is sent in multiple list operations.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_VALUES")] DuplicateValues = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
