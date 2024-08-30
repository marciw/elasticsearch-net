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

namespace Elastic.Clients.Elasticsearch.QueryDsl;

internal sealed partial class WeightedTokensQueryConverter : JsonConverter<WeightedTokensQuery>
{
	public override WeightedTokensQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var fieldName = reader.GetString();
		reader.Read();
		var variant = new WeightedTokensQuery(fieldName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "boost")
				{
					variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
					continue;
				}

				if (property == "pruning_config")
				{
					variant.PruningConfig = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfig?>(ref reader, options);
					continue;
				}

				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "tokens")
				{
					variant.Tokens = JsonSerializer.Deserialize<IDictionary<string, float>>(ref reader, options);
					continue;
				}
			}
		}

		reader.Read();
		return variant;
	}

	public override void Write(Utf8JsonWriter writer, WeightedTokensQuery value, JsonSerializerOptions options)
	{
		if (value.Field is null)
			throw new JsonException("Unable to serialize WeightedTokensQuery because the `Field` property is not set. Field name queries must include a valid field name.");
		if (!options.TryGetClientSettings(out var settings))
			throw new JsonException("Unable to retrieve client settings required to infer field.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(value.Field));
		writer.WriteStartObject();
		if (value.Boost.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(value.Boost.Value);
		}

		if (value.PruningConfig is not null)
		{
			writer.WritePropertyName("pruning_config");
			JsonSerializer.Serialize(writer, value.PruningConfig, options);
		}

		if (!string.IsNullOrEmpty(value.QueryName))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(value.QueryName);
		}

		writer.WritePropertyName("tokens");
		JsonSerializer.Serialize(writer, value.Tokens, options);
		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(WeightedTokensQueryConverter))]
public sealed partial class WeightedTokensQuery
{
	public WeightedTokensQuery(Elastic.Clients.Elasticsearch.Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		Field = field;
	}

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public float? Boost { get; set; }
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>
	/// Token pruning configurations
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfig? PruningConfig { get; set; }
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>
	/// The tokens representing this query
	/// </para>
	/// </summary>
	public IDictionary<string, float> Tokens { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.Query(WeightedTokensQuery weightedTokensQuery) => Elastic.Clients.Elasticsearch.QueryDsl.Query.WeightedTokens(weightedTokensQuery);
}

public sealed partial class WeightedTokensQueryDescriptor<TDocument> : SerializableDescriptor<WeightedTokensQueryDescriptor<TDocument>>
{
	internal WeightedTokensQueryDescriptor(Action<WeightedTokensQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public WeightedTokensQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfig? PruningConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor PruningConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor> PruningConfigDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private IDictionary<string, float> TokensValue { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public WeightedTokensQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public WeightedTokensQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public WeightedTokensQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public WeightedTokensQueryDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Token pruning configurations
	/// </para>
	/// </summary>
	public WeightedTokensQueryDescriptor<TDocument> PruningConfig(Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfig? pruningConfig)
	{
		PruningConfigDescriptor = null;
		PruningConfigDescriptorAction = null;
		PruningConfigValue = pruningConfig;
		return Self;
	}

	public WeightedTokensQueryDescriptor<TDocument> PruningConfig(Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor descriptor)
	{
		PruningConfigValue = null;
		PruningConfigDescriptorAction = null;
		PruningConfigDescriptor = descriptor;
		return Self;
	}

	public WeightedTokensQueryDescriptor<TDocument> PruningConfig(Action<Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor> configure)
	{
		PruningConfigValue = null;
		PruningConfigDescriptor = null;
		PruningConfigDescriptorAction = configure;
		return Self;
	}

	public WeightedTokensQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The tokens representing this query
	/// </para>
	/// </summary>
	public WeightedTokensQueryDescriptor<TDocument> Tokens(Func<FluentDictionary<string, float>, FluentDictionary<string, float>> selector)
	{
		TokensValue = selector?.Invoke(new FluentDictionary<string, float>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (PruningConfigDescriptor is not null)
		{
			writer.WritePropertyName("pruning_config");
			JsonSerializer.Serialize(writer, PruningConfigDescriptor, options);
		}
		else if (PruningConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("pruning_config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor(PruningConfigDescriptorAction), options);
		}
		else if (PruningConfigValue is not null)
		{
			writer.WritePropertyName("pruning_config");
			JsonSerializer.Serialize(writer, PruningConfigValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WritePropertyName("tokens");
		JsonSerializer.Serialize(writer, TokensValue, options);
		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class WeightedTokensQueryDescriptor : SerializableDescriptor<WeightedTokensQueryDescriptor>
{
	internal WeightedTokensQueryDescriptor(Action<WeightedTokensQueryDescriptor> configure) => configure.Invoke(this);

	public WeightedTokensQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfig? PruningConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor PruningConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor> PruningConfigDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private IDictionary<string, float> TokensValue { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public WeightedTokensQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public WeightedTokensQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public WeightedTokensQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public WeightedTokensQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Token pruning configurations
	/// </para>
	/// </summary>
	public WeightedTokensQueryDescriptor PruningConfig(Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfig? pruningConfig)
	{
		PruningConfigDescriptor = null;
		PruningConfigDescriptorAction = null;
		PruningConfigValue = pruningConfig;
		return Self;
	}

	public WeightedTokensQueryDescriptor PruningConfig(Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor descriptor)
	{
		PruningConfigValue = null;
		PruningConfigDescriptorAction = null;
		PruningConfigDescriptor = descriptor;
		return Self;
	}

	public WeightedTokensQueryDescriptor PruningConfig(Action<Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor> configure)
	{
		PruningConfigValue = null;
		PruningConfigDescriptor = null;
		PruningConfigDescriptorAction = configure;
		return Self;
	}

	public WeightedTokensQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The tokens representing this query
	/// </para>
	/// </summary>
	public WeightedTokensQueryDescriptor Tokens(Func<FluentDictionary<string, float>, FluentDictionary<string, float>> selector)
	{
		TokensValue = selector?.Invoke(new FluentDictionary<string, float>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (PruningConfigDescriptor is not null)
		{
			writer.WritePropertyName("pruning_config");
			JsonSerializer.Serialize(writer, PruningConfigDescriptor, options);
		}
		else if (PruningConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("pruning_config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.TokenPruningConfigDescriptor(PruningConfigDescriptorAction), options);
		}
		else if (PruningConfigValue is not null)
		{
			writer.WritePropertyName("pruning_config");
			JsonSerializer.Serialize(writer, PruningConfigValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WritePropertyName("tokens");
		JsonSerializer.Serialize(writer, TokensValue, options);
		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}