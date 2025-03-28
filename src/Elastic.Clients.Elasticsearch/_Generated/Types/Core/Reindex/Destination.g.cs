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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Core.Reindex;

public sealed partial class Destination
{
	/// <summary>
	/// <para>
	/// The name of the data stream, index, or index alias you are copying to.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

	/// <summary>
	/// <para>
	/// If it is <c>create</c>, the operation will only index documents that do not already exist (also known as "put if absent").
	/// </para>
	/// <para>
	/// IMPORTANT: To reindex to a data stream destination, this argument must be <c>create</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("op_type")]
	public Elastic.Clients.Elasticsearch.OpType? OpType { get; set; }

	/// <summary>
	/// <para>
	/// The name of the pipeline to use.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("pipeline")]
	public string? Pipeline { get; set; }

	/// <summary>
	/// <para>
	/// By default, a document's routing is preserved unless it's changed by the script.
	/// If it is <c>keep</c>, the routing on the bulk request sent for each match is set to the routing on the match.
	/// If it is <c>discard</c>, the routing on the bulk request sent for each match is set to <c>null</c>.
	/// If it is <c>=value</c>, the routing on the bulk request sent for each match is set to all value specified after the equals sign (<c>=</c>).
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

	/// <summary>
	/// <para>
	/// The versioning to use for the indexing operation.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version_type")]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get; set; }
}

public sealed partial class DestinationDescriptor : SerializableDescriptor<DestinationDescriptor>
{
	internal DestinationDescriptor(Action<DestinationDescriptor> configure) => configure.Invoke(this);

	public DestinationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.IndexName IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.OpType? OpTypeValue { get; set; }
	private string? PipelineValue { get; set; }
	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }
	private Elastic.Clients.Elasticsearch.VersionType? VersionTypeValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the data stream, index, or index alias you are copying to.
	/// </para>
	/// </summary>
	public DestinationDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If it is <c>create</c>, the operation will only index documents that do not already exist (also known as "put if absent").
	/// </para>
	/// <para>
	/// IMPORTANT: To reindex to a data stream destination, this argument must be <c>create</c>.
	/// </para>
	/// </summary>
	public DestinationDescriptor OpType(Elastic.Clients.Elasticsearch.OpType? opType)
	{
		OpTypeValue = opType;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the pipeline to use.
	/// </para>
	/// </summary>
	public DestinationDescriptor Pipeline(string? pipeline)
	{
		PipelineValue = pipeline;
		return Self;
	}

	/// <summary>
	/// <para>
	/// By default, a document's routing is preserved unless it's changed by the script.
	/// If it is <c>keep</c>, the routing on the bulk request sent for each match is set to the routing on the match.
	/// If it is <c>discard</c>, the routing on the bulk request sent for each match is set to <c>null</c>.
	/// If it is <c>=value</c>, the routing on the bulk request sent for each match is set to all value specified after the equals sign (<c>=</c>).
	/// </para>
	/// </summary>
	public DestinationDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The versioning to use for the indexing operation.
	/// </para>
	/// </summary>
	public DestinationDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType)
	{
		VersionTypeValue = versionType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("index");
		JsonSerializer.Serialize(writer, IndexValue, options);
		if (OpTypeValue is not null)
		{
			writer.WritePropertyName("op_type");
			JsonSerializer.Serialize(writer, OpTypeValue, options);
		}

		if (!string.IsNullOrEmpty(PipelineValue))
		{
			writer.WritePropertyName("pipeline");
			writer.WriteStringValue(PipelineValue);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (VersionTypeValue is not null)
		{
			writer.WritePropertyName("version_type");
			JsonSerializer.Serialize(writer, VersionTypeValue, options);
		}

		writer.WriteEndObject();
	}
}