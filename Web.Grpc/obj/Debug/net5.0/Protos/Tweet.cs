// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/tweet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Twitter.Web.Grpc.Protos.Tweet {

  /// <summary>Holder for reflection information generated from Protos/tweet.proto</summary>
  public static partial class TweetReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/tweet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TweetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvdHdlZXQucHJvdG8SDXR3aXR0ZXIudHdlZXQaHmdvb2dsZS9w",
            "cm90b2J1Zi93cmFwcGVycy5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5",
            "LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvInwKEkNy",
            "ZWF0ZVR3ZWV0UmVxdWVzdBJEChdncnBjX3R3ZWV0X2NvbnRlbnRfdHlwZRgB",
            "IAEoDjIjLnR3aXR0ZXIudHdlZXQuR3JwY1R3ZWV0Q29udGVudFR5cGUSDwoH",
            "Y29udGVudBgCIAEoCRIPCgd1c2VyX2lkGAMgASgJIiIKD01lc3NhZ2VSZXNw",
            "b25zZRIPCgdtZXNzYWdlGAEgASgJKjYKFEdycGNUd2VldENvbnRlbnRUeXBl",
            "EgkKBUltYWdlEAASCAoEVGV4dBABEgkKBVZpZGVvEAIyXAoLVHdlZXRBY3Rp",
            "b24STQoITmV3VHdlZXQSIS50d2l0dGVyLnR3ZWV0LkNyZWF0ZVR3ZWV0UmVx",
            "dWVzdBoeLnR3aXR0ZXIudHdlZXQuTWVzc2FnZVJlc3BvbnNlQiCqAh1Ud2l0",
            "dGVyLldlYi5HcnBjLlByb3Rvcy5Ud2VldGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Twitter.Web.Grpc.Protos.Tweet.CreateTweetRequest), global::Twitter.Web.Grpc.Protos.Tweet.CreateTweetRequest.Parser, new[]{ "GrpcTweetContentType", "Content", "UserId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Twitter.Web.Grpc.Protos.Tweet.MessageResponse), global::Twitter.Web.Grpc.Protos.Tweet.MessageResponse.Parser, new[]{ "Message" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum GrpcTweetContentType {
    [pbr::OriginalName("Image")] Image = 0,
    [pbr::OriginalName("Text")] Text = 1,
    [pbr::OriginalName("Video")] Video = 2,
  }

  #endregion

  #region Messages
  public sealed partial class CreateTweetRequest : pb::IMessage<CreateTweetRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateTweetRequest> _parser = new pb::MessageParser<CreateTweetRequest>(() => new CreateTweetRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateTweetRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Twitter.Web.Grpc.Protos.Tweet.TweetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateTweetRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateTweetRequest(CreateTweetRequest other) : this() {
      grpcTweetContentType_ = other.grpcTweetContentType_;
      content_ = other.content_;
      userId_ = other.userId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateTweetRequest Clone() {
      return new CreateTweetRequest(this);
    }

    /// <summary>Field number for the "grpc_tweet_content_type" field.</summary>
    public const int GrpcTweetContentTypeFieldNumber = 1;
    private global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType grpcTweetContentType_ = global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType.Image;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType GrpcTweetContentType {
      get { return grpcTweetContentType_; }
      set {
        grpcTweetContentType_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 2;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 3;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateTweetRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateTweetRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GrpcTweetContentType != other.GrpcTweetContentType) return false;
      if (Content != other.Content) return false;
      if (UserId != other.UserId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GrpcTweetContentType != global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType.Image) hash ^= GrpcTweetContentType.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
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
      if (GrpcTweetContentType != global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType.Image) {
        output.WriteRawTag(8);
        output.WriteEnum((int) GrpcTweetContentType);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Content);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GrpcTweetContentType != global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType.Image) {
        output.WriteRawTag(8);
        output.WriteEnum((int) GrpcTweetContentType);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Content);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GrpcTweetContentType != global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType.Image) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GrpcTweetContentType);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateTweetRequest other) {
      if (other == null) {
        return;
      }
      if (other.GrpcTweetContentType != global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType.Image) {
        GrpcTweetContentType = other.GrpcTweetContentType;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
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
          case 8: {
            GrpcTweetContentType = (global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType) input.ReadEnum();
            break;
          }
          case 18: {
            Content = input.ReadString();
            break;
          }
          case 26: {
            UserId = input.ReadString();
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
          case 8: {
            GrpcTweetContentType = (global::Twitter.Web.Grpc.Protos.Tweet.GrpcTweetContentType) input.ReadEnum();
            break;
          }
          case 18: {
            Content = input.ReadString();
            break;
          }
          case 26: {
            UserId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class MessageResponse : pb::IMessage<MessageResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MessageResponse> _parser = new pb::MessageParser<MessageResponse>(() => new MessageResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Twitter.Web.Grpc.Protos.Tweet.TweetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageResponse(MessageResponse other) : this() {
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageResponse Clone() {
      return new MessageResponse(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
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
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageResponse other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
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
            Message = input.ReadString();
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
            Message = input.ReadString();
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
