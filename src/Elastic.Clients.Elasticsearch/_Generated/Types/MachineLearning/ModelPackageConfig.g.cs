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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class ModelPackageConfig
{
	[JsonInclude, JsonPropertyName("create_time")]
	public long? CreateTime { get; init; }
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; init; }
	[JsonInclude, JsonPropertyName("inference_config")]
	public IReadOnlyDictionary<string, object>? InferenceConfig { get; init; }
	[JsonInclude, JsonPropertyName("metadata")]
	public IReadOnlyDictionary<string, object>? Metadata { get; init; }
	[JsonInclude, JsonPropertyName("minimum_version")]
	public string? MinimumVersion { get; init; }
	[JsonInclude, JsonPropertyName("model_repository")]
	public string? ModelRepository { get; init; }
	[JsonInclude, JsonPropertyName("model_type")]
	public string? ModelType { get; init; }
	[JsonInclude, JsonPropertyName("packaged_model_id")]
	public string PackagedModelId { get; init; }
	[JsonInclude, JsonPropertyName("platform_architecture")]
	public string? PlatformArchitecture { get; init; }
	[JsonInclude, JsonPropertyName("prefix_strings")]
	public Elastic.Clients.Elasticsearch.MachineLearning.TrainedModelPrefixStrings? PrefixStrings { get; init; }
	[JsonInclude, JsonPropertyName("sha256")]
	public string? Sha256 { get; init; }
	[JsonInclude, JsonPropertyName("size")]
	public Elastic.Clients.Elasticsearch.ByteSize? Size { get; init; }
	[JsonInclude, JsonPropertyName("tags")]
	public IReadOnlyCollection<string>? Tags { get; init; }
	[JsonInclude, JsonPropertyName("vocabulary_file")]
	public string? VocabularyFile { get; init; }
}