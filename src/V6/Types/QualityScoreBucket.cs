// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/enums/quality_score_bucket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/enums/quality_score_bucket.proto</summary>
  public static partial class QualityScoreBucketReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/enums/quality_score_bucket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QualityScoreBucketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9lbnVtcy9xdWFsaXR5X3Njb3Jl",
            "X2J1Y2tldC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjYuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ifwoWUXVhbGl0eVNjb3Jl",
            "QnVja2V0RW51bSJlChJRdWFsaXR5U2NvcmVCdWNrZXQSDwoLVU5TUEVDSUZJ",
            "RUQQABILCgdVTktOT1dOEAESEQoNQkVMT1dfQVZFUkFHRRACEgsKB0FWRVJB",
            "R0UQAxIRCg1BQk9WRV9BVkVSQUdFEARC7AEKIWNvbS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52Ni5lbnVtc0IXUXVhbGl0eVNjb3JlQnVja2V0UHJvdG9QAVpC",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3Y2L2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjYuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWNlxFbnVt",
            "c+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY2OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Enums.QualityScoreBucketEnum), global::Google.Ads.GoogleAds.V6.Enums.QualityScoreBucketEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V6.Enums.QualityScoreBucketEnum.Types.QualityScoreBucket) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The relative performance compared to other advertisers.
  /// </summary>
  public sealed partial class QualityScoreBucketEnum : pb::IMessage<QualityScoreBucketEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QualityScoreBucketEnum> _parser = new pb::MessageParser<QualityScoreBucketEnum>(() => new QualityScoreBucketEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QualityScoreBucketEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Enums.QualityScoreBucketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QualityScoreBucketEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QualityScoreBucketEnum(QualityScoreBucketEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QualityScoreBucketEnum Clone() {
      return new QualityScoreBucketEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QualityScoreBucketEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QualityScoreBucketEnum other) {
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QualityScoreBucketEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the QualityScoreBucketEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum listing the possible quality score buckets.
      /// </summary>
      public enum QualityScoreBucket {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Quality of the creative is below average.
        /// </summary>
        [pbr::OriginalName("BELOW_AVERAGE")] BelowAverage = 2,
        /// <summary>
        /// Quality of the creative is average.
        /// </summary>
        [pbr::OriginalName("AVERAGE")] Average = 3,
        /// <summary>
        /// Quality of the creative is above average.
        /// </summary>
        [pbr::OriginalName("ABOVE_AVERAGE")] AboveAverage = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code