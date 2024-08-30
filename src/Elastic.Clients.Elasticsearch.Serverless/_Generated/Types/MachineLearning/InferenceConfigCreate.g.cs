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

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

/// <summary>
/// <para>
/// Inference configuration provided when storing the model config
/// </para>
/// </summary>
[JsonConverter(typeof(InferenceConfigCreateConverter))]
public sealed partial class InferenceConfigCreate
{
	internal InferenceConfigCreate(string variantName, object variant)
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

	public static InferenceConfigCreate Classification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ClassificationInferenceOptions classificationInferenceOptions) => new InferenceConfigCreate("classification", classificationInferenceOptions);
	public static InferenceConfigCreate FillMask(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.FillMaskInferenceOptions fillMaskInferenceOptions) => new InferenceConfigCreate("fill_mask", fillMaskInferenceOptions);
	public static InferenceConfigCreate Ner(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.NerInferenceOptions nerInferenceOptions) => new InferenceConfigCreate("ner", nerInferenceOptions);
	public static InferenceConfigCreate PassThrough(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PassThroughInferenceOptions passThroughInferenceOptions) => new InferenceConfigCreate("pass_through", passThroughInferenceOptions);
	public static InferenceConfigCreate QuestionAnswering(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.QuestionAnsweringInferenceOptions questionAnsweringInferenceOptions) => new InferenceConfigCreate("question_answering", questionAnsweringInferenceOptions);
	public static InferenceConfigCreate Regression(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.RegressionInferenceOptions regressionInferenceOptions) => new InferenceConfigCreate("regression", regressionInferenceOptions);
	public static InferenceConfigCreate TextClassification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextClassificationInferenceOptions textClassificationInferenceOptions) => new InferenceConfigCreate("text_classification", textClassificationInferenceOptions);
	public static InferenceConfigCreate TextEmbedding(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextEmbeddingInferenceOptions textEmbeddingInferenceOptions) => new InferenceConfigCreate("text_embedding", textEmbeddingInferenceOptions);
	public static InferenceConfigCreate TextExpansion(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextExpansionInferenceOptions textExpansionInferenceOptions) => new InferenceConfigCreate("text_expansion", textExpansionInferenceOptions);
	public static InferenceConfigCreate ZeroShotClassification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ZeroShotClassificationInferenceOptions zeroShotClassificationInferenceOptions) => new InferenceConfigCreate("zero_shot_classification", zeroShotClassificationInferenceOptions);

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

internal sealed partial class InferenceConfigCreateConverter : JsonConverter<InferenceConfigCreate>
{
	public override InferenceConfigCreate Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
			if (propertyName == "classification")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ClassificationInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "fill_mask")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.FillMaskInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "ner")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.NerInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "pass_through")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PassThroughInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "question_answering")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.QuestionAnsweringInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "regression")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.RegressionInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "text_classification")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextClassificationInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "text_embedding")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextEmbeddingInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "text_expansion")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextExpansionInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "zero_shot_classification")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ZeroShotClassificationInferenceOptions?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'InferenceConfigCreate' from the response.");
		}

		var result = new InferenceConfigCreate(variantNameValue, variantValue);
		return result;
	}

	public override void Write(Utf8JsonWriter writer, InferenceConfigCreate value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "classification":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ClassificationInferenceOptions)value.Variant, options);
					break;
				case "fill_mask":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.FillMaskInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.FillMaskInferenceOptions)value.Variant, options);
					break;
				case "ner":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.NerInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.NerInferenceOptions)value.Variant, options);
					break;
				case "pass_through":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PassThroughInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PassThroughInferenceOptions)value.Variant, options);
					break;
				case "question_answering":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.QuestionAnsweringInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.QuestionAnsweringInferenceOptions)value.Variant, options);
					break;
				case "regression":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.RegressionInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.RegressionInferenceOptions)value.Variant, options);
					break;
				case "text_classification":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextClassificationInferenceOptions)value.Variant, options);
					break;
				case "text_embedding":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextEmbeddingInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextEmbeddingInferenceOptions)value.Variant, options);
					break;
				case "text_expansion":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextExpansionInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextExpansionInferenceOptions)value.Variant, options);
					break;
				case "zero_shot_classification":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ZeroShotClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ZeroShotClassificationInferenceOptions)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class InferenceConfigCreateDescriptor<TDocument> : SerializableDescriptor<InferenceConfigCreateDescriptor<TDocument>>
{
	internal InferenceConfigCreateDescriptor(Action<InferenceConfigCreateDescriptor<TDocument>> configure) => configure.Invoke(this);

	public InferenceConfigCreateDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private InferenceConfigCreateDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private InferenceConfigCreateDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public InferenceConfigCreateDescriptor<TDocument> Classification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ClassificationInferenceOptions classificationInferenceOptions) => Set(classificationInferenceOptions, "classification");
	public InferenceConfigCreateDescriptor<TDocument> Classification(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ClassificationInferenceOptionsDescriptor> configure) => Set(configure, "classification");
	public InferenceConfigCreateDescriptor<TDocument> FillMask(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.FillMaskInferenceOptions fillMaskInferenceOptions) => Set(fillMaskInferenceOptions, "fill_mask");
	public InferenceConfigCreateDescriptor<TDocument> FillMask(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.FillMaskInferenceOptionsDescriptor> configure) => Set(configure, "fill_mask");
	public InferenceConfigCreateDescriptor<TDocument> Ner(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.NerInferenceOptions nerInferenceOptions) => Set(nerInferenceOptions, "ner");
	public InferenceConfigCreateDescriptor<TDocument> Ner(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.NerInferenceOptionsDescriptor> configure) => Set(configure, "ner");
	public InferenceConfigCreateDescriptor<TDocument> PassThrough(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PassThroughInferenceOptions passThroughInferenceOptions) => Set(passThroughInferenceOptions, "pass_through");
	public InferenceConfigCreateDescriptor<TDocument> PassThrough(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PassThroughInferenceOptionsDescriptor> configure) => Set(configure, "pass_through");
	public InferenceConfigCreateDescriptor<TDocument> QuestionAnswering(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.QuestionAnsweringInferenceOptions questionAnsweringInferenceOptions) => Set(questionAnsweringInferenceOptions, "question_answering");
	public InferenceConfigCreateDescriptor<TDocument> QuestionAnswering(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.QuestionAnsweringInferenceOptionsDescriptor> configure) => Set(configure, "question_answering");
	public InferenceConfigCreateDescriptor<TDocument> Regression(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.RegressionInferenceOptions regressionInferenceOptions) => Set(regressionInferenceOptions, "regression");
	public InferenceConfigCreateDescriptor<TDocument> Regression(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.RegressionInferenceOptionsDescriptor<TDocument>> configure) => Set(configure, "regression");
	public InferenceConfigCreateDescriptor<TDocument> TextClassification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextClassificationInferenceOptions textClassificationInferenceOptions) => Set(textClassificationInferenceOptions, "text_classification");
	public InferenceConfigCreateDescriptor<TDocument> TextClassification(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextClassificationInferenceOptionsDescriptor> configure) => Set(configure, "text_classification");
	public InferenceConfigCreateDescriptor<TDocument> TextEmbedding(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextEmbeddingInferenceOptions textEmbeddingInferenceOptions) => Set(textEmbeddingInferenceOptions, "text_embedding");
	public InferenceConfigCreateDescriptor<TDocument> TextEmbedding(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextEmbeddingInferenceOptionsDescriptor> configure) => Set(configure, "text_embedding");
	public InferenceConfigCreateDescriptor<TDocument> TextExpansion(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextExpansionInferenceOptions textExpansionInferenceOptions) => Set(textExpansionInferenceOptions, "text_expansion");
	public InferenceConfigCreateDescriptor<TDocument> TextExpansion(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextExpansionInferenceOptionsDescriptor> configure) => Set(configure, "text_expansion");
	public InferenceConfigCreateDescriptor<TDocument> ZeroShotClassification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ZeroShotClassificationInferenceOptions zeroShotClassificationInferenceOptions) => Set(zeroShotClassificationInferenceOptions, "zero_shot_classification");
	public InferenceConfigCreateDescriptor<TDocument> ZeroShotClassification(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ZeroShotClassificationInferenceOptionsDescriptor> configure) => Set(configure, "zero_shot_classification");

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

public sealed partial class InferenceConfigCreateDescriptor : SerializableDescriptor<InferenceConfigCreateDescriptor>
{
	internal InferenceConfigCreateDescriptor(Action<InferenceConfigCreateDescriptor> configure) => configure.Invoke(this);

	public InferenceConfigCreateDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private InferenceConfigCreateDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private InferenceConfigCreateDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public InferenceConfigCreateDescriptor Classification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ClassificationInferenceOptions classificationInferenceOptions) => Set(classificationInferenceOptions, "classification");
	public InferenceConfigCreateDescriptor Classification(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ClassificationInferenceOptionsDescriptor> configure) => Set(configure, "classification");
	public InferenceConfigCreateDescriptor FillMask(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.FillMaskInferenceOptions fillMaskInferenceOptions) => Set(fillMaskInferenceOptions, "fill_mask");
	public InferenceConfigCreateDescriptor FillMask(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.FillMaskInferenceOptionsDescriptor> configure) => Set(configure, "fill_mask");
	public InferenceConfigCreateDescriptor Ner(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.NerInferenceOptions nerInferenceOptions) => Set(nerInferenceOptions, "ner");
	public InferenceConfigCreateDescriptor Ner(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.NerInferenceOptionsDescriptor> configure) => Set(configure, "ner");
	public InferenceConfigCreateDescriptor PassThrough(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PassThroughInferenceOptions passThroughInferenceOptions) => Set(passThroughInferenceOptions, "pass_through");
	public InferenceConfigCreateDescriptor PassThrough(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.PassThroughInferenceOptionsDescriptor> configure) => Set(configure, "pass_through");
	public InferenceConfigCreateDescriptor QuestionAnswering(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.QuestionAnsweringInferenceOptions questionAnsweringInferenceOptions) => Set(questionAnsweringInferenceOptions, "question_answering");
	public InferenceConfigCreateDescriptor QuestionAnswering(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.QuestionAnsweringInferenceOptionsDescriptor> configure) => Set(configure, "question_answering");
	public InferenceConfigCreateDescriptor Regression(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.RegressionInferenceOptions regressionInferenceOptions) => Set(regressionInferenceOptions, "regression");
	public InferenceConfigCreateDescriptor Regression<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.RegressionInferenceOptionsDescriptor> configure) => Set(configure, "regression");
	public InferenceConfigCreateDescriptor TextClassification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextClassificationInferenceOptions textClassificationInferenceOptions) => Set(textClassificationInferenceOptions, "text_classification");
	public InferenceConfigCreateDescriptor TextClassification(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextClassificationInferenceOptionsDescriptor> configure) => Set(configure, "text_classification");
	public InferenceConfigCreateDescriptor TextEmbedding(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextEmbeddingInferenceOptions textEmbeddingInferenceOptions) => Set(textEmbeddingInferenceOptions, "text_embedding");
	public InferenceConfigCreateDescriptor TextEmbedding(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextEmbeddingInferenceOptionsDescriptor> configure) => Set(configure, "text_embedding");
	public InferenceConfigCreateDescriptor TextExpansion(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextExpansionInferenceOptions textExpansionInferenceOptions) => Set(textExpansionInferenceOptions, "text_expansion");
	public InferenceConfigCreateDescriptor TextExpansion(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TextExpansionInferenceOptionsDescriptor> configure) => Set(configure, "text_expansion");
	public InferenceConfigCreateDescriptor ZeroShotClassification(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ZeroShotClassificationInferenceOptions zeroShotClassificationInferenceOptions) => Set(zeroShotClassificationInferenceOptions, "zero_shot_classification");
	public InferenceConfigCreateDescriptor ZeroShotClassification(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.ZeroShotClassificationInferenceOptionsDescriptor> configure) => Set(configure, "zero_shot_classification");

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