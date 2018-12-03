// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/placeholder_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/placeholder_type.proto</summary>
  public static partial class PlaceholderTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/placeholder_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlaceholderTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9wbGFjZWhvbGRlcl90",
            "eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtcyKQAwoT",
            "UGxhY2Vob2xkZXJUeXBlRW51bSL4AgoPUGxhY2Vob2xkZXJUeXBlEg8KC1VO",
            "U1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgwKCFNJVEVMSU5LEAISCAoEQ0FM",
            "TBADEgcKA0FQUBAEEgwKCExPQ0FUSU9OEAUSFgoSQUZGSUxJQVRFX0xPQ0FU",
            "SU9OEAYSCwoHQ0FMTE9VVBAHEhYKElNUUlVDVFVSRURfU05JUFBFVBAIEgsK",
            "B01FU1NBR0UQCRIJCgVQUklDRRAKEg0KCVBST01PVElPThALEhEKDUFEX0NV",
            "U1RPTUlaRVIQDBIVChFEWU5BTUlDX0VEVUNBVElPThANEhIKDkRZTkFNSUNf",
            "RkxJR0hUEA4SEgoORFlOQU1JQ19DVVNUT00QDxIRCg1EWU5BTUlDX0hPVEVM",
            "EBASFwoTRFlOQU1JQ19SRUFMX0VTVEFURRAREhIKDkRZTkFNSUNfVFJBVkVM",
            "EBISEQoNRFlOQU1JQ19MT0NBTBATEg8KC0RZTkFNSUNfSk9CEBRCxQEKIWNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtc0IUUGxhY2Vob2xkZXJU",
            "eXBlUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2VudW1zO2VudW1zogIDR0FBqgIdR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjAuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMFxFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum.Types.PlaceholderType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible placeholder types for a feed mapping.
  /// </summary>
  public sealed partial class PlaceholderTypeEnum : pb::IMessage<PlaceholderTypeEnum> {
    private static readonly pb::MessageParser<PlaceholderTypeEnum> _parser = new pb::MessageParser<PlaceholderTypeEnum>(() => new PlaceholderTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlaceholderTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlaceholderTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlaceholderTypeEnum(PlaceholderTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlaceholderTypeEnum Clone() {
      return new PlaceholderTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlaceholderTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlaceholderTypeEnum other) {
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
    public void MergeFrom(PlaceholderTypeEnum other) {
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
    /// <summary>Container for nested types declared in the PlaceholderTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible placeholder types for a feed mapping.
      /// </summary>
      public enum PlaceholderType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Sitelink.
        /// </summary>
        [pbr::OriginalName("SITELINK")] Sitelink = 2,
        /// <summary>
        /// Call.
        /// </summary>
        [pbr::OriginalName("CALL")] Call = 3,
        /// <summary>
        /// App.
        /// </summary>
        [pbr::OriginalName("APP")] App = 4,
        /// <summary>
        /// Location.
        /// </summary>
        [pbr::OriginalName("LOCATION")] Location = 5,
        /// <summary>
        /// Affiliate location.
        /// </summary>
        [pbr::OriginalName("AFFILIATE_LOCATION")] AffiliateLocation = 6,
        /// <summary>
        /// Callout.
        /// </summary>
        [pbr::OriginalName("CALLOUT")] Callout = 7,
        /// <summary>
        /// Structured snippet.
        /// </summary>
        [pbr::OriginalName("STRUCTURED_SNIPPET")] StructuredSnippet = 8,
        /// <summary>
        /// Message.
        /// </summary>
        [pbr::OriginalName("MESSAGE")] Message = 9,
        /// <summary>
        /// Price.
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 10,
        /// <summary>
        /// Promotion.
        /// </summary>
        [pbr::OriginalName("PROMOTION")] Promotion = 11,
        /// <summary>
        /// Ad customizer.
        /// </summary>
        [pbr::OriginalName("AD_CUSTOMIZER")] AdCustomizer = 12,
        /// <summary>
        /// Dynamic education.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_EDUCATION")] DynamicEducation = 13,
        /// <summary>
        /// Dynamic flights.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_FLIGHT")] DynamicFlight = 14,
        /// <summary>
        /// Dynamic custom.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_CUSTOM")] DynamicCustom = 15,
        /// <summary>
        /// Dynamic hotels.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_HOTEL")] DynamicHotel = 16,
        /// <summary>
        /// Dynamic real estate.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_REAL_ESTATE")] DynamicRealEstate = 17,
        /// <summary>
        /// Dynamic travel.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_TRAVEL")] DynamicTravel = 18,
        /// <summary>
        /// Dynamic local.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_LOCAL")] DynamicLocal = 19,
        /// <summary>
        /// Dynamic jobs.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_JOB")] DynamicJob = 20,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code