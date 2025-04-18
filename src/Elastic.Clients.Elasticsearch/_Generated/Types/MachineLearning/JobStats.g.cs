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

public sealed partial class JobStats
{
	/// <summary>
	/// <para>
	/// For open anomaly detection jobs only, contains messages relating to the selection of a node to run the job.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("assignment_explanation")]
	public string? AssignmentExplanation { get; init; }

	/// <summary>
	/// <para>
	/// An object that describes the quantity of input to the job and any related error counts.
	/// The <c>data_count</c> values are cumulative for the lifetime of a job.
	/// If a model snapshot is reverted or old results are deleted, the job counts are not reset.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("data_counts")]
	public Elastic.Clients.Elasticsearch.MachineLearning.DataCounts DataCounts { get; init; }

	/// <summary>
	/// <para>
	/// Indicates that the process of deleting the job is in progress but not yet completed. It is only reported when <c>true</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("deleting")]
	public bool? Deleting { get; init; }

	/// <summary>
	/// <para>
	/// An object that provides statistical information about forecasts belonging to this job.
	/// Some statistics are omitted if no forecasts have been made.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("forecasts_stats")]
	public Elastic.Clients.Elasticsearch.MachineLearning.JobForecastStatistics ForecastsStats { get; init; }

	/// <summary>
	/// <para>
	/// Identifier for the anomaly detection job.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("job_id")]
	public string JobId { get; init; }

	/// <summary>
	/// <para>
	/// An object that provides information about the size and contents of the model.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_size_stats")]
	public Elastic.Clients.Elasticsearch.MachineLearning.ModelSizeStats ModelSizeStats { get; init; }

	/// <summary>
	/// <para>
	/// Contains properties for the node that runs the job.
	/// This information is available only for open jobs.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("node")]
	public Elastic.Clients.Elasticsearch.MachineLearning.DiscoveryNodeCompact? Node { get; init; }

	/// <summary>
	/// <para>
	/// For open jobs only, the elapsed time for which the job has been open.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("open_time")]
	public DateTimeOffset? OpenTime { get; init; }

	/// <summary>
	/// <para>
	/// The status of the anomaly detection job, which can be one of the following values: <c>closed</c>, <c>closing</c>, <c>failed</c>, <c>opened</c>, <c>opening</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("state")]
	public Elastic.Clients.Elasticsearch.MachineLearning.JobState State { get; init; }

	/// <summary>
	/// <para>
	/// An object that provides statistical information about timing aspect of this job.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timing_stats")]
	public Elastic.Clients.Elasticsearch.MachineLearning.JobTimingStats TimingStats { get; init; }
}