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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class SearchAccess
{
	/// <summary>
	/// <para>
	/// Set to <c>true</c> if using wildcard or regular expressions for patterns that cover restricted indices. Implicitly, restricted indices have limited privileges that can cause pattern tests to fail. If restricted indices are explicitly included in the <c>names</c> list, Elasticsearch checks privileges against these indices regardless of the value set for <c>allow_restricted_indices</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allow_restricted_indices")]
	public bool? AllowRestrictedIndices { get; set; }

	/// <summary>
	/// <para>
	/// The document fields that the owners of the role have read access to.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field_security")]
	public Elastic.Clients.Elasticsearch.Security.FieldSecurity? FieldSecurity { get; set; }

	/// <summary>
	/// <para>
	/// A list of indices (or index name patterns) to which the permissions in this entry apply.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("names")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.IndexName))]
	public ICollection<Elastic.Clients.Elasticsearch.IndexName> Names { get; set; }

	/// <summary>
	/// <para>
	/// A search query that defines the documents the owners of the role have access to. A document within the specified indices must match this query for it to be accessible by the owners of the role.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public object? Query { get; set; }
}

public sealed partial class SearchAccessDescriptor<TDocument> : SerializableDescriptor<SearchAccessDescriptor<TDocument>>
{
	internal SearchAccessDescriptor(Action<SearchAccessDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SearchAccessDescriptor() : base()
	{
	}

	private bool? AllowRestrictedIndicesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.FieldSecurity? FieldSecurityValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor<TDocument> FieldSecurityDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor<TDocument>> FieldSecurityDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.IndexName> NamesValue { get; set; }
	private object? QueryValue { get; set; }

	/// <summary>
	/// <para>
	/// Set to <c>true</c> if using wildcard or regular expressions for patterns that cover restricted indices. Implicitly, restricted indices have limited privileges that can cause pattern tests to fail. If restricted indices are explicitly included in the <c>names</c> list, Elasticsearch checks privileges against these indices regardless of the value set for <c>allow_restricted_indices</c>.
	/// </para>
	/// </summary>
	public SearchAccessDescriptor<TDocument> AllowRestrictedIndices(bool? allowRestrictedIndices = true)
	{
		AllowRestrictedIndicesValue = allowRestrictedIndices;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The document fields that the owners of the role have read access to.
	/// </para>
	/// </summary>
	public SearchAccessDescriptor<TDocument> FieldSecurity(Elastic.Clients.Elasticsearch.Security.FieldSecurity? fieldSecurity)
	{
		FieldSecurityDescriptor = null;
		FieldSecurityDescriptorAction = null;
		FieldSecurityValue = fieldSecurity;
		return Self;
	}

	public SearchAccessDescriptor<TDocument> FieldSecurity(Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor<TDocument> descriptor)
	{
		FieldSecurityValue = null;
		FieldSecurityDescriptorAction = null;
		FieldSecurityDescriptor = descriptor;
		return Self;
	}

	public SearchAccessDescriptor<TDocument> FieldSecurity(Action<Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor<TDocument>> configure)
	{
		FieldSecurityValue = null;
		FieldSecurityDescriptor = null;
		FieldSecurityDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of indices (or index name patterns) to which the permissions in this entry apply.
	/// </para>
	/// </summary>
	public SearchAccessDescriptor<TDocument> Names(ICollection<Elastic.Clients.Elasticsearch.IndexName> names)
	{
		NamesValue = names;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A search query that defines the documents the owners of the role have access to. A document within the specified indices must match this query for it to be accessible by the owners of the role.
	/// </para>
	/// </summary>
	public SearchAccessDescriptor<TDocument> Query(object? query)
	{
		QueryValue = query;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowRestrictedIndicesValue.HasValue)
		{
			writer.WritePropertyName("allow_restricted_indices");
			writer.WriteBooleanValue(AllowRestrictedIndicesValue.Value);
		}

		if (FieldSecurityDescriptor is not null)
		{
			writer.WritePropertyName("field_security");
			JsonSerializer.Serialize(writer, FieldSecurityDescriptor, options);
		}
		else if (FieldSecurityDescriptorAction is not null)
		{
			writer.WritePropertyName("field_security");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor<TDocument>(FieldSecurityDescriptorAction), options);
		}
		else if (FieldSecurityValue is not null)
		{
			writer.WritePropertyName("field_security");
			JsonSerializer.Serialize(writer, FieldSecurityValue, options);
		}

		writer.WritePropertyName("names");
		SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.IndexName>(NamesValue, writer, options);
		if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SearchAccessDescriptor : SerializableDescriptor<SearchAccessDescriptor>
{
	internal SearchAccessDescriptor(Action<SearchAccessDescriptor> configure) => configure.Invoke(this);

	public SearchAccessDescriptor() : base()
	{
	}

	private bool? AllowRestrictedIndicesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.FieldSecurity? FieldSecurityValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor FieldSecurityDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor> FieldSecurityDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.IndexName> NamesValue { get; set; }
	private object? QueryValue { get; set; }

	/// <summary>
	/// <para>
	/// Set to <c>true</c> if using wildcard or regular expressions for patterns that cover restricted indices. Implicitly, restricted indices have limited privileges that can cause pattern tests to fail. If restricted indices are explicitly included in the <c>names</c> list, Elasticsearch checks privileges against these indices regardless of the value set for <c>allow_restricted_indices</c>.
	/// </para>
	/// </summary>
	public SearchAccessDescriptor AllowRestrictedIndices(bool? allowRestrictedIndices = true)
	{
		AllowRestrictedIndicesValue = allowRestrictedIndices;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The document fields that the owners of the role have read access to.
	/// </para>
	/// </summary>
	public SearchAccessDescriptor FieldSecurity(Elastic.Clients.Elasticsearch.Security.FieldSecurity? fieldSecurity)
	{
		FieldSecurityDescriptor = null;
		FieldSecurityDescriptorAction = null;
		FieldSecurityValue = fieldSecurity;
		return Self;
	}

	public SearchAccessDescriptor FieldSecurity(Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor descriptor)
	{
		FieldSecurityValue = null;
		FieldSecurityDescriptorAction = null;
		FieldSecurityDescriptor = descriptor;
		return Self;
	}

	public SearchAccessDescriptor FieldSecurity(Action<Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor> configure)
	{
		FieldSecurityValue = null;
		FieldSecurityDescriptor = null;
		FieldSecurityDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of indices (or index name patterns) to which the permissions in this entry apply.
	/// </para>
	/// </summary>
	public SearchAccessDescriptor Names(ICollection<Elastic.Clients.Elasticsearch.IndexName> names)
	{
		NamesValue = names;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A search query that defines the documents the owners of the role have access to. A document within the specified indices must match this query for it to be accessible by the owners of the role.
	/// </para>
	/// </summary>
	public SearchAccessDescriptor Query(object? query)
	{
		QueryValue = query;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowRestrictedIndicesValue.HasValue)
		{
			writer.WritePropertyName("allow_restricted_indices");
			writer.WriteBooleanValue(AllowRestrictedIndicesValue.Value);
		}

		if (FieldSecurityDescriptor is not null)
		{
			writer.WritePropertyName("field_security");
			JsonSerializer.Serialize(writer, FieldSecurityDescriptor, options);
		}
		else if (FieldSecurityDescriptorAction is not null)
		{
			writer.WritePropertyName("field_security");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.FieldSecurityDescriptor(FieldSecurityDescriptorAction), options);
		}
		else if (FieldSecurityValue is not null)
		{
			writer.WritePropertyName("field_security");
			JsonSerializer.Serialize(writer, FieldSecurityValue, options);
		}

		writer.WritePropertyName("names");
		SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.IndexName>(NamesValue, writer, options);
		if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		writer.WriteEndObject();
	}
}