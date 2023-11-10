// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using System;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Elastic.Clients.Elasticsearch.Serverless.Core;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

[JsonConverter(typeof(ConvertTypeConverter))]
public enum ConvertType
{
	[EnumMember(Value = "string")]
	String,
	[EnumMember(Value = "long")]
	Long,
	[EnumMember(Value = "integer")]
	Integer,
	[EnumMember(Value = "float")]
	Float,
	[EnumMember(Value = "double")]
	Double,
	[EnumMember(Value = "boolean")]
	Boolean,
	[EnumMember(Value = "auto")]
	Auto
}

internal sealed class ConvertTypeConverter : JsonConverter<ConvertType>
{
	public override ConvertType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "string":
				return ConvertType.String;
			case "long":
				return ConvertType.Long;
			case "integer":
				return ConvertType.Integer;
			case "float":
				return ConvertType.Float;
			case "double":
				return ConvertType.Double;
			case "boolean":
				return ConvertType.Boolean;
			case "auto":
				return ConvertType.Auto;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, ConvertType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ConvertType.String:
				writer.WriteStringValue("string");
				return;
			case ConvertType.Long:
				writer.WriteStringValue("long");
				return;
			case ConvertType.Integer:
				writer.WriteStringValue("integer");
				return;
			case ConvertType.Float:
				writer.WriteStringValue("float");
				return;
			case ConvertType.Double:
				writer.WriteStringValue("double");
				return;
			case ConvertType.Boolean:
				writer.WriteStringValue("boolean");
				return;
			case ConvertType.Auto:
				writer.WriteStringValue("auto");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(JsonProcessorConflictStrategyConverter))]
public enum JsonProcessorConflictStrategy
{
	/// <summary>
	/// <para>Root fields that conflict with fields from the parsed JSON will be overridden.</para>
	/// </summary>
	[EnumMember(Value = "replace")]
	Replace,
	/// <summary>
	/// <para>Conflicting fields will be merged.</para>
	/// </summary>
	[EnumMember(Value = "merge")]
	Merge
}

internal sealed class JsonProcessorConflictStrategyConverter : JsonConverter<JsonProcessorConflictStrategy>
{
	public override JsonProcessorConflictStrategy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "replace":
				return JsonProcessorConflictStrategy.Replace;
			case "merge":
				return JsonProcessorConflictStrategy.Merge;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, JsonProcessorConflictStrategy value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case JsonProcessorConflictStrategy.Replace:
				writer.WriteStringValue("replace");
				return;
			case JsonProcessorConflictStrategy.Merge:
				writer.WriteStringValue("merge");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(ShapeTypeConverter))]
public enum ShapeType
{
	[EnumMember(Value = "shape")]
	Shape,
	[EnumMember(Value = "geo_shape")]
	GeoShape
}

internal sealed class ShapeTypeConverter : JsonConverter<ShapeType>
{
	public override ShapeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "shape":
				return ShapeType.Shape;
			case "geo_shape":
				return ShapeType.GeoShape;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, ShapeType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ShapeType.Shape:
				writer.WriteStringValue("shape");
				return;
			case ShapeType.GeoShape:
				writer.WriteStringValue("geo_shape");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(UserAgentPropertyConverter))]
public enum UserAgentProperty
{
	[EnumMember(Value = "PATCH")]
	Patch,
	[EnumMember(Value = "OS_NAME")]
	OsName,
	[EnumMember(Value = "OS_MINOR")]
	OsMinor,
	[EnumMember(Value = "OS_MAJOR")]
	OsMajor,
	[EnumMember(Value = "OS")]
	Os,
	[EnumMember(Value = "NAME")]
	Name,
	[EnumMember(Value = "MINOR")]
	Minor,
	[EnumMember(Value = "MAJOR")]
	Major,
	[EnumMember(Value = "DEVICE")]
	Device,
	[EnumMember(Value = "BUILD")]
	Build
}

internal sealed class UserAgentPropertyConverter : JsonConverter<UserAgentProperty>
{
	public override UserAgentProperty Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "PATCH":
				return UserAgentProperty.Patch;
			case "OS_NAME":
				return UserAgentProperty.OsName;
			case "OS_MINOR":
				return UserAgentProperty.OsMinor;
			case "OS_MAJOR":
				return UserAgentProperty.OsMajor;
			case "OS":
				return UserAgentProperty.Os;
			case "NAME":
				return UserAgentProperty.Name;
			case "MINOR":
				return UserAgentProperty.Minor;
			case "MAJOR":
				return UserAgentProperty.Major;
			case "DEVICE":
				return UserAgentProperty.Device;
			case "BUILD":
				return UserAgentProperty.Build;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, UserAgentProperty value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case UserAgentProperty.Patch:
				writer.WriteStringValue("PATCH");
				return;
			case UserAgentProperty.OsName:
				writer.WriteStringValue("OS_NAME");
				return;
			case UserAgentProperty.OsMinor:
				writer.WriteStringValue("OS_MINOR");
				return;
			case UserAgentProperty.OsMajor:
				writer.WriteStringValue("OS_MAJOR");
				return;
			case UserAgentProperty.Os:
				writer.WriteStringValue("OS");
				return;
			case UserAgentProperty.Name:
				writer.WriteStringValue("NAME");
				return;
			case UserAgentProperty.Minor:
				writer.WriteStringValue("MINOR");
				return;
			case UserAgentProperty.Major:
				writer.WriteStringValue("MAJOR");
				return;
			case UserAgentProperty.Device:
				writer.WriteStringValue("DEVICE");
				return;
			case UserAgentProperty.Build:
				writer.WriteStringValue("BUILD");
				return;
		}

		writer.WriteNullValue();
	}
}