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
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Sql;

public sealed partial class GetAsyncStatusResponse : ElasticsearchResponse
{
	/// <summary>
	/// <para>
	/// HTTP status code for the search. The API only returns this property for completed searches.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("completion_status")]
	public int? CompletionStatus { get; init; }

	/// <summary>
	/// <para>
	/// Timestamp, in milliseconds since the Unix epoch, when Elasticsearch will delete
	/// the search and its results, even if the search is still running.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("expiration_time_in_millis")]
	public long ExpirationTimeInMillis { get; init; }

	/// <summary>
	/// <para>
	/// Identifier for the search.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("id")]
	public string Id { get; init; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response does not contain complete search results. If <c>is_partial</c>
	/// is <c>true</c> and <c>is_running</c> is <c>true</c>, the search is still running. If <c>is_partial</c>
	/// is <c>true</c> but <c>is_running</c> is <c>false</c>, the results are partial due to a failure or
	/// timeout.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("is_partial")]
	public bool IsPartial { get; init; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the search is still running. If <c>false</c>, the search has finished.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("is_running")]
	public bool IsRunning { get; init; }

	/// <summary>
	/// <para>
	/// Timestamp, in milliseconds since the Unix epoch, when the search started.
	/// The API only returns this property for running searches.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("start_time_in_millis")]
	public long StartTimeInMillis { get; init; }
}