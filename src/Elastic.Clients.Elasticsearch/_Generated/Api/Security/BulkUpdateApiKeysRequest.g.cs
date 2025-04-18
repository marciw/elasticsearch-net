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

public sealed partial class BulkUpdateApiKeysRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Bulk update API keys.
/// Update the attributes for multiple API keys.
/// </para>
/// <para>
/// IMPORTANT: It is not possible to use an API key as the authentication credential for this API. To update API keys, the owner user's credentials are required.
/// </para>
/// <para>
/// This API is similar to the update API key API but enables you to apply the same update to multiple API keys in one API call. This operation can greatly improve performance over making individual updates.
/// </para>
/// <para>
/// It is not possible to update expired or invalidated API keys.
/// </para>
/// <para>
/// This API supports updates to API key access scope, metadata and expiration.
/// The access scope of each API key is derived from the <c>role_descriptors</c> you specify in the request and a snapshot of the owner user's permissions at the time of the request.
/// The snapshot of the owner's permissions is updated automatically on every call.
/// </para>
/// <para>
/// IMPORTANT: If you don't specify <c>role_descriptors</c> in the request, a call to this API might still change an API key's access scope. This change can occur if the owner user's permissions have changed since the API key was created or last modified.
/// </para>
/// <para>
/// A successful request returns a JSON structure that contains the IDs of all updated API keys, the IDs of API keys that already had the requested changes and did not require an update, and error details for any failed update.
/// </para>
/// </summary>
public sealed partial class BulkUpdateApiKeysRequest : PlainRequest<BulkUpdateApiKeysRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityBulkUpdateApiKeys;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.bulk_update_api_keys";

	/// <summary>
	/// <para>
	/// Expiration time for the API keys.
	/// By default, API keys never expire.
	/// This property can be omitted to leave the value unchanged.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("expiration")]
	public Elastic.Clients.Elasticsearch.Duration? Expiration { get; set; }

	/// <summary>
	/// <para>
	/// The API key identifiers.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ids")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string> Ids { get; set; }

	/// <summary>
	/// <para>
	/// Arbitrary nested metadata to associate with the API keys.
	/// Within the <c>metadata</c> object, top-level keys beginning with an underscore (<c>_</c>) are reserved for system usage.
	/// Any information specified with this parameter fully replaces metadata previously associated with the API key.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metadata")]
	public IDictionary<string, object>? Metadata { get; set; }

	/// <summary>
	/// <para>
	/// The role descriptors to assign to the API keys.
	/// An API key's effective permissions are an intersection of its assigned privileges and the point-in-time snapshot of permissions of the owner user.
	/// You can assign new privileges by specifying them in this parameter.
	/// To remove assigned privileges, supply the <c>role_descriptors</c> parameter as an empty object <c>{}</c>.
	/// If an API key has no assigned privileges, it inherits the owner user's full permissions.
	/// The snapshot of the owner's permissions is always updated, whether you supply the <c>role_descriptors</c> parameter.
	/// The structure of a role descriptor is the same as the request for the create API keys API.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("role_descriptors")]
	public IDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptor>? RoleDescriptors { get; set; }
}

/// <summary>
/// <para>
/// Bulk update API keys.
/// Update the attributes for multiple API keys.
/// </para>
/// <para>
/// IMPORTANT: It is not possible to use an API key as the authentication credential for this API. To update API keys, the owner user's credentials are required.
/// </para>
/// <para>
/// This API is similar to the update API key API but enables you to apply the same update to multiple API keys in one API call. This operation can greatly improve performance over making individual updates.
/// </para>
/// <para>
/// It is not possible to update expired or invalidated API keys.
/// </para>
/// <para>
/// This API supports updates to API key access scope, metadata and expiration.
/// The access scope of each API key is derived from the <c>role_descriptors</c> you specify in the request and a snapshot of the owner user's permissions at the time of the request.
/// The snapshot of the owner's permissions is updated automatically on every call.
/// </para>
/// <para>
/// IMPORTANT: If you don't specify <c>role_descriptors</c> in the request, a call to this API might still change an API key's access scope. This change can occur if the owner user's permissions have changed since the API key was created or last modified.
/// </para>
/// <para>
/// A successful request returns a JSON structure that contains the IDs of all updated API keys, the IDs of API keys that already had the requested changes and did not require an update, and error details for any failed update.
/// </para>
/// </summary>
public sealed partial class BulkUpdateApiKeysRequestDescriptor<TDocument> : RequestDescriptor<BulkUpdateApiKeysRequestDescriptor<TDocument>, BulkUpdateApiKeysRequestParameters>
{
	internal BulkUpdateApiKeysRequestDescriptor(Action<BulkUpdateApiKeysRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public BulkUpdateApiKeysRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityBulkUpdateApiKeys;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.bulk_update_api_keys";

	private Elastic.Clients.Elasticsearch.Duration? ExpirationValue { get; set; }
	private ICollection<string> IdsValue { get; set; }
	private IDictionary<string, object>? MetadataValue { get; set; }
	private IDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptorDescriptor<TDocument>> RoleDescriptorsValue { get; set; }

	/// <summary>
	/// <para>
	/// Expiration time for the API keys.
	/// By default, API keys never expire.
	/// This property can be omitted to leave the value unchanged.
	/// </para>
	/// </summary>
	public BulkUpdateApiKeysRequestDescriptor<TDocument> Expiration(Elastic.Clients.Elasticsearch.Duration? expiration)
	{
		ExpirationValue = expiration;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The API key identifiers.
	/// </para>
	/// </summary>
	public BulkUpdateApiKeysRequestDescriptor<TDocument> Ids(ICollection<string> ids)
	{
		IdsValue = ids;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Arbitrary nested metadata to associate with the API keys.
	/// Within the <c>metadata</c> object, top-level keys beginning with an underscore (<c>_</c>) are reserved for system usage.
	/// Any information specified with this parameter fully replaces metadata previously associated with the API key.
	/// </para>
	/// </summary>
	public BulkUpdateApiKeysRequestDescriptor<TDocument> Metadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// The role descriptors to assign to the API keys.
	/// An API key's effective permissions are an intersection of its assigned privileges and the point-in-time snapshot of permissions of the owner user.
	/// You can assign new privileges by specifying them in this parameter.
	/// To remove assigned privileges, supply the <c>role_descriptors</c> parameter as an empty object <c>{}</c>.
	/// If an API key has no assigned privileges, it inherits the owner user's full permissions.
	/// The snapshot of the owner's permissions is always updated, whether you supply the <c>role_descriptors</c> parameter.
	/// The structure of a role descriptor is the same as the request for the create API keys API.
	/// </para>
	/// </summary>
	public BulkUpdateApiKeysRequestDescriptor<TDocument> RoleDescriptors(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptorDescriptor<TDocument>>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptorDescriptor<TDocument>>> selector)
	{
		RoleDescriptorsValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptorDescriptor<TDocument>>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ExpirationValue is not null)
		{
			writer.WritePropertyName("expiration");
			JsonSerializer.Serialize(writer, ExpirationValue, options);
		}

		writer.WritePropertyName("ids");
		SingleOrManySerializationHelper.Serialize<string>(IdsValue, writer, options);
		if (MetadataValue is not null)
		{
			writer.WritePropertyName("metadata");
			JsonSerializer.Serialize(writer, MetadataValue, options);
		}

		if (RoleDescriptorsValue is not null)
		{
			writer.WritePropertyName("role_descriptors");
			JsonSerializer.Serialize(writer, RoleDescriptorsValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Bulk update API keys.
/// Update the attributes for multiple API keys.
/// </para>
/// <para>
/// IMPORTANT: It is not possible to use an API key as the authentication credential for this API. To update API keys, the owner user's credentials are required.
/// </para>
/// <para>
/// This API is similar to the update API key API but enables you to apply the same update to multiple API keys in one API call. This operation can greatly improve performance over making individual updates.
/// </para>
/// <para>
/// It is not possible to update expired or invalidated API keys.
/// </para>
/// <para>
/// This API supports updates to API key access scope, metadata and expiration.
/// The access scope of each API key is derived from the <c>role_descriptors</c> you specify in the request and a snapshot of the owner user's permissions at the time of the request.
/// The snapshot of the owner's permissions is updated automatically on every call.
/// </para>
/// <para>
/// IMPORTANT: If you don't specify <c>role_descriptors</c> in the request, a call to this API might still change an API key's access scope. This change can occur if the owner user's permissions have changed since the API key was created or last modified.
/// </para>
/// <para>
/// A successful request returns a JSON structure that contains the IDs of all updated API keys, the IDs of API keys that already had the requested changes and did not require an update, and error details for any failed update.
/// </para>
/// </summary>
public sealed partial class BulkUpdateApiKeysRequestDescriptor : RequestDescriptor<BulkUpdateApiKeysRequestDescriptor, BulkUpdateApiKeysRequestParameters>
{
	internal BulkUpdateApiKeysRequestDescriptor(Action<BulkUpdateApiKeysRequestDescriptor> configure) => configure.Invoke(this);

	public BulkUpdateApiKeysRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityBulkUpdateApiKeys;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.bulk_update_api_keys";

	private Elastic.Clients.Elasticsearch.Duration? ExpirationValue { get; set; }
	private ICollection<string> IdsValue { get; set; }
	private IDictionary<string, object>? MetadataValue { get; set; }
	private IDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptorDescriptor> RoleDescriptorsValue { get; set; }

	/// <summary>
	/// <para>
	/// Expiration time for the API keys.
	/// By default, API keys never expire.
	/// This property can be omitted to leave the value unchanged.
	/// </para>
	/// </summary>
	public BulkUpdateApiKeysRequestDescriptor Expiration(Elastic.Clients.Elasticsearch.Duration? expiration)
	{
		ExpirationValue = expiration;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The API key identifiers.
	/// </para>
	/// </summary>
	public BulkUpdateApiKeysRequestDescriptor Ids(ICollection<string> ids)
	{
		IdsValue = ids;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Arbitrary nested metadata to associate with the API keys.
	/// Within the <c>metadata</c> object, top-level keys beginning with an underscore (<c>_</c>) are reserved for system usage.
	/// Any information specified with this parameter fully replaces metadata previously associated with the API key.
	/// </para>
	/// </summary>
	public BulkUpdateApiKeysRequestDescriptor Metadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// The role descriptors to assign to the API keys.
	/// An API key's effective permissions are an intersection of its assigned privileges and the point-in-time snapshot of permissions of the owner user.
	/// You can assign new privileges by specifying them in this parameter.
	/// To remove assigned privileges, supply the <c>role_descriptors</c> parameter as an empty object <c>{}</c>.
	/// If an API key has no assigned privileges, it inherits the owner user's full permissions.
	/// The snapshot of the owner's permissions is always updated, whether you supply the <c>role_descriptors</c> parameter.
	/// The structure of a role descriptor is the same as the request for the create API keys API.
	/// </para>
	/// </summary>
	public BulkUpdateApiKeysRequestDescriptor RoleDescriptors(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptorDescriptor>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptorDescriptor>> selector)
	{
		RoleDescriptorsValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Security.RoleDescriptorDescriptor>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ExpirationValue is not null)
		{
			writer.WritePropertyName("expiration");
			JsonSerializer.Serialize(writer, ExpirationValue, options);
		}

		writer.WritePropertyName("ids");
		SingleOrManySerializationHelper.Serialize<string>(IdsValue, writer, options);
		if (MetadataValue is not null)
		{
			writer.WritePropertyName("metadata");
			JsonSerializer.Serialize(writer, MetadataValue, options);
		}

		if (RoleDescriptorsValue is not null)
		{
			writer.WritePropertyName("role_descriptors");
			JsonSerializer.Serialize(writer, RoleDescriptorsValue, options);
		}

		writer.WriteEndObject();
	}
}