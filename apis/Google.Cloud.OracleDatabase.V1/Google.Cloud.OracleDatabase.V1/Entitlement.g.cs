// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/oracledatabase/v1/entitlement.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.OracleDatabase.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/oracledatabase/v1/entitlement.proto</summary>
  public static partial class EntitlementReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/oracledatabase/v1/entitlement.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntitlementReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvb3JhY2xlZGF0YWJhc2UvdjEvZW50aXRsZW1lbnQu",
            "cHJvdG8SHmdvb2dsZS5jbG91ZC5vcmFjbGVkYXRhYmFzZS52MRofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJj",
            "ZS5wcm90byLcAwoLRW50aXRsZW1lbnQSEQoEbmFtZRgBIAEoCUID4EEIElIK",
            "FWNsb3VkX2FjY291bnRfZGV0YWlscxgCIAEoCzIzLmdvb2dsZS5jbG91ZC5v",
            "cmFjbGVkYXRhYmFzZS52MS5DbG91ZEFjY291bnREZXRhaWxzEhsKDmVudGl0",
            "bGVtZW50X2lkGAMgASgJQgPgQQMSRQoFc3RhdGUYBCABKA4yMS5nb29nbGUu",
            "Y2xvdWQub3JhY2xlZGF0YWJhc2UudjEuRW50aXRsZW1lbnQuU3RhdGVCA+BB",
            "AyJxCgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklFRBAAEhYKEkFDQ09VTlRf",
            "Tk9UX0xJTktFRBABEhYKEkFDQ09VTlRfTk9UX0FDVElWRRACEgoKBkFDVElW",
            "RRADEhUKEUFDQ09VTlRfU1VTUEVOREVEEAQ6jgHqQYoBCilvcmFjbGVkYXRh",
            "YmFzZS5nb29nbGVhcGlzLmNvbS9FbnRpdGxlbWVudBJCcHJvamVjdHMve3By",
            "b2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L2VudGl0bGVtZW50cy97ZW50",
            "aXRsZW1lbnR9KgxlbnRpdGxlbWVudHMyC2VudGl0bGVtZW50IuUBChNDbG91",
            "ZEFjY291bnREZXRhaWxzEhoKDWNsb3VkX2FjY291bnQYASABKAlCA+BBAxIm",
            "ChljbG91ZF9hY2NvdW50X2hvbWVfcmVnaW9uGAIgASgJQgPgQQMSKwoZbGlu",
            "a19leGlzdGluZ19hY2NvdW50X3VyaRgDIAEoCUID4EEDSACIAQESJgoUYWNj",
            "b3VudF9jcmVhdGlvbl91cmkYBCABKAlCA+BBA0gBiAEBQhwKGl9saW5rX2V4",
            "aXN0aW5nX2FjY291bnRfdXJpQhcKFV9hY2NvdW50X2NyZWF0aW9uX3VyaULq",
            "AQoiY29tLmdvb2dsZS5jbG91ZC5vcmFjbGVkYXRhYmFzZS52MUIQRW50aXRs",
            "ZW1lbnRQcm90b1ABWkpjbG91ZC5nb29nbGUuY29tL2dvL29yYWNsZWRhdGFi",
            "YXNlL2FwaXYxL29yYWNsZWRhdGFiYXNlcGI7b3JhY2xlZGF0YWJhc2VwYqoC",
            "Hkdvb2dsZS5DbG91ZC5PcmFjbGVEYXRhYmFzZS5WMcoCHkdvb2dsZVxDbG91",
            "ZFxPcmFjbGVEYXRhYmFzZVxWMeoCIUdvb2dsZTo6Q2xvdWQ6Ok9yYWNsZURh",
            "dGFiYXNlOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.OracleDatabase.V1.Entitlement), global::Google.Cloud.OracleDatabase.V1.Entitlement.Parser, new[]{ "Name", "CloudAccountDetails", "EntitlementId", "State" }, null, new[]{ typeof(global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.OracleDatabase.V1.CloudAccountDetails), global::Google.Cloud.OracleDatabase.V1.CloudAccountDetails.Parser, new[]{ "CloudAccount", "CloudAccountHomeRegion", "LinkExistingAccountUri", "AccountCreationUri" }, new[]{ "LinkExistingAccountUri", "AccountCreationUri" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Details of the Entitlement resource.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Entitlement : pb::IMessage<Entitlement>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Entitlement> _parser = new pb::MessageParser<Entitlement>(() => new Entitlement());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Entitlement> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.OracleDatabase.V1.EntitlementReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Entitlement() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Entitlement(Entitlement other) : this() {
      name_ = other.name_;
      cloudAccountDetails_ = other.cloudAccountDetails_ != null ? other.cloudAccountDetails_.Clone() : null;
      entitlementId_ = other.entitlementId_;
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Entitlement Clone() {
      return new Entitlement(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Identifier. The name of the Entitlement resource with the format:
    /// projects/{project}/locations/{region}/entitlements/{entitlement}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cloud_account_details" field.</summary>
    public const int CloudAccountDetailsFieldNumber = 2;
    private global::Google.Cloud.OracleDatabase.V1.CloudAccountDetails cloudAccountDetails_;
    /// <summary>
    /// Details of the OCI Cloud Account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.OracleDatabase.V1.CloudAccountDetails CloudAccountDetails {
      get { return cloudAccountDetails_; }
      set {
        cloudAccountDetails_ = value;
      }
    }

    /// <summary>Field number for the "entitlement_id" field.</summary>
    public const int EntitlementIdFieldNumber = 3;
    private string entitlementId_ = "";
    /// <summary>
    /// Output only. Google Cloud Marketplace order ID (aka entitlement ID)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EntitlementId {
      get { return entitlementId_; }
      set {
        entitlementId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State state_ = global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State.Unspecified;
    /// <summary>
    /// Output only. Entitlement State.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Entitlement);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Entitlement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CloudAccountDetails, other.CloudAccountDetails)) return false;
      if (EntitlementId != other.EntitlementId) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (cloudAccountDetails_ != null) hash ^= CloudAccountDetails.GetHashCode();
      if (EntitlementId.Length != 0) hash ^= EntitlementId.GetHashCode();
      if (State != global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State.Unspecified) hash ^= State.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (cloudAccountDetails_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CloudAccountDetails);
      }
      if (EntitlementId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EntitlementId);
      }
      if (State != global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (cloudAccountDetails_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CloudAccountDetails);
      }
      if (EntitlementId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EntitlementId);
      }
      if (State != global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (cloudAccountDetails_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CloudAccountDetails);
      }
      if (EntitlementId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EntitlementId);
      }
      if (State != global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Entitlement other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.cloudAccountDetails_ != null) {
        if (cloudAccountDetails_ == null) {
          CloudAccountDetails = new global::Google.Cloud.OracleDatabase.V1.CloudAccountDetails();
        }
        CloudAccountDetails.MergeFrom(other.CloudAccountDetails);
      }
      if (other.EntitlementId.Length != 0) {
        EntitlementId = other.EntitlementId;
      }
      if (other.State != global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State.Unspecified) {
        State = other.State;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (cloudAccountDetails_ == null) {
              CloudAccountDetails = new global::Google.Cloud.OracleDatabase.V1.CloudAccountDetails();
            }
            input.ReadMessage(CloudAccountDetails);
            break;
          }
          case 26: {
            EntitlementId = input.ReadString();
            break;
          }
          case 32: {
            State = (global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State) input.ReadEnum();
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (cloudAccountDetails_ == null) {
              CloudAccountDetails = new global::Google.Cloud.OracleDatabase.V1.CloudAccountDetails();
            }
            input.ReadMessage(CloudAccountDetails);
            break;
          }
          case 26: {
            EntitlementId = input.ReadString();
            break;
          }
          case 32: {
            State = (global::Google.Cloud.OracleDatabase.V1.Entitlement.Types.State) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Entitlement message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The various lifecycle states of the subscription.
      /// </summary>
      public enum State {
        /// <summary>
        /// Default unspecified value.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Account not linked.
        /// </summary>
        [pbr::OriginalName("ACCOUNT_NOT_LINKED")] AccountNotLinked = 1,
        /// <summary>
        /// Account is linked but not active.
        /// </summary>
        [pbr::OriginalName("ACCOUNT_NOT_ACTIVE")] AccountNotActive = 2,
        /// <summary>
        /// Entitlement and Account are active.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 3,
        /// <summary>
        /// Account is suspended.
        /// </summary>
        [pbr::OriginalName("ACCOUNT_SUSPENDED")] AccountSuspended = 4,
      }

    }
    #endregion

  }

  /// <summary>
  /// Details of the OCI Cloud Account.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CloudAccountDetails : pb::IMessage<CloudAccountDetails>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CloudAccountDetails> _parser = new pb::MessageParser<CloudAccountDetails>(() => new CloudAccountDetails());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CloudAccountDetails> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.OracleDatabase.V1.EntitlementReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudAccountDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudAccountDetails(CloudAccountDetails other) : this() {
      cloudAccount_ = other.cloudAccount_;
      cloudAccountHomeRegion_ = other.cloudAccountHomeRegion_;
      linkExistingAccountUri_ = other.linkExistingAccountUri_;
      accountCreationUri_ = other.accountCreationUri_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudAccountDetails Clone() {
      return new CloudAccountDetails(this);
    }

    /// <summary>Field number for the "cloud_account" field.</summary>
    public const int CloudAccountFieldNumber = 1;
    private string cloudAccount_ = "";
    /// <summary>
    /// Output only. OCI account name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CloudAccount {
      get { return cloudAccount_; }
      set {
        cloudAccount_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cloud_account_home_region" field.</summary>
    public const int CloudAccountHomeRegionFieldNumber = 2;
    private string cloudAccountHomeRegion_ = "";
    /// <summary>
    /// Output only. OCI account home region.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CloudAccountHomeRegion {
      get { return cloudAccountHomeRegion_; }
      set {
        cloudAccountHomeRegion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "link_existing_account_uri" field.</summary>
    public const int LinkExistingAccountUriFieldNumber = 3;
    private readonly static string LinkExistingAccountUriDefaultValue = "";

    private string linkExistingAccountUri_;
    /// <summary>
    /// Output only. URL to link an existing account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LinkExistingAccountUri {
      get { return linkExistingAccountUri_ ?? LinkExistingAccountUriDefaultValue; }
      set {
        linkExistingAccountUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "link_existing_account_uri" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLinkExistingAccountUri {
      get { return linkExistingAccountUri_ != null; }
    }
    /// <summary>Clears the value of the "link_existing_account_uri" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLinkExistingAccountUri() {
      linkExistingAccountUri_ = null;
    }

    /// <summary>Field number for the "account_creation_uri" field.</summary>
    public const int AccountCreationUriFieldNumber = 4;
    private readonly static string AccountCreationUriDefaultValue = "";

    private string accountCreationUri_;
    /// <summary>
    /// Output only. URL to create a new account and link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccountCreationUri {
      get { return accountCreationUri_ ?? AccountCreationUriDefaultValue; }
      set {
        accountCreationUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "account_creation_uri" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAccountCreationUri {
      get { return accountCreationUri_ != null; }
    }
    /// <summary>Clears the value of the "account_creation_uri" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAccountCreationUri() {
      accountCreationUri_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CloudAccountDetails);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CloudAccountDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CloudAccount != other.CloudAccount) return false;
      if (CloudAccountHomeRegion != other.CloudAccountHomeRegion) return false;
      if (LinkExistingAccountUri != other.LinkExistingAccountUri) return false;
      if (AccountCreationUri != other.AccountCreationUri) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CloudAccount.Length != 0) hash ^= CloudAccount.GetHashCode();
      if (CloudAccountHomeRegion.Length != 0) hash ^= CloudAccountHomeRegion.GetHashCode();
      if (HasLinkExistingAccountUri) hash ^= LinkExistingAccountUri.GetHashCode();
      if (HasAccountCreationUri) hash ^= AccountCreationUri.GetHashCode();
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
      if (CloudAccount.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CloudAccount);
      }
      if (CloudAccountHomeRegion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CloudAccountHomeRegion);
      }
      if (HasLinkExistingAccountUri) {
        output.WriteRawTag(26);
        output.WriteString(LinkExistingAccountUri);
      }
      if (HasAccountCreationUri) {
        output.WriteRawTag(34);
        output.WriteString(AccountCreationUri);
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
      if (CloudAccount.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CloudAccount);
      }
      if (CloudAccountHomeRegion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CloudAccountHomeRegion);
      }
      if (HasLinkExistingAccountUri) {
        output.WriteRawTag(26);
        output.WriteString(LinkExistingAccountUri);
      }
      if (HasAccountCreationUri) {
        output.WriteRawTag(34);
        output.WriteString(AccountCreationUri);
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
      if (CloudAccount.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CloudAccount);
      }
      if (CloudAccountHomeRegion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CloudAccountHomeRegion);
      }
      if (HasLinkExistingAccountUri) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LinkExistingAccountUri);
      }
      if (HasAccountCreationUri) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccountCreationUri);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CloudAccountDetails other) {
      if (other == null) {
        return;
      }
      if (other.CloudAccount.Length != 0) {
        CloudAccount = other.CloudAccount;
      }
      if (other.CloudAccountHomeRegion.Length != 0) {
        CloudAccountHomeRegion = other.CloudAccountHomeRegion;
      }
      if (other.HasLinkExistingAccountUri) {
        LinkExistingAccountUri = other.LinkExistingAccountUri;
      }
      if (other.HasAccountCreationUri) {
        AccountCreationUri = other.AccountCreationUri;
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
            CloudAccount = input.ReadString();
            break;
          }
          case 18: {
            CloudAccountHomeRegion = input.ReadString();
            break;
          }
          case 26: {
            LinkExistingAccountUri = input.ReadString();
            break;
          }
          case 34: {
            AccountCreationUri = input.ReadString();
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
            CloudAccount = input.ReadString();
            break;
          }
          case 18: {
            CloudAccountHomeRegion = input.ReadString();
            break;
          }
          case 26: {
            LinkExistingAccountUri = input.ReadString();
            break;
          }
          case 34: {
            AccountCreationUri = input.ReadString();
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
