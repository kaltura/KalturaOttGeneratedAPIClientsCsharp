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
	public class PpvAddRequestBuilder : RequestBuilder<Ppv>
	{
		#region Constants
		public const string PPV = "ppv";
		#endregion

		public Ppv Ppv { get; set; }

		public PpvAddRequestBuilder()
			: base("ppv", "add")
		{
		}

		public PpvAddRequestBuilder(Ppv ppv)
			: this()
		{
			this.Ppv = ppv;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("ppv"))
				kparams.AddIfNotNull("ppv", Ppv);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Ppv>(result);
		}
	}

	public class PpvDeleteRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public PpvDeleteRequestBuilder()
			: base("ppv", "delete")
		{
		}

		public PpvDeleteRequestBuilder(long id)
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

	public class PpvGetRequestBuilder : RequestBuilder<Ppv>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public PpvGetRequestBuilder()
			: base("ppv", "get")
		{
		}

		public PpvGetRequestBuilder(long id)
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
			return ObjectFactory.Create<Ppv>(result);
		}
	}

	public class PpvListRequestBuilder : RequestBuilder<ListResponse<Ppv>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public PpvFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public PpvListRequestBuilder()
			: base("ppv", "list")
		{
		}

		public PpvListRequestBuilder(PpvFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Ppv>>(result);
		}
	}

	public class PpvUpdateRequestBuilder : RequestBuilder<Ppv>
	{
		#region Constants
		public const string ID = "id";
		public const string PPV = "ppv";
		#endregion

		public int Id { get; set; }
		public Ppv Ppv { get; set; }

		public PpvUpdateRequestBuilder()
			: base("ppv", "update")
		{
		}

		public PpvUpdateRequestBuilder(int id, Ppv ppv)
			: this()
		{
			this.Id = id;
			this.Ppv = ppv;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("ppv"))
				kparams.AddIfNotNull("ppv", Ppv);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Ppv>(result);
		}
	}


	public class PpvService
	{
		private PpvService()
		{
		}

		public static PpvAddRequestBuilder Add(Ppv ppv)
		{
			return new PpvAddRequestBuilder(ppv);
		}

		public static PpvDeleteRequestBuilder Delete(long id)
		{
			return new PpvDeleteRequestBuilder(id);
		}

		public static PpvGetRequestBuilder Get(long id)
		{
			return new PpvGetRequestBuilder(id);
		}

		public static PpvListRequestBuilder List(PpvFilter filter = null, FilterPager pager = null)
		{
			return new PpvListRequestBuilder(filter, pager);
		}

		public static PpvUpdateRequestBuilder Update(int id, Ppv ppv)
		{
			return new PpvUpdateRequestBuilder(id, ppv);
		}
	}
}
