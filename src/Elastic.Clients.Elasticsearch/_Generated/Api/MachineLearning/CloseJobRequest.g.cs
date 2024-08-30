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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class CloseJobRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Close anomaly detection jobs.
/// A job can be opened and closed multiple times throughout its lifecycle. A closed job cannot receive data or perform analysis operations, but you can still explore and navigate results.
/// When you close a job, it runs housekeeping tasks such as pruning the model history, flushing buffers, calculating final results and persisting the model snapshots. Depending upon the size of the job, it could take several minutes to close and the equivalent time to re-open. After it is closed, the job has a minimal overhead on the cluster except for maintaining its meta data. Therefore it is a best practice to close jobs that are no longer required to process data.
/// If you close an anomaly detection job whose datafeed is running, the request first tries to stop the datafeed. This behavior is equivalent to calling stop datafeed API with the same timeout and force parameters as the close job request.
/// When a datafeed that has a specified end date stops, it automatically closes its associated job.
/// </para>
/// </summary>
public sealed partial class CloseJobRequest : PlainRequest<CloseJobRequestParameters>
{
	public CloseJobRequest(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningCloseJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.close_job";

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>allow_no_match</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allow_no_match")]
	public bool? AllowNoMatch { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the descriptiion for the <c>force</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("force")]
	public bool? Force { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>timeout</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timeout")]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get; set; }
}

/// <summary>
/// <para>
/// Close anomaly detection jobs.
/// A job can be opened and closed multiple times throughout its lifecycle. A closed job cannot receive data or perform analysis operations, but you can still explore and navigate results.
/// When you close a job, it runs housekeeping tasks such as pruning the model history, flushing buffers, calculating final results and persisting the model snapshots. Depending upon the size of the job, it could take several minutes to close and the equivalent time to re-open. After it is closed, the job has a minimal overhead on the cluster except for maintaining its meta data. Therefore it is a best practice to close jobs that are no longer required to process data.
/// If you close an anomaly detection job whose datafeed is running, the request first tries to stop the datafeed. This behavior is equivalent to calling stop datafeed API with the same timeout and force parameters as the close job request.
/// When a datafeed that has a specified end date stops, it automatically closes its associated job.
/// </para>
/// </summary>
public sealed partial class CloseJobRequestDescriptor : RequestDescriptor<CloseJobRequestDescriptor, CloseJobRequestParameters>
{
	internal CloseJobRequestDescriptor(Action<CloseJobRequestDescriptor> configure) => configure.Invoke(this);

	public CloseJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningCloseJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.close_job";

	public CloseJobRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id jobId)
	{
		RouteValues.Required("job_id", jobId);
		return Self;
	}

	private bool? AllowNoMatchValue { get; set; }
	private bool? ForceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? TimeoutValue { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>allow_no_match</c> query parameter.
	/// </para>
	/// </summary>
	public CloseJobRequestDescriptor AllowNoMatch(bool? allowNoMatch = true)
	{
		AllowNoMatchValue = allowNoMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Refer to the descriptiion for the <c>force</c> query parameter.
	/// </para>
	/// </summary>
	public CloseJobRequestDescriptor Force(bool? force = true)
	{
		ForceValue = force;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>timeout</c> query parameter.
	/// </para>
	/// </summary>
	public CloseJobRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout)
	{
		TimeoutValue = timeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowNoMatchValue.HasValue)
		{
			writer.WritePropertyName("allow_no_match");
			writer.WriteBooleanValue(AllowNoMatchValue.Value);
		}

		if (ForceValue.HasValue)
		{
			writer.WritePropertyName("force");
			writer.WriteBooleanValue(ForceValue.Value);
		}

		if (TimeoutValue is not null)
		{
			writer.WritePropertyName("timeout");
			JsonSerializer.Serialize(writer, TimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}