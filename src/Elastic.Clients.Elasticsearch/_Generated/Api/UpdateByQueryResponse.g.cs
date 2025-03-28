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
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

public sealed partial class UpdateByQueryResponse : ElasticsearchResponse
{
	/// <summary>
	/// <para>
	/// The number of scroll responses pulled back by the update by query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("batches")]
	public long? Batches { get; init; }

	/// <summary>
	/// <para>
	/// The number of documents that were successfully deleted.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("deleted")]
	public long? Deleted { get; init; }

	/// <summary>
	/// <para>
	/// Array of failures if there were any unrecoverable errors during the process.
	/// If this is non-empty then the request ended because of those failures.
	/// Update by query is implemented using batches.
	/// Any failure causes the entire process to end, but all failures in the current batch are collected into the array.
	/// You can use the <c>conflicts</c> option to prevent reindex from ending when version conflicts occur.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("failures")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.BulkIndexByScrollFailure>? Failures { get; init; }

	/// <summary>
	/// <para>
	/// The number of documents that were ignored because the script used for the update by query returned a noop value for <c>ctx.op</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("noops")]
	public long? Noops { get; init; }

	/// <summary>
	/// <para>
	/// The number of requests per second effectively run during the update by query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("requests_per_second")]
	public float? RequestsPerSecond { get; init; }

	/// <summary>
	/// <para>
	/// The number of retries attempted by update by query.
	/// <c>bulk</c> is the number of bulk actions retried.
	/// <c>search</c> is the number of search actions retried.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("retries")]
	public Elastic.Clients.Elasticsearch.Retries? Retries { get; init; }
	[JsonInclude, JsonPropertyName("task")]
	public Elastic.Clients.Elasticsearch.TaskId? Task { get; init; }
	[JsonInclude, JsonPropertyName("throttled")]
	public Elastic.Clients.Elasticsearch.Duration? Throttled { get; init; }

	/// <summary>
	/// <para>
	/// The number of milliseconds the request slept to conform to <c>requests_per_second</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("throttled_millis")]
	public long? ThrottledMillis { get; init; }
	[JsonInclude, JsonPropertyName("throttled_until")]
	public Elastic.Clients.Elasticsearch.Duration? ThrottledUntil { get; init; }

	/// <summary>
	/// <para>
	/// This field should always be equal to zero in an _update_by_query response.
	/// It only has meaning when using the task API, where it indicates the next time (in milliseconds since epoch) a throttled request will be run again in order to conform to <c>requests_per_second</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("throttled_until_millis")]
	public long? ThrottledUntilMillis { get; init; }

	/// <summary>
	/// <para>
	/// If true, some requests timed out during the update by query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timed_out")]
	public bool? TimedOut { get; init; }

	/// <summary>
	/// <para>
	/// The number of milliseconds from start to end of the whole operation.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("took")]
	public long? Took { get; init; }

	/// <summary>
	/// <para>
	/// The number of documents that were successfully processed.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("total")]
	public long? Total { get; init; }

	/// <summary>
	/// <para>
	/// The number of documents that were successfully updated.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("updated")]
	public long? Updated { get; init; }

	/// <summary>
	/// <para>
	/// The number of version conflicts that the update by query hit.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version_conflicts")]
	public long? VersionConflicts { get; init; }
}