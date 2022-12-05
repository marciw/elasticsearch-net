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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed class DeleteIndexRequestParameters : RequestParameters
{
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

public sealed partial class DeleteIndexRequest : PlainRequest<DeleteIndexRequestParameters>
{
	public DeleteIndexRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDelete;
	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;
	internal override bool SupportsBody => false;
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

public sealed partial class DeleteIndexRequestDescriptor<TDocument> : RequestDescriptor<DeleteIndexRequestDescriptor<TDocument>, DeleteIndexRequestParameters>
{
	internal DeleteIndexRequestDescriptor(Action<DeleteIndexRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public DeleteIndexRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal DeleteIndexRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDelete;
	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;
	internal override bool SupportsBody => false;
	public DeleteIndexRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public DeleteIndexRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public DeleteIndexRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public DeleteIndexRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public DeleteIndexRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public DeleteIndexRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class DeleteIndexRequestDescriptor : RequestDescriptor<DeleteIndexRequestDescriptor, DeleteIndexRequestParameters>
{
	internal DeleteIndexRequestDescriptor(Action<DeleteIndexRequestDescriptor> configure) => configure.Invoke(this);
	public DeleteIndexRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal DeleteIndexRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDelete;
	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;
	internal override bool SupportsBody => false;
	public DeleteIndexRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public DeleteIndexRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public DeleteIndexRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public DeleteIndexRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public DeleteIndexRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public DeleteIndexRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}