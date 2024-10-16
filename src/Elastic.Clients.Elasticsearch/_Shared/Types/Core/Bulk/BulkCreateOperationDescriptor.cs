// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
#if ELASTICSEARCH_SERVERLESS
using Elastic.Clients.Elasticsearch.Serverless.Fluent;
#else
using Elastic.Clients.Elasticsearch.Fluent;
#endif
#if ELASTICSEARCH_SERVERLESS
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
#else
using Elastic.Clients.Elasticsearch.Serialization;
#endif
using Elastic.Transport;
using Elastic.Transport.Extensions;

#if ELASTICSEARCH_SERVERLESS
namespace Elastic.Clients.Elasticsearch.Serverless.Core.Bulk;
#else
namespace Elastic.Clients.Elasticsearch.Core.Bulk;
#endif

public sealed class BulkCreateOperationDescriptor<TSource> : BulkOperationDescriptor<BulkCreateOperationDescriptor<TSource>>
{
	private string _pipeline;
	private Dictionary<string, string> _dynamicTemplates;

	private static byte _newline => (byte)'\n';

	private readonly TSource _document;

	public BulkCreateOperationDescriptor(TSource source) => _document = source;

	public BulkCreateOperationDescriptor(TSource source, IndexName index) : this(source) => IndexNameValue = index;

	public BulkCreateOperationDescriptor<TSource> Pipeline(string pipeline) => Assign(pipeline, (a, v) => a._pipeline = v);

	public BulkCreateOperationDescriptor<TSource> DynamicTemplates(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector) => Assign(selector, (a, v) => a._dynamicTemplates = v?.Invoke(new FluentDictionary<string, string>()));

	protected override string Operation => "create";

	protected override Type ClrType => typeof(TSource);

	protected override void Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		var requestResponseSerializer = settings.RequestResponseSerializer;
		var internalWriter = new Utf8JsonWriter(stream);
		internalWriter.WriteStartObject();
		internalWriter.WritePropertyName(Operation);
		requestResponseSerializer.Serialize(this, internalWriter, settings.MemoryStreamFactory, formatting);
		internalWriter.WriteEndObject();
		internalWriter.Flush();
		stream.WriteByte(_newline);
		settings.SourceSerializer.Serialize(GetBody(), stream, formatting);
	}

	protected override async Task SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting, CancellationToken cancellationToken = default)
	{
		var requestResponseSerializer = settings.RequestResponseSerializer;
		var internalWriter = new Utf8JsonWriter(stream);
		internalWriter.WriteStartObject();
		internalWriter.WritePropertyName(Operation);
		requestResponseSerializer.Serialize(this, internalWriter, settings.MemoryStreamFactory, formatting);
		internalWriter.WriteEndObject();
		await internalWriter.FlushAsync(cancellationToken).ConfigureAwait(false);
		stream.WriteByte(_newline);
		await settings.SourceSerializer.SerializeAsync(GetBody(), stream, formatting, cancellationToken).ConfigureAwait(false);
	}

	protected override void SerializeInternal(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!string.IsNullOrEmpty(_pipeline))
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, _pipeline, options);
		}

		if (_dynamicTemplates is not null)
		{
			writer.WritePropertyName("dynamic_templates");
			JsonSerializer.Serialize(writer, _dynamicTemplates, options);
		}
	}

	protected override object GetBody() => _document;
}