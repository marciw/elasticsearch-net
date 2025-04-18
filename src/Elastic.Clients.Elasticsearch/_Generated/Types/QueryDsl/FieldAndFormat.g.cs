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

/// <summary>
/// <para>
/// A reference to a field with formatting instructions on how to return the value
/// </para>
/// </summary>
public sealed partial class FieldAndFormat
{
	/// <summary>
	/// <para>
	/// A wildcard pattern. The request returns values for field names matching this pattern.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>
	/// The format in which the values are returned.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }
	[JsonInclude, JsonPropertyName("include_unmapped")]
	public bool? IncludeUnmapped { get; set; }
}

/// <summary>
/// <para>
/// A reference to a field with formatting instructions on how to return the value
/// </para>
/// </summary>
public sealed partial class FieldAndFormatDescriptor<TDocument> : SerializableDescriptor<FieldAndFormatDescriptor<TDocument>>
{
	internal FieldAndFormatDescriptor(Action<FieldAndFormatDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FieldAndFormatDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private bool? IncludeUnmappedValue { get; set; }

	/// <summary>
	/// <para>
	/// A wildcard pattern. The request returns values for field names matching this pattern.
	/// </para>
	/// </summary>
	public FieldAndFormatDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A wildcard pattern. The request returns values for field names matching this pattern.
	/// </para>
	/// </summary>
	public FieldAndFormatDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A wildcard pattern. The request returns values for field names matching this pattern.
	/// </para>
	/// </summary>
	public FieldAndFormatDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The format in which the values are returned.
	/// </para>
	/// </summary>
	public FieldAndFormatDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public FieldAndFormatDescriptor<TDocument> IncludeUnmapped(bool? includeUnmapped = true)
	{
		IncludeUnmappedValue = includeUnmapped;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (IncludeUnmappedValue.HasValue)
		{
			writer.WritePropertyName("include_unmapped");
			writer.WriteBooleanValue(IncludeUnmappedValue.Value);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// A reference to a field with formatting instructions on how to return the value
/// </para>
/// </summary>
public sealed partial class FieldAndFormatDescriptor : SerializableDescriptor<FieldAndFormatDescriptor>
{
	internal FieldAndFormatDescriptor(Action<FieldAndFormatDescriptor> configure) => configure.Invoke(this);

	public FieldAndFormatDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private bool? IncludeUnmappedValue { get; set; }

	/// <summary>
	/// <para>
	/// A wildcard pattern. The request returns values for field names matching this pattern.
	/// </para>
	/// </summary>
	public FieldAndFormatDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A wildcard pattern. The request returns values for field names matching this pattern.
	/// </para>
	/// </summary>
	public FieldAndFormatDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A wildcard pattern. The request returns values for field names matching this pattern.
	/// </para>
	/// </summary>
	public FieldAndFormatDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The format in which the values are returned.
	/// </para>
	/// </summary>
	public FieldAndFormatDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public FieldAndFormatDescriptor IncludeUnmapped(bool? includeUnmapped = true)
	{
		IncludeUnmappedValue = includeUnmapped;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (IncludeUnmappedValue.HasValue)
		{
			writer.WritePropertyName("include_unmapped");
			writer.WriteBooleanValue(IncludeUnmappedValue.Value);
		}

		writer.WriteEndObject();
	}
}