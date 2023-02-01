// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class RecordingAddRequestBuilder : RequestBuilder<Recording>
	{
		#region Constants
		public const string RECORDING = "recording";
		#endregion

		public Recording Recording { get; set; }

		public RecordingAddRequestBuilder()
			: base("recording", "add")
		{
		}

		public RecordingAddRequestBuilder(Recording recording)
			: this()
		{
			this.Recording = recording;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("recording"))
				kparams.AddIfNotNull("recording", Recording);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Recording>(result);
		}
	}

	public class RecordingBulkdeleteRequestBuilder : RequestBuilder<IList<ActionResult>>
	{
		#region Constants
		public const string RECORDING_IDS = "recordingIds";
		#endregion

		public string RecordingIds { get; set; }

		public RecordingBulkdeleteRequestBuilder()
			: base("recording", "bulkdelete")
		{
		}

		public RecordingBulkdeleteRequestBuilder(string recordingIds)
			: this()
		{
			this.RecordingIds = recordingIds;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("recordingIds"))
				kparams.AddIfNotNull("recordingIds", RecordingIds);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<ActionResult> list = new List<ActionResult>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<ActionResult>(node));
			}
			return list;
		}
	}

	public class RecordingCancelRequestBuilder : RequestBuilder<Recording>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public RecordingCancelRequestBuilder()
			: base("recording", "cancel")
		{
		}

		public RecordingCancelRequestBuilder(long id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Recording>(result);
		}
	}

	public class RecordingDeleteRequestBuilder : RequestBuilder<Recording>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public RecordingDeleteRequestBuilder()
			: base("recording", "delete")
		{
		}

		public RecordingDeleteRequestBuilder(long id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Recording>(result);
		}
	}

	public class RecordingGetRequestBuilder : RequestBuilder<Recording>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public RecordingGetRequestBuilder()
			: base("recording", "get")
		{
		}

		public RecordingGetRequestBuilder(long id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Recording>(result);
		}
	}

	public class RecordingImmediateRecordRequestBuilder : RequestBuilder<ImmediateRecording>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string EPG_CHANNEL_ID = "epgChannelId";
		public const string END_PADDING = "endPadding";
		#endregion

		public long AssetId { get; set; }
		public long EpgChannelId { get; set; }
		public int EndPadding { get; set; }

		public RecordingImmediateRecordRequestBuilder()
			: base("recording", "immediateRecord")
		{
		}

		public RecordingImmediateRecordRequestBuilder(long assetId, long epgChannelId, int endPadding)
			: this()
		{
			this.AssetId = assetId;
			this.EpgChannelId = epgChannelId;
			this.EndPadding = endPadding;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("epgChannelId"))
				kparams.AddIfNotNull("epgChannelId", EpgChannelId);
			if (!isMapped("endPadding"))
				kparams.AddIfNotNull("endPadding", EndPadding);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ImmediateRecording>(result);
		}
	}

	public class RecordingListRequestBuilder : RequestBuilder<ListResponse<Recording>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public RecordingFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public RecordingListRequestBuilder()
			: base("recording", "list")
		{
		}

		public RecordingListRequestBuilder(RecordingFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<Recording>>(result);
		}
	}

	public class RecordingProtectRequestBuilder : RequestBuilder<Recording>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public RecordingProtectRequestBuilder()
			: base("recording", "protect")
		{
		}

		public RecordingProtectRequestBuilder(long id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Recording>(result);
		}
	}

	public class RecordingStopRequestBuilder : RequestBuilder<Recording>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string EPG_CHANNEL_ID = "epgChannelId";
		public const string HOUSEHOLD_RECORDING_ID = "householdRecordingId";
		#endregion

		public long AssetId { get; set; }
		public long EpgChannelId { get; set; }
		public long HouseholdRecordingId { get; set; }

		public RecordingStopRequestBuilder()
			: base("recording", "stop")
		{
		}

		public RecordingStopRequestBuilder(long assetId, long epgChannelId, long householdRecordingId)
			: this()
		{
			this.AssetId = assetId;
			this.EpgChannelId = epgChannelId;
			this.HouseholdRecordingId = householdRecordingId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("epgChannelId"))
				kparams.AddIfNotNull("epgChannelId", EpgChannelId);
			if (!isMapped("householdRecordingId"))
				kparams.AddIfNotNull("householdRecordingId", HouseholdRecordingId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Recording>(result);
		}
	}

	public class RecordingUpdateRequestBuilder : RequestBuilder<Recording>
	{
		#region Constants
		public const string ID = "id";
		public const string RECORDING = "recording";
		#endregion

		public long Id { get; set; }
		public Recording Recording { get; set; }

		public RecordingUpdateRequestBuilder()
			: base("recording", "update")
		{
		}

		public RecordingUpdateRequestBuilder(long id, Recording recording)
			: this()
		{
			this.Id = id;
			this.Recording = recording;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("recording"))
				kparams.AddIfNotNull("recording", Recording);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Recording>(result);
		}
	}


	public class RecordingService
	{
		private RecordingService()
		{
		}

		public static RecordingAddRequestBuilder Add(Recording recording)
		{
			return new RecordingAddRequestBuilder(recording);
		}

		public static RecordingBulkdeleteRequestBuilder Bulkdelete(string recordingIds)
		{
			return new RecordingBulkdeleteRequestBuilder(recordingIds);
		}

		public static RecordingCancelRequestBuilder Cancel(long id)
		{
			return new RecordingCancelRequestBuilder(id);
		}

		public static RecordingDeleteRequestBuilder Delete(long id)
		{
			return new RecordingDeleteRequestBuilder(id);
		}

		public static RecordingGetRequestBuilder Get(long id)
		{
			return new RecordingGetRequestBuilder(id);
		}

		public static RecordingImmediateRecordRequestBuilder ImmediateRecord(long assetId, long epgChannelId, int endPadding = Int32.MinValue)
		{
			return new RecordingImmediateRecordRequestBuilder(assetId, epgChannelId, endPadding);
		}

		public static RecordingListRequestBuilder List(RecordingFilter filter = null, FilterPager pager = null)
		{
			return new RecordingListRequestBuilder(filter, pager);
		}

		public static RecordingProtectRequestBuilder Protect(long id)
		{
			return new RecordingProtectRequestBuilder(id);
		}

		public static RecordingStopRequestBuilder Stop(long assetId, long epgChannelId, long householdRecordingId)
		{
			return new RecordingStopRequestBuilder(assetId, epgChannelId, householdRecordingId);
		}

		public static RecordingUpdateRequestBuilder Update(long id, Recording recording)
		{
			return new RecordingUpdateRequestBuilder(id, recording);
		}
	}
}
