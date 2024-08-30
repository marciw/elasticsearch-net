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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class DeleteCalendarRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Delete a calendar.
/// Removes all scheduled events from a calendar, then deletes it.
/// </para>
/// </summary>
public sealed partial class DeleteCalendarRequest : PlainRequest<DeleteCalendarRequestParameters>
{
	public DeleteCalendarRequest(Elastic.Clients.Elasticsearch.Serverless.Id calendarId) : base(r => r.Required("calendar_id", calendarId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteCalendar;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_calendar";
}

/// <summary>
/// <para>
/// Delete a calendar.
/// Removes all scheduled events from a calendar, then deletes it.
/// </para>
/// </summary>
public sealed partial class DeleteCalendarRequestDescriptor : RequestDescriptor<DeleteCalendarRequestDescriptor, DeleteCalendarRequestParameters>
{
	internal DeleteCalendarRequestDescriptor(Action<DeleteCalendarRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteCalendarRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id calendarId) : base(r => r.Required("calendar_id", calendarId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteCalendar;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_calendar";

	public DeleteCalendarRequestDescriptor CalendarId(Elastic.Clients.Elasticsearch.Serverless.Id calendarId)
	{
		RouteValues.Required("calendar_id", calendarId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}