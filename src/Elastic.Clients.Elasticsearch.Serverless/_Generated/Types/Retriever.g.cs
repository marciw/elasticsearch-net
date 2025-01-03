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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless;

[JsonConverter(typeof(RetrieverConverter))]
public sealed partial class Retriever
{
	internal Retriever(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }
	internal string VariantName { get; }

	public static Retriever Knn(Elastic.Clients.Elasticsearch.Serverless.KnnRetriever knnRetriever) => new Retriever("knn", knnRetriever);
	public static Retriever Rrf(Elastic.Clients.Elasticsearch.Serverless.RRFRetriever rRFRetriever) => new Retriever("rrf", rRFRetriever);
	public static Retriever Rule(Elastic.Clients.Elasticsearch.Serverless.RuleRetriever ruleRetriever) => new Retriever("rule", ruleRetriever);
	public static Retriever Standard(Elastic.Clients.Elasticsearch.Serverless.StandardRetriever standardRetriever) => new Retriever("standard", standardRetriever);
	public static Retriever TextSimilarityReranker(Elastic.Clients.Elasticsearch.Serverless.TextSimilarityReranker textSimilarityReranker) => new Retriever("text_similarity_reranker", textSimilarityReranker);

	public bool TryGet<T>([NotNullWhen(true)] out T? result) where T : class
	{
		result = default;
		if (Variant is T variant)
		{
			result = variant;
			return true;
		}

		return false;
	}
}

internal sealed partial class RetrieverConverter : JsonConverter<Retriever>
{
	public override Retriever Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		object? variantValue = default;
		string? variantNameValue = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token.");
			}

			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token representing the name of an Elasticsearch field.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "knn")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.KnnRetriever?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "rrf")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.RRFRetriever?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "rule")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.RuleRetriever?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "standard")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.StandardRetriever?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "text_similarity_reranker")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.TextSimilarityReranker?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'Retriever' from the response.");
		}

		var result = new Retriever(variantNameValue, variantValue);
		return result;
	}

	public override void Write(Utf8JsonWriter writer, Retriever value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "knn":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.KnnRetriever>(writer, (Elastic.Clients.Elasticsearch.Serverless.KnnRetriever)value.Variant, options);
					break;
				case "rrf":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.RRFRetriever>(writer, (Elastic.Clients.Elasticsearch.Serverless.RRFRetriever)value.Variant, options);
					break;
				case "rule":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.RuleRetriever>(writer, (Elastic.Clients.Elasticsearch.Serverless.RuleRetriever)value.Variant, options);
					break;
				case "standard":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.StandardRetriever>(writer, (Elastic.Clients.Elasticsearch.Serverless.StandardRetriever)value.Variant, options);
					break;
				case "text_similarity_reranker":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.TextSimilarityReranker>(writer, (Elastic.Clients.Elasticsearch.Serverless.TextSimilarityReranker)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RetrieverDescriptor<TDocument> : SerializableDescriptor<RetrieverDescriptor<TDocument>>
{
	internal RetrieverDescriptor(Action<RetrieverDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RetrieverDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private RetrieverDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private RetrieverDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public RetrieverDescriptor<TDocument> Knn(Elastic.Clients.Elasticsearch.Serverless.KnnRetriever knnRetriever) => Set(knnRetriever, "knn");
	public RetrieverDescriptor<TDocument> Knn(Action<Elastic.Clients.Elasticsearch.Serverless.KnnRetrieverDescriptor<TDocument>> configure) => Set(configure, "knn");
	public RetrieverDescriptor<TDocument> Rrf(Elastic.Clients.Elasticsearch.Serverless.RRFRetriever rRFRetriever) => Set(rRFRetriever, "rrf");
	public RetrieverDescriptor<TDocument> Rrf(Action<Elastic.Clients.Elasticsearch.Serverless.RRFRetrieverDescriptor<TDocument>> configure) => Set(configure, "rrf");
	public RetrieverDescriptor<TDocument> Rule(Elastic.Clients.Elasticsearch.Serverless.RuleRetriever ruleRetriever) => Set(ruleRetriever, "rule");
	public RetrieverDescriptor<TDocument> Rule(Action<Elastic.Clients.Elasticsearch.Serverless.RuleRetrieverDescriptor<TDocument>> configure) => Set(configure, "rule");
	public RetrieverDescriptor<TDocument> Standard(Elastic.Clients.Elasticsearch.Serverless.StandardRetriever standardRetriever) => Set(standardRetriever, "standard");
	public RetrieverDescriptor<TDocument> Standard(Action<Elastic.Clients.Elasticsearch.Serverless.StandardRetrieverDescriptor<TDocument>> configure) => Set(configure, "standard");
	public RetrieverDescriptor<TDocument> TextSimilarityReranker(Elastic.Clients.Elasticsearch.Serverless.TextSimilarityReranker textSimilarityReranker) => Set(textSimilarityReranker, "text_similarity_reranker");
	public RetrieverDescriptor<TDocument> TextSimilarityReranker(Action<Elastic.Clients.Elasticsearch.Serverless.TextSimilarityRerankerDescriptor<TDocument>> configure) => Set(configure, "text_similarity_reranker");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RetrieverDescriptor : SerializableDescriptor<RetrieverDescriptor>
{
	internal RetrieverDescriptor(Action<RetrieverDescriptor> configure) => configure.Invoke(this);

	public RetrieverDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private RetrieverDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private RetrieverDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public RetrieverDescriptor Knn(Elastic.Clients.Elasticsearch.Serverless.KnnRetriever knnRetriever) => Set(knnRetriever, "knn");
	public RetrieverDescriptor Knn<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.KnnRetrieverDescriptor> configure) => Set(configure, "knn");
	public RetrieverDescriptor Rrf(Elastic.Clients.Elasticsearch.Serverless.RRFRetriever rRFRetriever) => Set(rRFRetriever, "rrf");
	public RetrieverDescriptor Rrf<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.RRFRetrieverDescriptor> configure) => Set(configure, "rrf");
	public RetrieverDescriptor Rule(Elastic.Clients.Elasticsearch.Serverless.RuleRetriever ruleRetriever) => Set(ruleRetriever, "rule");
	public RetrieverDescriptor Rule<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.RuleRetrieverDescriptor> configure) => Set(configure, "rule");
	public RetrieverDescriptor Standard(Elastic.Clients.Elasticsearch.Serverless.StandardRetriever standardRetriever) => Set(standardRetriever, "standard");
	public RetrieverDescriptor Standard<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.StandardRetrieverDescriptor> configure) => Set(configure, "standard");
	public RetrieverDescriptor TextSimilarityReranker(Elastic.Clients.Elasticsearch.Serverless.TextSimilarityReranker textSimilarityReranker) => Set(textSimilarityReranker, "text_similarity_reranker");
	public RetrieverDescriptor TextSimilarityReranker<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.TextSimilarityRerankerDescriptor> configure) => Set(configure, "text_similarity_reranker");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}