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

public sealed partial class UpdateSettingsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// The period to wait for a connection to the master node.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// The period to wait for a response.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Update security index settings.
/// </para>
/// <para>
/// Update the user-configurable settings for the security internal index (<c>.security</c> and associated indices). Only a subset of settings are allowed to be modified. This includes <c>index.auto_expand_replicas</c> and <c>index.number_of_replicas</c>.
/// </para>
/// <para>
/// NOTE: If <c>index.auto_expand_replicas</c> is set, <c>index.number_of_replicas</c> will be ignored during updates.
/// </para>
/// <para>
/// If a specific index is not in use on the system and settings are provided for it, the request will be rejected.
/// This API does not yet support configuring the settings for indices before they are in use.
/// </para>
/// </summary>
public sealed partial class UpdateSettingsRequest : PlainRequest<UpdateSettingsRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityUpdateSettings;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.update_settings";

	/// <summary>
	/// <para>
	/// The period to wait for a connection to the master node.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// The period to wait for a response.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// Settings for the index used for most security configuration, including native realm users and roles configured with the API.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("security")]
	public Elastic.Clients.Elasticsearch.Security.SecuritySettings? Security { get; set; }

	/// <summary>
	/// <para>
	/// Settings for the index used to store profile information.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("security-profile")]
	public Elastic.Clients.Elasticsearch.Security.SecuritySettings? SecurityProfile { get; set; }

	/// <summary>
	/// <para>
	/// Settings for the index used to store tokens.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("security-tokens")]
	public Elastic.Clients.Elasticsearch.Security.SecuritySettings? SecurityTokens { get; set; }
}

/// <summary>
/// <para>
/// Update security index settings.
/// </para>
/// <para>
/// Update the user-configurable settings for the security internal index (<c>.security</c> and associated indices). Only a subset of settings are allowed to be modified. This includes <c>index.auto_expand_replicas</c> and <c>index.number_of_replicas</c>.
/// </para>
/// <para>
/// NOTE: If <c>index.auto_expand_replicas</c> is set, <c>index.number_of_replicas</c> will be ignored during updates.
/// </para>
/// <para>
/// If a specific index is not in use on the system and settings are provided for it, the request will be rejected.
/// This API does not yet support configuring the settings for indices before they are in use.
/// </para>
/// </summary>
public sealed partial class UpdateSettingsRequestDescriptor<TDocument> : RequestDescriptor<UpdateSettingsRequestDescriptor<TDocument>, UpdateSettingsRequestParameters>
{
	internal UpdateSettingsRequestDescriptor(Action<UpdateSettingsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public UpdateSettingsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityUpdateSettings;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.update_settings";

	public UpdateSettingsRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public UpdateSettingsRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	private Elastic.Clients.Elasticsearch.Security.SecuritySettings? SecurityValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument> SecurityDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>> SecurityDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettings? SecurityProfileValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument> SecurityProfileDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>> SecurityProfileDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettings? SecurityTokensValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument> SecurityTokensDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>> SecurityTokensDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Settings for the index used for most security configuration, including native realm users and roles configured with the API.
	/// </para>
	/// </summary>
	public UpdateSettingsRequestDescriptor<TDocument> Security(Elastic.Clients.Elasticsearch.Security.SecuritySettings? security)
	{
		SecurityDescriptor = null;
		SecurityDescriptorAction = null;
		SecurityValue = security;
		return Self;
	}

	public UpdateSettingsRequestDescriptor<TDocument> Security(Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument> descriptor)
	{
		SecurityValue = null;
		SecurityDescriptorAction = null;
		SecurityDescriptor = descriptor;
		return Self;
	}

	public UpdateSettingsRequestDescriptor<TDocument> Security(Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>> configure)
	{
		SecurityValue = null;
		SecurityDescriptor = null;
		SecurityDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Settings for the index used to store profile information.
	/// </para>
	/// </summary>
	public UpdateSettingsRequestDescriptor<TDocument> SecurityProfile(Elastic.Clients.Elasticsearch.Security.SecuritySettings? securityProfile)
	{
		SecurityProfileDescriptor = null;
		SecurityProfileDescriptorAction = null;
		SecurityProfileValue = securityProfile;
		return Self;
	}

	public UpdateSettingsRequestDescriptor<TDocument> SecurityProfile(Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument> descriptor)
	{
		SecurityProfileValue = null;
		SecurityProfileDescriptorAction = null;
		SecurityProfileDescriptor = descriptor;
		return Self;
	}

	public UpdateSettingsRequestDescriptor<TDocument> SecurityProfile(Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>> configure)
	{
		SecurityProfileValue = null;
		SecurityProfileDescriptor = null;
		SecurityProfileDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Settings for the index used to store tokens.
	/// </para>
	/// </summary>
	public UpdateSettingsRequestDescriptor<TDocument> SecurityTokens(Elastic.Clients.Elasticsearch.Security.SecuritySettings? securityTokens)
	{
		SecurityTokensDescriptor = null;
		SecurityTokensDescriptorAction = null;
		SecurityTokensValue = securityTokens;
		return Self;
	}

	public UpdateSettingsRequestDescriptor<TDocument> SecurityTokens(Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument> descriptor)
	{
		SecurityTokensValue = null;
		SecurityTokensDescriptorAction = null;
		SecurityTokensDescriptor = descriptor;
		return Self;
	}

	public UpdateSettingsRequestDescriptor<TDocument> SecurityTokens(Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>> configure)
	{
		SecurityTokensValue = null;
		SecurityTokensDescriptor = null;
		SecurityTokensDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SecurityDescriptor is not null)
		{
			writer.WritePropertyName("security");
			JsonSerializer.Serialize(writer, SecurityDescriptor, options);
		}
		else if (SecurityDescriptorAction is not null)
		{
			writer.WritePropertyName("security");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>(SecurityDescriptorAction), options);
		}
		else if (SecurityValue is not null)
		{
			writer.WritePropertyName("security");
			JsonSerializer.Serialize(writer, SecurityValue, options);
		}

		if (SecurityProfileDescriptor is not null)
		{
			writer.WritePropertyName("security-profile");
			JsonSerializer.Serialize(writer, SecurityProfileDescriptor, options);
		}
		else if (SecurityProfileDescriptorAction is not null)
		{
			writer.WritePropertyName("security-profile");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>(SecurityProfileDescriptorAction), options);
		}
		else if (SecurityProfileValue is not null)
		{
			writer.WritePropertyName("security-profile");
			JsonSerializer.Serialize(writer, SecurityProfileValue, options);
		}

		if (SecurityTokensDescriptor is not null)
		{
			writer.WritePropertyName("security-tokens");
			JsonSerializer.Serialize(writer, SecurityTokensDescriptor, options);
		}
		else if (SecurityTokensDescriptorAction is not null)
		{
			writer.WritePropertyName("security-tokens");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor<TDocument>(SecurityTokensDescriptorAction), options);
		}
		else if (SecurityTokensValue is not null)
		{
			writer.WritePropertyName("security-tokens");
			JsonSerializer.Serialize(writer, SecurityTokensValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Update security index settings.
/// </para>
/// <para>
/// Update the user-configurable settings for the security internal index (<c>.security</c> and associated indices). Only a subset of settings are allowed to be modified. This includes <c>index.auto_expand_replicas</c> and <c>index.number_of_replicas</c>.
/// </para>
/// <para>
/// NOTE: If <c>index.auto_expand_replicas</c> is set, <c>index.number_of_replicas</c> will be ignored during updates.
/// </para>
/// <para>
/// If a specific index is not in use on the system and settings are provided for it, the request will be rejected.
/// This API does not yet support configuring the settings for indices before they are in use.
/// </para>
/// </summary>
public sealed partial class UpdateSettingsRequestDescriptor : RequestDescriptor<UpdateSettingsRequestDescriptor, UpdateSettingsRequestParameters>
{
	internal UpdateSettingsRequestDescriptor(Action<UpdateSettingsRequestDescriptor> configure) => configure.Invoke(this);

	public UpdateSettingsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityUpdateSettings;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.update_settings";

	public UpdateSettingsRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public UpdateSettingsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	private Elastic.Clients.Elasticsearch.Security.SecuritySettings? SecurityValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor SecurityDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor> SecurityDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettings? SecurityProfileValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor SecurityProfileDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor> SecurityProfileDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettings? SecurityTokensValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor SecurityTokensDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor> SecurityTokensDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Settings for the index used for most security configuration, including native realm users and roles configured with the API.
	/// </para>
	/// </summary>
	public UpdateSettingsRequestDescriptor Security(Elastic.Clients.Elasticsearch.Security.SecuritySettings? security)
	{
		SecurityDescriptor = null;
		SecurityDescriptorAction = null;
		SecurityValue = security;
		return Self;
	}

	public UpdateSettingsRequestDescriptor Security(Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor descriptor)
	{
		SecurityValue = null;
		SecurityDescriptorAction = null;
		SecurityDescriptor = descriptor;
		return Self;
	}

	public UpdateSettingsRequestDescriptor Security(Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor> configure)
	{
		SecurityValue = null;
		SecurityDescriptor = null;
		SecurityDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Settings for the index used to store profile information.
	/// </para>
	/// </summary>
	public UpdateSettingsRequestDescriptor SecurityProfile(Elastic.Clients.Elasticsearch.Security.SecuritySettings? securityProfile)
	{
		SecurityProfileDescriptor = null;
		SecurityProfileDescriptorAction = null;
		SecurityProfileValue = securityProfile;
		return Self;
	}

	public UpdateSettingsRequestDescriptor SecurityProfile(Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor descriptor)
	{
		SecurityProfileValue = null;
		SecurityProfileDescriptorAction = null;
		SecurityProfileDescriptor = descriptor;
		return Self;
	}

	public UpdateSettingsRequestDescriptor SecurityProfile(Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor> configure)
	{
		SecurityProfileValue = null;
		SecurityProfileDescriptor = null;
		SecurityProfileDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Settings for the index used to store tokens.
	/// </para>
	/// </summary>
	public UpdateSettingsRequestDescriptor SecurityTokens(Elastic.Clients.Elasticsearch.Security.SecuritySettings? securityTokens)
	{
		SecurityTokensDescriptor = null;
		SecurityTokensDescriptorAction = null;
		SecurityTokensValue = securityTokens;
		return Self;
	}

	public UpdateSettingsRequestDescriptor SecurityTokens(Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor descriptor)
	{
		SecurityTokensValue = null;
		SecurityTokensDescriptorAction = null;
		SecurityTokensDescriptor = descriptor;
		return Self;
	}

	public UpdateSettingsRequestDescriptor SecurityTokens(Action<Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor> configure)
	{
		SecurityTokensValue = null;
		SecurityTokensDescriptor = null;
		SecurityTokensDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SecurityDescriptor is not null)
		{
			writer.WritePropertyName("security");
			JsonSerializer.Serialize(writer, SecurityDescriptor, options);
		}
		else if (SecurityDescriptorAction is not null)
		{
			writer.WritePropertyName("security");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor(SecurityDescriptorAction), options);
		}
		else if (SecurityValue is not null)
		{
			writer.WritePropertyName("security");
			JsonSerializer.Serialize(writer, SecurityValue, options);
		}

		if (SecurityProfileDescriptor is not null)
		{
			writer.WritePropertyName("security-profile");
			JsonSerializer.Serialize(writer, SecurityProfileDescriptor, options);
		}
		else if (SecurityProfileDescriptorAction is not null)
		{
			writer.WritePropertyName("security-profile");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor(SecurityProfileDescriptorAction), options);
		}
		else if (SecurityProfileValue is not null)
		{
			writer.WritePropertyName("security-profile");
			JsonSerializer.Serialize(writer, SecurityProfileValue, options);
		}

		if (SecurityTokensDescriptor is not null)
		{
			writer.WritePropertyName("security-tokens");
			JsonSerializer.Serialize(writer, SecurityTokensDescriptor, options);
		}
		else if (SecurityTokensDescriptorAction is not null)
		{
			writer.WritePropertyName("security-tokens");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.SecuritySettingsDescriptor(SecurityTokensDescriptorAction), options);
		}
		else if (SecurityTokensValue is not null)
		{
			writer.WritePropertyName("security-tokens");
			JsonSerializer.Serialize(writer, SecurityTokensValue, options);
		}

		writer.WriteEndObject();
	}
}