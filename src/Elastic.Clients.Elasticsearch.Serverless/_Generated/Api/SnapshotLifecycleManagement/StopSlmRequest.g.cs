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

namespace Elastic.Clients.Elasticsearch.Serverless.SnapshotLifecycleManagement;

public sealed partial class StopSlmRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Turns off snapshot lifecycle management (SLM).
/// </para>
/// </summary>
public sealed partial class StopSlmRequest : PlainRequest<StopSlmRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementStop;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.stop";
}

/// <summary>
/// <para>
/// Turns off snapshot lifecycle management (SLM).
/// </para>
/// </summary>
public sealed partial class StopSlmRequestDescriptor : RequestDescriptor<StopSlmRequestDescriptor, StopSlmRequestParameters>
{
	internal StopSlmRequestDescriptor(Action<StopSlmRequestDescriptor> configure) => configure.Invoke(this);

	public StopSlmRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementStop;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.stop";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}