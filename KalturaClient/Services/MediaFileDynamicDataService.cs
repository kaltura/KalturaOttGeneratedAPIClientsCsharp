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
	public class MediaFileDynamicDataAddRequestBuilder : RequestBuilder<MediaFileDynamicData>
	{
		#region Constants
		public const string DYNAMIC_DATA = "dynamicData";
		#endregion

		public MediaFileDynamicData DynamicData { get; set; }

		public MediaFileDynamicDataAddRequestBuilder()
			: base("mediafiledynamicdata", "add")
		{
		}

		public MediaFileDynamicDataAddRequestBuilder(MediaFileDynamicData dynamicData)
			: this()
		{
			this.DynamicData = dynamicData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dynamicData"))
				kparams.AddIfNotNull("dynamicData", DynamicData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<MediaFileDynamicData>(result);
		}
	}

	public class MediaFileDynamicDataDeleteRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public MediaFileDynamicDataDeleteRequestBuilder()
			: base("mediafiledynamicdata", "delete")
		{
		}

		public MediaFileDynamicDataDeleteRequestBuilder(long id)
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
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class MediaFileDynamicDataListRequestBuilder : RequestBuilder<ListResponse<MediaFileDynamicData>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public MediaFileDynamicDataFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public MediaFileDynamicDataListRequestBuilder()
			: base("mediafiledynamicdata", "list")
		{
		}

		public MediaFileDynamicDataListRequestBuilder(MediaFileDynamicDataFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<MediaFileDynamicData>>(result);
		}
	}

	public class MediaFileDynamicDataUpdateRequestBuilder : RequestBuilder<MediaFileDynamicData>
	{
		#region Constants
		public const string ID = "id";
		public const string DYNAMIC_DATA = "dynamicData";
		#endregion

		public long Id { get; set; }
		public MediaFileDynamicData DynamicData { get; set; }

		public MediaFileDynamicDataUpdateRequestBuilder()
			: base("mediafiledynamicdata", "update")
		{
		}

		public MediaFileDynamicDataUpdateRequestBuilder(long id, MediaFileDynamicData dynamicData)
			: this()
		{
			this.Id = id;
			this.DynamicData = dynamicData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("dynamicData"))
				kparams.AddIfNotNull("dynamicData", DynamicData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<MediaFileDynamicData>(result);
		}
	}


	public class MediaFileDynamicDataService
	{
		private MediaFileDynamicDataService()
		{
		}

		public static MediaFileDynamicDataAddRequestBuilder Add(MediaFileDynamicData dynamicData)
		{
			return new MediaFileDynamicDataAddRequestBuilder(dynamicData);
		}

		public static MediaFileDynamicDataDeleteRequestBuilder Delete(long id)
		{
			return new MediaFileDynamicDataDeleteRequestBuilder(id);
		}

		public static MediaFileDynamicDataListRequestBuilder List(MediaFileDynamicDataFilter filter = null, FilterPager pager = null)
		{
			return new MediaFileDynamicDataListRequestBuilder(filter, pager);
		}

		public static MediaFileDynamicDataUpdateRequestBuilder Update(long id, MediaFileDynamicData dynamicData)
		{
			return new MediaFileDynamicDataUpdateRequestBuilder(id, dynamicData);
		}
	}
}
