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

namespace Elastic.Clients.Elasticsearch.Mapping;

public sealed partial class CompletionProperty : IProperty
{
	[JsonInclude, JsonPropertyName("analyzer")]
	public string? Analyzer { get; set; }
	[JsonInclude, JsonPropertyName("contexts")]
	public ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>? Contexts { get; set; }
	[JsonInclude, JsonPropertyName("copy_to")]
	[JsonConverter(typeof(SingleOrManyFieldsConverter))]
	public Elastic.Clients.Elasticsearch.Fields? CopyTo { get; set; }
	[JsonInclude, JsonPropertyName("doc_values")]
	public bool? DocValues { get; set; }
	[JsonInclude, JsonPropertyName("dynamic")]
	public Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? Dynamic { get; set; }
	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Fields { get; set; }
	[JsonInclude, JsonPropertyName("ignore_above")]
	public int? IgnoreAbove { get; set; }
	[JsonInclude, JsonPropertyName("max_input_length")]
	public int? MaxInputLength { get; set; }

	/// <summary>
	/// <para>
	/// Metadata about the field.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, string>? Meta { get; set; }
	[JsonInclude, JsonPropertyName("preserve_position_increments")]
	public bool? PreservePositionIncrements { get; set; }
	[JsonInclude, JsonPropertyName("preserve_separators")]
	public bool? PreserveSeparators { get; set; }
	[JsonInclude, JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Properties { get; set; }
	[JsonInclude, JsonPropertyName("search_analyzer")]
	public string? SearchAnalyzer { get; set; }
	[JsonInclude, JsonPropertyName("store")]
	public bool? Store { get; set; }
	[JsonInclude, JsonPropertyName("synthetic_source_keep")]
	public Elastic.Clients.Elasticsearch.Mapping.SyntheticSourceKeepEnum? SyntheticSourceKeep { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "completion";
}

public sealed partial class CompletionPropertyDescriptor<TDocument> : SerializableDescriptor<CompletionPropertyDescriptor<TDocument>>, IBuildableDescriptor<CompletionProperty>
{
	internal CompletionPropertyDescriptor(Action<CompletionPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);

	public CompletionPropertyDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>? ContextsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument> ContextsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument>> ContextsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument>>[] ContextsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private int? MaxInputLengthValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private bool? PreservePositionIncrementsValue { get; set; }
	private bool? PreserveSeparatorsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }
	private string? SearchAnalyzerValue { get; set; }
	private bool? StoreValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.SyntheticSourceKeepEnum? SyntheticSourceKeepValue { get; set; }

	public CompletionPropertyDescriptor<TDocument> Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Contexts(ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>? contexts)
	{
		ContextsDescriptor = null;
		ContextsDescriptorAction = null;
		ContextsDescriptorActions = null;
		ContextsValue = contexts;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Contexts(Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument> descriptor)
	{
		ContextsValue = null;
		ContextsDescriptorAction = null;
		ContextsDescriptorActions = null;
		ContextsDescriptor = descriptor;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Contexts(Action<Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument>> configure)
	{
		ContextsValue = null;
		ContextsDescriptor = null;
		ContextsDescriptorActions = null;
		ContextsDescriptorAction = configure;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Contexts(params Action<Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument>>[] configure)
	{
		ContextsValue = null;
		ContextsDescriptor = null;
		ContextsDescriptorAction = null;
		ContextsDescriptorActions = configure;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Fields(Action<Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> MaxInputLength(int? maxInputLength)
	{
		MaxInputLengthValue = maxInputLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Metadata about the field.
	/// </para>
	/// </summary>
	public CompletionPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> PreservePositionIncrements(bool? preservePositionIncrements = true)
	{
		PreservePositionIncrementsValue = preservePositionIncrements;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> PreserveSeparators(bool? preserveSeparators = true)
	{
		PreserveSeparatorsValue = preserveSeparators;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Properties(Action<Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> SearchAnalyzer(string? searchAnalyzer)
	{
		SearchAnalyzerValue = searchAnalyzer;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	public CompletionPropertyDescriptor<TDocument> SyntheticSourceKeep(Elastic.Clients.Elasticsearch.Mapping.SyntheticSourceKeepEnum? syntheticSourceKeep)
	{
		SyntheticSourceKeepValue = syntheticSourceKeep;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (ContextsDescriptor is not null)
		{
			writer.WritePropertyName("contexts");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ContextsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ContextsDescriptorAction is not null)
		{
			writer.WritePropertyName("contexts");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument>(ContextsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ContextsDescriptorActions is not null)
		{
			writer.WritePropertyName("contexts");
			writer.WriteStartArray();
			foreach (var action in ContextsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ContextsValue is not null)
		{
			writer.WritePropertyName("contexts");
			JsonSerializer.Serialize(writer, ContextsValue, options);
		}

		if (CopyToValue is not null)
		{
			writer.WritePropertyName("copy_to");
			JsonSerializer.Serialize(writer, CopyToValue, options);
		}

		if (DocValuesValue.HasValue)
		{
			writer.WritePropertyName("doc_values");
			writer.WriteBooleanValue(DocValuesValue.Value);
		}

		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (MaxInputLengthValue.HasValue)
		{
			writer.WritePropertyName("max_input_length");
			writer.WriteNumberValue(MaxInputLengthValue.Value);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (PreservePositionIncrementsValue.HasValue)
		{
			writer.WritePropertyName("preserve_position_increments");
			writer.WriteBooleanValue(PreservePositionIncrementsValue.Value);
		}

		if (PreserveSeparatorsValue.HasValue)
		{
			writer.WritePropertyName("preserve_separators");
			writer.WriteBooleanValue(PreserveSeparatorsValue.Value);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (!string.IsNullOrEmpty(SearchAnalyzerValue))
		{
			writer.WritePropertyName("search_analyzer");
			writer.WriteStringValue(SearchAnalyzerValue);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		if (SyntheticSourceKeepValue is not null)
		{
			writer.WritePropertyName("synthetic_source_keep");
			JsonSerializer.Serialize(writer, SyntheticSourceKeepValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("completion");
		writer.WriteEndObject();
	}

	private ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>? BuildContexts()
	{
		if (ContextsValue is not null)
		{
			return ContextsValue;
		}

		if ((object)ContextsDescriptor is IBuildableDescriptor<ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>?> buildable)
		{
			return buildable.Build();
		}

		if (ContextsDescriptorAction is not null)
		{
			var descriptor = new Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor<TDocument>(ContextsDescriptorAction);
			if ((object)descriptor is IBuildableDescriptor<ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>?> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	CompletionProperty IBuildableDescriptor<CompletionProperty>.Build() => new()
	{
		Analyzer = AnalyzerValue,
		Contexts = BuildContexts(),
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		MaxInputLength = MaxInputLengthValue,
		Meta = MetaValue,
		PreservePositionIncrements = PreservePositionIncrementsValue,
		PreserveSeparators = PreserveSeparatorsValue,
		Properties = PropertiesValue,
		SearchAnalyzer = SearchAnalyzerValue,
		Store = StoreValue,
		SyntheticSourceKeep = SyntheticSourceKeepValue
	};
}

public sealed partial class CompletionPropertyDescriptor : SerializableDescriptor<CompletionPropertyDescriptor>, IBuildableDescriptor<CompletionProperty>
{
	internal CompletionPropertyDescriptor(Action<CompletionPropertyDescriptor> configure) => configure.Invoke(this);

	public CompletionPropertyDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>? ContextsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor ContextsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor> ContextsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor>[] ContextsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private int? MaxInputLengthValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private bool? PreservePositionIncrementsValue { get; set; }
	private bool? PreserveSeparatorsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }
	private string? SearchAnalyzerValue { get; set; }
	private bool? StoreValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.SyntheticSourceKeepEnum? SyntheticSourceKeepValue { get; set; }

	public CompletionPropertyDescriptor Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	public CompletionPropertyDescriptor Contexts(ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>? contexts)
	{
		ContextsDescriptor = null;
		ContextsDescriptorAction = null;
		ContextsDescriptorActions = null;
		ContextsValue = contexts;
		return Self;
	}

	public CompletionPropertyDescriptor Contexts(Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor descriptor)
	{
		ContextsValue = null;
		ContextsDescriptorAction = null;
		ContextsDescriptorActions = null;
		ContextsDescriptor = descriptor;
		return Self;
	}

	public CompletionPropertyDescriptor Contexts(Action<Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor> configure)
	{
		ContextsValue = null;
		ContextsDescriptor = null;
		ContextsDescriptorActions = null;
		ContextsDescriptorAction = configure;
		return Self;
	}

	public CompletionPropertyDescriptor Contexts(params Action<Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor>[] configure)
	{
		ContextsValue = null;
		ContextsDescriptor = null;
		ContextsDescriptorAction = null;
		ContextsDescriptorActions = configure;
		return Self;
	}

	public CompletionPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public CompletionPropertyDescriptor DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public CompletionPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public CompletionPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public CompletionPropertyDescriptor Fields<TDocument>(Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public CompletionPropertyDescriptor Fields<TDocument>(Action<Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public CompletionPropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public CompletionPropertyDescriptor MaxInputLength(int? maxInputLength)
	{
		MaxInputLengthValue = maxInputLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Metadata about the field.
	/// </para>
	/// </summary>
	public CompletionPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public CompletionPropertyDescriptor PreservePositionIncrements(bool? preservePositionIncrements = true)
	{
		PreservePositionIncrementsValue = preservePositionIncrements;
		return Self;
	}

	public CompletionPropertyDescriptor PreserveSeparators(bool? preserveSeparators = true)
	{
		PreserveSeparatorsValue = preserveSeparators;
		return Self;
	}

	public CompletionPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public CompletionPropertyDescriptor Properties<TDocument>(Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public CompletionPropertyDescriptor Properties<TDocument>(Action<Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public CompletionPropertyDescriptor SearchAnalyzer(string? searchAnalyzer)
	{
		SearchAnalyzerValue = searchAnalyzer;
		return Self;
	}

	public CompletionPropertyDescriptor Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	public CompletionPropertyDescriptor SyntheticSourceKeep(Elastic.Clients.Elasticsearch.Mapping.SyntheticSourceKeepEnum? syntheticSourceKeep)
	{
		SyntheticSourceKeepValue = syntheticSourceKeep;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (ContextsDescriptor is not null)
		{
			writer.WritePropertyName("contexts");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ContextsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ContextsDescriptorAction is not null)
		{
			writer.WritePropertyName("contexts");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor(ContextsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ContextsDescriptorActions is not null)
		{
			writer.WritePropertyName("contexts");
			writer.WriteStartArray();
			foreach (var action in ContextsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ContextsValue is not null)
		{
			writer.WritePropertyName("contexts");
			JsonSerializer.Serialize(writer, ContextsValue, options);
		}

		if (CopyToValue is not null)
		{
			writer.WritePropertyName("copy_to");
			JsonSerializer.Serialize(writer, CopyToValue, options);
		}

		if (DocValuesValue.HasValue)
		{
			writer.WritePropertyName("doc_values");
			writer.WriteBooleanValue(DocValuesValue.Value);
		}

		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (MaxInputLengthValue.HasValue)
		{
			writer.WritePropertyName("max_input_length");
			writer.WriteNumberValue(MaxInputLengthValue.Value);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (PreservePositionIncrementsValue.HasValue)
		{
			writer.WritePropertyName("preserve_position_increments");
			writer.WriteBooleanValue(PreservePositionIncrementsValue.Value);
		}

		if (PreserveSeparatorsValue.HasValue)
		{
			writer.WritePropertyName("preserve_separators");
			writer.WriteBooleanValue(PreserveSeparatorsValue.Value);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (!string.IsNullOrEmpty(SearchAnalyzerValue))
		{
			writer.WritePropertyName("search_analyzer");
			writer.WriteStringValue(SearchAnalyzerValue);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		if (SyntheticSourceKeepValue is not null)
		{
			writer.WritePropertyName("synthetic_source_keep");
			JsonSerializer.Serialize(writer, SyntheticSourceKeepValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("completion");
		writer.WriteEndObject();
	}

	private ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>? BuildContexts()
	{
		if (ContextsValue is not null)
		{
			return ContextsValue;
		}

		if ((object)ContextsDescriptor is IBuildableDescriptor<ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>?> buildable)
		{
			return buildable.Build();
		}

		if (ContextsDescriptorAction is not null)
		{
			var descriptor = new Elastic.Clients.Elasticsearch.Mapping.SuggestContextDescriptor(ContextsDescriptorAction);
			if ((object)descriptor is IBuildableDescriptor<ICollection<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>?> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	CompletionProperty IBuildableDescriptor<CompletionProperty>.Build() => new()
	{
		Analyzer = AnalyzerValue,
		Contexts = BuildContexts(),
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		MaxInputLength = MaxInputLengthValue,
		Meta = MetaValue,
		PreservePositionIncrements = PreservePositionIncrementsValue,
		PreserveSeparators = PreserveSeparatorsValue,
		Properties = PropertiesValue,
		SearchAnalyzer = SearchAnalyzerValue,
		Store = StoreValue,
		SyntheticSourceKeep = SyntheticSourceKeepValue
	};
}