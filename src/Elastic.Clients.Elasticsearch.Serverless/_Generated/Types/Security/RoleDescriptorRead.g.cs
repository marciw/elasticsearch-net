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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Security;

internal sealed partial class RoleDescriptorReadConverter : JsonConverter<RoleDescriptorRead>
{
	public override RoleDescriptorRead Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivileges>? applications = default;
		IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.ClusterPrivilege> cluster = default;
		string? description = default;
		IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.IndicesPrivileges> indices = default;
		IReadOnlyDictionary<string, object>? metadata = default;
		IReadOnlyCollection<string>? runAs = default;
		IReadOnlyDictionary<string, object>? transientMetadata = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "applications")
				{
					applications = JsonSerializer.Deserialize<IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivileges>?>(ref reader, options);
					continue;
				}

				if (property == "cluster")
				{
					cluster = JsonSerializer.Deserialize<IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.ClusterPrivilege>>(ref reader, options);
					continue;
				}

				if (property == "description")
				{
					description = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "indices" || property == "index")
				{
					indices = JsonSerializer.Deserialize<IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.IndicesPrivileges>>(ref reader, options);
					continue;
				}

				if (property == "metadata")
				{
					metadata = JsonSerializer.Deserialize<IReadOnlyDictionary<string, object>?>(ref reader, options);
					continue;
				}

				if (property == "run_as")
				{
					runAs = JsonSerializer.Deserialize<IReadOnlyCollection<string>?>(ref reader, options);
					continue;
				}

				if (property == "transient_metadata")
				{
					transientMetadata = JsonSerializer.Deserialize<IReadOnlyDictionary<string, object>?>(ref reader, options);
					continue;
				}
			}
		}

		return new RoleDescriptorRead { Applications = applications, Cluster = cluster, Description = description, Indices = indices, Metadata = metadata, RunAs = runAs, TransientMetadata = transientMetadata };
	}

	public override void Write(Utf8JsonWriter writer, RoleDescriptorRead value, JsonSerializerOptions options)
	{
		throw new NotImplementedException("'RoleDescriptorRead' is a readonly type, used only on responses and does not support being written to JSON.");
	}
}

[JsonConverter(typeof(RoleDescriptorReadConverter))]
public sealed partial class RoleDescriptorRead
{
	/// <summary>
	/// <para>
	/// A list of application privilege entries
	/// </para>
	/// </summary>
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.ApplicationPrivileges>? Applications { get; init; }

	/// <summary>
	/// <para>
	/// A list of cluster privileges. These privileges define the cluster level actions that API keys are able to execute.
	/// </para>
	/// </summary>
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.ClusterPrivilege> Cluster { get; init; }

	/// <summary>
	/// <para>
	/// Optional description of the role descriptor
	/// </para>
	/// </summary>
	public string? Description { get; init; }

	/// <summary>
	/// <para>
	/// A list of indices permissions entries.
	/// </para>
	/// </summary>
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Security.IndicesPrivileges> Indices { get; init; }

	/// <summary>
	/// <para>
	/// Optional meta-data. Within the metadata object, keys that begin with <c>_</c> are reserved for system usage.
	/// </para>
	/// </summary>
	public IReadOnlyDictionary<string, object>? Metadata { get; init; }

	/// <summary>
	/// <para>
	/// A list of users that the API keys can impersonate.
	/// </para>
	/// </summary>
	public IReadOnlyCollection<string>? RunAs { get; init; }
	public IReadOnlyDictionary<string, object>? TransientMetadata { get; init; }
}