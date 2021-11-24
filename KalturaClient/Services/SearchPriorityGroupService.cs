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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class SearchPriorityGroupAddRequestBuilder : RequestBuilder<SearchPriorityGroup>
	{
		#region Constants
		public const string SEARCH_PRIORITY_GROUP = "searchPriorityGroup";
		#endregion

		public SearchPriorityGroup SearchPriorityGroup { get; set; }

		public SearchPriorityGroupAddRequestBuilder()
			: base("searchprioritygroup", "add")
		{
		}

		public SearchPriorityGroupAddRequestBuilder(SearchPriorityGroup searchPriorityGroup)
			: this()
		{
			this.SearchPriorityGroup = searchPriorityGroup;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("searchPriorityGroup"))
				kparams.AddIfNotNull("searchPriorityGroup", SearchPriorityGroup);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SearchPriorityGroup>(result);
		}
	}

	public class SearchPriorityGroupDeleteRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public SearchPriorityGroupDeleteRequestBuilder()
			: base("searchprioritygroup", "delete")
		{
		}

		public SearchPriorityGroupDeleteRequestBuilder(int id)
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

	public class SearchPriorityGroupListRequestBuilder : RequestBuilder<ListResponse<SearchPriorityGroup>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public SearchPriorityGroupFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public SearchPriorityGroupListRequestBuilder()
			: base("searchprioritygroup", "list")
		{
		}

		public SearchPriorityGroupListRequestBuilder(SearchPriorityGroupFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<SearchPriorityGroup>>(result);
		}
	}

	public class SearchPriorityGroupUpdateRequestBuilder : RequestBuilder<SearchPriorityGroup>
	{
		#region Constants
		public const string ID = "id";
		public const string SEARCH_PRIORITY_GROUP = "searchPriorityGroup";
		#endregion

		public long Id { get; set; }
		public SearchPriorityGroup SearchPriorityGroup { get; set; }

		public SearchPriorityGroupUpdateRequestBuilder()
			: base("searchprioritygroup", "update")
		{
		}

		public SearchPriorityGroupUpdateRequestBuilder(long id, SearchPriorityGroup searchPriorityGroup)
			: this()
		{
			this.Id = id;
			this.SearchPriorityGroup = searchPriorityGroup;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("searchPriorityGroup"))
				kparams.AddIfNotNull("searchPriorityGroup", SearchPriorityGroup);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SearchPriorityGroup>(result);
		}
	}


	public class SearchPriorityGroupService
	{
		private SearchPriorityGroupService()
		{
		}

		public static SearchPriorityGroupAddRequestBuilder Add(SearchPriorityGroup searchPriorityGroup)
		{
			return new SearchPriorityGroupAddRequestBuilder(searchPriorityGroup);
		}

		public static SearchPriorityGroupDeleteRequestBuilder Delete(int id)
		{
			return new SearchPriorityGroupDeleteRequestBuilder(id);
		}

		public static SearchPriorityGroupListRequestBuilder List(SearchPriorityGroupFilter filter, FilterPager pager = null)
		{
			return new SearchPriorityGroupListRequestBuilder(filter, pager);
		}

		public static SearchPriorityGroupUpdateRequestBuilder Update(long id, SearchPriorityGroup searchPriorityGroup)
		{
			return new SearchPriorityGroupUpdateRequestBuilder(id, searchPriorityGroup);
		}
	}
}
