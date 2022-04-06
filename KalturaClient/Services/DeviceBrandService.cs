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
	public class DeviceBrandAddRequestBuilder : RequestBuilder<DeviceBrand>
	{
		#region Constants
		public const string DEVICE_BRAND = "deviceBrand";
		#endregion

		public DeviceBrand DeviceBrand { get; set; }

		public DeviceBrandAddRequestBuilder()
			: base("devicebrand", "add")
		{
		}

		public DeviceBrandAddRequestBuilder(DeviceBrand deviceBrand)
			: this()
		{
			this.DeviceBrand = deviceBrand;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("deviceBrand"))
				kparams.AddIfNotNull("deviceBrand", DeviceBrand);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DeviceBrand>(result);
		}
	}

	public class DeviceBrandListRequestBuilder : RequestBuilder<ListResponse<DeviceBrand>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DeviceBrandFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public DeviceBrandListRequestBuilder()
			: base("devicebrand", "list")
		{
		}

		public DeviceBrandListRequestBuilder(DeviceBrandFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DeviceBrand>>(result);
		}
	}

	public class DeviceBrandUpdateRequestBuilder : RequestBuilder<DeviceBrand>
	{
		#region Constants
		public const string ID = "id";
		public const string DEVICE_BRAND = "deviceBrand";
		#endregion

		public long Id { get; set; }
		public DeviceBrand DeviceBrand { get; set; }

		public DeviceBrandUpdateRequestBuilder()
			: base("devicebrand", "update")
		{
		}

		public DeviceBrandUpdateRequestBuilder(long id, DeviceBrand deviceBrand)
			: this()
		{
			this.Id = id;
			this.DeviceBrand = deviceBrand;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("deviceBrand"))
				kparams.AddIfNotNull("deviceBrand", DeviceBrand);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DeviceBrand>(result);
		}
	}


	public class DeviceBrandService
	{
		private DeviceBrandService()
		{
		}

		public static DeviceBrandAddRequestBuilder Add(DeviceBrand deviceBrand)
		{
			return new DeviceBrandAddRequestBuilder(deviceBrand);
		}

		public static DeviceBrandListRequestBuilder List(DeviceBrandFilter filter = null, FilterPager pager = null)
		{
			return new DeviceBrandListRequestBuilder(filter, pager);
		}

		public static DeviceBrandUpdateRequestBuilder Update(long id, DeviceBrand deviceBrand)
		{
			return new DeviceBrandUpdateRequestBuilder(id, deviceBrand);
		}
	}
}
