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
	public class AssetCommentAddRequestBuilder : RequestBuilder<AssetComment>
	{
		#region Constants
		public const string COMMENT = "comment";
		#endregion

		public AssetComment Comment { get; set; }

		public AssetCommentAddRequestBuilder()
			: base("assetcomment", "add")
		{
		}

		public AssetCommentAddRequestBuilder(AssetComment comment)
			: this()
		{
			this.Comment = comment;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("comment"))
				kparams.AddIfNotNull("comment", Comment);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<AssetComment>(result);
		}
	}

	public class AssetCommentListRequestBuilder : RequestBuilder<ListResponse<AssetComment>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public AssetCommentFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public AssetCommentListRequestBuilder()
			: base("assetcomment", "list")
		{
		}

		public AssetCommentListRequestBuilder(AssetCommentFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<AssetComment>>(result);
		}
	}


	public class AssetCommentService
	{
		private AssetCommentService()
		{
		}

		public static AssetCommentAddRequestBuilder Add(AssetComment comment)
		{
			return new AssetCommentAddRequestBuilder(comment);
		}

		public static AssetCommentListRequestBuilder List(AssetCommentFilter filter, FilterPager pager = null)
		{
			return new AssetCommentListRequestBuilder(filter, pager);
		}
	}
}
