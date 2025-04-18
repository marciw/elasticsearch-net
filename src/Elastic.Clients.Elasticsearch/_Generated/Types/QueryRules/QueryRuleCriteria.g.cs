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

namespace Elastic.Clients.Elasticsearch.QueryRules;

public sealed partial class QueryRuleCriteria
{
	/// <summary>
	/// <para>
	/// The metadata field to match against.
	/// This metadata will be used to match against <c>match_criteria</c> sent in the rule.
	/// It is required for all criteria types except <c>always</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metadata")]
	public string? Metadata { get; set; }

	/// <summary>
	/// <para>
	/// The type of criteria. The following criteria types are supported:
	/// </para>
	/// <list type="bullet">
	/// <item>
	/// <para>
	/// <c>always</c>: Matches all queries, regardless of input.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>contains</c>: Matches that contain this value anywhere in the field meet the criteria defined by the rule. Only applicable for string values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>exact</c>: Only exact matches meet the criteria defined by the rule. Applicable for string or numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>fuzzy</c>: Exact matches or matches within the allowed Levenshtein Edit Distance meet the criteria defined by the rule. Only applicable for string values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>gt</c>: Matches with a value greater than this value meet the criteria defined by the rule. Only applicable for numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>gte</c>: Matches with a value greater than or equal to this value meet the criteria defined by the rule. Only applicable for numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>lt</c>: Matches with a value less than this value meet the criteria defined by the rule. Only applicable for numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>lte</c>: Matches with a value less than or equal to this value meet the criteria defined by the rule. Only applicable for numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>prefix</c>: Matches that start with this value meet the criteria defined by the rule. Only applicable for string values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>suffix</c>: Matches that end with this value meet the criteria defined by the rule. Only applicable for string values.
	/// </para>
	/// </item>
	/// </list>
	/// </summary>
	[JsonInclude, JsonPropertyName("type")]
	public Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaType Type { get; set; }

	/// <summary>
	/// <para>
	/// The values to match against the <c>metadata</c> field.
	/// Only one value must match for the criteria to be met.
	/// It is required for all criteria types except <c>always</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("values")]
	public ICollection<object>? Values { get; set; }
}

public sealed partial class QueryRuleCriteriaDescriptor : SerializableDescriptor<QueryRuleCriteriaDescriptor>
{
	internal QueryRuleCriteriaDescriptor(Action<QueryRuleCriteriaDescriptor> configure) => configure.Invoke(this);

	public QueryRuleCriteriaDescriptor() : base()
	{
	}

	private string? MetadataValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaType TypeValue { get; set; }
	private ICollection<object>? ValuesValue { get; set; }

	/// <summary>
	/// <para>
	/// The metadata field to match against.
	/// This metadata will be used to match against <c>match_criteria</c> sent in the rule.
	/// It is required for all criteria types except <c>always</c>.
	/// </para>
	/// </summary>
	public QueryRuleCriteriaDescriptor Metadata(string? metadata)
	{
		MetadataValue = metadata;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The type of criteria. The following criteria types are supported:
	/// </para>
	/// <list type="bullet">
	/// <item>
	/// <para>
	/// <c>always</c>: Matches all queries, regardless of input.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>contains</c>: Matches that contain this value anywhere in the field meet the criteria defined by the rule. Only applicable for string values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>exact</c>: Only exact matches meet the criteria defined by the rule. Applicable for string or numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>fuzzy</c>: Exact matches or matches within the allowed Levenshtein Edit Distance meet the criteria defined by the rule. Only applicable for string values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>gt</c>: Matches with a value greater than this value meet the criteria defined by the rule. Only applicable for numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>gte</c>: Matches with a value greater than or equal to this value meet the criteria defined by the rule. Only applicable for numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>lt</c>: Matches with a value less than this value meet the criteria defined by the rule. Only applicable for numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>lte</c>: Matches with a value less than or equal to this value meet the criteria defined by the rule. Only applicable for numerical values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>prefix</c>: Matches that start with this value meet the criteria defined by the rule. Only applicable for string values.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// <c>suffix</c>: Matches that end with this value meet the criteria defined by the rule. Only applicable for string values.
	/// </para>
	/// </item>
	/// </list>
	/// </summary>
	public QueryRuleCriteriaDescriptor Type(Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaType type)
	{
		TypeValue = type;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The values to match against the <c>metadata</c> field.
	/// Only one value must match for the criteria to be met.
	/// It is required for all criteria types except <c>always</c>.
	/// </para>
	/// </summary>
	public QueryRuleCriteriaDescriptor Values(ICollection<object>? values)
	{
		ValuesValue = values;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(MetadataValue))
		{
			writer.WritePropertyName("metadata");
			writer.WriteStringValue(MetadataValue);
		}

		writer.WritePropertyName("type");
		JsonSerializer.Serialize(writer, TypeValue, options);
		if (ValuesValue is not null)
		{
			writer.WritePropertyName("values");
			JsonSerializer.Serialize(writer, ValuesValue, options);
		}

		writer.WriteEndObject();
	}
}