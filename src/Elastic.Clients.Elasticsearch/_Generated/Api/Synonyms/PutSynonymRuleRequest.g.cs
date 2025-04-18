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

namespace Elastic.Clients.Elasticsearch.Synonyms;

public sealed partial class PutSynonymRuleRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Create or update a synonym rule.
/// Create or update a synonym rule in a synonym set.
/// </para>
/// <para>
/// If any of the synonym rules included is invalid, the API returns an error.
/// </para>
/// <para>
/// When you update a synonym rule, all analyzers using the synonyms set will be reloaded automatically to reflect the new rule.
/// </para>
/// </summary>
public sealed partial class PutSynonymRuleRequest : PlainRequest<PutSynonymRuleRequestParameters>
{
	public PutSynonymRuleRequest(Elastic.Clients.Elasticsearch.Id setId, Elastic.Clients.Elasticsearch.Id ruleId) : base(r => r.Required("set_id", setId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsPutSynonymRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "synonyms.put_synonym_rule";

	/// <summary>
	/// <para>
	/// The synonym rule information definition, which must be in Solr format.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("synonyms")]
	public string Synonyms { get; set; }
}

/// <summary>
/// <para>
/// Create or update a synonym rule.
/// Create or update a synonym rule in a synonym set.
/// </para>
/// <para>
/// If any of the synonym rules included is invalid, the API returns an error.
/// </para>
/// <para>
/// When you update a synonym rule, all analyzers using the synonyms set will be reloaded automatically to reflect the new rule.
/// </para>
/// </summary>
public sealed partial class PutSynonymRuleRequestDescriptor : RequestDescriptor<PutSynonymRuleRequestDescriptor, PutSynonymRuleRequestParameters>
{
	internal PutSynonymRuleRequestDescriptor(Action<PutSynonymRuleRequestDescriptor> configure) => configure.Invoke(this);

	public PutSynonymRuleRequestDescriptor(Elastic.Clients.Elasticsearch.Id setId, Elastic.Clients.Elasticsearch.Id ruleId) : base(r => r.Required("set_id", setId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsPutSynonymRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "synonyms.put_synonym_rule";

	public PutSynonymRuleRequestDescriptor RuleId(Elastic.Clients.Elasticsearch.Id ruleId)
	{
		RouteValues.Required("rule_id", ruleId);
		return Self;
	}

	public PutSynonymRuleRequestDescriptor SetId(Elastic.Clients.Elasticsearch.Id setId)
	{
		RouteValues.Required("set_id", setId);
		return Self;
	}

	private string SynonymsValue { get; set; }

	/// <summary>
	/// <para>
	/// The synonym rule information definition, which must be in Solr format.
	/// </para>
	/// </summary>
	public PutSynonymRuleRequestDescriptor Synonyms(string synonyms)
	{
		SynonymsValue = synonyms;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("synonyms");
		writer.WriteStringValue(SynonymsValue);
		writer.WriteEndObject();
	}
}