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

using Elastic.Clients.Elasticsearch.Core;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Tasks;

[JsonConverter(typeof(GroupByConverter))]
public enum GroupBy
{
	/// <summary>
	/// <para>
	/// Group tasks by parent task ID.
	/// </para>
	/// </summary>
	[EnumMember(Value = "parents")]
	Parents,
	/// <summary>
	/// <para>
	/// Do not group tasks.
	/// </para>
	/// </summary>
	[EnumMember(Value = "none")]
	None,
	/// <summary>
	/// <para>
	/// Group tasks by node ID.
	/// </para>
	/// </summary>
	[EnumMember(Value = "nodes")]
	Nodes
}

internal sealed class GroupByConverter : JsonConverter<GroupBy>
{
	public override GroupBy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "parents":
				return GroupBy.Parents;
			case "none":
				return GroupBy.None;
			case "nodes":
				return GroupBy.Nodes;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, GroupBy value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case GroupBy.Parents:
				writer.WriteStringValue("parents");
				return;
			case GroupBy.None:
				writer.WriteStringValue("none");
				return;
			case GroupBy.Nodes:
				writer.WriteStringValue("nodes");
				return;
		}

		writer.WriteNullValue();
	}
}