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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class IndexTemplateSummary
{
	/// <summary>
	/// <para>
	/// Aliases to add.
	/// If the index template includes a <c>data_stream</c> object, these are data stream aliases.
	/// Otherwise, these are index aliases.
	/// Data stream aliases ignore the <c>index_routing</c>, <c>routing</c>, and <c>search_routing</c> options.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aliases")]
	public IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }
	[JsonInclude, JsonPropertyName("lifecycle")]
	public Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRollover? Lifecycle { get; set; }

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// If specified, this mapping can include field names, field data types, and mapping parameters.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; set; }

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? Settings { get; set; }
}

public sealed partial class IndexTemplateSummaryDescriptor<TDocument> : SerializableDescriptor<IndexTemplateSummaryDescriptor<TDocument>>
{
	internal IndexTemplateSummaryDescriptor(Action<IndexTemplateSummaryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public IndexTemplateSummaryDescriptor() : base()
	{
	}

	private IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor<TDocument>> AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRollover? LifecycleValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor LifecycleDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor> LifecycleDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument> MappingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument>> MappingsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<TDocument> SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<TDocument>> SettingsDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Aliases to add.
	/// If the index template includes a <c>data_stream</c> object, these are data stream aliases.
	/// Otherwise, these are index aliases.
	/// Data stream aliases ignore the <c>index_routing</c>, <c>routing</c>, and <c>search_routing</c> options.
	/// </para>
	/// </summary>
	public IndexTemplateSummaryDescriptor<TDocument> Aliases(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor<TDocument>>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor<TDocument>>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor<TDocument>>());
		return Self;
	}

	public IndexTemplateSummaryDescriptor<TDocument> Lifecycle(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRollover? lifecycle)
	{
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = null;
		LifecycleValue = lifecycle;
		return Self;
	}

	public IndexTemplateSummaryDescriptor<TDocument> Lifecycle(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor descriptor)
	{
		LifecycleValue = null;
		LifecycleDescriptorAction = null;
		LifecycleDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateSummaryDescriptor<TDocument> Lifecycle(Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor> configure)
	{
		LifecycleValue = null;
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// If specified, this mapping can include field names, field data types, and mapping parameters.
	/// </para>
	/// </summary>
	public IndexTemplateSummaryDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public IndexTemplateSummaryDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument> descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateSummaryDescriptor<TDocument> Mappings(Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument>> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// </para>
	/// </summary>
	public IndexTemplateSummaryDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public IndexTemplateSummaryDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<TDocument> descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateSummaryDescriptor<TDocument> Settings(Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<TDocument>> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			JsonSerializer.Serialize(writer, AliasesValue, options);
		}

		if (LifecycleDescriptor is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, LifecycleDescriptor, options);
		}
		else if (LifecycleDescriptorAction is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor(LifecycleDescriptorAction), options);
		}
		else if (LifecycleValue is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, LifecycleValue, options);
		}

		if (MappingsDescriptor is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsDescriptor, options);
		}
		else if (MappingsDescriptorAction is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument>(MappingsDescriptorAction), options);
		}
		else if (MappingsValue is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsValue, options);
		}

		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<TDocument>(SettingsDescriptorAction), options);
		}
		else if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class IndexTemplateSummaryDescriptor : SerializableDescriptor<IndexTemplateSummaryDescriptor>
{
	internal IndexTemplateSummaryDescriptor(Action<IndexTemplateSummaryDescriptor> configure) => configure.Invoke(this);

	public IndexTemplateSummaryDescriptor() : base()
	{
	}

	private IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor> AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRollover? LifecycleValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor LifecycleDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor> LifecycleDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor> SettingsDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Aliases to add.
	/// If the index template includes a <c>data_stream</c> object, these are data stream aliases.
	/// Otherwise, these are index aliases.
	/// Data stream aliases ignore the <c>index_routing</c>, <c>routing</c>, and <c>search_routing</c> options.
	/// </para>
	/// </summary>
	public IndexTemplateSummaryDescriptor Aliases(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor>());
		return Self;
	}

	public IndexTemplateSummaryDescriptor Lifecycle(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRollover? lifecycle)
	{
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = null;
		LifecycleValue = lifecycle;
		return Self;
	}

	public IndexTemplateSummaryDescriptor Lifecycle(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor descriptor)
	{
		LifecycleValue = null;
		LifecycleDescriptorAction = null;
		LifecycleDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateSummaryDescriptor Lifecycle(Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor> configure)
	{
		LifecycleValue = null;
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// If specified, this mapping can include field names, field data types, and mapping parameters.
	/// </para>
	/// </summary>
	public IndexTemplateSummaryDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public IndexTemplateSummaryDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateSummaryDescriptor Mappings(Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// </para>
	/// </summary>
	public IndexTemplateSummaryDescriptor Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public IndexTemplateSummaryDescriptor Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateSummaryDescriptor Settings(Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			JsonSerializer.Serialize(writer, AliasesValue, options);
		}

		if (LifecycleDescriptor is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, LifecycleDescriptor, options);
		}
		else if (LifecycleDescriptorAction is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycleWithRolloverDescriptor(LifecycleDescriptorAction), options);
		}
		else if (LifecycleValue is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, LifecycleValue, options);
		}

		if (MappingsDescriptor is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsDescriptor, options);
		}
		else if (MappingsDescriptorAction is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor(MappingsDescriptorAction), options);
		}
		else if (MappingsValue is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsValue, options);
		}

		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor(SettingsDescriptorAction), options);
		}
		else if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WriteEndObject();
	}
}