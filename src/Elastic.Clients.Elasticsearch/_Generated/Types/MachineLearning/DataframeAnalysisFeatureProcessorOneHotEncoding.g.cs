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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class DataframeAnalysisFeatureProcessorOneHotEncoding
{
	/// <summary>
	/// <para>
	/// The name of the field to encode.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>
	/// The one hot map mapping the field value with the column name.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("hot_map")]
	public string HotMap { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessor(DataframeAnalysisFeatureProcessorOneHotEncoding dataframeAnalysisFeatureProcessorOneHotEncoding) => Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessor.OneHotEncoding(dataframeAnalysisFeatureProcessorOneHotEncoding);
}

public sealed partial class DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> : SerializableDescriptor<DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument>>
{
	internal DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor(Action<DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string HotMapValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the field to encode.
	/// </para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the field to encode.
	/// </para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the field to encode.
	/// </para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The one hot map mapping the field value with the column name.
	/// </para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> HotMap(string hotMap)
	{
		HotMapValue = hotMap;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("hot_map");
		writer.WriteStringValue(HotMapValue);
		writer.WriteEndObject();
	}
}

public sealed partial class DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor : SerializableDescriptor<DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor>
{
	internal DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor(Action<DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor> configure) => configure.Invoke(this);

	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string HotMapValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the field to encode.
	/// </para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the field to encode.
	/// </para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the field to encode.
	/// </para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The one hot map mapping the field value with the column name.
	/// </para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor HotMap(string hotMap)
	{
		HotMapValue = hotMap;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("hot_map");
		writer.WriteStringValue(HotMapValue);
		writer.WriteEndObject();
	}
}