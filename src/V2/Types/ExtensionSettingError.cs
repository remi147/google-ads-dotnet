// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/errors/extension_setting_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/errors/extension_setting_error.proto</summary>
  public static partial class ExtensionSettingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/errors/extension_setting_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtensionSettingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnMvZXh0ZW5zaW9uX3Nl",
            "dHRpbmdfZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVy",
            "cm9ycxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKYFAoZRXh0ZW5z",
            "aW9uU2V0dGluZ0Vycm9yRW51bSL6EwoVRXh0ZW5zaW9uU2V0dGluZ0Vycm9y",
            "Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhcKE0VYVEVOU0lPTlNf",
            "UkVRVUlSRUQQAhIlCiFGRUVEX1RZUEVfRVhURU5TSU9OX1RZUEVfTUlTTUFU",
            "Q0gQAxIVChFJTlZBTElEX0ZFRURfVFlQRRAEEjQKMElOVkFMSURfRkVFRF9U",
            "WVBFX0ZPUl9DVVNUT01FUl9FWFRFTlNJT05fU0VUVElORxAFEiUKIUNBTk5P",
            "VF9DSEFOR0VfRkVFRF9JVEVNX09OX0NSRUFURRAGEikKJUNBTk5PVF9VUERB",
            "VEVfTkVXTFlfQ1JFQVRFRF9FWFRFTlNJT04QBxIzCi9OT19FWElTVElOR19B",
            "RF9HUk9VUF9FWFRFTlNJT05fU0VUVElOR19GT1JfVFlQRRAIEjMKL05PX0VY",
            "SVNUSU5HX0NBTVBBSUdOX0VYVEVOU0lPTl9TRVRUSU5HX0ZPUl9UWVBFEAkS",
            "MwovTk9fRVhJU1RJTkdfQ1VTVE9NRVJfRVhURU5TSU9OX1NFVFRJTkdfRk9S",
            "X1RZUEUQChItCilBRF9HUk9VUF9FWFRFTlNJT05fU0VUVElOR19BTFJFQURZ",
            "X0VYSVNUUxALEi0KKUNBTVBBSUdOX0VYVEVOU0lPTl9TRVRUSU5HX0FMUkVB",
            "RFlfRVhJU1RTEAwSLQopQ1VTVE9NRVJfRVhURU5TSU9OX1NFVFRJTkdfQUxS",
            "RUFEWV9FWElTVFMQDRI1CjFBRF9HUk9VUF9GRUVEX0FMUkVBRFlfRVhJU1RT",
            "X0ZPUl9QTEFDRUhPTERFUl9UWVBFEA4SNQoxQ0FNUEFJR05fRkVFRF9BTFJF",
            "QURZX0VYSVNUU19GT1JfUExBQ0VIT0xERVJfVFlQRRAPEjUKMUNVU1RPTUVS",
            "X0ZFRURfQUxSRUFEWV9FWElTVFNfRk9SX1BMQUNFSE9MREVSX1RZUEUQEBIW",
            "ChJWQUxVRV9PVVRfT0ZfUkFOR0UQERIkCiBDQU5OT1RfU0VUX0ZJRUxEX1dJ",
            "VEhfRklOQUxfVVJMUxASEhYKEkZJTkFMX1VSTFNfTk9UX1NFVBATEhgKFElO",
            "VkFMSURfUEhPTkVfTlVNQkVSEBQSKgomUEhPTkVfTlVNQkVSX05PVF9TVVBQ",
            "T1JURURfRk9SX0NPVU5UUlkQFRItCilDQVJSSUVSX1NQRUNJRklDX1NIT1JU",
            "X05VTUJFUl9OT1RfQUxMT1dFRBAWEiMKH1BSRU1JVU1fUkFURV9OVU1CRVJf",
            "Tk9UX0FMTE9XRUQQFxIaChZESVNBTExPV0VEX05VTUJFUl9UWVBFEBgSKAok",
            "SU5WQUxJRF9ET01FU1RJQ19QSE9ORV9OVU1CRVJfRk9STUFUEBkSIwofVkFO",
            "SVRZX1BIT05FX05VTUJFUl9OT1RfQUxMT1dFRBAaEhgKFElOVkFMSURfQ09V",
            "TlRSWV9DT0RFEBsSIwofSU5WQUxJRF9DQUxMX0NPTlZFUlNJT05fVFlQRV9J",
            "RBAcEi0KKUNVU1RPTUVSX05PVF9XSElURUxJU1RFRF9GT1JfQ0FMTFRSQUNL",
            "SU5HEB0SKgomQ0FMTFRSQUNLSU5HX05PVF9TVVBQT1JURURfRk9SX0NPVU5U",
            "UlkQHhISCg5JTlZBTElEX0FQUF9JRBAfEiYKIlFVT1RFU19JTl9SRVZJRVdf",
            "RVhURU5TSU9OX1NOSVBQRVQQIBInCiNIWVBIRU5TX0lOX1JFVklFV19FWFRF",
            "TlNJT05fU05JUFBFVBAhEigKJFJFVklFV19FWFRFTlNJT05fU09VUkNFX05P",
            "VF9FTElHSUJMRRAiEigKJFNPVVJDRV9OQU1FX0lOX1JFVklFV19FWFRFTlNJ",
            "T05fVEVYVBAjEhEKDU1JU1NJTkdfRklFTEQQJBIfChtJTkNPTlNJU1RFTlRf",
            "Q1VSUkVOQ1lfQ09ERVMQJRIqCiZQUklDRV9FWFRFTlNJT05fSEFTX0RVUExJ",
            "Q0FURURfSEVBREVSUxAmEjQKMFBSSUNFX0lURU1fSEFTX0RVUExJQ0FURURf",
            "SEVBREVSX0FORF9ERVNDUklQVElPThAnEiUKIVBSSUNFX0VYVEVOU0lPTl9I",
            "QVNfVE9PX0ZFV19JVEVNUxAoEiYKIlBSSUNFX0VYVEVOU0lPTl9IQVNfVE9P",
            "X01BTllfSVRFTVMQKRIVChFVTlNVUFBPUlRFRF9WQUxVRRAqEh0KGUlOVkFM",
            "SURfREVWSUNFX1BSRUZFUkVOQ0UQKxIYChRJTlZBTElEX1NDSEVEVUxFX0VO",
            "RBAtEioKJkRBVEVfVElNRV9NVVNUX0JFX0lOX0FDQ09VTlRfVElNRV9aT05F",
            "EC8SJQohT1ZFUkxBUFBJTkdfU0NIRURVTEVTX05PVF9BTExPV0VEEDASIAoc",
            "U0NIRURVTEVfRU5EX05PVF9BRlRFUl9TVEFSVBAxEh4KGlRPT19NQU5ZX1ND",
            "SEVEVUxFU19QRVJfREFZEDISJgoiRFVQTElDQVRFX0VYVEVOU0lPTl9GRUVE",
            "X0lURU1fRURJVBAzEhsKF0lOVkFMSURfU05JUFBFVFNfSEVBREVSEDQSPAo4",
            "UEhPTkVfTlVNQkVSX05PVF9TVVBQT1JURURfV0lUSF9DQUxMVFJBQ0tJTkdf",
            "Rk9SX0NPVU5UUlkQNRIfChtDQU1QQUlHTl9UQVJHRVRJTkdfTUlTTUFUQ0gQ",
            "NhIiCh5DQU5OT1RfT1BFUkFURV9PTl9SRU1PVkVEX0ZFRUQQNxIbChdFWFRF",
            "TlNJT05fVFlQRV9SRVFVSVJFRBA4Ei0KKUlOQ09NUEFUSUJMRV9VTkRFUkxZ",
            "SU5HX01BVENISU5HX0ZVTkNUSU9OEDkSHQoZU1RBUlRfREFURV9BRlRFUl9F",
            "TkRfREFURRA6EhgKFElOVkFMSURfUFJJQ0VfRk9STUFUEDsSGgoWUFJPTU9U",
            "SU9OX0lOVkFMSURfVElNRRA8EjwKOFBST01PVElPTl9DQU5OT1RfU0VUX1BF",
            "UkNFTlRfRElTQ09VTlRfQU5EX01PTkVZX0RJU0NPVU5UED0SPgo6UFJPTU9U",
            "SU9OX0NBTk5PVF9TRVRfUFJPTU9USU9OX0NPREVfQU5EX09SREVSU19PVkVS",
            "X0FNT1VOVBA+EiUKIVRPT19NQU5ZX0RFQ0lNQUxfUExBQ0VTX1NQRUNJRklF",
            "RBA/EhkKFUlOVkFMSURfTEFOR1VBR0VfQ09ERRBAEhgKFFVOU1VQUE9SVEVE",
            "X0xBTkdVQUdFEEESMAosQ1VTVE9NRVJfQ09OU0VOVF9GT1JfQ0FMTF9SRUNP",
            "UkRJTkdfUkVRVUlSRUQQQhImCiJFWFRFTlNJT05fU0VUVElOR19VUERBVEVf",
            "SVNfQV9OT09QEENC9QEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5l",
            "cnJvcnNCGkV4dGVuc2lvblNldHRpbmdFcnJvclByb3RvUAFaRGdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "Mi9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjIuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjJcRXJyb3Jz6gIi",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Errors.ExtensionSettingErrorEnum), global::Google.Ads.GoogleAds.V2.Errors.ExtensionSettingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Errors.ExtensionSettingErrorEnum.Types.ExtensionSettingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing validation errors of extension settings.
  /// </summary>
  public sealed partial class ExtensionSettingErrorEnum : pb::IMessage<ExtensionSettingErrorEnum> {
    private static readonly pb::MessageParser<ExtensionSettingErrorEnum> _parser = new pb::MessageParser<ExtensionSettingErrorEnum>(() => new ExtensionSettingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExtensionSettingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Errors.ExtensionSettingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtensionSettingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtensionSettingErrorEnum(ExtensionSettingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtensionSettingErrorEnum Clone() {
      return new ExtensionSettingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExtensionSettingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExtensionSettingErrorEnum other) {
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
    public void MergeFrom(ExtensionSettingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ExtensionSettingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible extension setting errors.
      /// </summary>
      public enum ExtensionSettingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A platform restriction was provided without input extensions or existing
        /// extensions.
        /// </summary>
        [pbr::OriginalName("EXTENSIONS_REQUIRED")] ExtensionsRequired = 2,
        /// <summary>
        /// The provided feed type does not correspond to the provided extensions.
        /// </summary>
        [pbr::OriginalName("FEED_TYPE_EXTENSION_TYPE_MISMATCH")] FeedTypeExtensionTypeMismatch = 3,
        /// <summary>
        /// The provided feed type cannot be used.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_TYPE")] InvalidFeedType = 4,
        /// <summary>
        /// The provided feed type cannot be used at the customer level.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_TYPE_FOR_CUSTOMER_EXTENSION_SETTING")] InvalidFeedTypeForCustomerExtensionSetting = 5,
        /// <summary>
        /// Cannot change a feed item field on a CREATE operation.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_FEED_ITEM_ON_CREATE")] CannotChangeFeedItemOnCreate = 6,
        /// <summary>
        /// Cannot update an extension that is not already in this setting.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_NEWLY_CREATED_EXTENSION")] CannotUpdateNewlyCreatedExtension = 7,
        /// <summary>
        /// There is no existing AdGroupExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_AD_GROUP_EXTENSION_SETTING_FOR_TYPE")] NoExistingAdGroupExtensionSettingForType = 8,
        /// <summary>
        /// There is no existing CampaignExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_CAMPAIGN_EXTENSION_SETTING_FOR_TYPE")] NoExistingCampaignExtensionSettingForType = 9,
        /// <summary>
        /// There is no existing CustomerExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_CUSTOMER_EXTENSION_SETTING_FOR_TYPE")] NoExistingCustomerExtensionSettingForType = 10,
        /// <summary>
        /// The AdGroupExtensionSetting already exists. UPDATE should be used to
        /// modify the existing AdGroupExtensionSetting.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_EXTENSION_SETTING_ALREADY_EXISTS")] AdGroupExtensionSettingAlreadyExists = 11,
        /// <summary>
        /// The CampaignExtensionSetting already exists. UPDATE should be used to
        /// modify the existing CampaignExtensionSetting.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_EXTENSION_SETTING_ALREADY_EXISTS")] CampaignExtensionSettingAlreadyExists = 12,
        /// <summary>
        /// The CustomerExtensionSetting already exists. UPDATE should be used to
        /// modify the existing CustomerExtensionSetting.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_EXTENSION_SETTING_ALREADY_EXISTS")] CustomerExtensionSettingAlreadyExists = 13,
        /// <summary>
        /// An active ad group feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] AdGroupFeedAlreadyExistsForPlaceholderType = 14,
        /// <summary>
        /// An active campaign feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] CampaignFeedAlreadyExistsForPlaceholderType = 15,
        /// <summary>
        /// An active customer feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] CustomerFeedAlreadyExistsForPlaceholderType = 16,
        /// <summary>
        /// Value is not within the accepted range.
        /// </summary>
        [pbr::OriginalName("VALUE_OUT_OF_RANGE")] ValueOutOfRange = 17,
        /// <summary>
        /// Cannot simultaneously set specified field with final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_FIELD_WITH_FINAL_URLS")] CannotSetFieldWithFinalUrls = 18,
        /// <summary>
        /// Must set field with final urls.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS_NOT_SET")] FinalUrlsNotSet = 19,
        /// <summary>
        /// Phone number for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PHONE_NUMBER")] InvalidPhoneNumber = 20,
        /// <summary>
        /// Phone number for a call extension is not supported for the given country
        /// code.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY")] PhoneNumberNotSupportedForCountry = 21,
        /// <summary>
        /// A carrier specific number in short format is not allowed for call
        /// extensions.
        /// </summary>
        [pbr::OriginalName("CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED")] CarrierSpecificShortNumberNotAllowed = 22,
        /// <summary>
        /// Premium rate numbers are not allowed for call extensions.
        /// </summary>
        [pbr::OriginalName("PREMIUM_RATE_NUMBER_NOT_ALLOWED")] PremiumRateNumberNotAllowed = 23,
        /// <summary>
        /// Phone number type for a call extension is not allowed.
        /// </summary>
        [pbr::OriginalName("DISALLOWED_NUMBER_TYPE")] DisallowedNumberType = 24,
        /// <summary>
        /// Phone number for a call extension does not meet domestic format
        /// requirements.
        /// </summary>
        [pbr::OriginalName("INVALID_DOMESTIC_PHONE_NUMBER_FORMAT")] InvalidDomesticPhoneNumberFormat = 25,
        /// <summary>
        /// Vanity phone numbers (i.e. those including letters) are not allowed for
        /// call extensions.
        /// </summary>
        [pbr::OriginalName("VANITY_PHONE_NUMBER_NOT_ALLOWED")] VanityPhoneNumberNotAllowed = 26,
        /// <summary>
        /// Country code provided for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 27,
        /// <summary>
        /// Call conversion type id provided for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_CALL_CONVERSION_TYPE_ID")] InvalidCallConversionTypeId = 28,
        /// <summary>
        /// For a call extension, the customer is not whitelisted for call tracking.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_WHITELISTED_FOR_CALLTRACKING")] CustomerNotWhitelistedForCalltracking = 29,
        /// <summary>
        /// Call tracking is not supported for the given country for a call
        /// extension.
        /// </summary>
        [pbr::OriginalName("CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY")] CalltrackingNotSupportedForCountry = 30,
        /// <summary>
        /// App id provided for an app extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APP_ID")] InvalidAppId = 31,
        /// <summary>
        /// Quotation marks present in the review text for a review extension.
        /// </summary>
        [pbr::OriginalName("QUOTES_IN_REVIEW_EXTENSION_SNIPPET")] QuotesInReviewExtensionSnippet = 32,
        /// <summary>
        /// Hyphen character present in the review text for a review extension.
        /// </summary>
        [pbr::OriginalName("HYPHENS_IN_REVIEW_EXTENSION_SNIPPET")] HyphensInReviewExtensionSnippet = 33,
        /// <summary>
        /// A blacklisted review source name or url was provided for a review
        /// extension.
        /// </summary>
        [pbr::OriginalName("REVIEW_EXTENSION_SOURCE_NOT_ELIGIBLE")] ReviewExtensionSourceNotEligible = 34,
        /// <summary>
        /// Review source name should not be found in the review text.
        /// </summary>
        [pbr::OriginalName("SOURCE_NAME_IN_REVIEW_EXTENSION_TEXT")] SourceNameInReviewExtensionText = 35,
        /// <summary>
        /// Field must be set.
        /// </summary>
        [pbr::OriginalName("MISSING_FIELD")] MissingField = 36,
        /// <summary>
        /// Inconsistent currency codes.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_CURRENCY_CODES")] InconsistentCurrencyCodes = 37,
        /// <summary>
        /// Price extension cannot have duplicated headers.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_DUPLICATED_HEADERS")] PriceExtensionHasDuplicatedHeaders = 38,
        /// <summary>
        /// Price item cannot have duplicated header and description.
        /// </summary>
        [pbr::OriginalName("PRICE_ITEM_HAS_DUPLICATED_HEADER_AND_DESCRIPTION")] PriceItemHasDuplicatedHeaderAndDescription = 39,
        /// <summary>
        /// Price extension has too few items
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_FEW_ITEMS")] PriceExtensionHasTooFewItems = 40,
        /// <summary>
        /// Price extension has too many items
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_MANY_ITEMS")] PriceExtensionHasTooManyItems = 41,
        /// <summary>
        /// The input value is not currently supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_VALUE")] UnsupportedValue = 42,
        /// <summary>
        /// Unknown or unsupported device preference.
        /// </summary>
        [pbr::OriginalName("INVALID_DEVICE_PREFERENCE")] InvalidDevicePreference = 43,
        /// <summary>
        /// Invalid feed item schedule end time (i.e., endHour = 24 and
        /// endMinute != 0).
        /// </summary>
        [pbr::OriginalName("INVALID_SCHEDULE_END")] InvalidScheduleEnd = 45,
        /// <summary>
        /// Date time zone does not match the account's time zone.
        /// </summary>
        [pbr::OriginalName("DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE")] DateTimeMustBeInAccountTimeZone = 47,
        /// <summary>
        /// Overlapping feed item schedule times (e.g., 7-10AM and 8-11AM) are not
        /// allowed.
        /// </summary>
        [pbr::OriginalName("OVERLAPPING_SCHEDULES_NOT_ALLOWED")] OverlappingSchedulesNotAllowed = 48,
        /// <summary>
        /// Feed item schedule end time must be after start time.
        /// </summary>
        [pbr::OriginalName("SCHEDULE_END_NOT_AFTER_START")] ScheduleEndNotAfterStart = 49,
        /// <summary>
        /// There are too many feed item schedules per day.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_SCHEDULES_PER_DAY")] TooManySchedulesPerDay = 50,
        /// <summary>
        /// Cannot edit the same extension feed item more than once in the same
        /// request.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_EXTENSION_FEED_ITEM_EDIT")] DuplicateExtensionFeedItemEdit = 51,
        /// <summary>
        /// Invalid structured snippet header.
        /// </summary>
        [pbr::OriginalName("INVALID_SNIPPETS_HEADER")] InvalidSnippetsHeader = 52,
        /// <summary>
        /// Phone number with call tracking enabled is not supported for the
        /// specified country.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY")] PhoneNumberNotSupportedWithCalltrackingForCountry = 53,
        /// <summary>
        /// The targeted adgroup must belong to the targeted campaign.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_TARGETING_MISMATCH")] CampaignTargetingMismatch = 54,
        /// <summary>
        /// The feed used by the ExtensionSetting is removed and cannot be operated
        /// on. Remove the ExtensionSetting to allow a new one to be created using
        /// an active feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_REMOVED_FEED")] CannotOperateOnRemovedFeed = 55,
        /// <summary>
        /// The ExtensionFeedItem type is required for this operation.
        /// </summary>
        [pbr::OriginalName("EXTENSION_TYPE_REQUIRED")] ExtensionTypeRequired = 56,
        /// <summary>
        /// The matching function that links the extension feed to the customer,
        /// campaign, or ad group is not compatible with the ExtensionSetting
        /// services.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_UNDERLYING_MATCHING_FUNCTION")] IncompatibleUnderlyingMatchingFunction = 57,
        /// <summary>
        /// Start date must be before end date.
        /// </summary>
        [pbr::OriginalName("START_DATE_AFTER_END_DATE")] StartDateAfterEndDate = 58,
        /// <summary>
        /// Input price is not in a valid format.
        /// </summary>
        [pbr::OriginalName("INVALID_PRICE_FORMAT")] InvalidPriceFormat = 59,
        /// <summary>
        /// The promotion time is invalid.
        /// </summary>
        [pbr::OriginalName("PROMOTION_INVALID_TIME")] PromotionInvalidTime = 60,
        /// <summary>
        /// Cannot set both percent discount and money discount fields.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PERCENT_DISCOUNT_AND_MONEY_DISCOUNT")] PromotionCannotSetPercentDiscountAndMoneyDiscount = 61,
        /// <summary>
        /// Cannot set both promotion code and orders over amount fields.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PROMOTION_CODE_AND_ORDERS_OVER_AMOUNT")] PromotionCannotSetPromotionCodeAndOrdersOverAmount = 62,
        /// <summary>
        /// This field has too many decimal places specified.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_DECIMAL_PLACES_SPECIFIED")] TooManyDecimalPlacesSpecified = 63,
        /// <summary>
        /// The language code is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_LANGUAGE_CODE")] InvalidLanguageCode = 64,
        /// <summary>
        /// The language is not supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_LANGUAGE")] UnsupportedLanguage = 65,
        /// <summary>
        /// Customer hasn't consented for call recording, which is required for
        /// adding/updating call extensions. Please see
        /// https://support.google.com/google-ads/answer/7412639.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CONSENT_FOR_CALL_RECORDING_REQUIRED")] CustomerConsentForCallRecordingRequired = 66,
        /// <summary>
        /// The UPDATE operation does not specify any fields other than the resource
        /// name in the update mask.
        /// </summary>
        [pbr::OriginalName("EXTENSION_SETTING_UPDATE_IS_A_NOOP")] ExtensionSettingUpdateIsANoop = 67,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
