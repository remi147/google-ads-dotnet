// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/ad_group_ad.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/ad_group_ad.proto</summary>
  public static partial class AdGroupAdReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/ad_group_ad.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "YWQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LnJlc291cmNlcxor",
            "Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvY29tbW9uL3BvbGljeS5wcm90bxo2",
            "Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvZW51bXMvYWRfZ3JvdXBfYWRfc3Rh",
            "dHVzLnByb3RvGi9nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9hZF9z",
            "dHJlbmd0aC5wcm90bxo6Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvZW51bXMv",
            "cG9saWN5X2FwcHJvdmFsX3N0YXR1cy5wcm90bxo4Z29vZ2xlL2Fkcy9nb29n",
            "bGVhZHMvdjcvZW51bXMvcG9saWN5X3Jldmlld19zdGF0dXMucHJvdG8aKmdv",
            "b2dsZS9hZHMvZ29vZ2xlYWRzL3Y3L3Jlc291cmNlcy9hZC5wcm90bxofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byL4BAoJ",
            "QWRHcm91cEFkEkEKDXJlc291cmNlX25hbWUYASABKAlCKuBBBfpBJAoiZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBBZBJSCgZzdGF0dXMYAyAB",
            "KA4yQi5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5lbnVtcy5BZEdyb3VwQWRT",
            "dGF0dXNFbnVtLkFkR3JvdXBBZFN0YXR1cxI/CghhZF9ncm91cBgJIAEoCUIo",
            "4EEF+kEiCiBnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cEgAiAEB",
            "EjYKAmFkGAUgASgLMiUuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcucmVzb3Vy",
            "Y2VzLkFkQgPgQQUSVgoOcG9saWN5X3N1bW1hcnkYBiABKAsyOS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52Ny5yZXNvdXJjZXMuQWRHcm91cEFkUG9saWN5U3Vt",
            "bWFyeUID4EEDElIKC2FkX3N0cmVuZ3RoGAcgASgOMjguZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjcuZW51bXMuQWRTdHJlbmd0aEVudW0uQWRTdHJlbmd0aEID",
            "4EEDEj8KBmxhYmVscxgKIAMoCUIv4EED+kEpCidnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQWRHcm91cEFkTGFiZWw6YepBXgoiZ29vZ2xlYWRzLmdvb2ds",
            "ZWFwaXMuY29tL0FkR3JvdXBBZBI4Y3VzdG9tZXJzL3tjdXN0b21lcl9pZH0v",
            "YWRHcm91cEFkcy97YWRfZ3JvdXBfaWR9fnthZF9pZH1CCwoJX2FkX2dyb3Vw",
            "Ir8CChZBZEdyb3VwQWRQb2xpY3lTdW1tYXJ5ElMKFHBvbGljeV90b3BpY19l",
            "bnRyaWVzGAEgAygLMjAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuY29tbW9u",
            "LlBvbGljeVRvcGljRW50cnlCA+BBAxJkCg1yZXZpZXdfc3RhdHVzGAIgASgO",
            "MkguZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZW51bXMuUG9saWN5UmV2aWV3",
            "U3RhdHVzRW51bS5Qb2xpY3lSZXZpZXdTdGF0dXNCA+BBAxJqCg9hcHByb3Zh",
            "bF9zdGF0dXMYAyABKA4yTC5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5lbnVt",
            "cy5Qb2xpY3lBcHByb3ZhbFN0YXR1c0VudW0uUG9saWN5QXBwcm92YWxTdGF0",
            "dXNCA+BBA0L7AQolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LnJlc291",
            "cmNlc0IOQWRHcm91cEFkUHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y3L3Jlc291cmNlczty",
            "ZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WNy5SZXNv",
            "dXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWN1xSZXNvdXJjZXPqAiVH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNzo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Common.PolicyReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.AdStrengthReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Resources.AdReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.AdGroupAd), global::Google.Ads.GoogleAds.V7.Resources.AdGroupAd.Parser, new[]{ "ResourceName", "Status", "AdGroup", "Ad", "PolicySummary", "AdStrength", "Labels" }, new[]{ "AdGroup" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdPolicySummary), global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdPolicySummary.Parser, new[]{ "PolicyTopicEntries", "ReviewStatus", "ApprovalStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An ad group ad.
  /// </summary>
  public sealed partial class AdGroupAd : pb::IMessage<AdGroupAd>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAd> _parser = new pb::MessageParser<AdGroupAd>(() => new AdGroupAd());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupAd> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAd() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAd(AdGroupAd other) : this() {
      resourceName_ = other.resourceName_;
      status_ = other.status_;
      adGroup_ = other.adGroup_;
      ad_ = other.ad_ != null ? other.ad_.Clone() : null;
      policySummary_ = other.policySummary_ != null ? other.policySummary_.Clone() : null;
      adStrength_ = other.adStrength_;
      labels_ = other.labels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAd Clone() {
      return new AdGroupAd(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad.
    /// Ad group ad resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupAds/{ad_group_id}~{ad_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus status_ = global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified;
    /// <summary>
    /// The status of the ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 9;
    private string adGroup_;
    /// <summary>
    /// Immutable. The ad group to which the ad belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_ ?? ""; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAdGroup {
      get { return adGroup_ != null; }
    }
    /// <summary>Clears the value of the "ad_group" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAdGroup() {
      adGroup_ = null;
    }

    /// <summary>Field number for the "ad" field.</summary>
    public const int AdFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V7.Resources.Ad ad_;
    /// <summary>
    /// Immutable. The ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V7.Resources.Ad Ad {
      get { return ad_; }
      set {
        ad_ = value;
      }
    }

    /// <summary>Field number for the "policy_summary" field.</summary>
    public const int PolicySummaryFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdPolicySummary policySummary_;
    /// <summary>
    /// Output only. Policy information for the ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdPolicySummary PolicySummary {
      get { return policySummary_; }
      set {
        policySummary_ = value;
      }
    }

    /// <summary>Field number for the "ad_strength" field.</summary>
    public const int AdStrengthFieldNumber = 7;
    private global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength adStrength_ = global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength.Unspecified;
    /// <summary>
    /// Output only. Overall ad strength for this ad group ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength AdStrength {
      get { return adStrength_; }
      set {
        adStrength_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _repeated_labels_codec
        = pb::FieldCodec.ForString(82);
    private readonly pbc::RepeatedField<string> labels_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The resource names of labels attached to this ad group ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Labels {
      get { return labels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAd);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupAd other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Status != other.Status) return false;
      if (AdGroup != other.AdGroup) return false;
      if (!object.Equals(Ad, other.Ad)) return false;
      if (!object.Equals(PolicySummary, other.PolicySummary)) return false;
      if (AdStrength != other.AdStrength) return false;
      if(!labels_.Equals(other.labels_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) hash ^= Status.GetHashCode();
      if (HasAdGroup) hash ^= AdGroup.GetHashCode();
      if (ad_ != null) hash ^= Ad.GetHashCode();
      if (policySummary_ != null) hash ^= PolicySummary.GetHashCode();
      if (AdStrength != global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) hash ^= AdStrength.GetHashCode();
      hash ^= labels_.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (ad_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Ad);
      }
      if (policySummary_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PolicySummary);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) AdStrength);
      }
      if (HasAdGroup) {
        output.WriteRawTag(74);
        output.WriteString(AdGroup);
      }
      labels_.WriteTo(output, _repeated_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (ad_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Ad);
      }
      if (policySummary_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PolicySummary);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) AdStrength);
      }
      if (HasAdGroup) {
        output.WriteRawTag(74);
        output.WriteString(AdGroup);
      }
      labels_.WriteTo(ref output, _repeated_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (HasAdGroup) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (ad_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ad);
      }
      if (policySummary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PolicySummary);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AdStrength);
      }
      size += labels_.CalculateSize(_repeated_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupAd other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.HasAdGroup) {
        AdGroup = other.AdGroup;
      }
      if (other.ad_ != null) {
        if (ad_ == null) {
          Ad = new global::Google.Ads.GoogleAds.V7.Resources.Ad();
        }
        Ad.MergeFrom(other.Ad);
      }
      if (other.policySummary_ != null) {
        if (policySummary_ == null) {
          PolicySummary = new global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdPolicySummary();
        }
        PolicySummary.MergeFrom(other.PolicySummary);
      }
      if (other.AdStrength != global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        AdStrength = other.AdStrength;
      }
      labels_.Add(other.labels_);
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (ad_ == null) {
              Ad = new global::Google.Ads.GoogleAds.V7.Resources.Ad();
            }
            input.ReadMessage(Ad);
            break;
          }
          case 50: {
            if (policySummary_ == null) {
              PolicySummary = new global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdPolicySummary();
            }
            input.ReadMessage(PolicySummary);
            break;
          }
          case 56: {
            AdStrength = (global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength) input.ReadEnum();
            break;
          }
          case 74: {
            AdGroup = input.ReadString();
            break;
          }
          case 82: {
            labels_.AddEntriesFrom(input, _repeated_labels_codec);
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types.AdGroupAdStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (ad_ == null) {
              Ad = new global::Google.Ads.GoogleAds.V7.Resources.Ad();
            }
            input.ReadMessage(Ad);
            break;
          }
          case 50: {
            if (policySummary_ == null) {
              PolicySummary = new global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdPolicySummary();
            }
            input.ReadMessage(PolicySummary);
            break;
          }
          case 56: {
            AdStrength = (global::Google.Ads.GoogleAds.V7.Enums.AdStrengthEnum.Types.AdStrength) input.ReadEnum();
            break;
          }
          case 74: {
            AdGroup = input.ReadString();
            break;
          }
          case 82: {
            labels_.AddEntriesFrom(ref input, _repeated_labels_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Contains policy information for an ad.
  /// </summary>
  public sealed partial class AdGroupAdPolicySummary : pb::IMessage<AdGroupAdPolicySummary>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAdPolicySummary> _parser = new pb::MessageParser<AdGroupAdPolicySummary>(() => new AdGroupAdPolicySummary());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupAdPolicySummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.AdGroupAdReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdPolicySummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdPolicySummary(AdGroupAdPolicySummary other) : this() {
      policyTopicEntries_ = other.policyTopicEntries_.Clone();
      reviewStatus_ = other.reviewStatus_;
      approvalStatus_ = other.approvalStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdPolicySummary Clone() {
      return new AdGroupAdPolicySummary(this);
    }

    /// <summary>Field number for the "policy_topic_entries" field.</summary>
    public const int PolicyTopicEntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V7.Common.PolicyTopicEntry> _repeated_policyTopicEntries_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V7.Common.PolicyTopicEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V7.Common.PolicyTopicEntry> policyTopicEntries_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V7.Common.PolicyTopicEntry>();
    /// <summary>
    /// Output only. The list of policy findings for this ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V7.Common.PolicyTopicEntry> PolicyTopicEntries {
      get { return policyTopicEntries_; }
    }

    /// <summary>Field number for the "review_status" field.</summary>
    public const int ReviewStatusFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus reviewStatus_ = global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified;
    /// <summary>
    /// Output only. Where in the review process this ad is.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus ReviewStatus {
      get { return reviewStatus_; }
      set {
        reviewStatus_ = value;
      }
    }

    /// <summary>Field number for the "approval_status" field.</summary>
    public const int ApprovalStatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus approvalStatus_ = global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified;
    /// <summary>
    /// Output only. The overall approval status of this ad, calculated based on the status of
    /// its individual policy topic entries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus ApprovalStatus {
      get { return approvalStatus_; }
      set {
        approvalStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdPolicySummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupAdPolicySummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!policyTopicEntries_.Equals(other.policyTopicEntries_)) return false;
      if (ReviewStatus != other.ReviewStatus) return false;
      if (ApprovalStatus != other.ApprovalStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= policyTopicEntries_.GetHashCode();
      if (ReviewStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) hash ^= ReviewStatus.GetHashCode();
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) hash ^= ApprovalStatus.GetHashCode();
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
      policyTopicEntries_.WriteTo(output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      policyTopicEntries_.WriteTo(ref output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += policyTopicEntries_.CalculateSize(_repeated_policyTopicEntries_codec);
      if (ReviewStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReviewStatus);
      }
      if (ApprovalStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ApprovalStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupAdPolicySummary other) {
      if (other == null) {
        return;
      }
      policyTopicEntries_.Add(other.policyTopicEntries_);
      if (other.ReviewStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus.Unspecified) {
        ReviewStatus = other.ReviewStatus;
      }
      if (other.ApprovalStatus != global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus.Unspecified) {
        ApprovalStatus = other.ApprovalStatus;
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
          case 10: {
            policyTopicEntries_.AddEntriesFrom(input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
            break;
          }
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
          case 10: {
            policyTopicEntries_.AddEntriesFrom(ref input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V7.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V7.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
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