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
	public class CollectionAddRequestBuilder : RequestBuilder<Collection>
	{
		#region Constants
		public const string COLLECTION = "collection";
		#endregion

		public Collection Collection { get; set; }

		public CollectionAddRequestBuilder()
			: base("collection", "add")
		{
		}

		public CollectionAddRequestBuilder(Collection collection)
			: this()
		{
			this.Collection = collection;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("collection"))
				kparams.AddIfNotNull("collection", Collection);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Collection>(result);
		}
	}

	public class CollectionDeleteRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public CollectionDeleteRequestBuilder()
			: base("collection", "delete")
		{
		}

		public CollectionDeleteRequestBuilder(long id)
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

	public class CollectionListRequestBuilder : RequestBuilder<ListResponse<Collection>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public CollectionFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public CollectionListRequestBuilder()
			: base("collection", "list")
		{
		}

		public CollectionListRequestBuilder(CollectionFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Collection>>(result);
		}
	}

	public class CollectionUpdateRequestBuilder : RequestBuilder<Collection>
	{
		#region Constants
		public const string ID = "id";
		public const string COLLECTION = "collection";
		#endregion

		public long Id { get; set; }
		public Collection Collection { get; set; }

		public CollectionUpdateRequestBuilder()
			: base("collection", "update")
		{
		}

		public CollectionUpdateRequestBuilder(long id, Collection collection)
			: this()
		{
			this.Id = id;
			this.Collection = collection;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("collection"))
				kparams.AddIfNotNull("collection", Collection);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Collection>(result);
		}
	}


	public class CollectionService
	{
		private CollectionService()
		{
		}

		public static CollectionAddRequestBuilder Add(Collection collection)
		{
			return new CollectionAddRequestBuilder(collection);
		}

		public static CollectionDeleteRequestBuilder Delete(long id)
		{
			return new CollectionDeleteRequestBuilder(id);
		}

		public static CollectionListRequestBuilder List(CollectionFilter filter = null, FilterPager pager = null)
		{
			return new CollectionListRequestBuilder(filter, pager);
		}

		public static CollectionUpdateRequestBuilder Update(long id, Collection collection)
		{
			return new CollectionUpdateRequestBuilder(id, collection);
		}
	}
}
