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

namespace Elastic.Clients.Elasticsearch.Esql;

public sealed partial class AsyncQueryDeleteRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Delete an async ES|QL query.
/// If the query is still running, it is cancelled.
/// Otherwise, the stored results are deleted.
/// </para>
/// <para>
/// If the Elasticsearch security features are enabled, only the following users can use this API to delete a query:
/// </para>
/// <list type="bullet">
/// <item>
/// <para>
/// The authenticated user that submitted the original query request
/// </para>
/// </item>
/// <item>
/// <para>
/// Users with the <c>cancel_task</c> cluster privilege
/// </para>
/// </item>
/// </list>
/// </summary>
public sealed partial class AsyncQueryDeleteRequest : PlainRequest<AsyncQueryDeleteRequestParameters>
{
	public AsyncQueryDeleteRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EsqlAsyncQueryDelete;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "esql.async_query_delete";
}

/// <summary>
/// <para>
/// Delete an async ES|QL query.
/// If the query is still running, it is cancelled.
/// Otherwise, the stored results are deleted.
/// </para>
/// <para>
/// If the Elasticsearch security features are enabled, only the following users can use this API to delete a query:
/// </para>
/// <list type="bullet">
/// <item>
/// <para>
/// The authenticated user that submitted the original query request
/// </para>
/// </item>
/// <item>
/// <para>
/// Users with the <c>cancel_task</c> cluster privilege
/// </para>
/// </item>
/// </list>
/// </summary>
public sealed partial class AsyncQueryDeleteRequestDescriptor<TDocument> : RequestDescriptor<AsyncQueryDeleteRequestDescriptor<TDocument>, AsyncQueryDeleteRequestParameters>
{
	internal AsyncQueryDeleteRequestDescriptor(Action<AsyncQueryDeleteRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public AsyncQueryDeleteRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EsqlAsyncQueryDelete;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "esql.async_query_delete";

	public AsyncQueryDeleteRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Delete an async ES|QL query.
/// If the query is still running, it is cancelled.
/// Otherwise, the stored results are deleted.
/// </para>
/// <para>
/// If the Elasticsearch security features are enabled, only the following users can use this API to delete a query:
/// </para>
/// <list type="bullet">
/// <item>
/// <para>
/// The authenticated user that submitted the original query request
/// </para>
/// </item>
/// <item>
/// <para>
/// Users with the <c>cancel_task</c> cluster privilege
/// </para>
/// </item>
/// </list>
/// </summary>
public sealed partial class AsyncQueryDeleteRequestDescriptor : RequestDescriptor<AsyncQueryDeleteRequestDescriptor, AsyncQueryDeleteRequestParameters>
{
	internal AsyncQueryDeleteRequestDescriptor(Action<AsyncQueryDeleteRequestDescriptor> configure) => configure.Invoke(this);

	public AsyncQueryDeleteRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EsqlAsyncQueryDelete;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "esql.async_query_delete";

	public AsyncQueryDeleteRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}