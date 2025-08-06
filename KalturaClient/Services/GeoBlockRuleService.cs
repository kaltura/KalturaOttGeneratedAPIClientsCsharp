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
	public class GeoBlockRuleAddRequestBuilder : RequestBuilder<GeoBlockRule>
	{
		#region Constants
		public const string GEO_BLOCK_RULE = "geoBlockRule";
		#endregion

		public GeoBlockRule GeoBlockRule { get; set; }

		public GeoBlockRuleAddRequestBuilder()
			: base("geoblockrule", "add")
		{
		}

		public GeoBlockRuleAddRequestBuilder(GeoBlockRule geoBlockRule)
			: this()
		{
			this.GeoBlockRule = geoBlockRule;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("geoBlockRule"))
				kparams.AddIfNotNull("geoBlockRule", GeoBlockRule);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GeoBlockRule>(result);
		}
	}

	public class GeoBlockRuleDeleteRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public GeoBlockRuleDeleteRequestBuilder()
			: base("geoblockrule", "delete")
		{
		}

		public GeoBlockRuleDeleteRequestBuilder(long id)
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

	public class GeoBlockRuleListRequestBuilder : RequestBuilder<ListResponse<GeoBlockRule>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public GeoBlockRuleFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public GeoBlockRuleListRequestBuilder()
			: base("geoblockrule", "list")
		{
		}

		public GeoBlockRuleListRequestBuilder(GeoBlockRuleFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<GeoBlockRule>>(result);
		}
	}

	public class GeoBlockRuleUpdateRequestBuilder : RequestBuilder<GeoBlockRule>
	{
		#region Constants
		public const string ID = "id";
		public const string GEO_BLOCK_RULE = "geoBlockRule";
		#endregion

		public long Id { get; set; }
		public GeoBlockRule GeoBlockRule { get; set; }

		public GeoBlockRuleUpdateRequestBuilder()
			: base("geoblockrule", "update")
		{
		}

		public GeoBlockRuleUpdateRequestBuilder(long id, GeoBlockRule geoBlockRule)
			: this()
		{
			this.Id = id;
			this.GeoBlockRule = geoBlockRule;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("geoBlockRule"))
				kparams.AddIfNotNull("geoBlockRule", GeoBlockRule);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GeoBlockRule>(result);
		}
	}


	public class GeoBlockRuleService
	{
		private GeoBlockRuleService()
		{
		}

		public static GeoBlockRuleAddRequestBuilder Add(GeoBlockRule geoBlockRule)
		{
			return new GeoBlockRuleAddRequestBuilder(geoBlockRule);
		}

		public static GeoBlockRuleDeleteRequestBuilder Delete(long id)
		{
			return new GeoBlockRuleDeleteRequestBuilder(id);
		}

		public static GeoBlockRuleListRequestBuilder List(GeoBlockRuleFilter filter = null, FilterPager pager = null)
		{
			return new GeoBlockRuleListRequestBuilder(filter, pager);
		}

		public static GeoBlockRuleUpdateRequestBuilder Update(long id, GeoBlockRule geoBlockRule)
		{
			return new GeoBlockRuleUpdateRequestBuilder(id, geoBlockRule);
		}
	}
}
