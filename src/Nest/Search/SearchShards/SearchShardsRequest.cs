﻿using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace Nest
{
	public partial interface ISearchShardsRequest { }
	public partial interface ISearchShardsRequest<T> : ISearchShardsRequest { }

	public partial class SearchShardsRequest { }
	public partial class SearchShardsRequest<T> where T : class { }

	/// <summary>
	/// A descriptor wich describes a search operation for _search_shards
	/// </summary>
	public partial class SearchShardsDescriptor<T> where T : class { }
}
