// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/weather.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcClientStreamingExample {

  /// <summary>Holder for reflection information generated from Protos/weather.proto</summary>
  public static partial class WeatherReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/weather.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeatherReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcm90b3Mvd2VhdGhlci5wcm90byJKChJUZW1wZXJhdHVyZVJlYWRpbmcS",
            "DAoEY2l0eRgBIAEoCRITCgt0ZW1wZXJhdHVyZRgCIAEoBRIRCgl0aW1lc3Rh",
            "bXAYAyABKAkiPgoSVGVtcGVyYXR1cmVTdW1tYXJ5EgwKBGNpdHkYASABKAkS",
            "GgoSYXZlcmFnZVRlbXBlcmF0dXJlGAIgASgCMksKB1dlYXRoZXISQAoSUmVj",
            "b3JkVGVtcGVyYXR1cmVzEhMuVGVtcGVyYXR1cmVSZWFkaW5nGhMuVGVtcGVy",
            "YXR1cmVTdW1tYXJ5KAFCHaoCGkdycGNDbGllbnRTdHJlYW1pbmdFeGFtcGxl",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcClientStreamingExample.TemperatureReading), global::GrpcClientStreamingExample.TemperatureReading.Parser, new[]{ "City", "Temperature", "Timestamp" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcClientStreamingExample.TemperatureSummary), global::GrpcClientStreamingExample.TemperatureSummary.Parser, new[]{ "City", "AverageTemperature" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TemperatureReading : pb::IMessage<TemperatureReading>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TemperatureReading> _parser = new pb::MessageParser<TemperatureReading>(() => new TemperatureReading());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TemperatureReading> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcClientStreamingExample.WeatherReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TemperatureReading() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TemperatureReading(TemperatureReading other) : this() {
      city_ = other.city_;
      temperature_ = other.temperature_;
      timestamp_ = other.timestamp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TemperatureReading Clone() {
      return new TemperatureReading(this);
    }

    /// <summary>Field number for the "city" field.</summary>
    public const int CityFieldNumber = 1;
    private string city_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string City {
      get { return city_; }
      set {
        city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "temperature" field.</summary>
    public const int TemperatureFieldNumber = 2;
    private int temperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Temperature {
      get { return temperature_; }
      set {
        temperature_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 3;
    private string timestamp_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TemperatureReading);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TemperatureReading other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (City != other.City) return false;
      if (Temperature != other.Temperature) return false;
      if (Timestamp != other.Timestamp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (City.Length != 0) hash ^= City.GetHashCode();
      if (Temperature != 0) hash ^= Temperature.GetHashCode();
      if (Timestamp.Length != 0) hash ^= Timestamp.GetHashCode();
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
      if (City.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(City);
      }
      if (Temperature != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Temperature);
      }
      if (Timestamp.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Timestamp);
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
      if (City.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(City);
      }
      if (Temperature != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Temperature);
      }
      if (Timestamp.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Timestamp);
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
      if (City.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
      }
      if (Temperature != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Temperature);
      }
      if (Timestamp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TemperatureReading other) {
      if (other == null) {
        return;
      }
      if (other.City.Length != 0) {
        City = other.City;
      }
      if (other.Temperature != 0) {
        Temperature = other.Temperature;
      }
      if (other.Timestamp.Length != 0) {
        Timestamp = other.Timestamp;
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
            City = input.ReadString();
            break;
          }
          case 16: {
            Temperature = input.ReadInt32();
            break;
          }
          case 26: {
            Timestamp = input.ReadString();
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
            City = input.ReadString();
            break;
          }
          case 16: {
            Temperature = input.ReadInt32();
            break;
          }
          case 26: {
            Timestamp = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class TemperatureSummary : pb::IMessage<TemperatureSummary>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TemperatureSummary> _parser = new pb::MessageParser<TemperatureSummary>(() => new TemperatureSummary());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TemperatureSummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcClientStreamingExample.WeatherReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TemperatureSummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TemperatureSummary(TemperatureSummary other) : this() {
      city_ = other.city_;
      averageTemperature_ = other.averageTemperature_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TemperatureSummary Clone() {
      return new TemperatureSummary(this);
    }

    /// <summary>Field number for the "city" field.</summary>
    public const int CityFieldNumber = 1;
    private string city_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string City {
      get { return city_; }
      set {
        city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "averageTemperature" field.</summary>
    public const int AverageTemperatureFieldNumber = 2;
    private float averageTemperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AverageTemperature {
      get { return averageTemperature_; }
      set {
        averageTemperature_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TemperatureSummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TemperatureSummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (City != other.City) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AverageTemperature, other.AverageTemperature)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (City.Length != 0) hash ^= City.GetHashCode();
      if (AverageTemperature != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AverageTemperature);
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
      if (City.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(City);
      }
      if (AverageTemperature != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(AverageTemperature);
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
      if (City.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(City);
      }
      if (AverageTemperature != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(AverageTemperature);
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
      if (City.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
      }
      if (AverageTemperature != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TemperatureSummary other) {
      if (other == null) {
        return;
      }
      if (other.City.Length != 0) {
        City = other.City;
      }
      if (other.AverageTemperature != 0F) {
        AverageTemperature = other.AverageTemperature;
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
            City = input.ReadString();
            break;
          }
          case 21: {
            AverageTemperature = input.ReadFloat();
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
            City = input.ReadString();
            break;
          }
          case 21: {
            AverageTemperature = input.ReadFloat();
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
