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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.CrossClusterReplication;

public sealed partial class GetAutoFollowPatternRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Get auto-follow patterns.
/// Get cross-cluster replication auto-follow patterns.
/// </para>
/// </summary>
public sealed partial class GetAutoFollowPatternRequest : PlainRequest<GetAutoFollowPatternRequestParameters>
{
	public GetAutoFollowPatternRequest()
	{
	}

	public GetAutoFollowPatternRequest(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.CrossClusterReplicationGetAutoFollowPattern;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ccr.get_auto_follow_pattern";
}

/// <summary>
/// <para>
/// Get auto-follow patterns.
/// Get cross-cluster replication auto-follow patterns.
/// </para>
/// </summary>
public sealed partial class GetAutoFollowPatternRequestDescriptor : RequestDescriptor<GetAutoFollowPatternRequestDescriptor, GetAutoFollowPatternRequestParameters>
{
	internal GetAutoFollowPatternRequestDescriptor(Action<GetAutoFollowPatternRequestDescriptor> configure) => configure.Invoke(this);

	public GetAutoFollowPatternRequestDescriptor(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
	{
	}

	public GetAutoFollowPatternRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.CrossClusterReplicationGetAutoFollowPattern;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ccr.get_auto_follow_pattern";

	public GetAutoFollowPatternRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}