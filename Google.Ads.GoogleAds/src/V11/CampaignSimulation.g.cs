// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/campaign_simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/campaign_simulation.proto</summary>
  public static partial class CampaignSimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/campaign_simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignSimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2NhbXBhaWdu",
            "X3NpbXVsYXRpb24ucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5y",
            "ZXNvdXJjZXMaMGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMS9jb21tb24vc2lt",
            "dWxhdGlvbi5wcm90bxpDZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjExL2VudW1z",
            "L3NpbXVsYXRpb25fbW9kaWZpY2F0aW9uX21ldGhvZC5wcm90bxo0Z29vZ2xl",
            "L2Fkcy9nb29nbGVhZHMvdjExL2VudW1zL3NpbXVsYXRpb25fdHlwZS5wcm90",
            "bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2Fw",
            "aS9yZXNvdXJjZS5wcm90byK6CAoSQ2FtcGFpZ25TaW11bGF0aW9uEkoKDXJl",
            "c291cmNlX25hbWUYASABKAlCM+BBA/pBLQorZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0NhbXBhaWduU2ltdWxhdGlvbhIYCgtjYW1wYWlnbl9pZBgCIAEo",
            "A0ID4EEDElQKBHR5cGUYAyABKA4yQS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTEuZW51bXMuU2ltdWxhdGlvblR5cGVFbnVtLlNpbXVsYXRpb25UeXBlQgPg",
            "QQMSfwoTbW9kaWZpY2F0aW9uX21ldGhvZBgEIAEoDjJdLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxMS5lbnVtcy5TaW11bGF0aW9uTW9kaWZpY2F0aW9uTWV0",
            "aG9kRW51bS5TaW11bGF0aW9uTW9kaWZpY2F0aW9uTWV0aG9kQgPgQQMSFwoK",
            "c3RhcnRfZGF0ZRgFIAEoCUID4EEDEhUKCGVuZF9kYXRlGAYgASgJQgPgQQMS",
            "XQoSY3BjX2JpZF9wb2ludF9saXN0GAcgASgLMjouZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjExLmNvbW1vbi5DcGNCaWRTaW11bGF0aW9uUG9pbnRMaXN0QgPg",
            "QQNIABJjChV0YXJnZXRfY3BhX3BvaW50X2xpc3QYCCABKAsyPS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MTEuY29tbW9uLlRhcmdldENwYVNpbXVsYXRpb25Q",
            "b2ludExpc3RCA+BBA0gAEmUKFnRhcmdldF9yb2FzX3BvaW50X2xpc3QYCSAB",
            "KAsyPi5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuY29tbW9uLlRhcmdldFJv",
            "YXNTaW11bGF0aW9uUG9pbnRMaXN0QgPgQQNIABJ8CiJ0YXJnZXRfaW1wcmVz",
            "c2lvbl9zaGFyZV9wb2ludF9saXN0GAogASgLMkkuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjExLmNvbW1vbi5UYXJnZXRJbXByZXNzaW9uU2hhcmVTaW11bGF0",
            "aW9uUG9pbnRMaXN0QgPgQQNIABJcChFidWRnZXRfcG9pbnRfbGlzdBgLIAEo",
            "CzI6Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5jb21tb24uQnVkZ2V0U2lt",
            "dWxhdGlvblBvaW50TGlzdEID4EEDSAA6oQHqQZ0BCitnb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vQ2FtcGFpZ25TaW11bGF0aW9uEm5jdXN0b21lcnMve2N1",
            "c3RvbWVyX2lkfS9jYW1wYWlnblNpbXVsYXRpb25zL3tjYW1wYWlnbl9pZH1+",
            "e3R5cGV9fnttb2RpZmljYXRpb25fbWV0aG9kfX57c3RhcnRfZGF0ZX1+e2Vu",
            "ZF9kYXRlfUIMCgpwb2ludF9saXN0QokCCiZjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjExLnJlc291cmNlc0IXQ2FtcGFpZ25TaW11bGF0aW9uUHJvdG9Q",
            "AVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YxMS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjExLlJlc291cmNlc8oCIkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxMVxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWMTE6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V11.Common.SimulationReflection.Descriptor, global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodReflection.Descriptor, global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.CampaignSimulation), global::Google.Ads.GoogleAds.V11.Resources.CampaignSimulation.Parser, new[]{ "ResourceName", "CampaignId", "Type", "ModificationMethod", "StartDate", "EndDate", "CpcBidPointList", "TargetCpaPointList", "TargetRoasPointList", "TargetImpressionSharePointList", "BudgetPointList" }, new[]{ "PointList" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A campaign simulation. Supported combinations of advertising
  /// channel type, simulation type and simulation modification
  /// method is detailed below respectively.
  ///
  /// SEARCH - CPC_BID - UNIFORM
  /// SEARCH - CPC_BID - SCALING
  /// SEARCH - TARGET_CPA - UNIFORM
  /// SEARCH - TARGET_CPA - SCALING
  /// SEARCH - TARGET_ROAS - UNIFORM
  /// SEARCH - TARGET_IMPRESSION_SHARE - UNIFORM
  /// SEARCH - BUDGET - UNIFORM
  /// SHOPPING - BUDGET - UNIFORM
  /// SHOPPING - TARGET_ROAS - UNIFORM
  /// MULTIPLE - TARGET_CPA - UNIFORM
  /// OWNED_AND_OPERATED - TARGET_CPA - DEFAULT
  /// DISPLAY - TARGET_CPA - UNIFORM
  /// </summary>
  public sealed partial class CampaignSimulation : pb::IMessage<CampaignSimulation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignSimulation> _parser = new pb::MessageParser<CampaignSimulation>(() => new CampaignSimulation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignSimulation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.CampaignSimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSimulation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSimulation(CampaignSimulation other) : this() {
      resourceName_ = other.resourceName_;
      campaignId_ = other.campaignId_;
      type_ = other.type_;
      modificationMethod_ = other.modificationMethod_;
      startDate_ = other.startDate_;
      endDate_ = other.endDate_;
      switch (other.PointListCase) {
        case PointListOneofCase.CpcBidPointList:
          CpcBidPointList = other.CpcBidPointList.Clone();
          break;
        case PointListOneofCase.TargetCpaPointList:
          TargetCpaPointList = other.TargetCpaPointList.Clone();
          break;
        case PointListOneofCase.TargetRoasPointList:
          TargetRoasPointList = other.TargetRoasPointList.Clone();
          break;
        case PointListOneofCase.TargetImpressionSharePointList:
          TargetImpressionSharePointList = other.TargetImpressionSharePointList.Clone();
          break;
        case PointListOneofCase.BudgetPointList:
          BudgetPointList = other.BudgetPointList.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSimulation Clone() {
      return new CampaignSimulation(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the campaign simulation.
    /// Campaign simulation resource names have the form:
    ///
    /// `customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign_id" field.</summary>
    public const int CampaignIdFieldNumber = 2;
    private long campaignId_;
    /// <summary>
    /// Output only. Campaign id of the simulation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CampaignId {
      get { return campaignId_; }
      set {
        campaignId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType type_ = global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified;
    /// <summary>
    /// Output only. The field that the simulation modifies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "modification_method" field.</summary>
    public const int ModificationMethodFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod modificationMethod_ = global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified;
    /// <summary>
    /// Output only. How the simulation modifies the field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod ModificationMethod {
      get { return modificationMethod_; }
      set {
        modificationMethod_ = value;
      }
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 5;
    private string startDate_ = "";
    /// <summary>
    /// Output only. First day on which the simulation is based, in YYYY-MM-DD format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StartDate {
      get { return startDate_; }
      set {
        startDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 6;
    private string endDate_ = "";
    /// <summary>
    /// Output only. Last day on which the simulation is based, in YYYY-MM-DD format
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndDate {
      get { return endDate_; }
      set {
        endDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cpc_bid_point_list" field.</summary>
    public const int CpcBidPointListFieldNumber = 7;
    /// <summary>
    /// Output only. Simulation points if the simulation type is CPC_BID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Common.CpcBidSimulationPointList CpcBidPointList {
      get { return pointListCase_ == PointListOneofCase.CpcBidPointList ? (global::Google.Ads.GoogleAds.V11.Common.CpcBidSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.CpcBidPointList;
      }
    }

    /// <summary>Field number for the "target_cpa_point_list" field.</summary>
    public const int TargetCpaPointListFieldNumber = 8;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_CPA.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Common.TargetCpaSimulationPointList TargetCpaPointList {
      get { return pointListCase_ == PointListOneofCase.TargetCpaPointList ? (global::Google.Ads.GoogleAds.V11.Common.TargetCpaSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetCpaPointList;
      }
    }

    /// <summary>Field number for the "target_roas_point_list" field.</summary>
    public const int TargetRoasPointListFieldNumber = 9;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_ROAS.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Common.TargetRoasSimulationPointList TargetRoasPointList {
      get { return pointListCase_ == PointListOneofCase.TargetRoasPointList ? (global::Google.Ads.GoogleAds.V11.Common.TargetRoasSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetRoasPointList;
      }
    }

    /// <summary>Field number for the "target_impression_share_point_list" field.</summary>
    public const int TargetImpressionSharePointListFieldNumber = 10;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_IMPRESSION_SHARE.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Common.TargetImpressionShareSimulationPointList TargetImpressionSharePointList {
      get { return pointListCase_ == PointListOneofCase.TargetImpressionSharePointList ? (global::Google.Ads.GoogleAds.V11.Common.TargetImpressionShareSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetImpressionSharePointList;
      }
    }

    /// <summary>Field number for the "budget_point_list" field.</summary>
    public const int BudgetPointListFieldNumber = 11;
    /// <summary>
    /// Output only. Simulation points if the simulation type is BUDGET.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Common.BudgetSimulationPointList BudgetPointList {
      get { return pointListCase_ == PointListOneofCase.BudgetPointList ? (global::Google.Ads.GoogleAds.V11.Common.BudgetSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.BudgetPointList;
      }
    }

    private object pointList_;
    /// <summary>Enum of possible cases for the "point_list" oneof.</summary>
    public enum PointListOneofCase {
      None = 0,
      CpcBidPointList = 7,
      TargetCpaPointList = 8,
      TargetRoasPointList = 9,
      TargetImpressionSharePointList = 10,
      BudgetPointList = 11,
    }
    private PointListOneofCase pointListCase_ = PointListOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PointListOneofCase PointListCase {
      get { return pointListCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPointList() {
      pointListCase_ = PointListOneofCase.None;
      pointList_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignSimulation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignSimulation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CampaignId != other.CampaignId) return false;
      if (Type != other.Type) return false;
      if (ModificationMethod != other.ModificationMethod) return false;
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      if (!object.Equals(CpcBidPointList, other.CpcBidPointList)) return false;
      if (!object.Equals(TargetCpaPointList, other.TargetCpaPointList)) return false;
      if (!object.Equals(TargetRoasPointList, other.TargetRoasPointList)) return false;
      if (!object.Equals(TargetImpressionSharePointList, other.TargetImpressionSharePointList)) return false;
      if (!object.Equals(BudgetPointList, other.BudgetPointList)) return false;
      if (PointListCase != other.PointListCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (CampaignId != 0L) hash ^= CampaignId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) hash ^= Type.GetHashCode();
      if (ModificationMethod != global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) hash ^= ModificationMethod.GetHashCode();
      if (StartDate.Length != 0) hash ^= StartDate.GetHashCode();
      if (EndDate.Length != 0) hash ^= EndDate.GetHashCode();
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) hash ^= CpcBidPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) hash ^= TargetCpaPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) hash ^= TargetRoasPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) hash ^= TargetImpressionSharePointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.BudgetPointList) hash ^= BudgetPointList.GetHashCode();
      hash ^= (int) pointListCase_;
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
      if (CampaignId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CampaignId);
      }
      if (Type != global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModificationMethod);
      }
      if (StartDate.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StartDate);
      }
      if (EndDate.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        output.WriteRawTag(58);
        output.WriteMessage(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        output.WriteRawTag(74);
        output.WriteMessage(TargetRoasPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
        output.WriteRawTag(82);
        output.WriteMessage(TargetImpressionSharePointList);
      }
      if (pointListCase_ == PointListOneofCase.BudgetPointList) {
        output.WriteRawTag(90);
        output.WriteMessage(BudgetPointList);
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
      if (CampaignId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CampaignId);
      }
      if (Type != global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModificationMethod);
      }
      if (StartDate.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StartDate);
      }
      if (EndDate.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        output.WriteRawTag(58);
        output.WriteMessage(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        output.WriteRawTag(74);
        output.WriteMessage(TargetRoasPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
        output.WriteRawTag(82);
        output.WriteMessage(TargetImpressionSharePointList);
      }
      if (pointListCase_ == PointListOneofCase.BudgetPointList) {
        output.WriteRawTag(90);
        output.WriteMessage(BudgetPointList);
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
      if (CampaignId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CampaignId);
      }
      if (Type != global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModificationMethod);
      }
      if (StartDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StartDate);
      }
      if (EndDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetRoasPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetImpressionSharePointList);
      }
      if (pointListCase_ == PointListOneofCase.BudgetPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BudgetPointList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignSimulation other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.CampaignId != 0L) {
        CampaignId = other.CampaignId;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        Type = other.Type;
      }
      if (other.ModificationMethod != global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        ModificationMethod = other.ModificationMethod;
      }
      if (other.StartDate.Length != 0) {
        StartDate = other.StartDate;
      }
      if (other.EndDate.Length != 0) {
        EndDate = other.EndDate;
      }
      switch (other.PointListCase) {
        case PointListOneofCase.CpcBidPointList:
          if (CpcBidPointList == null) {
            CpcBidPointList = new global::Google.Ads.GoogleAds.V11.Common.CpcBidSimulationPointList();
          }
          CpcBidPointList.MergeFrom(other.CpcBidPointList);
          break;
        case PointListOneofCase.TargetCpaPointList:
          if (TargetCpaPointList == null) {
            TargetCpaPointList = new global::Google.Ads.GoogleAds.V11.Common.TargetCpaSimulationPointList();
          }
          TargetCpaPointList.MergeFrom(other.TargetCpaPointList);
          break;
        case PointListOneofCase.TargetRoasPointList:
          if (TargetRoasPointList == null) {
            TargetRoasPointList = new global::Google.Ads.GoogleAds.V11.Common.TargetRoasSimulationPointList();
          }
          TargetRoasPointList.MergeFrom(other.TargetRoasPointList);
          break;
        case PointListOneofCase.TargetImpressionSharePointList:
          if (TargetImpressionSharePointList == null) {
            TargetImpressionSharePointList = new global::Google.Ads.GoogleAds.V11.Common.TargetImpressionShareSimulationPointList();
          }
          TargetImpressionSharePointList.MergeFrom(other.TargetImpressionSharePointList);
          break;
        case PointListOneofCase.BudgetPointList:
          if (BudgetPointList == null) {
            BudgetPointList = new global::Google.Ads.GoogleAds.V11.Common.BudgetSimulationPointList();
          }
          BudgetPointList.MergeFrom(other.BudgetPointList);
          break;
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
          case 16: {
            CampaignId = input.ReadInt64();
            break;
          }
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
            break;
          }
          case 42: {
            StartDate = input.ReadString();
            break;
          }
          case 50: {
            EndDate = input.ReadString();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V11.Common.CpcBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.CpcBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
              subBuilder.MergeFrom(CpcBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpcBidPointList = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V11.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V11.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.TargetRoasSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
              subBuilder.MergeFrom(TargetRoasPointList);
            }
            input.ReadMessage(subBuilder);
            TargetRoasPointList = subBuilder;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V11.Common.TargetImpressionShareSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.TargetImpressionShareSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
              subBuilder.MergeFrom(TargetImpressionSharePointList);
            }
            input.ReadMessage(subBuilder);
            TargetImpressionSharePointList = subBuilder;
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V11.Common.BudgetSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.BudgetSimulationPointList();
            if (pointListCase_ == PointListOneofCase.BudgetPointList) {
              subBuilder.MergeFrom(BudgetPointList);
            }
            input.ReadMessage(subBuilder);
            BudgetPointList = subBuilder;
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
          case 16: {
            CampaignId = input.ReadInt64();
            break;
          }
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V11.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V11.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
            break;
          }
          case 42: {
            StartDate = input.ReadString();
            break;
          }
          case 50: {
            EndDate = input.ReadString();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V11.Common.CpcBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.CpcBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
              subBuilder.MergeFrom(CpcBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpcBidPointList = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V11.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V11.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.TargetRoasSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
              subBuilder.MergeFrom(TargetRoasPointList);
            }
            input.ReadMessage(subBuilder);
            TargetRoasPointList = subBuilder;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V11.Common.TargetImpressionShareSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.TargetImpressionShareSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
              subBuilder.MergeFrom(TargetImpressionSharePointList);
            }
            input.ReadMessage(subBuilder);
            TargetImpressionSharePointList = subBuilder;
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V11.Common.BudgetSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V11.Common.BudgetSimulationPointList();
            if (pointListCase_ == PointListOneofCase.BudgetPointList) {
              subBuilder.MergeFrom(BudgetPointList);
            }
            input.ReadMessage(subBuilder);
            BudgetPointList = subBuilder;
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
