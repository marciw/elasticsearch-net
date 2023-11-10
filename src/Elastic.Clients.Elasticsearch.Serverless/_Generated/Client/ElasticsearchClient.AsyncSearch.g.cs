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

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.AsyncSearch;

public partial class AsyncSearchNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AsyncSearchNamespacedClient"/> class for mocking.
	/// </summary>
	protected AsyncSearchNamespacedClient() : base()
	{
	}

	internal AsyncSearchNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AsyncSearchStatusResponse Status(AsyncSearchStatusRequest request)
	{
		request.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequest, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(request);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AsyncSearchStatusResponse> StatusAsync(AsyncSearchStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequest, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AsyncSearchStatusResponse Status(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AsyncSearchStatusResponse Status(AsyncSearchStatusRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AsyncSearchStatusResponse Status(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<AsyncSearchStatusRequestDescriptor> configureRequest)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AsyncSearchStatusResponse Status<TDocument>(AsyncSearchStatusRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AsyncSearchStatusResponse Status<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<AsyncSearchStatusRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AsyncSearchStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AsyncSearchStatusResponse> StatusAsync(AsyncSearchStatusRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AsyncSearchStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<AsyncSearchStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AsyncSearchStatusResponse> StatusAsync<TDocument>(AsyncSearchStatusRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the status of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AsyncSearchStatusResponse> StatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<AsyncSearchStatusRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncSearchResponse Delete(DeleteAsyncSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequest, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(request);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync(DeleteAsyncSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequest, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncSearchResponse Delete(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncSearchResponse Delete(DeleteAsyncSearchRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncSearchResponse Delete(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncSearchRequestDescriptor> configureRequest)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncSearchResponse Delete<TDocument>(DeleteAsyncSearchRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor<TDocument>, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncSearchResponse Delete<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncSearchRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor<TDocument>, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync(DeleteAsyncSearchRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncSearchRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync<TDocument>(DeleteAsyncSearchRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor<TDocument>, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncSearchRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor<TDocument>, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the results of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncSearchResponse<TDocument> Get<TDocument>(GetAsyncSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetAsyncSearchRequest, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(request);
	}

	/// <summary>
	/// <para>Retrieves the results of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(GetAsyncSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequest, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the results of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncSearchResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves the results of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncSearchResponse<TDocument> Get<TDocument>(GetAsyncSearchRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves the results of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncSearchResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncSearchRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves the results of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the results of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(GetAsyncSearchRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves the results of a previously submitted async search request given its ID.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncSearchRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a search request asynchronously.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual SubmitAsyncSearchResponse<TDocument> Submit<TDocument>(SubmitAsyncSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<SubmitAsyncSearchRequest, SubmitAsyncSearchResponse<TDocument>, SubmitAsyncSearchRequestParameters>(request);
	}

	/// <summary>
	/// <para>Executes a search request asynchronously.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SubmitAsyncSearchResponse<TDocument>> SubmitAsync<TDocument>(SubmitAsyncSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<SubmitAsyncSearchRequest, SubmitAsyncSearchResponse<TDocument>, SubmitAsyncSearchRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a search request asynchronously.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual SubmitAsyncSearchResponse<TDocument> Submit<TDocument>()
	{
		var descriptor = new SubmitAsyncSearchRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequest<SubmitAsyncSearchRequestDescriptor<TDocument>, SubmitAsyncSearchResponse<TDocument>, SubmitAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Executes a search request asynchronously.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual SubmitAsyncSearchResponse<TDocument> Submit<TDocument>(SubmitAsyncSearchRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<SubmitAsyncSearchRequestDescriptor<TDocument>, SubmitAsyncSearchResponse<TDocument>, SubmitAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Executes a search request asynchronously.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual SubmitAsyncSearchResponse<TDocument> Submit<TDocument>(Action<SubmitAsyncSearchRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new SubmitAsyncSearchRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<SubmitAsyncSearchRequestDescriptor<TDocument>, SubmitAsyncSearchResponse<TDocument>, SubmitAsyncSearchRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Executes a search request asynchronously.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SubmitAsyncSearchResponse<TDocument>> SubmitAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new SubmitAsyncSearchRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<SubmitAsyncSearchRequestDescriptor<TDocument>, SubmitAsyncSearchResponse<TDocument>, SubmitAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a search request asynchronously.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SubmitAsyncSearchResponse<TDocument>> SubmitAsync<TDocument>(SubmitAsyncSearchRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<SubmitAsyncSearchRequestDescriptor<TDocument>, SubmitAsyncSearchResponse<TDocument>, SubmitAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a search request asynchronously.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.10/async-search.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SubmitAsyncSearchResponse<TDocument>> SubmitAsync<TDocument>(Action<SubmitAsyncSearchRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new SubmitAsyncSearchRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<SubmitAsyncSearchRequestDescriptor<TDocument>, SubmitAsyncSearchResponse<TDocument>, SubmitAsyncSearchRequestParameters>(descriptor, cancellationToken);
	}
}