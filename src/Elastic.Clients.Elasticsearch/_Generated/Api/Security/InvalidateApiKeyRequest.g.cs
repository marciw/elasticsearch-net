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

public sealed partial class InvalidateApiKeyRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Invalidate API keys.
/// </para>
/// <para>
/// This API invalidates API keys created by the create API key or grant API key APIs.
/// Invalidated API keys fail authentication, but they can still be viewed using the get API key information and query API key information APIs, for at least the configured retention period, until they are automatically deleted.
/// </para>
/// <para>
/// To use this API, you must have at least the <c>manage_security</c>, <c>manage_api_key</c>, or <c>manage_own_api_key</c> cluster privileges.
/// The <c>manage_security</c> privilege allows deleting any API key, including both REST and cross cluster API keys.
/// The <c>manage_api_key</c> privilege allows deleting any REST API key, but not cross cluster API keys.
/// The <c>manage_own_api_key</c> only allows deleting REST API keys that are owned by the user.
/// In addition, with the <c>manage_own_api_key</c> privilege, an invalidation request must be issued in one of the three formats:
/// </para>
/// <list type="bullet">
/// <item>
/// <para>
/// Set the parameter <c>owner=true</c>.
/// </para>
/// </item>
/// <item>
/// <para>
/// Or, set both <c>username</c> and <c>realm_name</c> to match the user's identity.
/// </para>
/// </item>
/// <item>
/// <para>
/// Or, if the request is issued by an API key, that is to say an API key invalidates itself, specify its ID in the <c>ids</c> field.
/// </para>
/// </item>
/// </list>
/// </summary>
public sealed partial class InvalidateApiKeyRequest : PlainRequest<InvalidateApiKeyRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityInvalidateApiKey;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.invalidate_api_key";

	[JsonInclude, JsonPropertyName("id")]
	public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

	/// <summary>
	/// <para>
	/// A list of API key ids.
	/// This parameter cannot be used with any of <c>name</c>, <c>realm_name</c>, or <c>username</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ids")]
	public ICollection<Elastic.Clients.Elasticsearch.Id>? Ids { get; set; }

	/// <summary>
	/// <para>
	/// An API key name.
	/// This parameter cannot be used with any of <c>ids</c>, <c>realm_name</c> or <c>username</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public Elastic.Clients.Elasticsearch.Name? Name { get; set; }

	/// <summary>
	/// <para>
	/// Query API keys owned by the currently authenticated user.
	/// The <c>realm_name</c> or <c>username</c> parameters cannot be specified when this parameter is set to <c>true</c> as they are assumed to be the currently authenticated ones.
	/// </para>
	/// <para>
	/// NOTE: At least one of <c>ids</c>, <c>name</c>, <c>username</c>, and <c>realm_name</c> must be specified if <c>owner</c> is <c>false</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("owner")]
	public bool? Owner { get; set; }

	/// <summary>
	/// <para>
	/// The name of an authentication realm.
	/// This parameter cannot be used with either <c>ids</c> or <c>name</c>, or when <c>owner</c> flag is set to <c>true</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("realm_name")]
	public string? RealmName { get; set; }

	/// <summary>
	/// <para>
	/// The username of a user.
	/// This parameter cannot be used with either <c>ids</c> or <c>name</c> or when <c>owner</c> flag is set to <c>true</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("username")]
	public Elastic.Clients.Elasticsearch.Username? Username { get; set; }
}

/// <summary>
/// <para>
/// Invalidate API keys.
/// </para>
/// <para>
/// This API invalidates API keys created by the create API key or grant API key APIs.
/// Invalidated API keys fail authentication, but they can still be viewed using the get API key information and query API key information APIs, for at least the configured retention period, until they are automatically deleted.
/// </para>
/// <para>
/// To use this API, you must have at least the <c>manage_security</c>, <c>manage_api_key</c>, or <c>manage_own_api_key</c> cluster privileges.
/// The <c>manage_security</c> privilege allows deleting any API key, including both REST and cross cluster API keys.
/// The <c>manage_api_key</c> privilege allows deleting any REST API key, but not cross cluster API keys.
/// The <c>manage_own_api_key</c> only allows deleting REST API keys that are owned by the user.
/// In addition, with the <c>manage_own_api_key</c> privilege, an invalidation request must be issued in one of the three formats:
/// </para>
/// <list type="bullet">
/// <item>
/// <para>
/// Set the parameter <c>owner=true</c>.
/// </para>
/// </item>
/// <item>
/// <para>
/// Or, set both <c>username</c> and <c>realm_name</c> to match the user's identity.
/// </para>
/// </item>
/// <item>
/// <para>
/// Or, if the request is issued by an API key, that is to say an API key invalidates itself, specify its ID in the <c>ids</c> field.
/// </para>
/// </item>
/// </list>
/// </summary>
public sealed partial class InvalidateApiKeyRequestDescriptor : RequestDescriptor<InvalidateApiKeyRequestDescriptor, InvalidateApiKeyRequestParameters>
{
	internal InvalidateApiKeyRequestDescriptor(Action<InvalidateApiKeyRequestDescriptor> configure) => configure.Invoke(this);

	public InvalidateApiKeyRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityInvalidateApiKey;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.invalidate_api_key";

	private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Id>? IdsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name? NameValue { get; set; }
	private bool? OwnerValue { get; set; }
	private string? RealmNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Username? UsernameValue { get; set; }

	public InvalidateApiKeyRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of API key ids.
	/// This parameter cannot be used with any of <c>name</c>, <c>realm_name</c>, or <c>username</c>.
	/// </para>
	/// </summary>
	public InvalidateApiKeyRequestDescriptor Ids(ICollection<Elastic.Clients.Elasticsearch.Id>? ids)
	{
		IdsValue = ids;
		return Self;
	}

	/// <summary>
	/// <para>
	/// An API key name.
	/// This parameter cannot be used with any of <c>ids</c>, <c>realm_name</c> or <c>username</c>.
	/// </para>
	/// </summary>
	public InvalidateApiKeyRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query API keys owned by the currently authenticated user.
	/// The <c>realm_name</c> or <c>username</c> parameters cannot be specified when this parameter is set to <c>true</c> as they are assumed to be the currently authenticated ones.
	/// </para>
	/// <para>
	/// NOTE: At least one of <c>ids</c>, <c>name</c>, <c>username</c>, and <c>realm_name</c> must be specified if <c>owner</c> is <c>false</c>.
	/// </para>
	/// </summary>
	public InvalidateApiKeyRequestDescriptor Owner(bool? owner = true)
	{
		OwnerValue = owner;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of an authentication realm.
	/// This parameter cannot be used with either <c>ids</c> or <c>name</c>, or when <c>owner</c> flag is set to <c>true</c>.
	/// </para>
	/// </summary>
	public InvalidateApiKeyRequestDescriptor RealmName(string? realmName)
	{
		RealmNameValue = realmName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The username of a user.
	/// This parameter cannot be used with either <c>ids</c> or <c>name</c> or when <c>owner</c> flag is set to <c>true</c>.
	/// </para>
	/// </summary>
	public InvalidateApiKeyRequestDescriptor Username(Elastic.Clients.Elasticsearch.Username? username)
	{
		UsernameValue = username;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IdValue is not null)
		{
			writer.WritePropertyName("id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (IdsValue is not null)
		{
			writer.WritePropertyName("ids");
			JsonSerializer.Serialize(writer, IdsValue, options);
		}

		if (NameValue is not null)
		{
			writer.WritePropertyName("name");
			JsonSerializer.Serialize(writer, NameValue, options);
		}

		if (OwnerValue.HasValue)
		{
			writer.WritePropertyName("owner");
			writer.WriteBooleanValue(OwnerValue.Value);
		}

		if (!string.IsNullOrEmpty(RealmNameValue))
		{
			writer.WritePropertyName("realm_name");
			writer.WriteStringValue(RealmNameValue);
		}

		if (UsernameValue is not null)
		{
			writer.WritePropertyName("username");
			JsonSerializer.Serialize(writer, UsernameValue, options);
		}

		writer.WriteEndObject();
	}
}