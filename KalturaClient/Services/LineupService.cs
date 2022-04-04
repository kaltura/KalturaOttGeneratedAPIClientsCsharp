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
	public class LineupGetRequestBuilder : RequestBuilder<ListResponse<LineupChannelAsset>>
	{
		#region Constants
		public const string PAGE_INDEX = "pageIndex";
		public const string PAGE_SIZE = "pageSize";
		#endregion

		public int PageIndex { get; set; }
		public int PageSize { get; set; }

		public LineupGetRequestBuilder()
			: base("lineup", "get")
		{
		}

		public LineupGetRequestBuilder(int pageIndex, int pageSize)
			: this()
		{
			this.PageIndex = pageIndex;
			this.PageSize = pageSize;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("pageIndex"))
				kparams.AddIfNotNull("pageIndex", PageIndex);
			if (!isMapped("pageSize"))
				kparams.AddIfNotNull("pageSize", PageSize);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<LineupChannelAsset>>(result);
		}
	}


	public class LineupService
	{
		private LineupService()
		{
		}

		public static LineupGetRequestBuilder Get(int pageIndex, int pageSize)
		{
			return new LineupGetRequestBuilder(pageIndex, pageSize);
		}
	}
}
