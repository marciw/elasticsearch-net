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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class DeleteExpiredDataRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Delete expired ML data.
/// Deletes all job results, model snapshots and forecast data that have exceeded
/// their retention days period. Machine learning state documents that are not
/// associated with any job are also deleted.
/// You can limit the request to a single or set of anomaly detection jobs by
/// using a job identifier, a group name, a comma-separated list of jobs, or a
/// wildcard expression. You can delete expired data for all anomaly detection
/// jobs by using _all, by specifying * as the &lt;job_id>, or by omitting the
/// &lt;job_id>.
/// </para>
/// </summary>
public sealed partial class DeleteExpiredDataRequest : PlainRequest<DeleteExpiredDataRequestParameters>
{
	public DeleteExpiredDataRequest()
	{
	}

	public DeleteExpiredDataRequest(Elastic.Clients.Elasticsearch.Serverless.Id? jobId) : base(r => r.Optional("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteExpiredData;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.delete_expired_data";

	/// <summary>
	/// <para>
	/// The desired requests per second for the deletion processes. The default
	/// behavior is no throttling.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("requests_per_second")]
	public float? RequestsPerSecond { get; set; }

	/// <summary>
	/// <para>
	/// How long can the underlying delete processes run until they are canceled.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timeout")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get; set; }
}

/// <summary>
/// <para>
/// Delete expired ML data.
/// Deletes all job results, model snapshots and forecast data that have exceeded
/// their retention days period. Machine learning state documents that are not
/// associated with any job are also deleted.
/// You can limit the request to a single or set of anomaly detection jobs by
/// using a job identifier, a group name, a comma-separated list of jobs, or a
/// wildcard expression. You can delete expired data for all anomaly detection
/// jobs by using _all, by specifying * as the &lt;job_id>, or by omitting the
/// &lt;job_id>.
/// </para>
/// </summary>
public sealed partial class DeleteExpiredDataRequestDescriptor : RequestDescriptor<DeleteExpiredDataRequestDescriptor, DeleteExpiredDataRequestParameters>
{
	internal DeleteExpiredDataRequestDescriptor(Action<DeleteExpiredDataRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteExpiredDataRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id? jobId) : base(r => r.Optional("job_id", jobId))
	{
	}

	public DeleteExpiredDataRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteExpiredData;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.delete_expired_data";

	public DeleteExpiredDataRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Serverless.Id? jobId)
	{
		RouteValues.Optional("job_id", jobId);
		return Self;
	}

	private float? RequestsPerSecondValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? TimeoutValue { get; set; }

	/// <summary>
	/// <para>
	/// The desired requests per second for the deletion processes. The default
	/// behavior is no throttling.
	/// </para>
	/// </summary>
	public DeleteExpiredDataRequestDescriptor RequestsPerSecond(float? requestsPerSecond)
	{
		RequestsPerSecondValue = requestsPerSecond;
		return Self;
	}

	/// <summary>
	/// <para>
	/// How long can the underlying delete processes run until they are canceled.
	/// </para>
	/// </summary>
	public DeleteExpiredDataRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout)
	{
		TimeoutValue = timeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (RequestsPerSecondValue.HasValue)
		{
			writer.WritePropertyName("requests_per_second");
			writer.WriteNumberValue(RequestsPerSecondValue.Value);
		}

		if (TimeoutValue is not null)
		{
			writer.WritePropertyName("timeout");
			JsonSerializer.Serialize(writer, TimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}