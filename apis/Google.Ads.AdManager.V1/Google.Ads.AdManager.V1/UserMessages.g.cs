// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/admanager/v1/user_messages.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.AdManager.V1 {

  /// <summary>Holder for reflection information generated from google/ads/admanager/v1/user_messages.proto</summary>
  public static partial class UserMessagesReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/admanager/v1/user_messages.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserMessagesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvYWRzL2FkbWFuYWdlci92MS91c2VyX21lc3NhZ2VzLnByb3Rv",
            "Ehdnb29nbGUuYWRzLmFkbWFuYWdlci52MRofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byLfAgoE",
            "VXNlchIRCgRuYW1lGAEgASgJQgPgQQgSFAoHdXNlcl9pZBgKIAEoA0ID4EED",
            "EhkKDGRpc3BsYXlfbmFtZRgCIAEoCUID4EECEhIKBWVtYWlsGAMgASgJQgPg",
            "QQISMwoEcm9sZRgEIAEoCUIl4EEC+kEfCh1hZG1hbmFnZXIuZ29vZ2xlYXBp",
            "cy5jb20vUm9sZRITCgZhY3RpdmUYBiABKAhCA+BBAxIYCgtleHRlcm5hbF9p",
            "ZBgHIAEoCUID4EEBEhwKD3NlcnZpY2VfYWNjb3VudBgIIAEoCEID4EEDEiYK",
            "GW9yZGVyc191aV9sb2NhbF90aW1lX3pvbmUYCSABKAlCA+BBATpV6kFSCh1h",
            "ZG1hbmFnZXIuZ29vZ2xlYXBpcy5jb20vVXNlchIkbmV0d29ya3Mve25ldHdv",
            "cmtfY29kZX0vdXNlcnMve3VzZXJ9KgV1c2VyczIEdXNlckLFAQobY29tLmdv",
            "b2dsZS5hZHMuYWRtYW5hZ2VyLnYxQhFVc2VyTWVzc2FnZXNQcm90b1ABWkBn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9hZG1h",
            "bmFnZXIvdjE7YWRtYW5hZ2VyqgIXR29vZ2xlLkFkcy5BZE1hbmFnZXIuVjHK",
            "AhdHb29nbGVcQWRzXEFkTWFuYWdlclxWMeoCGkdvb2dsZTo6QWRzOjpBZE1h",
            "bmFnZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.AdManager.V1.User), global::Google.Ads.AdManager.V1.User.Parser, new[]{ "Name", "UserId", "DisplayName", "Email", "Role", "Active", "ExternalId", "ServiceAccount", "OrdersUiLocalTimeZone" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The User resource.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class User : pb::IMessage<User>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.AdManager.V1.UserMessagesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User(User other) : this() {
      name_ = other.name_;
      userId_ = other.userId_;
      displayName_ = other.displayName_;
      email_ = other.email_;
      role_ = other.role_;
      active_ = other.active_;
      externalId_ = other.externalId_;
      serviceAccount_ = other.serviceAccount_;
      ordersUiLocalTimeZone_ = other.ordersUiLocalTimeZone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Identifier. The resource name of the User.
    /// Format: `networks/{network_code}/users/{user_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 10;
    private long userId_;
    /// <summary>
    /// Output only. `User` ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. The name of the User. It has a maximum length of 128 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    /// <summary>
    /// Required. The email or login of the User. In order to create a new user,
    /// you must already have a Google Account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "role" field.</summary>
    public const int RoleFieldNumber = 4;
    private string role_ = "";
    /// <summary>
    /// Required. The unique Role ID of the User. Roles that are created by Google
    /// will have negative IDs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Role {
      get { return role_; }
      set {
        role_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "active" field.</summary>
    public const int ActiveFieldNumber = 6;
    private bool active_;
    /// <summary>
    /// Output only. Specifies whether or not the User is active. An inactive user
    /// cannot log in to the system or perform any operations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Active {
      get { return active_; }
      set {
        active_ = value;
      }
    }

    /// <summary>Field number for the "external_id" field.</summary>
    public const int ExternalIdFieldNumber = 7;
    private string externalId_ = "";
    /// <summary>
    /// Optional. An identifier for the User that is meaningful to the publisher.
    /// This attribute has a maximum length of 255 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ExternalId {
      get { return externalId_; }
      set {
        externalId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "service_account" field.</summary>
    public const int ServiceAccountFieldNumber = 8;
    private bool serviceAccount_;
    /// <summary>
    /// Output only. Whether the user is an OAuth2 service account user.
    /// Service account users can only be added through the UI.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ServiceAccount {
      get { return serviceAccount_; }
      set {
        serviceAccount_ = value;
      }
    }

    /// <summary>Field number for the "orders_ui_local_time_zone" field.</summary>
    public const int OrdersUiLocalTimeZoneFieldNumber = 9;
    private string ordersUiLocalTimeZone_ = "";
    /// <summary>
    /// Optional. The IANA Time Zone Database time zone, e.g. "America/New_York",
    /// used in the orders and line items UI for this User. If not provided, the UI
    /// then defaults to using the Network's timezone. This setting only affects
    /// the UI for this user and does not affect the timezone of any dates and
    /// times returned in API responses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OrdersUiLocalTimeZone {
      get { return ordersUiLocalTimeZone_; }
      set {
        ordersUiLocalTimeZone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (UserId != other.UserId) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Email != other.Email) return false;
      if (Role != other.Role) return false;
      if (Active != other.Active) return false;
      if (ExternalId != other.ExternalId) return false;
      if (ServiceAccount != other.ServiceAccount) return false;
      if (OrdersUiLocalTimeZone != other.OrdersUiLocalTimeZone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (UserId != 0L) hash ^= UserId.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Role.Length != 0) hash ^= Role.GetHashCode();
      if (Active != false) hash ^= Active.GetHashCode();
      if (ExternalId.Length != 0) hash ^= ExternalId.GetHashCode();
      if (ServiceAccount != false) hash ^= ServiceAccount.GetHashCode();
      if (OrdersUiLocalTimeZone.Length != 0) hash ^= OrdersUiLocalTimeZone.GetHashCode();
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      if (Role.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Role);
      }
      if (Active != false) {
        output.WriteRawTag(48);
        output.WriteBool(Active);
      }
      if (ExternalId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ExternalId);
      }
      if (ServiceAccount != false) {
        output.WriteRawTag(64);
        output.WriteBool(ServiceAccount);
      }
      if (OrdersUiLocalTimeZone.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(OrdersUiLocalTimeZone);
      }
      if (UserId != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(UserId);
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      if (Role.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Role);
      }
      if (Active != false) {
        output.WriteRawTag(48);
        output.WriteBool(Active);
      }
      if (ExternalId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ExternalId);
      }
      if (ServiceAccount != false) {
        output.WriteRawTag(64);
        output.WriteBool(ServiceAccount);
      }
      if (OrdersUiLocalTimeZone.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(OrdersUiLocalTimeZone);
      }
      if (UserId != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(UserId);
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
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Role.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Role);
      }
      if (Active != false) {
        size += 1 + 1;
      }
      if (ExternalId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExternalId);
      }
      if (ServiceAccount != false) {
        size += 1 + 1;
      }
      if (OrdersUiLocalTimeZone.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OrdersUiLocalTimeZone);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.UserId != 0L) {
        UserId = other.UserId;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Role.Length != 0) {
        Role = other.Role;
      }
      if (other.Active != false) {
        Active = other.Active;
      }
      if (other.ExternalId.Length != 0) {
        ExternalId = other.ExternalId;
      }
      if (other.ServiceAccount != false) {
        ServiceAccount = other.ServiceAccount;
      }
      if (other.OrdersUiLocalTimeZone.Length != 0) {
        OrdersUiLocalTimeZone = other.OrdersUiLocalTimeZone;
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            Role = input.ReadString();
            break;
          }
          case 48: {
            Active = input.ReadBool();
            break;
          }
          case 58: {
            ExternalId = input.ReadString();
            break;
          }
          case 64: {
            ServiceAccount = input.ReadBool();
            break;
          }
          case 74: {
            OrdersUiLocalTimeZone = input.ReadString();
            break;
          }
          case 80: {
            UserId = input.ReadInt64();
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            Role = input.ReadString();
            break;
          }
          case 48: {
            Active = input.ReadBool();
            break;
          }
          case 58: {
            ExternalId = input.ReadString();
            break;
          }
          case 64: {
            ServiceAccount = input.ReadBool();
            break;
          }
          case 74: {
            OrdersUiLocalTimeZone = input.ReadString();
            break;
          }
          case 80: {
            UserId = input.ReadInt64();
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
