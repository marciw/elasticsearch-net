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

namespace Elastic.Clients.Elasticsearch.Core.Search;

public sealed partial class LearningToRank
{
	/// <summary>
	/// <para>
	/// The unique identifier of the trained model uploaded to Elasticsearch
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_id")]
	public string ModelId { get; set; }

	/// <summary>
	/// <para>
	/// Named parameters to be passed to the query templates used for feature
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("params")]
	public IDictionary<string, object>? Params { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Core.Search.Rescore(LearningToRank learningToRank) => Elastic.Clients.Elasticsearch.Core.Search.Rescore.LearningToRank(learningToRank);
}

public sealed partial class LearningToRankDescriptor : SerializableDescriptor<LearningToRankDescriptor>
{
	internal LearningToRankDescriptor(Action<LearningToRankDescriptor> configure) => configure.Invoke(this);

	public LearningToRankDescriptor() : base()
	{
	}

	private string ModelIdValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }

	/// <summary>
	/// <para>
	/// The unique identifier of the trained model uploaded to Elasticsearch
	/// </para>
	/// </summary>
	public LearningToRankDescriptor ModelId(string modelId)
	{
		ModelIdValue = modelId;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Named parameters to be passed to the query templates used for feature
	/// </para>
	/// </summary>
	public LearningToRankDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("model_id");
		writer.WriteStringValue(ModelIdValue);
		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		writer.WriteEndObject();
	}
}