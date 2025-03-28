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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Sql;

public sealed partial class TranslateRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Translate SQL into Elasticsearch queries.
/// Translate an SQL search into a search API request containing Query DSL.
/// It accepts the same request body parameters as the SQL search API, excluding <c>cursor</c>.
/// </para>
/// </summary>
public sealed partial class TranslateRequest : PlainRequest<TranslateRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlTranslate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "sql.translate";

	/// <summary>
	/// <para>
	/// The maximum number of rows (or entries) to return in one response.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fetch_size")]
	public int? FetchSize { get; set; }

	/// <summary>
	/// <para>
	/// The Elasticsearch query DSL for additional filtering.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Filter { get; set; }

	/// <summary>
	/// <para>
	/// The SQL query to run.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public string Query { get; set; }

	/// <summary>
	/// <para>
	/// The ISO-8601 time zone ID for the search.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_zone")]
	public string? TimeZone { get; set; }
}

/// <summary>
/// <para>
/// Translate SQL into Elasticsearch queries.
/// Translate an SQL search into a search API request containing Query DSL.
/// It accepts the same request body parameters as the SQL search API, excluding <c>cursor</c>.
/// </para>
/// </summary>
public sealed partial class TranslateRequestDescriptor<TDocument> : RequestDescriptor<TranslateRequestDescriptor<TDocument>, TranslateRequestParameters>
{
	internal TranslateRequestDescriptor(Action<TranslateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TranslateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlTranslate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "sql.translate";

	private int? FetchSizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private string QueryValue { get; set; }
	private string? TimeZoneValue { get; set; }

	/// <summary>
	/// <para>
	/// The maximum number of rows (or entries) to return in one response.
	/// </para>
	/// </summary>
	public TranslateRequestDescriptor<TDocument> FetchSize(int? fetchSize)
	{
		FetchSizeValue = fetchSize;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The Elasticsearch query DSL for additional filtering.
	/// </para>
	/// </summary>
	public TranslateRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public TranslateRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public TranslateRequestDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The SQL query to run.
	/// </para>
	/// </summary>
	public TranslateRequestDescriptor<TDocument> Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The ISO-8601 time zone ID for the search.
	/// </para>
	/// </summary>
	public TranslateRequestDescriptor<TDocument> TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FetchSizeValue.HasValue)
		{
			writer.WritePropertyName("fetch_size");
			writer.WriteNumberValue(FetchSizeValue.Value);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Translate SQL into Elasticsearch queries.
/// Translate an SQL search into a search API request containing Query DSL.
/// It accepts the same request body parameters as the SQL search API, excluding <c>cursor</c>.
/// </para>
/// </summary>
public sealed partial class TranslateRequestDescriptor : RequestDescriptor<TranslateRequestDescriptor, TranslateRequestParameters>
{
	internal TranslateRequestDescriptor(Action<TranslateRequestDescriptor> configure) => configure.Invoke(this);

	public TranslateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlTranslate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "sql.translate";

	private int? FetchSizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private string QueryValue { get; set; }
	private string? TimeZoneValue { get; set; }

	/// <summary>
	/// <para>
	/// The maximum number of rows (or entries) to return in one response.
	/// </para>
	/// </summary>
	public TranslateRequestDescriptor FetchSize(int? fetchSize)
	{
		FetchSizeValue = fetchSize;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The Elasticsearch query DSL for additional filtering.
	/// </para>
	/// </summary>
	public TranslateRequestDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public TranslateRequestDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public TranslateRequestDescriptor Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The SQL query to run.
	/// </para>
	/// </summary>
	public TranslateRequestDescriptor Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The ISO-8601 time zone ID for the search.
	/// </para>
	/// </summary>
	public TranslateRequestDescriptor TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FetchSizeValue.HasValue)
		{
			writer.WritePropertyName("fetch_size");
			writer.WriteNumberValue(FetchSizeValue.Value);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		writer.WriteEndObject();
	}
}