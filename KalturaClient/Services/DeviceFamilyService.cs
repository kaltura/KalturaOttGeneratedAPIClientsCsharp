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
	public class DeviceFamilyAddRequestBuilder : RequestBuilder<DeviceFamily>
	{
		#region Constants
		public const string DEVICE_FAMILY = "deviceFamily";
		#endregion

		public DeviceFamily DeviceFamily { get; set; }

		public DeviceFamilyAddRequestBuilder()
			: base("devicefamily", "add")
		{
		}

		public DeviceFamilyAddRequestBuilder(DeviceFamily deviceFamily)
			: this()
		{
			this.DeviceFamily = deviceFamily;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("deviceFamily"))
				kparams.AddIfNotNull("deviceFamily", DeviceFamily);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DeviceFamily>(result);
		}
	}

	public class DeviceFamilyListRequestBuilder : RequestBuilder<ListResponse<DeviceFamily>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DeviceFamilyFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public DeviceFamilyListRequestBuilder()
			: base("devicefamily", "list")
		{
		}

		public DeviceFamilyListRequestBuilder(DeviceFamilyFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DeviceFamily>>(result);
		}
	}

	public class DeviceFamilyUpdateRequestBuilder : RequestBuilder<DeviceFamily>
	{
		#region Constants
		public const string ID = "id";
		public const string DEVICE_FAMILY = "deviceFamily";
		#endregion

		public long Id { get; set; }
		public DeviceFamily DeviceFamily { get; set; }

		public DeviceFamilyUpdateRequestBuilder()
			: base("devicefamily", "update")
		{
		}

		public DeviceFamilyUpdateRequestBuilder(long id, DeviceFamily deviceFamily)
			: this()
		{
			this.Id = id;
			this.DeviceFamily = deviceFamily;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("deviceFamily"))
				kparams.AddIfNotNull("deviceFamily", DeviceFamily);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DeviceFamily>(result);
		}
	}


	public class DeviceFamilyService
	{
		private DeviceFamilyService()
		{
		}

		public static DeviceFamilyAddRequestBuilder Add(DeviceFamily deviceFamily)
		{
			return new DeviceFamilyAddRequestBuilder(deviceFamily);
		}

		public static DeviceFamilyListRequestBuilder List(DeviceFamilyFilter filter = null, FilterPager pager = null)
		{
			return new DeviceFamilyListRequestBuilder(filter, pager);
		}

		public static DeviceFamilyUpdateRequestBuilder Update(long id, DeviceFamily deviceFamily)
		{
			return new DeviceFamilyUpdateRequestBuilder(id, deviceFamily);
		}
	}
}
