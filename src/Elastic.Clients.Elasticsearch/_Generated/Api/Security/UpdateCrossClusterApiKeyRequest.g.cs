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

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class UpdateCrossClusterApiKeyRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Update a cross-cluster API key.
/// </para>
/// <para>
/// Update the attributes of an existing cross-cluster API key, which is used for API key based remote cluster access.
/// </para>
/// <para>
/// To use this API, you must have at least the <c>manage_security</c> cluster privilege.
/// Users can only update API keys that they created.
/// To update another user's API key, use the <c>run_as</c> feature to submit a request on behalf of another user.
/// </para>
/// <para>
/// IMPORTANT: It's not possible to use an API key as the authentication credential for this API.
/// To update an API key, the owner user's credentials are required.
/// </para>
/// <para>
/// It's not possible to update expired API keys, or API keys that have been invalidated by the invalidate API key API.
/// </para>
/// <para>
/// This API supports updates to an API key's access scope, metadata, and expiration.
/// The owner user's information, such as the <c>username</c> and <c>realm</c>, is also updated automatically on every call.
/// </para>
/// <para>
/// NOTE: This API cannot update REST API keys, which should be updated by either the update API key or bulk update API keys API.
/// </para>
/// </summary>
public sealed partial class UpdateCrossClusterApiKeyRequest : PlainRequest<UpdateCrossClusterApiKeyRequestParameters>
{
	public UpdateCrossClusterApiKeyRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityUpdateCrossClusterApiKey;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.update_cross_cluster_api_key";

	/// <summary>
	/// <para>
	/// The access to be granted to this API key.
	/// The access is composed of permissions for cross cluster search and cross cluster replication.
	/// At least one of them must be specified.
	/// When specified, the new access assignment fully replaces the previously assigned access.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("access")]
	public Elastic.Clients.Elasticsearch.Security.Access Access { get; set; }

	/// <summary>
	/// <para>
	/// The expiration time for the API key.
	/// By default, API keys never expire. This property can be omitted to leave the value unchanged.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("expiration")]
	public Elastic.Clients.Elasticsearch.Duration? Expiration { get; set; }

	/// <summary>
	/// <para>
	/// Arbitrary metadata that you want to associate with the API key.
	/// It supports nested data structure.
	/// Within the metadata object, keys beginning with <c>_</c> are reserved for system usage.
	/// When specified, this information fully replaces metadata previously associated with the API key.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metadata")]
	public IDictionary<string, object>? Metadata { get; set; }
}

/// <summary>
/// <para>
/// Update a cross-cluster API key.
/// </para>
/// <para>
/// Update the attributes of an existing cross-cluster API key, which is used for API key based remote cluster access.
/// </para>
/// <para>
/// To use this API, you must have at least the <c>manage_security</c> cluster privilege.
/// Users can only update API keys that they created.
/// To update another user's API key, use the <c>run_as</c> feature to submit a request on behalf of another user.
/// </para>
/// <para>
/// IMPORTANT: It's not possible to use an API key as the authentication credential for this API.
/// To update an API key, the owner user's credentials are required.
/// </para>
/// <para>
/// It's not possible to update expired API keys, or API keys that have been invalidated by the invalidate API key API.
/// </para>
/// <para>
/// This API supports updates to an API key's access scope, metadata, and expiration.
/// The owner user's information, such as the <c>username</c> and <c>realm</c>, is also updated automatically on every call.
/// </para>
/// <para>
/// NOTE: This API cannot update REST API keys, which should be updated by either the update API key or bulk update API keys API.
/// </para>
/// </summary>
public sealed partial class UpdateCrossClusterApiKeyRequestDescriptor<TDocument> : RequestDescriptor<UpdateCrossClusterApiKeyRequestDescriptor<TDocument>, UpdateCrossClusterApiKeyRequestParameters>
{
	internal UpdateCrossClusterApiKeyRequestDescriptor(Action<UpdateCrossClusterApiKeyRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public UpdateCrossClusterApiKeyRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityUpdateCrossClusterApiKey;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.update_cross_cluster_api_key";

	public UpdateCrossClusterApiKeyRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Security.Access AccessValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.AccessDescriptor<TDocument> AccessDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.AccessDescriptor<TDocument>> AccessDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? ExpirationValue { get; set; }
	private IDictionary<string, object>? MetadataValue { get; set; }

	/// <summary>
	/// <para>
	/// The access to be granted to this API key.
	/// The access is composed of permissions for cross cluster search and cross cluster replication.
	/// At least one of them must be specified.
	/// When specified, the new access assignment fully replaces the previously assigned access.
	/// </para>
	/// </summary>
	public UpdateCrossClusterApiKeyRequestDescriptor<TDocument> Access(Elastic.Clients.Elasticsearch.Security.Access access)
	{
		AccessDescriptor = null;
		AccessDescriptorAction = null;
		AccessValue = access;
		return Self;
	}

	public UpdateCrossClusterApiKeyRequestDescriptor<TDocument> Access(Elastic.Clients.Elasticsearch.Security.AccessDescriptor<TDocument> descriptor)
	{
		AccessValue = null;
		AccessDescriptorAction = null;
		AccessDescriptor = descriptor;
		return Self;
	}

	public UpdateCrossClusterApiKeyRequestDescriptor<TDocument> Access(Action<Elastic.Clients.Elasticsearch.Security.AccessDescriptor<TDocument>> configure)
	{
		AccessValue = null;
		AccessDescriptor = null;
		AccessDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The expiration time for the API key.
	/// By default, API keys never expire. This property can be omitted to leave the value unchanged.
	/// </para>
	/// </summary>
	public UpdateCrossClusterApiKeyRequestDescriptor<TDocument> Expiration(Elastic.Clients.Elasticsearch.Duration? expiration)
	{
		ExpirationValue = expiration;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Arbitrary metadata that you want to associate with the API key.
	/// It supports nested data structure.
	/// Within the metadata object, keys beginning with <c>_</c> are reserved for system usage.
	/// When specified, this information fully replaces metadata previously associated with the API key.
	/// </para>
	/// </summary>
	public UpdateCrossClusterApiKeyRequestDescriptor<TDocument> Metadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AccessDescriptor is not null)
		{
			writer.WritePropertyName("access");
			JsonSerializer.Serialize(writer, AccessDescriptor, options);
		}
		else if (AccessDescriptorAction is not null)
		{
			writer.WritePropertyName("access");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.AccessDescriptor<TDocument>(AccessDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("access");
			JsonSerializer.Serialize(writer, AccessValue, options);
		}

		if (ExpirationValue is not null)
		{
			writer.WritePropertyName("expiration");
			JsonSerializer.Serialize(writer, ExpirationValue, options);
		}

		if (MetadataValue is not null)
		{
			writer.WritePropertyName("metadata");
			JsonSerializer.Serialize(writer, MetadataValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Update a cross-cluster API key.
/// </para>
/// <para>
/// Update the attributes of an existing cross-cluster API key, which is used for API key based remote cluster access.
/// </para>
/// <para>
/// To use this API, you must have at least the <c>manage_security</c> cluster privilege.
/// Users can only update API keys that they created.
/// To update another user's API key, use the <c>run_as</c> feature to submit a request on behalf of another user.
/// </para>
/// <para>
/// IMPORTANT: It's not possible to use an API key as the authentication credential for this API.
/// To update an API key, the owner user's credentials are required.
/// </para>
/// <para>
/// It's not possible to update expired API keys, or API keys that have been invalidated by the invalidate API key API.
/// </para>
/// <para>
/// This API supports updates to an API key's access scope, metadata, and expiration.
/// The owner user's information, such as the <c>username</c> and <c>realm</c>, is also updated automatically on every call.
/// </para>
/// <para>
/// NOTE: This API cannot update REST API keys, which should be updated by either the update API key or bulk update API keys API.
/// </para>
/// </summary>
public sealed partial class UpdateCrossClusterApiKeyRequestDescriptor : RequestDescriptor<UpdateCrossClusterApiKeyRequestDescriptor, UpdateCrossClusterApiKeyRequestParameters>
{
	internal UpdateCrossClusterApiKeyRequestDescriptor(Action<UpdateCrossClusterApiKeyRequestDescriptor> configure) => configure.Invoke(this);

	public UpdateCrossClusterApiKeyRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityUpdateCrossClusterApiKey;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.update_cross_cluster_api_key";

	public UpdateCrossClusterApiKeyRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Security.Access AccessValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.AccessDescriptor AccessDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.AccessDescriptor> AccessDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? ExpirationValue { get; set; }
	private IDictionary<string, object>? MetadataValue { get; set; }

	/// <summary>
	/// <para>
	/// The access to be granted to this API key.
	/// The access is composed of permissions for cross cluster search and cross cluster replication.
	/// At least one of them must be specified.
	/// When specified, the new access assignment fully replaces the previously assigned access.
	/// </para>
	/// </summary>
	public UpdateCrossClusterApiKeyRequestDescriptor Access(Elastic.Clients.Elasticsearch.Security.Access access)
	{
		AccessDescriptor = null;
		AccessDescriptorAction = null;
		AccessValue = access;
		return Self;
	}

	public UpdateCrossClusterApiKeyRequestDescriptor Access(Elastic.Clients.Elasticsearch.Security.AccessDescriptor descriptor)
	{
		AccessValue = null;
		AccessDescriptorAction = null;
		AccessDescriptor = descriptor;
		return Self;
	}

	public UpdateCrossClusterApiKeyRequestDescriptor Access(Action<Elastic.Clients.Elasticsearch.Security.AccessDescriptor> configure)
	{
		AccessValue = null;
		AccessDescriptor = null;
		AccessDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The expiration time for the API key.
	/// By default, API keys never expire. This property can be omitted to leave the value unchanged.
	/// </para>
	/// </summary>
	public UpdateCrossClusterApiKeyRequestDescriptor Expiration(Elastic.Clients.Elasticsearch.Duration? expiration)
	{
		ExpirationValue = expiration;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Arbitrary metadata that you want to associate with the API key.
	/// It supports nested data structure.
	/// Within the metadata object, keys beginning with <c>_</c> are reserved for system usage.
	/// When specified, this information fully replaces metadata previously associated with the API key.
	/// </para>
	/// </summary>
	public UpdateCrossClusterApiKeyRequestDescriptor Metadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AccessDescriptor is not null)
		{
			writer.WritePropertyName("access");
			JsonSerializer.Serialize(writer, AccessDescriptor, options);
		}
		else if (AccessDescriptorAction is not null)
		{
			writer.WritePropertyName("access");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.AccessDescriptor(AccessDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("access");
			JsonSerializer.Serialize(writer, AccessValue, options);
		}

		if (ExpirationValue is not null)
		{
			writer.WritePropertyName("expiration");
			JsonSerializer.Serialize(writer, ExpirationValue, options);
		}

		if (MetadataValue is not null)
		{
			writer.WritePropertyName("metadata");
			JsonSerializer.Serialize(writer, MetadataValue, options);
		}

		writer.WriteEndObject();
	}
}