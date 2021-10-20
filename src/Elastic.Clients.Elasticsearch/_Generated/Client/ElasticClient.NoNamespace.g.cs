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

using Elastic.Clients.Elasticsearch.Cluster;
using Elastic.Clients.Elasticsearch.IndexManagement;
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial class ElasticClient : IElasticClient
	{
		public ClusterNamespace Cluster { get; private set; }

		public IndexManagementNamespace IndexManagement { get; private set; }

		private partial void SetupNamespaces()
		{
			Cluster = new ClusterNamespace(this);
			IndexManagement = new IndexManagementNamespace(this);
		}

		public PingResponse Ping(IPingRequest request) => DoRequest<IPingRequest, PingResponse>(request, request.RequestParameters);
		public Task<PingResponse> PingAsync(IPingRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IPingRequest, PingResponse>(request, request.RequestParameters, cancellationToken);
		public PingResponse Ping(Func<PingRequestDescriptor, IPingRequest> selector = null) => Ping(selector.InvokeOrDefault(new PingRequestDescriptor()));
		public Task<PingResponse> PingAsync(Func<PingRequestDescriptor, IPingRequest> selector = null, CancellationToken cancellationToken = default) => PingAsync(selector.InvokeOrDefault(new PingRequestDescriptor()), cancellationToken);
	}
}