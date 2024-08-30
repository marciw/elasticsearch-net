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

namespace Elastic.Clients.Elasticsearch.IndexLifecycleManagement;

public sealed partial class RemovePolicyRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Removes the assigned lifecycle policy and stops managing the specified index
/// </para>
/// </summary>
public sealed partial class RemovePolicyRequest : PlainRequest<RemovePolicyRequestParameters>
{
	public RemovePolicyRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexLifecycleManagementRemovePolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ilm.remove_policy";
}

/// <summary>
/// <para>
/// Removes the assigned lifecycle policy and stops managing the specified index
/// </para>
/// </summary>
public sealed partial class RemovePolicyRequestDescriptor<TDocument> : RequestDescriptor<RemovePolicyRequestDescriptor<TDocument>, RemovePolicyRequestParameters>
{
	internal RemovePolicyRequestDescriptor(Action<RemovePolicyRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RemovePolicyRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	public RemovePolicyRequestDescriptor() : this(typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexLifecycleManagementRemovePolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ilm.remove_policy";

	public RemovePolicyRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Removes the assigned lifecycle policy and stops managing the specified index
/// </para>
/// </summary>
public sealed partial class RemovePolicyRequestDescriptor : RequestDescriptor<RemovePolicyRequestDescriptor, RemovePolicyRequestParameters>
{
	internal RemovePolicyRequestDescriptor(Action<RemovePolicyRequestDescriptor> configure) => configure.Invoke(this);

	public RemovePolicyRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexLifecycleManagementRemovePolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ilm.remove_policy";

	public RemovePolicyRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}