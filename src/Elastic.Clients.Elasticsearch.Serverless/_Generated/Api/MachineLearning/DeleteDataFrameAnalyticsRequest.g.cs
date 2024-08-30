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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class DeleteDataFrameAnalyticsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>true</c>, it deletes a job that is not stopped; this method is quicker than stopping and deleting the job.
	/// </para>
	/// </summary>
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

	/// <summary>
	/// <para>
	/// The time to wait for the job to be deleted.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Delete a data frame analytics job.
/// </para>
/// </summary>
public sealed partial class DeleteDataFrameAnalyticsRequest : PlainRequest<DeleteDataFrameAnalyticsRequestParameters>
{
	public DeleteDataFrameAnalyticsRequest(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_data_frame_analytics";

	/// <summary>
	/// <para>
	/// If <c>true</c>, it deletes a job that is not stopped; this method is quicker than stopping and deleting the job.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

	/// <summary>
	/// <para>
	/// The time to wait for the job to be deleted.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Delete a data frame analytics job.
/// </para>
/// </summary>
public sealed partial class DeleteDataFrameAnalyticsRequestDescriptor<TDocument> : RequestDescriptor<DeleteDataFrameAnalyticsRequestDescriptor<TDocument>, DeleteDataFrameAnalyticsRequestParameters>
{
	internal DeleteDataFrameAnalyticsRequestDescriptor(Action<DeleteDataFrameAnalyticsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DeleteDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_data_frame_analytics";

	public DeleteDataFrameAnalyticsRequestDescriptor<TDocument> Force(bool? force = true) => Qs("force", force);
	public DeleteDataFrameAnalyticsRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public DeleteDataFrameAnalyticsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Delete a data frame analytics job.
/// </para>
/// </summary>
public sealed partial class DeleteDataFrameAnalyticsRequestDescriptor : RequestDescriptor<DeleteDataFrameAnalyticsRequestDescriptor, DeleteDataFrameAnalyticsRequestParameters>
{
	internal DeleteDataFrameAnalyticsRequestDescriptor(Action<DeleteDataFrameAnalyticsRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_data_frame_analytics";

	public DeleteDataFrameAnalyticsRequestDescriptor Force(bool? force = true) => Qs("force", force);
	public DeleteDataFrameAnalyticsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public DeleteDataFrameAnalyticsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}