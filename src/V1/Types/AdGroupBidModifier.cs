// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/ad_group_bid_modifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/ad_group_bid_modifier.proto</summary>
  public static partial class AdGroupBidModifierReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/ad_group_bid_modifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupBidModifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "YmlkX21vZGlmaWVyLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52MS5y",
            "ZXNvdXJjZXMaLWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxL2NvbW1vbi9jcml0",
            "ZXJpYS5wcm90bxo3Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEvZW51bXMvYmlk",
            "X21vZGlmaWVyX3NvdXJjZS5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhh",
            "dmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xl",
            "L3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvIpEJChJBZEdyb3VwQmlkTW9kaWZpZXISSgoNcmVzb3VyY2Vf",
            "bmFtZRgBIAEoCUIz4EEF+kEtCitnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "QWRHcm91cEJpZE1vZGlmaWVyElgKCGFkX2dyb3VwGAIgASgLMhwuZ29vZ2xl",
            "LnByb3RvYnVmLlN0cmluZ1ZhbHVlQijgQQX6QSIKIGdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9BZEdyb3VwEjYKDGNyaXRlcmlvbl9pZBgDIAEoCzIbLmdv",
            "b2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlQgPgQQMSMgoMYmlkX21vZGlmaWVy",
            "GAQgASgLMhwuZ29vZ2xlLnByb3RvYnVmLkRvdWJsZVZhbHVlEl0KDWJhc2Vf",
            "YWRfZ3JvdXAYCSABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVC",
            "KOBBA/pBIgogZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXASaAoT",
            "YmlkX21vZGlmaWVyX3NvdXJjZRgKIAEoDjJGLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxLmVudW1zLkJpZE1vZGlmaWVyU291cmNlRW51bS5CaWRNb2RpZmll",
            "clNvdXJjZUID4EEDEmQKGWhvdGVsX2RhdGVfc2VsZWN0aW9uX3R5cGUYBSAB",
            "KAsyOi5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5jb21tb24uSG90ZWxEYXRl",
            "U2VsZWN0aW9uVHlwZUluZm9CA+BBBUgAEmoKHGhvdGVsX2FkdmFuY2VfYm9v",
            "a2luZ193aW5kb3cYBiABKAsyPS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5j",
            "b21tb24uSG90ZWxBZHZhbmNlQm9va2luZ1dpbmRvd0luZm9CA+BBBUgAEloK",
            "FGhvdGVsX2xlbmd0aF9vZl9zdGF5GAcgASgLMjUuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEuY29tbW9uLkhvdGVsTGVuZ3RoT2ZTdGF5SW5mb0ID4EEFSAAS",
            "VgoSaG90ZWxfY2hlY2tfaW5fZGF5GAggASgLMjMuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEuY29tbW9uLkhvdGVsQ2hlY2tJbkRheUluZm9CA+BBBUgAEkEK",
            "BmRldmljZRgLIAEoCzIqLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmNvbW1v",
            "bi5EZXZpY2VJbmZvQgPgQQVIABJWChFwcmVmZXJyZWRfY29udGVudBgMIAEo",
            "CzI0Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmNvbW1vbi5QcmVmZXJyZWRD",
            "b250ZW50SW5mb0ID4EEFSAA6cupBbworZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0FkR3JvdXBCaWRNb2RpZmllchJAY3VzdG9tZXJzL3tjdXN0b21lcn0v",
            "YWRHcm91cEJpZE1vZGlmaWVycy97YWRfZ3JvdXBfYmlkX21vZGlmaWVyfUIL",
            "Cgljcml0ZXJpb25ChAIKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5y",
            "ZXNvdXJjZXNCF0FkR3JvdXBCaWRNb2RpZmllclByb3RvUAFaSmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjEuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjFc",
            "UmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OlJlc291",
            "cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Common.CriteriaReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.AdGroupBidModifier), global::Google.Ads.GoogleAds.V1.Resources.AdGroupBidModifier.Parser, new[]{ "ResourceName", "AdGroup", "CriterionId", "BidModifier", "BaseAdGroup", "BidModifierSource", "HotelDateSelectionType", "HotelAdvanceBookingWindow", "HotelLengthOfStay", "HotelCheckInDay", "Device", "PreferredContent" }, new[]{ "Criterion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents an ad group bid modifier.
  /// </summary>
  public sealed partial class AdGroupBidModifier : pb::IMessage<AdGroupBidModifier> {
    private static readonly pb::MessageParser<AdGroupBidModifier> _parser = new pb::MessageParser<AdGroupBidModifier>(() => new AdGroupBidModifier());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupBidModifier> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.AdGroupBidModifierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupBidModifier() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupBidModifier(AdGroupBidModifier other) : this() {
      resourceName_ = other.resourceName_;
      AdGroup = other.AdGroup;
      CriterionId = other.CriterionId;
      BidModifier = other.BidModifier;
      BaseAdGroup = other.BaseAdGroup;
      bidModifierSource_ = other.bidModifierSource_;
      switch (other.CriterionCase) {
        case CriterionOneofCase.HotelDateSelectionType:
          HotelDateSelectionType = other.HotelDateSelectionType.Clone();
          break;
        case CriterionOneofCase.HotelAdvanceBookingWindow:
          HotelAdvanceBookingWindow = other.HotelAdvanceBookingWindow.Clone();
          break;
        case CriterionOneofCase.HotelLengthOfStay:
          HotelLengthOfStay = other.HotelLengthOfStay.Clone();
          break;
        case CriterionOneofCase.HotelCheckInDay:
          HotelCheckInDay = other.HotelCheckInDay.Clone();
          break;
        case CriterionOneofCase.Device:
          Device = other.Device.Clone();
          break;
        case CriterionOneofCase.PreferredContent:
          PreferredContent = other.PreferredContent.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupBidModifier Clone() {
      return new AdGroupBidModifier(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group bid modifier.
    /// Ad group bid modifier resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_adGroup_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string adGroup_;
    /// <summary>
    /// Immutable. The ad group to which this criterion belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = value;
      }
    }


    /// <summary>Field number for the "criterion_id" field.</summary>
    public const int CriterionIdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_criterionId_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? criterionId_;
    /// <summary>
    /// Output only. The ID of the criterion to bid modify.
    ///
    /// This field is ignored for mutates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CriterionId {
      get { return criterionId_; }
      set {
        criterionId_ = value;
      }
    }


    /// <summary>Field number for the "bid_modifier" field.</summary>
    public const int BidModifierFieldNumber = 4;
    private static readonly pb::FieldCodec<double?> _single_bidModifier_codec = pb::FieldCodec.ForStructWrapper<double>(34);
    private double? bidModifier_;
    /// <summary>
    /// The modifier for the bid when the criterion matches. The modifier must be
    /// in the range: 0.1 - 10.0. The range is 1.0 - 6.0 for PreferredContent.
    /// Use 0 to opt out of a Device type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double? BidModifier {
      get { return bidModifier_; }
      set {
        bidModifier_ = value;
      }
    }


    /// <summary>Field number for the "base_ad_group" field.</summary>
    public const int BaseAdGroupFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _single_baseAdGroup_codec = pb::FieldCodec.ForClassWrapper<string>(74);
    private string baseAdGroup_;
    /// <summary>
    /// Output only. The base ad group from which this draft/trial adgroup bid modifier was
    /// created. If ad_group is a base ad group then this field will be equal to
    /// ad_group. If the ad group was created in the draft or trial and has no
    /// corresponding base ad group, then this field will be null.
    /// This field is readonly.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BaseAdGroup {
      get { return baseAdGroup_; }
      set {
        baseAdGroup_ = value;
      }
    }


    /// <summary>Field number for the "bid_modifier_source" field.</summary>
    public const int BidModifierSourceFieldNumber = 10;
    private global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceEnum.Types.BidModifierSource bidModifierSource_ = global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceEnum.Types.BidModifierSource.Unspecified;
    /// <summary>
    /// Output only. Bid modifier source.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceEnum.Types.BidModifierSource BidModifierSource {
      get { return bidModifierSource_; }
      set {
        bidModifierSource_ = value;
      }
    }

    /// <summary>Field number for the "hotel_date_selection_type" field.</summary>
    public const int HotelDateSelectionTypeFieldNumber = 5;
    /// <summary>
    /// Immutable. Criterion for hotel date selection (default dates vs. user selected).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.HotelDateSelectionTypeInfo HotelDateSelectionType {
      get { return criterionCase_ == CriterionOneofCase.HotelDateSelectionType ? (global::Google.Ads.GoogleAds.V1.Common.HotelDateSelectionTypeInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.HotelDateSelectionType;
      }
    }

    /// <summary>Field number for the "hotel_advance_booking_window" field.</summary>
    public const int HotelAdvanceBookingWindowFieldNumber = 6;
    /// <summary>
    /// Immutable. Criterion for number of days prior to the stay the booking is being made.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.HotelAdvanceBookingWindowInfo HotelAdvanceBookingWindow {
      get { return criterionCase_ == CriterionOneofCase.HotelAdvanceBookingWindow ? (global::Google.Ads.GoogleAds.V1.Common.HotelAdvanceBookingWindowInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.HotelAdvanceBookingWindow;
      }
    }

    /// <summary>Field number for the "hotel_length_of_stay" field.</summary>
    public const int HotelLengthOfStayFieldNumber = 7;
    /// <summary>
    /// Immutable. Criterion for length of hotel stay in nights.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.HotelLengthOfStayInfo HotelLengthOfStay {
      get { return criterionCase_ == CriterionOneofCase.HotelLengthOfStay ? (global::Google.Ads.GoogleAds.V1.Common.HotelLengthOfStayInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.HotelLengthOfStay;
      }
    }

    /// <summary>Field number for the "hotel_check_in_day" field.</summary>
    public const int HotelCheckInDayFieldNumber = 8;
    /// <summary>
    /// Immutable. Criterion for day of the week the booking is for.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.HotelCheckInDayInfo HotelCheckInDay {
      get { return criterionCase_ == CriterionOneofCase.HotelCheckInDay ? (global::Google.Ads.GoogleAds.V1.Common.HotelCheckInDayInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.HotelCheckInDay;
      }
    }

    /// <summary>Field number for the "device" field.</summary>
    public const int DeviceFieldNumber = 11;
    /// <summary>
    /// Immutable. A device criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.DeviceInfo Device {
      get { return criterionCase_ == CriterionOneofCase.Device ? (global::Google.Ads.GoogleAds.V1.Common.DeviceInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.Device;
      }
    }

    /// <summary>Field number for the "preferred_content" field.</summary>
    public const int PreferredContentFieldNumber = 12;
    /// <summary>
    /// Immutable. A preferred content criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.PreferredContentInfo PreferredContent {
      get { return criterionCase_ == CriterionOneofCase.PreferredContent ? (global::Google.Ads.GoogleAds.V1.Common.PreferredContentInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.PreferredContent;
      }
    }

    private object criterion_;
    /// <summary>Enum of possible cases for the "criterion" oneof.</summary>
    public enum CriterionOneofCase {
      None = 0,
      HotelDateSelectionType = 5,
      HotelAdvanceBookingWindow = 6,
      HotelLengthOfStay = 7,
      HotelCheckInDay = 8,
      Device = 11,
      PreferredContent = 12,
    }
    private CriterionOneofCase criterionCase_ = CriterionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionOneofCase CriterionCase {
      get { return criterionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCriterion() {
      criterionCase_ = CriterionOneofCase.None;
      criterion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupBidModifier);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupBidModifier other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroup != other.AdGroup) return false;
      if (CriterionId != other.CriterionId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseNullableDoubleEqualityComparer.Equals(BidModifier, other.BidModifier)) return false;
      if (BaseAdGroup != other.BaseAdGroup) return false;
      if (BidModifierSource != other.BidModifierSource) return false;
      if (!object.Equals(HotelDateSelectionType, other.HotelDateSelectionType)) return false;
      if (!object.Equals(HotelAdvanceBookingWindow, other.HotelAdvanceBookingWindow)) return false;
      if (!object.Equals(HotelLengthOfStay, other.HotelLengthOfStay)) return false;
      if (!object.Equals(HotelCheckInDay, other.HotelCheckInDay)) return false;
      if (!object.Equals(Device, other.Device)) return false;
      if (!object.Equals(PreferredContent, other.PreferredContent)) return false;
      if (CriterionCase != other.CriterionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (adGroup_ != null) hash ^= AdGroup.GetHashCode();
      if (criterionId_ != null) hash ^= CriterionId.GetHashCode();
      if (bidModifier_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableDoubleEqualityComparer.GetHashCode(BidModifier);
      if (baseAdGroup_ != null) hash ^= BaseAdGroup.GetHashCode();
      if (BidModifierSource != global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceEnum.Types.BidModifierSource.Unspecified) hash ^= BidModifierSource.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.HotelDateSelectionType) hash ^= HotelDateSelectionType.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.HotelAdvanceBookingWindow) hash ^= HotelAdvanceBookingWindow.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.HotelLengthOfStay) hash ^= HotelLengthOfStay.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.HotelCheckInDay) hash ^= HotelCheckInDay.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.Device) hash ^= Device.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.PreferredContent) hash ^= PreferredContent.GetHashCode();
      hash ^= (int) criterionCase_;
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
      if (adGroup_ != null) {
        _single_adGroup_codec.WriteTagAndValue(output, AdGroup);
      }
      if (criterionId_ != null) {
        _single_criterionId_codec.WriteTagAndValue(output, CriterionId);
      }
      if (bidModifier_ != null) {
        _single_bidModifier_codec.WriteTagAndValue(output, BidModifier);
      }
      if (criterionCase_ == CriterionOneofCase.HotelDateSelectionType) {
        output.WriteRawTag(42);
        output.WriteMessage(HotelDateSelectionType);
      }
      if (criterionCase_ == CriterionOneofCase.HotelAdvanceBookingWindow) {
        output.WriteRawTag(50);
        output.WriteMessage(HotelAdvanceBookingWindow);
      }
      if (criterionCase_ == CriterionOneofCase.HotelLengthOfStay) {
        output.WriteRawTag(58);
        output.WriteMessage(HotelLengthOfStay);
      }
      if (criterionCase_ == CriterionOneofCase.HotelCheckInDay) {
        output.WriteRawTag(66);
        output.WriteMessage(HotelCheckInDay);
      }
      if (baseAdGroup_ != null) {
        _single_baseAdGroup_codec.WriteTagAndValue(output, BaseAdGroup);
      }
      if (BidModifierSource != global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceEnum.Types.BidModifierSource.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) BidModifierSource);
      }
      if (criterionCase_ == CriterionOneofCase.Device) {
        output.WriteRawTag(90);
        output.WriteMessage(Device);
      }
      if (criterionCase_ == CriterionOneofCase.PreferredContent) {
        output.WriteRawTag(98);
        output.WriteMessage(PreferredContent);
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
      if (adGroup_ != null) {
        size += _single_adGroup_codec.CalculateSizeWithTag(AdGroup);
      }
      if (criterionId_ != null) {
        size += _single_criterionId_codec.CalculateSizeWithTag(CriterionId);
      }
      if (bidModifier_ != null) {
        size += _single_bidModifier_codec.CalculateSizeWithTag(BidModifier);
      }
      if (baseAdGroup_ != null) {
        size += _single_baseAdGroup_codec.CalculateSizeWithTag(BaseAdGroup);
      }
      if (BidModifierSource != global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceEnum.Types.BidModifierSource.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BidModifierSource);
      }
      if (criterionCase_ == CriterionOneofCase.HotelDateSelectionType) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HotelDateSelectionType);
      }
      if (criterionCase_ == CriterionOneofCase.HotelAdvanceBookingWindow) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HotelAdvanceBookingWindow);
      }
      if (criterionCase_ == CriterionOneofCase.HotelLengthOfStay) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HotelLengthOfStay);
      }
      if (criterionCase_ == CriterionOneofCase.HotelCheckInDay) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HotelCheckInDay);
      }
      if (criterionCase_ == CriterionOneofCase.Device) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Device);
      }
      if (criterionCase_ == CriterionOneofCase.PreferredContent) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PreferredContent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupBidModifier other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.adGroup_ != null) {
        if (adGroup_ == null || other.AdGroup != "") {
          AdGroup = other.AdGroup;
        }
      }
      if (other.criterionId_ != null) {
        if (criterionId_ == null || other.CriterionId != 0L) {
          CriterionId = other.CriterionId;
        }
      }
      if (other.bidModifier_ != null) {
        if (bidModifier_ == null || other.BidModifier != 0D) {
          BidModifier = other.BidModifier;
        }
      }
      if (other.baseAdGroup_ != null) {
        if (baseAdGroup_ == null || other.BaseAdGroup != "") {
          BaseAdGroup = other.BaseAdGroup;
        }
      }
      if (other.BidModifierSource != global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceEnum.Types.BidModifierSource.Unspecified) {
        BidModifierSource = other.BidModifierSource;
      }
      switch (other.CriterionCase) {
        case CriterionOneofCase.HotelDateSelectionType:
          if (HotelDateSelectionType == null) {
            HotelDateSelectionType = new global::Google.Ads.GoogleAds.V1.Common.HotelDateSelectionTypeInfo();
          }
          HotelDateSelectionType.MergeFrom(other.HotelDateSelectionType);
          break;
        case CriterionOneofCase.HotelAdvanceBookingWindow:
          if (HotelAdvanceBookingWindow == null) {
            HotelAdvanceBookingWindow = new global::Google.Ads.GoogleAds.V1.Common.HotelAdvanceBookingWindowInfo();
          }
          HotelAdvanceBookingWindow.MergeFrom(other.HotelAdvanceBookingWindow);
          break;
        case CriterionOneofCase.HotelLengthOfStay:
          if (HotelLengthOfStay == null) {
            HotelLengthOfStay = new global::Google.Ads.GoogleAds.V1.Common.HotelLengthOfStayInfo();
          }
          HotelLengthOfStay.MergeFrom(other.HotelLengthOfStay);
          break;
        case CriterionOneofCase.HotelCheckInDay:
          if (HotelCheckInDay == null) {
            HotelCheckInDay = new global::Google.Ads.GoogleAds.V1.Common.HotelCheckInDayInfo();
          }
          HotelCheckInDay.MergeFrom(other.HotelCheckInDay);
          break;
        case CriterionOneofCase.Device:
          if (Device == null) {
            Device = new global::Google.Ads.GoogleAds.V1.Common.DeviceInfo();
          }
          Device.MergeFrom(other.Device);
          break;
        case CriterionOneofCase.PreferredContent:
          if (PreferredContent == null) {
            PreferredContent = new global::Google.Ads.GoogleAds.V1.Common.PreferredContentInfo();
          }
          PreferredContent.MergeFrom(other.PreferredContent);
          break;
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
          case 18: {
            string value = _single_adGroup_codec.Read(input);
            if (adGroup_ == null || value != "") {
              AdGroup = value;
            }
            break;
          }
          case 26: {
            long? value = _single_criterionId_codec.Read(input);
            if (criterionId_ == null || value != 0L) {
              CriterionId = value;
            }
            break;
          }
          case 34: {
            double? value = _single_bidModifier_codec.Read(input);
            if (bidModifier_ == null || value != 0D) {
              BidModifier = value;
            }
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V1.Common.HotelDateSelectionTypeInfo subBuilder = new global::Google.Ads.GoogleAds.V1.Common.HotelDateSelectionTypeInfo();
            if (criterionCase_ == CriterionOneofCase.HotelDateSelectionType) {
              subBuilder.MergeFrom(HotelDateSelectionType);
            }
            input.ReadMessage(subBuilder);
            HotelDateSelectionType = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V1.Common.HotelAdvanceBookingWindowInfo subBuilder = new global::Google.Ads.GoogleAds.V1.Common.HotelAdvanceBookingWindowInfo();
            if (criterionCase_ == CriterionOneofCase.HotelAdvanceBookingWindow) {
              subBuilder.MergeFrom(HotelAdvanceBookingWindow);
            }
            input.ReadMessage(subBuilder);
            HotelAdvanceBookingWindow = subBuilder;
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V1.Common.HotelLengthOfStayInfo subBuilder = new global::Google.Ads.GoogleAds.V1.Common.HotelLengthOfStayInfo();
            if (criterionCase_ == CriterionOneofCase.HotelLengthOfStay) {
              subBuilder.MergeFrom(HotelLengthOfStay);
            }
            input.ReadMessage(subBuilder);
            HotelLengthOfStay = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V1.Common.HotelCheckInDayInfo subBuilder = new global::Google.Ads.GoogleAds.V1.Common.HotelCheckInDayInfo();
            if (criterionCase_ == CriterionOneofCase.HotelCheckInDay) {
              subBuilder.MergeFrom(HotelCheckInDay);
            }
            input.ReadMessage(subBuilder);
            HotelCheckInDay = subBuilder;
            break;
          }
          case 74: {
            string value = _single_baseAdGroup_codec.Read(input);
            if (baseAdGroup_ == null || value != "") {
              BaseAdGroup = value;
            }
            break;
          }
          case 80: {
            BidModifierSource = (global::Google.Ads.GoogleAds.V1.Enums.BidModifierSourceEnum.Types.BidModifierSource) input.ReadEnum();
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V1.Common.DeviceInfo subBuilder = new global::Google.Ads.GoogleAds.V1.Common.DeviceInfo();
            if (criterionCase_ == CriterionOneofCase.Device) {
              subBuilder.MergeFrom(Device);
            }
            input.ReadMessage(subBuilder);
            Device = subBuilder;
            break;
          }
          case 98: {
            global::Google.Ads.GoogleAds.V1.Common.PreferredContentInfo subBuilder = new global::Google.Ads.GoogleAds.V1.Common.PreferredContentInfo();
            if (criterionCase_ == CriterionOneofCase.PreferredContent) {
              subBuilder.MergeFrom(PreferredContent);
            }
            input.ReadMessage(subBuilder);
            PreferredContent = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
