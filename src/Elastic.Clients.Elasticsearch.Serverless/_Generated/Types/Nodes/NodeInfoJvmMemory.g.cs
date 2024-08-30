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

public sealed partial class NodeInfoJvmMemory
{
	[JsonInclude, JsonPropertyName("direct_max")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? DirectMax { get; init; }
	[JsonInclude, JsonPropertyName("direct_max_in_bytes")]
	public long DirectMaxInBytes { get; init; }
	[JsonInclude, JsonPropertyName("heap_init")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? HeapInit { get; init; }
	[JsonInclude, JsonPropertyName("heap_init_in_bytes")]
	public long HeapInitInBytes { get; init; }
	[JsonInclude, JsonPropertyName("heap_max")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? HeapMax { get; init; }
	[JsonInclude, JsonPropertyName("heap_max_in_bytes")]
	public long HeapMaxInBytes { get; init; }
	[JsonInclude, JsonPropertyName("non_heap_init")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? NonHeapInit { get; init; }
	[JsonInclude, JsonPropertyName("non_heap_init_in_bytes")]
	public long NonHeapInitInBytes { get; init; }
	[JsonInclude, JsonPropertyName("non_heap_max")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? NonHeapMax { get; init; }
	[JsonInclude, JsonPropertyName("non_heap_max_in_bytes")]
	public long NonHeapMaxInBytes { get; init; }
}