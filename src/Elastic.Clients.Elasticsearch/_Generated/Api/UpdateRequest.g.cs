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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class UpdateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Only perform the operation if the document has this primary term.
	/// </para>
	/// </summary>
	public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

	/// <summary>
	/// <para>
	/// Only perform the operation if the document has this sequence number.
	/// </para>
	/// </summary>
	public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

	/// <summary>
	/// <para>
	/// The script language.
	/// </para>
	/// </summary>
	public string? Lang { get => Q<string?>("lang"); set => Q("lang", value); }

	/// <summary>
	/// <para>
	/// If 'true', Elasticsearch refreshes the affected shards to make this operation visible to search.
	/// If 'wait_for', it waits for a refresh to make this operation visible to search.
	/// If 'false', it does nothing with refreshes.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the destination must be an index alias.
	/// </para>
	/// </summary>
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }

	/// <summary>
	/// <para>
	/// The number of times the operation should be retried when a conflict occurs.
	/// </para>
	/// </summary>
	public int? RetryOnConflict { get => Q<int?>("retry_on_conflict"); set => Q("retry_on_conflict", value); }

	/// <summary>
	/// <para>
	/// A custom value used to route operations to a specific shard.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// The source fields you want to exclude.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>
	/// The source fields you want to retrieve.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>
	/// The period to wait for the following operations: dynamic mapping updates and waiting for active shards.
	/// Elasticsearch waits for at least the timeout period before failing.
	/// The actual wait time could be longer, particularly when multiple waits occur.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// The number of copies of each shard that must be active before proceeding with the operation.
	/// Set to 'all' or any positive integer up to the total number of shards in the index (<c>number_of_replicas</c>+1).
	/// The default value of <c>1</c> means it waits for each primary shard to be active.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
}

/// <summary>
/// <para>
/// Update a document.
/// </para>
/// <para>
/// Update a document by running a script or passing a partial document.
/// </para>
/// <para>
/// If the Elasticsearch security features are enabled, you must have the <c>index</c> or <c>write</c> index privilege for the target index or index alias.
/// </para>
/// <para>
/// The script can update, delete, or skip modifying the document.
/// The API also supports passing a partial document, which is merged into the existing document.
/// To fully replace an existing document, use the index API.
/// This operation:
/// </para>
/// <list type="bullet">
/// <item>
/// <para>
/// Gets the document (collocated with the shard) from the index.
/// </para>
/// </item>
/// <item>
/// <para>
/// Runs the specified script.
/// </para>
/// </item>
/// <item>
/// <para>
/// Indexes the result.
/// </para>
/// </item>
/// </list>
/// <para>
/// The document must still be reindexed, but using this API removes some network roundtrips and reduces chances of version conflicts between the GET and the index operation.
/// </para>
/// <para>
/// The <c>_source</c> field must be enabled to use this API.
/// In addition to <c>_source</c>, you can access the following variables through the <c>ctx</c> map: <c>_index</c>, <c>_type</c>, <c>_id</c>, <c>_version</c>, <c>_routing</c>, and <c>_now</c> (the current timestamp).
/// </para>
/// </summary>
public sealed partial class UpdateRequest<TDocument, TPartialDocument> : PlainRequest<UpdateRequestParameters>
{
	public UpdateRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceUpdate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "update";

	/// <summary>
	/// <para>
	/// Only perform the operation if the document has this primary term.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

	/// <summary>
	/// <para>
	/// Only perform the operation if the document has this sequence number.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

	/// <summary>
	/// <para>
	/// The script language.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? Lang { get => Q<string?>("lang"); set => Q("lang", value); }

	/// <summary>
	/// <para>
	/// If 'true', Elasticsearch refreshes the affected shards to make this operation visible to search.
	/// If 'wait_for', it waits for a refresh to make this operation visible to search.
	/// If 'false', it does nothing with refreshes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the destination must be an index alias.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }

	/// <summary>
	/// <para>
	/// The number of times the operation should be retried when a conflict occurs.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? RetryOnConflict { get => Q<int?>("retry_on_conflict"); set => Q("retry_on_conflict", value); }

	/// <summary>
	/// <para>
	/// A custom value used to route operations to a specific shard.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// The source fields you want to exclude.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>
	/// The source fields you want to retrieve.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>
	/// The period to wait for the following operations: dynamic mapping updates and waiting for active shards.
	/// Elasticsearch waits for at least the timeout period before failing.
	/// The actual wait time could be longer, particularly when multiple waits occur.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// The number of copies of each shard that must be active before proceeding with the operation.
	/// Set to 'all' or any positive integer up to the total number of shards in the index (<c>number_of_replicas</c>+1).
	/// The default value of <c>1</c> means it waits for each primary shard to be active.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the <c>result</c> in the response is set to <c>noop</c> (no operation) when there are no changes to the document.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("detect_noop")]
	public bool? DetectNoop { get; set; }

	/// <summary>
	/// <para>
	/// A partial update to an existing document.
	/// If both <c>doc</c> and <c>script</c> are specified, <c>doc</c> is ignored.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("doc")]
	[SourceConverter]
	public TPartialDocument? Doc { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, use the contents of 'doc' as the value of 'upsert'.
	/// NOTE: Using ingest pipelines with <c>doc_as_upsert</c> is not supported.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("doc_as_upsert")]
	public bool? DocAsUpsert { get; set; }

	/// <summary>
	/// <para>
	/// The script to run to update the document.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, run the script whether or not the document exists.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("scripted_upsert")]
	public bool? ScriptedUpsert { get; set; }

	/// <summary>
	/// <para>
	/// If <c>false</c>, turn off source retrieval.
	/// You can also specify a comma-separated list of the fields you want to retrieve.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_source")]
	public Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? Source { get; set; }

	/// <summary>
	/// <para>
	/// If the document does not already exist, the contents of 'upsert' are inserted as a new document.
	/// If the document exists, the 'script' is run.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("upsert")]
	[SourceConverter]
	public TDocument? Upsert { get; set; }
}

/// <summary>
/// <para>
/// Update a document.
/// </para>
/// <para>
/// Update a document by running a script or passing a partial document.
/// </para>
/// <para>
/// If the Elasticsearch security features are enabled, you must have the <c>index</c> or <c>write</c> index privilege for the target index or index alias.
/// </para>
/// <para>
/// The script can update, delete, or skip modifying the document.
/// The API also supports passing a partial document, which is merged into the existing document.
/// To fully replace an existing document, use the index API.
/// This operation:
/// </para>
/// <list type="bullet">
/// <item>
/// <para>
/// Gets the document (collocated with the shard) from the index.
/// </para>
/// </item>
/// <item>
/// <para>
/// Runs the specified script.
/// </para>
/// </item>
/// <item>
/// <para>
/// Indexes the result.
/// </para>
/// </item>
/// </list>
/// <para>
/// The document must still be reindexed, but using this API removes some network roundtrips and reduces chances of version conflicts between the GET and the index operation.
/// </para>
/// <para>
/// The <c>_source</c> field must be enabled to use this API.
/// In addition to <c>_source</c>, you can access the following variables through the <c>ctx</c> map: <c>_index</c>, <c>_type</c>, <c>_id</c>, <c>_version</c>, <c>_routing</c>, and <c>_now</c> (the current timestamp).
/// </para>
/// </summary>
public sealed partial class UpdateRequestDescriptor<TDocument, TPartialDocument> : RequestDescriptor<UpdateRequestDescriptor<TDocument, TPartialDocument>, UpdateRequestParameters>
{
	internal UpdateRequestDescriptor(Action<UpdateRequestDescriptor<TDocument, TPartialDocument>> configure) => configure.Invoke(this);

	public UpdateRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	public UpdateRequestDescriptor(TDocument document) : this(typeof(TDocument), Elastic.Clients.Elasticsearch.Id.From(document))
	{
	}

	public UpdateRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.IndexName index) : this(index, Elastic.Clients.Elasticsearch.Id.From(document))
	{
	}

	public UpdateRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.Id id) : this(typeof(TDocument), id)
	{
	}

	public UpdateRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : this(typeof(TDocument), id)
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceUpdate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "update";

	public UpdateRequestDescriptor<TDocument, TPartialDocument> IfPrimaryTerm(long? ifPrimaryTerm) => Qs("if_primary_term", ifPrimaryTerm);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> IfSeqNo(long? ifSeqNo) => Qs("if_seq_no", ifSeqNo);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Lang(string? lang) => Qs("lang", lang);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> RequireAlias(bool? requireAlias = true) => Qs("require_alias", requireAlias);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> RetryOnConflict(int? retryOnConflict) => Qs("retry_on_conflict", retryOnConflict);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public UpdateRequestDescriptor<TDocument, TPartialDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);

	public UpdateRequestDescriptor<TDocument, TPartialDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public UpdateRequestDescriptor<TDocument, TPartialDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	private bool? DetectNoopValue { get; set; }
	private TPartialDocument? DocValue { get; set; }
	private bool? DocAsUpsertValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private bool? ScriptedUpsertValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? SourceValue { get; set; }
	private TDocument? UpsertValue { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the <c>result</c> in the response is set to <c>noop</c> (no operation) when there are no changes to the document.
	/// </para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> DetectNoop(bool? detectNoop = true)
	{
		DetectNoopValue = detectNoop;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A partial update to an existing document.
	/// If both <c>doc</c> and <c>script</c> are specified, <c>doc</c> is ignored.
	/// </para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Doc(TPartialDocument? doc)
	{
		DocValue = doc;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, use the contents of 'doc' as the value of 'upsert'.
	/// NOTE: Using ingest pipelines with <c>doc_as_upsert</c> is not supported.
	/// </para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> DocAsUpsert(bool? docAsUpsert = true)
	{
		DocAsUpsertValue = docAsUpsert;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The script to run to update the document.
	/// </para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public UpdateRequestDescriptor<TDocument, TPartialDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public UpdateRequestDescriptor<TDocument, TPartialDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, run the script whether or not the document exists.
	/// </para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> ScriptedUpsert(bool? scriptedUpsert = true)
	{
		ScriptedUpsertValue = scriptedUpsert;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>false</c>, turn off source retrieval.
	/// You can also specify a comma-separated list of the fields you want to retrieve.
	/// </para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Source(Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? source)
	{
		SourceValue = source;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If the document does not already exist, the contents of 'upsert' are inserted as a new document.
	/// If the document exists, the 'script' is run.
	/// </para>
	/// </summary>
	public UpdateRequestDescriptor<TDocument, TPartialDocument> Upsert(TDocument? upsert)
	{
		UpsertValue = upsert;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DetectNoopValue.HasValue)
		{
			writer.WritePropertyName("detect_noop");
			writer.WriteBooleanValue(DetectNoopValue.Value);
		}

		if (DocValue is not null)
		{
			writer.WritePropertyName("doc");
			settings.SourceSerializer.Serialize(DocValue, writer);
		}

		if (DocAsUpsertValue.HasValue)
		{
			writer.WritePropertyName("doc_as_upsert");
			writer.WriteBooleanValue(DocAsUpsertValue.Value);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (ScriptedUpsertValue.HasValue)
		{
			writer.WritePropertyName("scripted_upsert");
			writer.WriteBooleanValue(ScriptedUpsertValue.Value);
		}

		if (SourceValue is not null)
		{
			writer.WritePropertyName("_source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (UpsertValue is not null)
		{
			writer.WritePropertyName("upsert");
			settings.SourceSerializer.Serialize(UpsertValue, writer);
		}

		writer.WriteEndObject();
	}
}