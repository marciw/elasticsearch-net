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

namespace Elastic.Clients.Elasticsearch.IndexLifecycleManagement;

public sealed partial class StepKey
{
	/// <summary>
	/// <para>
	/// The optional action to which the index will be moved.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("action")]
	public string? Action { get; set; }

	/// <summary>
	/// <para>
	/// The optional step name to which the index will be moved.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public string? Name { get; set; }
	[JsonInclude, JsonPropertyName("phase")]
	public string Phase { get; set; }
}

public sealed partial class StepKeyDescriptor : SerializableDescriptor<StepKeyDescriptor>
{
	internal StepKeyDescriptor(Action<StepKeyDescriptor> configure) => configure.Invoke(this);

	public StepKeyDescriptor() : base()
	{
	}

	private string? ActionValue { get; set; }
	private string? NameValue { get; set; }
	private string PhaseValue { get; set; }

	/// <summary>
	/// <para>
	/// The optional action to which the index will be moved.
	/// </para>
	/// </summary>
	public StepKeyDescriptor Action(string? action)
	{
		ActionValue = action;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The optional step name to which the index will be moved.
	/// </para>
	/// </summary>
	public StepKeyDescriptor Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	public StepKeyDescriptor Phase(string phase)
	{
		PhaseValue = phase;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ActionValue))
		{
			writer.WritePropertyName("action");
			writer.WriteStringValue(ActionValue);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		writer.WritePropertyName("phase");
		writer.WriteStringValue(PhaseValue);
		writer.WriteEndObject();
	}
}