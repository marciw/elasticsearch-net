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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class GetGeoipDatabaseRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Get GeoIP database configurations.
/// Get information about one or more IP geolocation database configurations.
/// </para>
/// </summary>
public sealed partial class GetGeoipDatabaseRequest : PlainRequest<GetGeoipDatabaseRequestParameters>
{
	public GetGeoipDatabaseRequest()
	{
	}

	public GetGeoipDatabaseRequest(Elastic.Clients.Elasticsearch.Ids? id) : base(r => r.Optional("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestGetGeoipDatabase;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ingest.get_geoip_database";

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Get GeoIP database configurations.
/// Get information about one or more IP geolocation database configurations.
/// </para>
/// </summary>
public sealed partial class GetGeoipDatabaseRequestDescriptor<TDocument> : RequestDescriptor<GetGeoipDatabaseRequestDescriptor<TDocument>, GetGeoipDatabaseRequestParameters>
{
	internal GetGeoipDatabaseRequestDescriptor(Action<GetGeoipDatabaseRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GetGeoipDatabaseRequestDescriptor(Elastic.Clients.Elasticsearch.Ids? id) : base(r => r.Optional("id", id))
	{
	}

	public GetGeoipDatabaseRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestGetGeoipDatabase;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ingest.get_geoip_database";

	public GetGeoipDatabaseRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public GetGeoipDatabaseRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Ids? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Get GeoIP database configurations.
/// Get information about one or more IP geolocation database configurations.
/// </para>
/// </summary>
public sealed partial class GetGeoipDatabaseRequestDescriptor : RequestDescriptor<GetGeoipDatabaseRequestDescriptor, GetGeoipDatabaseRequestParameters>
{
	internal GetGeoipDatabaseRequestDescriptor(Action<GetGeoipDatabaseRequestDescriptor> configure) => configure.Invoke(this);

	public GetGeoipDatabaseRequestDescriptor(Elastic.Clients.Elasticsearch.Ids? id) : base(r => r.Optional("id", id))
	{
	}

	public GetGeoipDatabaseRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestGetGeoipDatabase;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ingest.get_geoip_database";

	public GetGeoipDatabaseRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public GetGeoipDatabaseRequestDescriptor Id(Elastic.Clients.Elasticsearch.Ids? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}