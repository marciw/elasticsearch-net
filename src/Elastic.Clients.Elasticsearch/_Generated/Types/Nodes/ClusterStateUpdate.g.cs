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

namespace Elastic.Clients.Elasticsearch.Nodes;

public sealed partial class ClusterStateUpdate
{
	/// <summary>
	/// <para>
	/// The cumulative amount of time spent waiting for a successful cluster state update to commit, which measures the time from the start of each publication until a majority of the master-eligible nodes have written the state to disk and confirmed the write to the elected master.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("commit_time")]
	public Elastic.Clients.Elasticsearch.Duration? CommitTime { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time, in milliseconds, spent waiting for a successful cluster state update to commit, which measures the time from the start of each publication until a majority of the master-eligible nodes have written the state to disk and confirmed the write to the elected master.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("commit_time_millis")]
	public long? CommitTimeMillis { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time spent waiting for a successful cluster state update to complete, which measures the time from the start of each publication until all the other nodes have notified the elected master that they have applied the cluster state.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("completion_time")]
	public Elastic.Clients.Elasticsearch.Duration? CompletionTime { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time, in milliseconds,  spent waiting for a successful cluster state update to complete, which measures the time from the start of each publication until all the other nodes have notified the elected master that they have applied the cluster state.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("completion_time_millis")]
	public long? CompletionTimeMillis { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time spent computing no-op cluster state updates since the node started.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("computation_time")]
	public Elastic.Clients.Elasticsearch.Duration? ComputationTime { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time, in milliseconds, spent computing no-op cluster state updates since the node started.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("computation_time_millis")]
	public long? ComputationTimeMillis { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time spent constructing a publication context since the node started for publications that ultimately succeeded.
	/// This statistic includes the time spent computing the difference between the current and new cluster state preparing a serialized representation of this difference.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("context_construction_time")]
	public Elastic.Clients.Elasticsearch.Duration? ContextConstructionTime { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time, in milliseconds, spent constructing a publication context since the node started for publications that ultimately succeeded.
	/// This statistic includes the time spent computing the difference between the current and new cluster state preparing a serialized representation of this difference.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("context_construction_time_millis")]
	public long? ContextConstructionTimeMillis { get; init; }

	/// <summary>
	/// <para>
	/// The number of cluster state update attempts that did not change the cluster state since the node started.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("count")]
	public long Count { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time spent successfully applying cluster state updates on the elected master since the node started.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("master_apply_time")]
	public Elastic.Clients.Elasticsearch.Duration? MasterApplyTime { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time, in milliseconds, spent successfully applying cluster state updates on the elected master since the node started.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("master_apply_time_millis")]
	public long? MasterApplyTimeMillis { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time spent notifying listeners of a no-op cluster state update since the node started.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("notification_time")]
	public Elastic.Clients.Elasticsearch.Duration? NotificationTime { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time, in milliseconds, spent notifying listeners of a no-op cluster state update since the node started.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("notification_time_millis")]
	public long? NotificationTimeMillis { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time spent publishing cluster state updates which ultimately succeeded, which includes everything from the start of the publication (just after the computation of the new cluster state) until the publication has finished and the master node is ready to start processing the next state update.
	/// This includes the time measured by <c>context_construction_time</c>, <c>commit_time</c>, <c>completion_time</c> and <c>master_apply_time</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("publication_time")]
	public Elastic.Clients.Elasticsearch.Duration? PublicationTime { get; init; }

	/// <summary>
	/// <para>
	/// The cumulative amount of time, in milliseconds, spent publishing cluster state updates which ultimately succeeded, which includes everything from the start of the publication (just after the computation of the new cluster state) until the publication has finished and the master node is ready to start processing the next state update.
	/// This includes the time measured by <c>context_construction_time</c>, <c>commit_time</c>, <c>completion_time</c> and <c>master_apply_time</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("publication_time_millis")]
	public long? PublicationTimeMillis { get; init; }
}