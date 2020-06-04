// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/common/ad_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/common/ad_asset.proto</summary>
  public static partial class AdAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/common/ad_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9jb21tb24vYWRfYXNzZXQucHJv",
            "dG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmNvbW1vbho7Z29vZ2xlL2Fk",
            "cy9nb29nbGVhZHMvdjEvZW51bXMvc2VydmVkX2Fzc2V0X2ZpZWxkX3R5cGUu",
            "cHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byKdAQoLQWRUZXh0QXNzZXQSKgoEdGV4",
            "dBgBIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRJiCgxwaW5u",
            "ZWRfZmllbGQYAiABKA4yTC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5lbnVt",
            "cy5TZXJ2ZWRBc3NldEZpZWxkVHlwZUVudW0uU2VydmVkQXNzZXRGaWVsZFR5",
            "cGUiOwoMQWRJbWFnZUFzc2V0EisKBWFzc2V0GAEgASgLMhwuZ29vZ2xlLnBy",
            "b3RvYnVmLlN0cmluZ1ZhbHVlIjsKDEFkVmlkZW9Bc3NldBIrCgVhc3NldBgB",
            "IAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZSJBChJBZE1lZGlh",
            "QnVuZGxlQXNzZXQSKwoFYXNzZXQYASABKAsyHC5nb29nbGUucHJvdG9idWYu",
            "U3RyaW5nVmFsdWVC5wEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5j",
            "b21tb25CDEFkQXNzZXRQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEvY29tbW9uO2NvbW1v",
            "bqICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLkNvbW1vbsoCHkdv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFYxXENvbW1vbuoCIkdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYxOjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Common.AdTextAsset), global::Google.Ads.GoogleAds.V1.Common.AdTextAsset.Parser, new[]{ "Text", "PinnedField" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Common.AdImageAsset), global::Google.Ads.GoogleAds.V1.Common.AdImageAsset.Parser, new[]{ "Asset" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Common.AdVideoAsset), global::Google.Ads.GoogleAds.V1.Common.AdVideoAsset.Parser, new[]{ "Asset" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Common.AdMediaBundleAsset), global::Google.Ads.GoogleAds.V1.Common.AdMediaBundleAsset.Parser, new[]{ "Asset" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A text asset used inside an ad.
  /// </summary>
  public sealed partial class AdTextAsset : pb::IMessage<AdTextAsset> {
    private static readonly pb::MessageParser<AdTextAsset> _parser = new pb::MessageParser<AdTextAsset>(() => new AdTextAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdTextAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Common.AdAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdTextAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdTextAsset(AdTextAsset other) : this() {
      Text = other.Text;
      pinnedField_ = other.pinnedField_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdTextAsset Clone() {
      return new AdTextAsset(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_text_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string text_;
    /// <summary>
    /// Asset text.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = value;
      }
    }


    /// <summary>Field number for the "pinned_field" field.</summary>
    public const int PinnedFieldFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType pinnedField_ = global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified;
    /// <summary>
    /// The pinned field of the asset. This restricts the asset to only serve
    /// within this field. Multiple assets can be pinned to the same field. An
    /// asset that is unpinned or pinned to a different field will not serve in a
    /// field where some other asset has been pinned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType PinnedField {
      get { return pinnedField_; }
      set {
        pinnedField_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdTextAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdTextAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      if (PinnedField != other.PinnedField) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (text_ != null) hash ^= Text.GetHashCode();
      if (PinnedField != global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) hash ^= PinnedField.GetHashCode();
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
      if (text_ != null) {
        _single_text_codec.WriteTagAndValue(output, Text);
      }
      if (PinnedField != global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PinnedField);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (text_ != null) {
        size += _single_text_codec.CalculateSizeWithTag(Text);
      }
      if (PinnedField != global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PinnedField);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdTextAsset other) {
      if (other == null) {
        return;
      }
      if (other.text_ != null) {
        if (text_ == null || other.Text != "") {
          Text = other.Text;
        }
      }
      if (other.PinnedField != global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        PinnedField = other.PinnedField;
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
            string value = _single_text_codec.Read(input);
            if (text_ == null || value != "") {
              Text = value;
            }
            break;
          }
          case 16: {
            PinnedField = (global::Google.Ads.GoogleAds.V1.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// An image asset used inside an ad.
  /// </summary>
  public sealed partial class AdImageAsset : pb::IMessage<AdImageAsset> {
    private static readonly pb::MessageParser<AdImageAsset> _parser = new pb::MessageParser<AdImageAsset>(() => new AdImageAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdImageAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Common.AdAssetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdImageAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdImageAsset(AdImageAsset other) : this() {
      Asset = other.Asset;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdImageAsset Clone() {
      return new AdImageAsset(this);
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_asset_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string asset_;
    /// <summary>
    /// The Asset resource name of this image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdImageAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdImageAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Asset != other.Asset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (asset_ != null) hash ^= Asset.GetHashCode();
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
      if (asset_ != null) {
        _single_asset_codec.WriteTagAndValue(output, Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (asset_ != null) {
        size += _single_asset_codec.CalculateSizeWithTag(Asset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdImageAsset other) {
      if (other == null) {
        return;
      }
      if (other.asset_ != null) {
        if (asset_ == null || other.Asset != "") {
          Asset = other.Asset;
        }
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
            string value = _single_asset_codec.Read(input);
            if (asset_ == null || value != "") {
              Asset = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A video asset used inside an ad.
  /// </summary>
  public sealed partial class AdVideoAsset : pb::IMessage<AdVideoAsset> {
    private static readonly pb::MessageParser<AdVideoAsset> _parser = new pb::MessageParser<AdVideoAsset>(() => new AdVideoAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdVideoAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Common.AdAssetReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdVideoAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdVideoAsset(AdVideoAsset other) : this() {
      Asset = other.Asset;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdVideoAsset Clone() {
      return new AdVideoAsset(this);
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_asset_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string asset_;
    /// <summary>
    /// The Asset resource name of this video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdVideoAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdVideoAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Asset != other.Asset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (asset_ != null) hash ^= Asset.GetHashCode();
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
      if (asset_ != null) {
        _single_asset_codec.WriteTagAndValue(output, Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (asset_ != null) {
        size += _single_asset_codec.CalculateSizeWithTag(Asset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdVideoAsset other) {
      if (other == null) {
        return;
      }
      if (other.asset_ != null) {
        if (asset_ == null || other.Asset != "") {
          Asset = other.Asset;
        }
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
            string value = _single_asset_codec.Read(input);
            if (asset_ == null || value != "") {
              Asset = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A media bundle asset used inside an ad.
  /// </summary>
  public sealed partial class AdMediaBundleAsset : pb::IMessage<AdMediaBundleAsset> {
    private static readonly pb::MessageParser<AdMediaBundleAsset> _parser = new pb::MessageParser<AdMediaBundleAsset>(() => new AdMediaBundleAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdMediaBundleAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Common.AdAssetReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdMediaBundleAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdMediaBundleAsset(AdMediaBundleAsset other) : this() {
      Asset = other.Asset;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdMediaBundleAsset Clone() {
      return new AdMediaBundleAsset(this);
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_asset_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string asset_;
    /// <summary>
    /// The Asset resource name of this media bundle.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdMediaBundleAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdMediaBundleAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Asset != other.Asset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (asset_ != null) hash ^= Asset.GetHashCode();
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
      if (asset_ != null) {
        _single_asset_codec.WriteTagAndValue(output, Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (asset_ != null) {
        size += _single_asset_codec.CalculateSizeWithTag(Asset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdMediaBundleAsset other) {
      if (other == null) {
        return;
      }
      if (other.asset_ != null) {
        if (asset_ == null || other.Asset != "") {
          Asset = other.Asset;
        }
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
            string value = _single_asset_codec.Read(input);
            if (asset_ == null || value != "") {
              Asset = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
