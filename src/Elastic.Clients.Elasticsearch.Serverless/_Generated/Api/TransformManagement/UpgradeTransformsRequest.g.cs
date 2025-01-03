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

namespace Elastic.Clients.Elasticsearch.Serverless.TransformManagement;

public sealed partial class UpgradeTransformsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// When true, the request checks for updates but does not run them.
	/// </para>
	/// </summary>
	public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and
	/// returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Upgrades all transforms.
/// This API identifies transforms that have a legacy configuration format and upgrades them to the latest version. It
/// also cleans up the internal data structures that store the transform state and checkpoints. The upgrade does not
/// affect the source and destination indices. The upgrade also does not affect the roles that transforms use when
/// Elasticsearch security features are enabled; the role used to read source data and write to the destination index
/// remains unchanged.
/// </para>
/// </summary>
public sealed partial class UpgradeTransformsRequest : PlainRequest<UpgradeTransformsRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementUpgradeTransforms;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "transform.upgrade_transforms";

	/// <summary>
	/// <para>
	/// When true, the request checks for updates but does not run them.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and
	/// returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Upgrades all transforms.
/// This API identifies transforms that have a legacy configuration format and upgrades them to the latest version. It
/// also cleans up the internal data structures that store the transform state and checkpoints. The upgrade does not
/// affect the source and destination indices. The upgrade also does not affect the roles that transforms use when
/// Elasticsearch security features are enabled; the role used to read source data and write to the destination index
/// remains unchanged.
/// </para>
/// </summary>
public sealed partial class UpgradeTransformsRequestDescriptor : RequestDescriptor<UpgradeTransformsRequestDescriptor, UpgradeTransformsRequestParameters>
{
	internal UpgradeTransformsRequestDescriptor(Action<UpgradeTransformsRequestDescriptor> configure) => configure.Invoke(this);

	public UpgradeTransformsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementUpgradeTransforms;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "transform.upgrade_transforms";

	public UpgradeTransformsRequestDescriptor DryRun(bool? dryRun = true) => Qs("dry_run", dryRun);
	public UpgradeTransformsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}