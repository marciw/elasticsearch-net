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

public sealed partial class PutUserRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>true</c> (the default) then refresh the affected shards to make this operation visible to search, if <c>wait_for</c> then wait for a refresh to make this operation visible to search, if <c>false</c> then do nothing with refreshes.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }
}

/// <summary>
/// <para>
/// Create or update users.
/// </para>
/// <para>
/// A password is required for adding a new user but is optional when updating an existing user.
/// To change a user’s password without updating any other fields, use the change password API.
/// </para>
/// </summary>
public sealed partial class PutUserRequest : PlainRequest<PutUserRequestParameters>
{
	public PutUserRequest(Elastic.Clients.Elasticsearch.Username username) : base(r => r.Required("username", username))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityPutUser;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.put_user";

	/// <summary>
	/// <para>
	/// If <c>true</c> (the default) then refresh the affected shards to make this operation visible to search, if <c>wait_for</c> then wait for a refresh to make this operation visible to search, if <c>false</c> then do nothing with refreshes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }
	[JsonInclude, JsonPropertyName("email")]
	public string? Email { get; set; }
	[JsonInclude, JsonPropertyName("enabled")]
	public bool? Enabled { get; set; }
	[JsonInclude, JsonPropertyName("full_name")]
	public string? FullName { get; set; }
	[JsonInclude, JsonPropertyName("metadata")]
	public IDictionary<string, object>? Metadata { get; set; }
	[JsonInclude, JsonPropertyName("password")]
	public string? Password { get; set; }
	[JsonInclude, JsonPropertyName("password_hash")]
	public string? PasswordHash { get; set; }
	[JsonInclude, JsonPropertyName("roles")]
	public ICollection<string>? Roles { get; set; }
	[JsonInclude, JsonPropertyName("username")]
	public Elastic.Clients.Elasticsearch.Username? Username { get; set; }
}

/// <summary>
/// <para>
/// Create or update users.
/// </para>
/// <para>
/// A password is required for adding a new user but is optional when updating an existing user.
/// To change a user’s password without updating any other fields, use the change password API.
/// </para>
/// </summary>
public sealed partial class PutUserRequestDescriptor : RequestDescriptor<PutUserRequestDescriptor, PutUserRequestParameters>
{
	internal PutUserRequestDescriptor(Action<PutUserRequestDescriptor> configure) => configure.Invoke(this);

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityPutUser;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.put_user";

	public PutUserRequestDescriptor Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);

	private string? EmailValue { get; set; }
	private bool? EnabledValue { get; set; }
	private string? FullNameValue { get; set; }
	private IDictionary<string, object>? MetadataValue { get; set; }
	private string? PasswordValue { get; set; }
	private string? PasswordHashValue { get; set; }
	private ICollection<string>? RolesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Username? UsernameValue { get; set; }

	public PutUserRequestDescriptor Email(string? email)
	{
		EmailValue = email;
		return Self;
	}

	public PutUserRequestDescriptor Enabled(bool? enabled = true)
	{
		EnabledValue = enabled;
		return Self;
	}

	public PutUserRequestDescriptor FullName(string? fullName)
	{
		FullNameValue = fullName;
		return Self;
	}

	public PutUserRequestDescriptor Metadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public PutUserRequestDescriptor Password(string? password)
	{
		PasswordValue = password;
		return Self;
	}

	public PutUserRequestDescriptor PasswordHash(string? passwordHash)
	{
		PasswordHashValue = passwordHash;
		return Self;
	}

	public PutUserRequestDescriptor Roles(ICollection<string>? roles)
	{
		RolesValue = roles;
		return Self;
	}

	public PutUserRequestDescriptor Username(Elastic.Clients.Elasticsearch.Username? username)
	{
		UsernameValue = username;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(EmailValue))
		{
			writer.WritePropertyName("email");
			writer.WriteStringValue(EmailValue);
		}

		if (EnabledValue.HasValue)
		{
			writer.WritePropertyName("enabled");
			writer.WriteBooleanValue(EnabledValue.Value);
		}

		if (!string.IsNullOrEmpty(FullNameValue))
		{
			writer.WritePropertyName("full_name");
			writer.WriteStringValue(FullNameValue);
		}

		if (MetadataValue is not null)
		{
			writer.WritePropertyName("metadata");
			JsonSerializer.Serialize(writer, MetadataValue, options);
		}

		if (!string.IsNullOrEmpty(PasswordValue))
		{
			writer.WritePropertyName("password");
			writer.WriteStringValue(PasswordValue);
		}

		if (!string.IsNullOrEmpty(PasswordHashValue))
		{
			writer.WritePropertyName("password_hash");
			writer.WriteStringValue(PasswordHashValue);
		}

		if (RolesValue is not null)
		{
			writer.WritePropertyName("roles");
			JsonSerializer.Serialize(writer, RolesValue, options);
		}

		if (UsernameValue is not null)
		{
			writer.WritePropertyName("username");
			JsonSerializer.Serialize(writer, UsernameValue, options);
		}

		writer.WriteEndObject();
	}
}