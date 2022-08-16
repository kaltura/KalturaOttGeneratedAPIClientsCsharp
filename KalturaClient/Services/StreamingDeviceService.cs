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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class StreamingDeviceBookPlaybackSessionRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string FILE_ID = "fileId";
		public const string ASSET_ID = "assetId";
		public const string ASSET_TYPE = "assetType";
		#endregion

		public string FileId { get; set; }
		public string AssetId { get; set; }
		public AssetType AssetType { get; set; }

		public StreamingDeviceBookPlaybackSessionRequestBuilder()
			: base("streamingdevice", "bookPlaybackSession")
		{
		}

		public StreamingDeviceBookPlaybackSessionRequestBuilder(string fileId, string assetId, AssetType assetType)
			: this()
		{
			this.FileId = fileId;
			this.AssetId = assetId;
			this.AssetType = assetType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("fileId"))
				kparams.AddIfNotNull("fileId", FileId);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("assetType"))
				kparams.AddIfNotNull("assetType", AssetType);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class StreamingDeviceListRequestBuilder : RequestBuilder<ListResponse<StreamingDevice>>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public StreamingDeviceFilter Filter { get; set; }

		public StreamingDeviceListRequestBuilder()
			: base("streamingdevice", "list")
		{
		}

		public StreamingDeviceListRequestBuilder(StreamingDeviceFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<StreamingDevice>>(result);
		}
	}


	public class StreamingDeviceService
	{
		private StreamingDeviceService()
		{
		}

		public static StreamingDeviceBookPlaybackSessionRequestBuilder BookPlaybackSession(string fileId, string assetId, AssetType assetType)
		{
			return new StreamingDeviceBookPlaybackSessionRequestBuilder(fileId, assetId, assetType);
		}

		public static StreamingDeviceListRequestBuilder List(StreamingDeviceFilter filter = null)
		{
			return new StreamingDeviceListRequestBuilder(filter);
		}
	}
}
