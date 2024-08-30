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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Nodes;

public sealed partial class NodeInfoSettingsCluster
{
	[JsonInclude, JsonPropertyName("deprecation_indexing")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.DeprecationIndexing? DeprecationIndexing { get; init; }
	[JsonInclude, JsonPropertyName("election")]
	public Elastic.Clients.Elasticsearch.Serverless.Nodes.NodeInfoSettingsClusterElection Election { get; init; }
	[JsonInclude, JsonPropertyName("initial_master_nodes")]
	public IReadOnlyCollection<string>? InitialMasterNodes { get; init; }
	[JsonInclude, JsonPropertyName("name")]
	public string Name { get; init; }
	[JsonInclude, JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexRouting? Routing { get; init; }
}